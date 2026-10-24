using System.Drawing;
using System.Windows.Forms;
using RMS.Common;
using RMS.Models;
using RMS.Services;
using RMS.UI.Navigation;

namespace RMS.UI.Views;

/// <summary>
/// Dashboard screen view displaying live KPI summary cards and recent orders table.
/// </summary>
public class DashboardView : BaseView
{
    private readonly RestaurantStore _store = RestaurantStore.Instance;
    private readonly Panel _kpiContainer;
    private readonly TableLayoutPanel _recentOrdersTable;
    private readonly Button _btnNewOrder;

    // KPI Labels
    private readonly Label _lblTotalCount;
    private readonly Label _lblPendingCount;
    private readonly Label _lblPreparingCount;
    private readonly Label _lblReadyCount;
    private readonly Label _lblCompletedCount;
    private readonly Label _lblCompletedValue;

    public DashboardView() : base("Dashboard", "Overview of today's restaurant orders")
    {
        // Top "+ New Order" button on header
        _btnNewOrder = new Button
        {
            Text = "+ New Order",
            Font = AppTheme.BodyBold,
            ForeColor = Color.White,
            BackColor = AppTheme.PrimaryButton,
            FlatStyle = FlatStyle.Flat,
            Size = new Size(130, 38),
            Anchor = AnchorStyles.Top | AnchorStyles.Right,
            Cursor = Cursors.Hand
        };
        _btnNewOrder.FlatAppearance.BorderSize = 0;
        _btnNewOrder.Location = new Point(HeaderPanel.Width - 160, 18);
        _btnNewOrder.Click += (s, e) => Navigate(ViewType.NewOrder);
        HeaderPanel.Controls.Add(_btnNewOrder);
        HeaderPanel.Resize += (s, e) =>
        {
            _btnNewOrder.Location = new Point(HeaderPanel.Width - 160, 18);
        };

        // KPI container (Flow or custom grid)
        _kpiContainer = new Panel
        {
            Dock = DockStyle.Top,
            Height = 190,
            BackColor = AppTheme.ContentBackground
        };

        // Create 6 KPI cards
        var cardTotal = CreateKpiCard("Total Orders", out _lblTotalCount, "12", Color.FromArgb(244, 114, 182));
        var cardPending = CreateKpiCard("Pending", out _lblPendingCount, "2", AppTheme.StatusPendingText);
        var cardPreparing = CreateKpiCard("Preparing", out _lblPreparingCount, "3", AppTheme.StatusPreparingText);
        var cardReady = CreateKpiCard("Ready", out _lblReadyCount, "2", AppTheme.StatusReadyText);
        var cardCompleted = CreateKpiCard("Completed", out _lblCompletedCount, "5", AppTheme.StatusCompletedText);
        var cardValue = CreateKpiCard("Completed Order Value", out _lblCompletedValue, "1,850 ETB", AppTheme.PrimaryButton);

        var tlpKpi = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 3,
            RowCount = 2,
            BackColor = AppTheme.ContentBackground
        };
        tlpKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33f));
        tlpKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33f));
        tlpKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34f));
        tlpKpi.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
        tlpKpi.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));

        tlpKpi.Controls.Add(cardTotal, 0, 0);
        tlpKpi.Controls.Add(cardPending, 1, 0);
        tlpKpi.Controls.Add(cardPreparing, 2, 0);
        tlpKpi.Controls.Add(cardReady, 0, 1);
        tlpKpi.Controls.Add(cardCompleted, 1, 1);
        tlpKpi.Controls.Add(cardValue, 2, 1);
        _kpiContainer.Controls.Add(tlpKpi);

        // Recent Orders Card
        var pnlRecentOrders = new Panel
        {
            Dock = DockStyle.Fill,
            BackColor = AppTheme.CardBackground,
            Padding = new Padding(20)
        };
        pnlRecentOrders.Paint += (s, e) =>
        {
            using var pen = new Pen(AppTheme.CardBorder);
            e.Graphics.DrawRectangle(pen, 0, 0, pnlRecentOrders.Width - 1, pnlRecentOrders.Height - 1);
        };

        var pnlRecentHeader = new Panel { Dock = DockStyle.Top, Height = 40 };
        var lblRecentTitle = new Label
        {
            Text = "Recent Orders",
            Font = AppTheme.HeaderMedium,
            ForeColor = AppTheme.TextPrimary,
            AutoSize = true,
            Location = new Point(0, 5)
        };
        var lblRecentSubtitle = new Label
        {
            Text = "Today",
            Font = AppTheme.SmallRegular,
            ForeColor = AppTheme.TextSecondary,
            AutoSize = true,
            Location = new Point(130, 9)
        };
        var lnkViewAll = new LinkLabel
        {
            Text = "View all orders →",
            Font = AppTheme.BodyBold,
            LinkColor = AppTheme.PrimaryButton,
            ActiveLinkColor = AppTheme.PrimaryButtonHover,
            AutoSize = true,
            Dock = DockStyle.Right,
            Cursor = Cursors.Hand
        };
        lnkViewAll.Click += (s, e) => Navigate(ViewType.Orders);

        pnlRecentHeader.Controls.Add(lblRecentTitle);
        pnlRecentHeader.Controls.Add(lblRecentSubtitle);
        pnlRecentHeader.Controls.Add(lnkViewAll);

        _recentOrdersTable = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 6,
            AutoScroll = true,
            BackColor = Color.White
        };
        _recentOrdersTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14f)); // Order #
        _recentOrdersTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22f)); // Customer
        _recentOrdersTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18f)); // Table
        _recentOrdersTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16f)); // Created
        _recentOrdersTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16f)); // Total
        _recentOrdersTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14f)); // Status

        pnlRecentOrders.Controls.Add(_recentOrdersTable);
        pnlRecentOrders.Controls.Add(pnlRecentHeader);

        var spacing = new Panel { Dock = DockStyle.Top, Height = 14, BackColor = AppTheme.ContentBackground };

        ContentPanel.Controls.Add(pnlRecentOrders);
        ContentPanel.Controls.Add(spacing);
        ContentPanel.Controls.Add(_kpiContainer);

        _store.OnOrdersChanged += RefreshDashboard;
    }

    private Panel CreateKpiCard(string label, out Label valueLabel, string initialValue, Color iconAccent)
    {
        var card = new Panel
        {
            Dock = DockStyle.Fill,
            Margin = new Padding(6),
            BackColor = AppTheme.CardBackground,
            Padding = new Padding(16, 12, 16, 12)
        };
        card.Paint += (s, e) =>
        {
            using var pen = new Pen(AppTheme.CardBorder);
            e.Graphics.DrawRectangle(pen, 0, 0, card.Width - 1, card.Height - 1);
        };

        var lblName = new Label
        {
            Text = label,
            Font = AppTheme.SmallBold,
            ForeColor = AppTheme.TextSecondary,
            AutoSize = true,
            Location = new Point(14, 12)
        };

        valueLabel = new Label
        {
            Text = initialValue,
            Font = AppTheme.KpiNumberFont,
            ForeColor = AppTheme.TextPrimary,
            AutoSize = true,
            Location = new Point(14, 34)
        };

        card.Controls.Add(lblName);
        card.Controls.Add(valueLabel);
        return card;
    }

    public override void OnNavigatedTo(object? parameter = null)
    {
        base.OnNavigatedTo(parameter);
        RefreshDashboard();
    }

    private void RefreshDashboard()
    {
        if (IsDisposed || Disposing) return;

        if (InvokeRequired)
        {
            Invoke(new Action(RefreshDashboard));
            return;
        }

        // Live KPI updates
        _lblTotalCount.Text = _store.ActiveTotalOrdersCount.ToString();
        _lblPendingCount.Text = _store.PendingOrdersCount.ToString();
        _lblPreparingCount.Text = _store.PreparingOrdersCount.ToString();
        _lblReadyCount.Text = _store.ReadyOrdersCount.ToString();
        _lblCompletedCount.Text = _store.CompletedOrdersCount.ToString();
        _lblCompletedValue.Text = $"{_store.CompletedOrdersValue:N0} ETB";

        // Recent Orders Table Refresh
        _recentOrdersTable.SuspendLayout();
        _recentOrdersTable.Controls.Clear();
        _recentOrdersTable.RowCount = 0;
        _recentOrdersTable.RowStyles.Clear();

        // Header Row
        AddTableRow("Order #", "Customer", "Table", "Created", "Total", "Status", isHeader: true);

        // Display recent 4 orders (#104-#107) matching mockups
        var recentOrders = _store.Orders.Take(4);
        foreach (var order in recentOrders)
        {
            AddTableRow(
                $"#{order.OrderNumber}",
                order.CustomerName,
                $"Table {order.TableNumber}",
                order.CreatedAt.ToString("h:mm tt"),
                $"{order.Total:N0} ETB",
                order.Status.ToString(),
                isHeader: false,
                status: order.Status
            );
        }

        _recentOrdersTable.ResumeLayout();
    }

    private void AddTableRow(string col1, string col2, string col3, string col4, string col5, string col6, bool isHeader, OrderStatus? status = null)
    {
        int row = _recentOrdersTable.RowCount++;
        _recentOrdersTable.RowStyles.Add(new RowStyle(SizeType.Absolute, isHeader ? 32f : 40f));

        Font font = isHeader ? AppTheme.SmallBold : AppTheme.BodyRegular;
        Color textColor = isHeader ? AppTheme.TextSecondary : AppTheme.TextPrimary;

        _recentOrdersTable.Controls.Add(new Label { Text = col1, Font = font, ForeColor = isHeader ? textColor : AppTheme.PrimaryButton, AutoSize = true, Anchor = AnchorStyles.Left }, 0, row);
        _recentOrdersTable.Controls.Add(new Label { Text = col2, Font = font, ForeColor = textColor, AutoSize = true, Anchor = AnchorStyles.Left }, 1, row);
        _recentOrdersTable.Controls.Add(new Label { Text = col3, Font = font, ForeColor = textColor, AutoSize = true, Anchor = AnchorStyles.Left }, 2, row);
        _recentOrdersTable.Controls.Add(new Label { Text = col4, Font = font, ForeColor = textColor, AutoSize = true, Anchor = AnchorStyles.Left }, 3, row);
        _recentOrdersTable.Controls.Add(new Label { Text = col5, Font = isHeader ? font : AppTheme.BodyBold, ForeColor = textColor, AutoSize = true, Anchor = AnchorStyles.Left }, 4, row);

        if (isHeader || status == null)
        {
            _recentOrdersTable.Controls.Add(new Label { Text = col6, Font = font, ForeColor = textColor, AutoSize = true, Anchor = AnchorStyles.Left }, 5, row);
        }
        else
        {
            var badge = CreateStatusBadge(status.Value);
            _recentOrdersTable.Controls.Add(badge, 5, row);
        }
    }

    private Control CreateStatusBadge(OrderStatus status)
    {
        Color bg;
        Color text;

        switch (status)
        {
            case OrderStatus.Pending:
                bg = AppTheme.StatusPendingBg;
                text = AppTheme.StatusPendingText;
                break;
            case OrderStatus.Preparing:
                bg = AppTheme.StatusPreparingBg;
                text = AppTheme.StatusPreparingText;
                break;
            case OrderStatus.Ready:
                bg = AppTheme.StatusReadyBg;
                text = AppTheme.StatusReadyText;
                break;
            case OrderStatus.Completed:
                bg = AppTheme.StatusCompletedBg;
                text = AppTheme.StatusCompletedText;
                break;
            case OrderStatus.Cancelled:
            default:
                bg = AppTheme.StatusCancelledBg;
                text = AppTheme.StatusCancelledText;
                break;
        }

        var badge = new Label
        {
            Text = status.ToString(),
            Font = AppTheme.SmallBold,
            ForeColor = text,
            BackColor = bg,
            AutoSize = false,
            Size = new Size(82, 24),
            TextAlign = ContentAlignment.MiddleCenter,
            Anchor = AnchorStyles.Left
        };
        return badge;
    }
}
