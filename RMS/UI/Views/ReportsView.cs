using System.Drawing;
using System.Windows.Forms;
using RMS.Common;
using RMS.Models;
using RMS.Services;
using RMS.UI.Navigation;

namespace RMS.UI.Views;

/// <summary>
/// Reports screen view displaying order activity summary,
/// dynamic KPI metric cards, date and status filters, and order summary table.
/// Matches UI/reports/Reports.jpg.
/// </summary>
public class ReportsView : BaseView, INavigationAware
{
    private readonly RestaurantStore _store = RestaurantStore.Instance;

    // Filters
    private readonly ComboBox _cboDateFilter;
    private readonly RadioButton _rbAll;
    private readonly RadioButton _rbPending;
    private readonly RadioButton _rbPreparing;
    private readonly RadioButton _rbReady;
    private readonly RadioButton _rbCompleted;
    private readonly Button _btnClearFilters;
    private readonly Label _lblFilterSummary;

    // KPI Metric Labels
    private readonly Label _lblTotalOrders;
    private readonly Label _lblPendingOrders;
    private readonly Label _lblPreparingOrders;
    private readonly Label _lblReadyOrders;
    private readonly Label _lblCompletedOrders;
    private readonly Label _lblCompletedValue;

    // Order Summary Section
    private readonly Label _lblSummaryHeaderSubtitle;
    private readonly DataGridView _gridSummary;
    private readonly Label _lblSummaryFooterNote;

    public ReportsView() : base("Reports", "Review order activity and completed order value")
    {
        // Use an inner scrollable panel inside ContentPanel
        var pnlScroll = new Panel
        {
            Dock = DockStyle.Fill,
            AutoScroll = true,
            BackColor = AppTheme.ContentBackground,
            Padding = new Padding(0, 0, 10, 20)
        };
        ContentPanel.Controls.Add(pnlScroll);

        // ----------------------------------------------------
        // 1. Filter Panel / Card
        // ----------------------------------------------------
        var pnlFilterCard = new Panel
        {
            Dock = DockStyle.Top,
            Height = 115,
            BackColor = AppTheme.CardBackground,
            Padding = new Padding(20, 14, 20, 12)
        };
        pnlFilterCard.Paint += (s, e) =>
        {
            using var pen = new Pen(AppTheme.CardBorder);
            e.Graphics.DrawRectangle(pen, 0, 0, pnlFilterCard.Width - 1, pnlFilterCard.Height - 1);
        };

        // Date filter label & dropdown
        var lblDateTitle = new Label
        {
            Text = "Created date (local)",
            Font = AppTheme.SmallBold,
            ForeColor = AppTheme.TextSecondary,
            Location = new Point(20, 14),
            AutoSize = true
        };
        pnlFilterCard.Controls.Add(lblDateTitle);

        _cboDateFilter = new ComboBox
        {
            Font = AppTheme.BodyRegular,
            Location = new Point(20, 36),
            Size = new Size(160, 32),
            DropDownStyle = ComboBoxStyle.DropDownList
        };
        _cboDateFilter.Items.Add("All dates");
        _cboDateFilter.Items.Add("Today");
        _cboDateFilter.SelectedIndex = 0;
        _cboDateFilter.SelectedIndexChanged += (s, e) => RefreshReports();
        pnlFilterCard.Controls.Add(_cboDateFilter);

        // Status filter label & radio buttons
        var lblStatusTitle = new Label
        {
            Text = "Status",
            Font = AppTheme.SmallBold,
            ForeColor = AppTheme.TextSecondary,
            Location = new Point(200, 14),
            AutoSize = true
        };
        pnlFilterCard.Controls.Add(lblStatusTitle);

        var pnlStatusRadios = new FlowLayoutPanel
        {
            Location = new Point(200, 36),
            Size = new Size(580, 32),
            FlowDirection = FlowDirection.LeftToRight,
            WrapContents = false,
            BackColor = Color.Transparent
        };

        _rbAll = CreateStatusRadio("All", true);
        _rbPending = CreateStatusRadio("Pending", false);
        _rbPreparing = CreateStatusRadio("Preparing", false);
        _rbReady = CreateStatusRadio("Ready", false);
        _rbCompleted = CreateStatusRadio("Completed", false);

        pnlStatusRadios.Controls.Add(_rbAll);
        pnlStatusRadios.Controls.Add(_rbPending);
        pnlStatusRadios.Controls.Add(_rbPreparing);
        pnlStatusRadios.Controls.Add(_rbReady);
        pnlStatusRadios.Controls.Add(_rbCompleted);
        pnlFilterCard.Controls.Add(pnlStatusRadios);

        // Clear Filters button
        _btnClearFilters = new Button
        {
            Text = "Clear Filters",
            Font = AppTheme.BodyBold,
            ForeColor = AppTheme.TextPrimary,
            BackColor = Color.White,
            FlatStyle = FlatStyle.Flat,
            Size = new Size(110, 34),
            Anchor = AnchorStyles.Top | AnchorStyles.Right,
            Cursor = Cursors.Hand
        };
        _btnClearFilters.FlatAppearance.BorderColor = AppTheme.CardBorder;
        _btnClearFilters.Location = new Point(pnlFilterCard.Width - 130, 34);
        _btnClearFilters.Click += (s, e) =>
        {
            _cboDateFilter.SelectedIndex = 0;
            _rbAll.Checked = true;
            RefreshReports();
        };
        pnlFilterCard.Controls.Add(_btnClearFilters);
        pnlFilterCard.Resize += (s, e) =>
        {
            _btnClearFilters.Location = new Point(pnlFilterCard.Width - 130, 34);
        };

        // Filter summary text
        _lblFilterSummary = new Label
        {
            Text = "All dates • All statuses • 12 orders. Date and status filters apply to the summary cards and order table.",
            Font = AppTheme.SmallRegular,
            ForeColor = AppTheme.TextMuted,
            Location = new Point(20, 82),
            AutoSize = true
        };
        pnlFilterCard.Controls.Add(_lblFilterSummary);

        // ----------------------------------------------------
        // 2. 6 KPI Cards Panel
        // ----------------------------------------------------
        var pnlKpiContainer = new Panel
        {
            Dock = DockStyle.Top,
            Height = 230,
            BackColor = AppTheme.ContentBackground,
            Padding = new Padding(0, 8, 0, 8)
        };

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

        var cardTotal = CreateKpiCard("Total Orders", out _lblTotalOrders, "12", "📋", Color.FromArgb(244, 114, 182));
        var cardPending = CreateKpiCard("Pending Orders", out _lblPendingOrders, "2", "⏱", AppTheme.StatusPendingText);
        var cardPreparing = CreateKpiCard("Preparing Orders", out _lblPreparingOrders, "3", "🍲", AppTheme.StatusPreparingText);
        var cardReady = CreateKpiCard("Ready Orders", out _lblReadyOrders, "2", "🔔", AppTheme.StatusReadyText);
        var cardCompleted = CreateKpiCard("Completed Orders", out _lblCompletedOrders, "5", "✓", AppTheme.StatusCompletedText);
        var cardValue = CreateKpiCard("Completed Order Value", out _lblCompletedValue, "1,850 ETB", "💵", AppTheme.PrimaryButton, isCurrency: true);

        tlpKpi.Controls.Add(cardTotal, 0, 0);
        tlpKpi.Controls.Add(cardPending, 1, 0);
        tlpKpi.Controls.Add(cardPreparing, 2, 0);
        tlpKpi.Controls.Add(cardReady, 0, 1);
        tlpKpi.Controls.Add(cardCompleted, 1, 1);
        tlpKpi.Controls.Add(cardValue, 2, 1);
        pnlKpiContainer.Controls.Add(tlpKpi);

        // ----------------------------------------------------
        // 3. Order Summary Table Card
        // ----------------------------------------------------
        var pnlSummaryCard = new Panel
        {
            Dock = DockStyle.Top,
            Height = 450,
            BackColor = AppTheme.CardBackground,
            Padding = new Padding(20, 16, 20, 16)
        };
        pnlSummaryCard.Paint += (s, e) =>
        {
            using var pen = new Pen(AppTheme.CardBorder);
            e.Graphics.DrawRectangle(pen, 0, 0, pnlSummaryCard.Width - 1, pnlSummaryCard.Height - 1);
        };

        // Table Header
        var pnlTableHeader = new Panel
        {
            Dock = DockStyle.Top,
            Height = 44,
            BackColor = Color.Transparent
        };

        var lblOrderSummaryTitle = new Label
        {
            Text = "Order summary",
            Font = AppTheme.HeaderMedium,
            ForeColor = AppTheme.TextPrimary,
            Location = new Point(0, 0),
            AutoSize = true
        };

        _lblSummaryHeaderSubtitle = new Label
        {
            Text = "Four-order preview of 12 orders • All dates • All statuses",
            Font = AppTheme.SmallRegular,
            ForeColor = AppTheme.TextSecondary,
            Location = new Point(0, 24),
            AutoSize = true
        };

        var lblCreatedTimesNote = new Label
        {
            Text = "Created times are local",
            Font = AppTheme.SmallRegular,
            ForeColor = AppTheme.TextMuted,
            Dock = DockStyle.Right,
            TextAlign = ContentAlignment.TopRight,
            AutoSize = true
        };

        pnlTableHeader.Controls.Add(lblOrderSummaryTitle);
        pnlTableHeader.Controls.Add(_lblSummaryHeaderSubtitle);
        pnlTableHeader.Controls.Add(lblCreatedTimesNote);
        pnlSummaryCard.Controls.Add(pnlTableHeader);

        // Footer Note
        _lblSummaryFooterNote = new Label
        {
            Text = "Summary cards cover all 12 orders; completed order value totals the 5 completed orders, not this preview.",
            Font = AppTheme.SmallRegular,
            ForeColor = AppTheme.TextMuted,
            Dock = DockStyle.Bottom,
            Height = 24,
            TextAlign = ContentAlignment.MiddleLeft
        };
        pnlSummaryCard.Controls.Add(_lblSummaryFooterNote);

        // DataGridView
        _gridSummary = new DataGridView
        {
            Dock = DockStyle.Fill,
            BackgroundColor = Color.White,
            BorderStyle = BorderStyle.None,
            CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal,
            GridColor = Color.FromArgb(243, 244, 246),
            RowHeadersVisible = false,
            AllowUserToAddRows = false,
            AllowUserToDeleteRows = false,
            AllowUserToResizeRows = false,
            MultiSelect = false,
            ReadOnly = true,
            SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            EnableHeadersVisualStyles = false,
            RowTemplate = { Height = 44 }
        };

        _gridSummary.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
        {
            BackColor = Color.White,
            ForeColor = AppTheme.TextSecondary,
            Font = AppTheme.SmallBold,
            SelectionBackColor = Color.White,
            SelectionForeColor = AppTheme.TextSecondary,
            Padding = new Padding(12, 8, 12, 8),
            Alignment = DataGridViewContentAlignment.MiddleLeft
        };
        _gridSummary.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        _gridSummary.ColumnHeadersHeight = 38;

        _gridSummary.DefaultCellStyle = new DataGridViewCellStyle
        {
            BackColor = Color.White,
            ForeColor = AppTheme.TextPrimary,
            Font = AppTheme.BodyRegular,
            SelectionBackColor = Color.FromArgb(248, 250, 252),
            SelectionForeColor = AppTheme.TextPrimary,
            Padding = new Padding(12, 0, 12, 0),
            Alignment = DataGridViewContentAlignment.MiddleLeft
        };

        SetupSummaryGridColumns();
        _gridSummary.CellPainting += OnSummaryCellPainting;
        _gridSummary.CellDoubleClick += (s, e) =>
        {
            if (e.RowIndex >= 0 && _gridSummary.Rows[e.RowIndex].Tag is Order order)
            {
                Navigate(ViewType.OrderDetails, order.OrderNumber);
            }
        };

        pnlSummaryCard.Controls.Add(_gridSummary);

        // Spacing panels between cards
        var gap1 = new Panel { Dock = DockStyle.Top, Height = 14, BackColor = AppTheme.ContentBackground };
        var gap2 = new Panel { Dock = DockStyle.Top, Height = 14, BackColor = AppTheme.ContentBackground };

        // Add cards in reverse vertical layout order
        pnlScroll.Controls.Add(pnlSummaryCard);
        pnlScroll.Controls.Add(gap2);
        pnlScroll.Controls.Add(pnlKpiContainer);
        pnlScroll.Controls.Add(gap1);
        pnlScroll.Controls.Add(pnlFilterCard);

        RefreshReports();
    }

    private RadioButton CreateStatusRadio(string text, bool isChecked)
    {
        var rb = new RadioButton
        {
            Text = text,
            Font = AppTheme.BodyRegular,
            ForeColor = AppTheme.TextPrimary,
            Checked = isChecked,
            AutoSize = true,
            Margin = new Padding(0, 0, 12, 0),
            Cursor = Cursors.Hand
        };
        rb.CheckedChanged += (s, e) =>
        {
            if (rb.Checked) RefreshReports();
        };
        return rb;
    }

    private static Panel CreateKpiCard(string title, out Label valueLabel, string initialValue, string icon, Color accentColor, bool isCurrency = false)
    {
        var card = new Panel
        {
            Dock = DockStyle.Fill,
            BackColor = AppTheme.CardBackground,
            Margin = new Padding(6),
            Padding = new Padding(16, 12, 16, 12)
        };
        card.Paint += (s, e) =>
        {
            using var pen = new Pen(AppTheme.CardBorder);
            e.Graphics.DrawRectangle(pen, 0, 0, card.Width - 1, card.Height - 1);
        };

        var lblTitle = new Label
        {
            Text = title,
            Font = AppTheme.SmallBold,
            ForeColor = AppTheme.TextSecondary,
            Location = new Point(14, 12),
            AutoSize = true
        };

        valueLabel = new Label
        {
            Text = initialValue,
            Font = isCurrency ? new Font("Segoe UI", 18f, FontStyle.Bold) : new Font("Segoe UI", 22f, FontStyle.Bold),
            ForeColor = isCurrency ? AppTheme.PrimaryButton : AppTheme.TextPrimary,
            Location = new Point(14, 38),
            AutoSize = true
        };

        var pnlIcon = new Panel
        {
            Size = new Size(38, 38),
            Anchor = AnchorStyles.Top | AnchorStyles.Right,
            BackColor = Color.FromArgb(248, 250, 252)
        };
        pnlIcon.Location = new Point(card.Width - 52, 14);
        pnlIcon.Paint += (s, e) =>
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using var brushBg = new SolidBrush(Color.FromArgb(245, 245, 245));
            e.Graphics.FillEllipse(brushBg, 0, 0, pnlIcon.Width - 1, pnlIcon.Height - 1);

            using var brushFg = new SolidBrush(accentColor);
            using var iconFont = new Font("Segoe UI Emoji", 12f);
            using var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            e.Graphics.DrawString(icon, iconFont, brushFg, new Rectangle(0, 0, pnlIcon.Width, pnlIcon.Height), sf);
        };
        card.Resize += (s, e) =>
        {
            pnlIcon.Location = new Point(card.Width - 52, 14);
        };

        card.Controls.Add(lblTitle);
        card.Controls.Add(valueLabel);
        card.Controls.Add(pnlIcon);

        return card;
    }

    private void SetupSummaryGridColumns()
    {
        _gridSummary.Columns.Clear();

        _gridSummary.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ColNumber",
            HeaderText = "Order #",
            Width = 90,
            SortMode = DataGridViewColumnSortMode.NotSortable
        });

        _gridSummary.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ColCustomer",
            HeaderText = "Customer",
            Width = 180,
            SortMode = DataGridViewColumnSortMode.NotSortable
        });

        _gridSummary.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ColTable",
            HeaderText = "Table",
            Width = 110,
            SortMode = DataGridViewColumnSortMode.NotSortable
        });

        _gridSummary.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ColCreated",
            HeaderText = "Created",
            Width = 120,
            SortMode = DataGridViewColumnSortMode.NotSortable
        });

        _gridSummary.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ColTotal",
            HeaderText = "Total",
            Width = 120,
            SortMode = DataGridViewColumnSortMode.NotSortable
        });

        _gridSummary.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ColStatus",
            HeaderText = "Status",
            Width = 145,
            SortMode = DataGridViewColumnSortMode.NotSortable
        });
    }

    public void RefreshReports()
    {
        // 1. Date Filter
        bool isTodayOnly = _cboDateFilter.SelectedIndex == 1;
        DateTime today = DateTime.Today;

        // 2. Status Filter
        OrderStatus? selectedStatus = null;
        if (_rbPending.Checked) selectedStatus = OrderStatus.Pending;
        else if (_rbPreparing.Checked) selectedStatus = OrderStatus.Preparing;
        else if (_rbReady.Checked) selectedStatus = OrderStatus.Ready;
        else if (_rbCompleted.Checked) selectedStatus = OrderStatus.Completed;

        // Base order set (excluding cancelled from general stats)
        var allOrders = _store.Orders.Where(o => o.Status != OrderStatus.Cancelled).ToList();

        if (isTodayOnly)
        {
            allOrders = allOrders.Where(o => o.CreatedAt.Date == today).ToList();
        }

        // Apply status filter if single status selected
        var filteredOrders = allOrders.AsEnumerable();
        if (selectedStatus.HasValue)
        {
            filteredOrders = filteredOrders.Where(o => o.Status == selectedStatus.Value);
        }
        var filteredList = filteredOrders.ToList();

        // 3. Update KPI Card Counts
        int totalOrdersCount = allOrders.Count;
        int pendingCount = allOrders.Count(o => o.Status == OrderStatus.Pending);
        int preparingCount = allOrders.Count(o => o.Status == OrderStatus.Preparing);
        int readyCount = allOrders.Count(o => o.Status == OrderStatus.Ready);
        int completedCount = allOrders.Count(o => o.Status == OrderStatus.Completed);
        decimal completedRevenue = allOrders.Where(o => o.Status == OrderStatus.Completed).Sum(o => o.Total);

        _lblTotalOrders.Text = totalOrdersCount.ToString();
        _lblPendingOrders.Text = pendingCount.ToString();
        _lblPreparingOrders.Text = preparingCount.ToString();
        _lblReadyOrders.Text = readyCount.ToString();
        _lblCompletedOrders.Text = completedCount.ToString();
        _lblCompletedValue.Text = $"{completedRevenue:N0} ETB";

        // 4. Update Summary Labels
        string dateText = isTodayOnly ? "Today" : "All dates";
        string statusText = selectedStatus.HasValue ? selectedStatus.Value.ToString() : "All statuses";
        _lblFilterSummary.Text = $"{dateText} • {statusText} • {filteredList.Count} orders. Date and status filters apply to the summary cards and order table.";

        _lblSummaryHeaderSubtitle.Text = $"{filteredList.Count}-order preview of {_store.Orders.Count} orders • {dateText} • {statusText}";
        _lblSummaryFooterNote.Text = $"Summary cards cover all {totalOrdersCount} orders; completed order value totals the {completedCount} completed orders, not this preview.";

        // 5. Populate DataGridView
        _gridSummary.Rows.Clear();
        foreach (var order in filteredList)
        {
            int rowIndex = _gridSummary.Rows.Add(
                $"#{order.OrderNumber}",
                order.CustomerName,
                $"Table {order.TableNumber}",
                order.CreatedAt.ToString("h:mm tt"),
                $"{order.Total:N0} ETB",
                order.Status.ToString()
            );
            _gridSummary.Rows[rowIndex].Tag = order;
        }
    }

    private void OnSummaryCellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
    {
        if (e.RowIndex < 0 || e.Graphics == null) return;

        int statusColIdx = _gridSummary.Columns["ColStatus"]?.Index ?? -1;
        int totalColIdx = _gridSummary.Columns["ColTotal"]?.Index ?? -1;
        int numColIdx = _gridSummary.Columns["ColNumber"]?.Index ?? -1;

        if (e.ColumnIndex == statusColIdx && e.Value != null)
        {
            e.PaintBackground(e.CellBounds, true);

            string statusStr = e.Value.ToString() ?? "";
            Enum.TryParse<OrderStatus>(statusStr, out var status);

            var (bg, fg) = status switch
            {
                OrderStatus.Pending => (AppTheme.StatusPendingBg, AppTheme.StatusPendingText),
                OrderStatus.Preparing => (AppTheme.StatusPreparingBg, AppTheme.StatusPreparingText),
                OrderStatus.Ready => (AppTheme.StatusReadyBg, AppTheme.StatusReadyText),
                OrderStatus.Completed => (AppTheme.StatusCompletedBg, AppTheme.StatusCompletedText),
                _ => (AppTheme.StatusCancelledBg, AppTheme.StatusCancelledText)
            };

            int badgeWidth = 96;
            int badgeHeight = 24;
            int badgeX = e.CellBounds.X + 8;
            int badgeY = e.CellBounds.Y + (e.CellBounds.Height - badgeHeight) / 2;

            var badgeRect = new Rectangle(badgeX, badgeY, badgeWidth, badgeHeight);
            using var brushBg = new SolidBrush(bg);
            using var brushFg = new SolidBrush(fg);
            using var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };

            using var path = GetRoundedPath(badgeRect, 5);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillPath(brushBg, path);
            e.Graphics.DrawString(status.ToString(), AppTheme.SmallBold, brushFg, badgeRect, sf);

            e.Handled = true;
        }
        else if (e.ColumnIndex == totalColIdx && e.Value != null)
        {
            e.PaintBackground(e.CellBounds, true);
            using var brush = new SolidBrush(AppTheme.TextPrimary);
            using var sf = new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center };
            e.Graphics.DrawString(e.Value.ToString() ?? "", AppTheme.BodyBold, brush, e.CellBounds, sf);
            e.Handled = true;
        }
        else if (e.ColumnIndex == numColIdx && e.Value != null)
        {
            e.PaintBackground(e.CellBounds, true);
            using var brush = new SolidBrush(AppTheme.PrimaryButton);
            using var sf = new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center };
            e.Graphics.DrawString(e.Value.ToString() ?? "", AppTheme.BodyBold, brush, e.CellBounds, sf);
            e.Handled = true;
        }
    }

    private static System.Drawing.Drawing2D.GraphicsPath GetRoundedPath(Rectangle rect, int radius)
    {
        var path = new System.Drawing.Drawing2D.GraphicsPath();
        int d = radius * 2;
        path.AddArc(rect.X, rect.Y, d, d, 180, 90);
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
        path.CloseFigure();
        return path;
    }

    public override void OnNavigatedTo(object? parameter = null)
    {
        RefreshReports();
    }
}
