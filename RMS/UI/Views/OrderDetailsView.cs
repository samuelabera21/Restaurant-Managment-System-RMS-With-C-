using System.Drawing;
using System.Windows.Forms;
using RMS.Common;
using RMS.Models;
using RMS.Services;
using RMS.UI.Dialogs;
using RMS.UI.Navigation;

namespace RMS.UI.Views;

/// <summary>
/// Order Details screen view showing the complete order breakdown,
/// line items, unit prices, subtotal, and status-specific actions.
/// Matches UI/orders/Orders3.jpg, Orders4.jpg, and Orders5.jpg.
/// </summary>
public class OrderDetailsView : BaseView
{
    private readonly RestaurantStore _store = RestaurantStore.Instance;
    private readonly OrderService _orderService = new();

    private Order? _currentOrder;

    // Controls
    private readonly Button _btnBack;
    private readonly Panel _pnlInfoCard;
    private readonly Label _lblOrderNumberTitle;
    private readonly Label _lblOrderNumValue;
    private readonly Label _lblCustomerValue;
    private readonly Label _lblTableValue;
    private readonly Label _lblCreatedValue;
    private readonly Label _lblStatusBadge;

    private readonly Panel _pnlItemsCard;
    private readonly Label _lblItemsCountTitle;
    private readonly DataGridView _gridItems;
    private readonly Label _lblSummaryQty;
    private readonly Label _lblTotalAmount;

    private readonly Panel _pnlActionsBar;
    private readonly Label _lblLockedNotice;
    private readonly Button _btnEditOrder;
    private readonly Button _btnCancelOrder;

    public OrderDetailsView() : base("Order Details", "Review order information and items")
    {
        // Top "← Back to Orders" button
        _btnBack = new Button
        {
            Text = "← Back to Orders",
            Font = AppTheme.BodyBold,
            ForeColor = AppTheme.TextPrimary,
            BackColor = Color.White,
            FlatStyle = FlatStyle.Flat,
            Size = new Size(150, 36),
            Anchor = AnchorStyles.Top | AnchorStyles.Right,
            Cursor = Cursors.Hand
        };
        _btnBack.FlatAppearance.BorderColor = AppTheme.CardBorder;
        _btnBack.Location = new Point(HeaderPanel.Width - 180, 18);
        _btnBack.Click += (s, e) => Navigate(ViewType.Orders);
        HeaderPanel.Controls.Add(_btnBack);
        HeaderPanel.Resize += (s, e) =>
        {
            _btnBack.Location = new Point(HeaderPanel.Width - 180, 18);
        };

        var pnlScroll = new Panel
        {
            Dock = DockStyle.Fill,
            AutoScroll = true,
            BackColor = AppTheme.ContentBackground
        };

        // ----------------------------------------------------
        // 1. Order Information Card
        // ----------------------------------------------------
        _pnlInfoCard = CreateCard(110);

        _lblOrderNumberTitle = new Label
        {
            Text = "#104 Order Information",
            Font = AppTheme.SectionTitle,
            ForeColor = AppTheme.PrimaryButton,
            Location = new Point(18, 14),
            AutoSize = true
        };

        var lblCol1 = new Label { Text = "Order Number", Font = AppTheme.SmallBold, ForeColor = AppTheme.TextSecondary, Location = new Point(18, 42), AutoSize = true };
        _lblOrderNumValue = new Label { Text = "#104", Font = AppTheme.BodyBold, ForeColor = AppTheme.TextPrimary, Location = new Point(18, 64), AutoSize = true };

        var lblCol2 = new Label { Text = "Customer", Font = AppTheme.SmallBold, ForeColor = AppTheme.TextSecondary, Location = new Point(150, 42), AutoSize = true };
        _lblCustomerValue = new Label { Text = "Hana", Font = AppTheme.BodyRegular, ForeColor = AppTheme.TextPrimary, Location = new Point(150, 64), AutoSize = true };

        var lblCol3 = new Label { Text = "Table", Font = AppTheme.SmallBold, ForeColor = AppTheme.TextSecondary, Location = new Point(310, 42), AutoSize = true };
        _lblTableValue = new Label { Text = "Table 4", Font = AppTheme.BodyRegular, ForeColor = AppTheme.TextPrimary, Location = new Point(310, 64), AutoSize = true };

        var lblCol4 = new Label { Text = "Created", Font = AppTheme.SmallBold, ForeColor = AppTheme.TextSecondary, Location = new Point(450, 42), AutoSize = true };
        _lblCreatedValue = new Label { Text = "10:15 AM", Font = AppTheme.BodyRegular, ForeColor = AppTheme.TextPrimary, Location = new Point(450, 64), AutoSize = true };

        var lblCol5 = new Label { Text = "Status", Font = AppTheme.SmallBold, ForeColor = AppTheme.TextSecondary, Location = new Point(590, 42), AutoSize = true };
        _lblStatusBadge = new Label
        {
            Text = "Pending",
            Font = AppTheme.SmallBold,
            ForeColor = AppTheme.StatusPendingText,
            BackColor = AppTheme.StatusPendingBg,
            Size = new Size(86, 24),
            Location = new Point(590, 62),
            TextAlign = ContentAlignment.MiddleCenter
        };

        _pnlInfoCard.Controls.Add(_lblOrderNumberTitle);
        _pnlInfoCard.Controls.Add(lblCol1);
        _pnlInfoCard.Controls.Add(_lblOrderNumValue);
        _pnlInfoCard.Controls.Add(lblCol2);
        _pnlInfoCard.Controls.Add(_lblCustomerValue);
        _pnlInfoCard.Controls.Add(lblCol3);
        _pnlInfoCard.Controls.Add(_lblTableValue);
        _pnlInfoCard.Controls.Add(lblCol4);
        _pnlInfoCard.Controls.Add(_lblCreatedValue);
        _pnlInfoCard.Controls.Add(lblCol5);
        _pnlInfoCard.Controls.Add(_lblStatusBadge);

        // ----------------------------------------------------
        // 2. Order Items Card
        // ----------------------------------------------------
        _pnlItemsCard = CreateCard(260);

        var lblItemsHeader = new Label
        {
            Text = "Order Items",
            Font = AppTheme.SectionTitle,
            ForeColor = AppTheme.TextPrimary,
            Location = new Point(18, 14),
            AutoSize = true
        };

        _lblItemsCountTitle = new Label
        {
            Text = "2 items",
            Font = AppTheme.SmallRegular,
            ForeColor = AppTheme.TextSecondary,
            Anchor = AnchorStyles.Top | AnchorStyles.Right,
            Location = new Point(_pnlItemsCard.Width - 90, 16),
            AutoSize = true
        };
        _pnlItemsCard.Resize += (s, e) =>
        {
            _lblItemsCountTitle.Location = new Point(_pnlItemsCard.Width - 90, 16);
        };

        _gridItems = new DataGridView
        {
            Location = new Point(18, 44),
            Size = new Size(_pnlItemsCard.Width - 36, 150),
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom,
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
            RowTemplate = { Height = 42 }
        };

        _gridItems.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
        {
            BackColor = Color.White,
            ForeColor = AppTheme.TextSecondary,
            Font = AppTheme.SmallBold,
            SelectionBackColor = Color.White,
            SelectionForeColor = AppTheme.TextSecondary,
            Padding = new Padding(8, 8, 8, 8)
        };
        _gridItems.ColumnHeadersHeight = 36;
        _gridItems.DefaultCellStyle = new DataGridViewCellStyle
        {
            BackColor = Color.White,
            ForeColor = AppTheme.TextPrimary,
            Font = AppTheme.BodyRegular,
            SelectionBackColor = Color.FromArgb(249, 250, 251),
            SelectionForeColor = AppTheme.TextPrimary,
            Padding = new Padding(8, 0, 8, 0)
        };

        _gridItems.Columns.Add(new DataGridViewTextBoxColumn 
        { 
            Name = "ColItem", 
            HeaderText = "Item Name", 
            FillWeight = 36,
            MinimumWidth = 160, 
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill 
        });
        _gridItems.Columns.Add(new DataGridViewTextBoxColumn 
        { 
            Name = "ColPrice", 
            HeaderText = "Unit Price", 
            FillWeight = 22,
            MinimumWidth = 110, 
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill 
        });
        _gridItems.Columns.Add(new DataGridViewTextBoxColumn 
        { 
            Name = "ColQty", 
            HeaderText = "Quantity", 
            FillWeight = 20,
            MinimumWidth = 100, 
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill 
        });
        _gridItems.Columns.Add(new DataGridViewTextBoxColumn 
        { 
            Name = "ColSubtotal", 
            HeaderText = "Subtotal", 
            FillWeight = 22,
            MinimumWidth = 110, 
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill 
        });

        _lblSummaryQty = new Label
        {
            Text = "2 items • 3 total quantity",
            Font = AppTheme.SmallRegular,
            ForeColor = AppTheme.TextSecondary,
            Anchor = AnchorStyles.Bottom | AnchorStyles.Left,
            Location = new Point(18, 218),
            AutoSize = true
        };

        _lblTotalAmount = new Label
        {
            Text = "Total  260 ETB",
            Font = new Font("Segoe UI", 16f, FontStyle.Bold),
            ForeColor = AppTheme.PrimaryButton,
            Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
            Location = new Point(_pnlItemsCard.Width - 240, 208),
            Size = new Size(220, 36),
            TextAlign = ContentAlignment.MiddleRight
        };
        _pnlItemsCard.Resize += (s, e) =>
        {
            _lblTotalAmount.Location = new Point(_pnlItemsCard.Width - 240, 208);
        };

        _pnlItemsCard.Controls.Add(lblItemsHeader);
        _pnlItemsCard.Controls.Add(_lblItemsCountTitle);
        _pnlItemsCard.Controls.Add(_gridItems);
        _pnlItemsCard.Controls.Add(_lblSummaryQty);
        _pnlItemsCard.Controls.Add(_lblTotalAmount);

        // ----------------------------------------------------
        // 3. Bottom Actions Bar
        // ----------------------------------------------------
        _pnlActionsBar = new Panel
        {
            Dock = DockStyle.Top,
            Height = 80,
            BackColor = AppTheme.ContentBackground,
            Padding = new Padding(0, 10, 0, 0)
        };

        _lblLockedNotice = new Label
        {
            Text = "ⓘ Completed orders cannot be edited or cancelled, but remain viewable.",
            Font = AppTheme.SmallRegular,
            ForeColor = AppTheme.TextMuted,
            Location = new Point(0, 8),
            AutoSize = true,
            Visible = false
        };

        _btnEditOrder = new Button
        {
            Text = "✏️ Edit Order",
            Font = AppTheme.BodyBold,
            ForeColor = Color.White,
            BackColor = AppTheme.PrimaryButton,
            FlatStyle = FlatStyle.Flat,
            Size = new Size(130, 38),
            Location = new Point(0, 32),
            Cursor = Cursors.Hand
        };
        _btnEditOrder.FlatAppearance.BorderSize = 0;
        _btnEditOrder.Click += (s, e) =>
        {
            if (_currentOrder != null && _currentOrder.CanEdit)
            {
                Navigate(ViewType.EditOrder, _currentOrder.OrderNumber);
            }
        };

        _btnCancelOrder = new Button
        {
            Text = "✕ Cancel Order",
            Font = AppTheme.BodyRegular,
            ForeColor = AppTheme.DangerButton,
            BackColor = Color.White,
            FlatStyle = FlatStyle.Flat,
            Size = new Size(130, 38),
            Location = new Point(140, 32),
            Cursor = Cursors.Hand
        };
        _btnCancelOrder.FlatAppearance.BorderColor = AppTheme.CardBorder;
        _btnCancelOrder.Click += (s, e) => CancelCurrentOrder();

        _pnlActionsBar.Controls.Add(_lblLockedNotice);
        _pnlActionsBar.Controls.Add(_btnEditOrder);
        _pnlActionsBar.Controls.Add(_btnCancelOrder);

        // Assemble Layout
        var pnlStack = new Panel
        {
            Dock = DockStyle.Top,
            AutoSize = true,
            BackColor = AppTheme.ContentBackground
        };

        _pnlInfoCard.Dock = DockStyle.Top;
        _pnlItemsCard.Dock = DockStyle.Top;
        _pnlActionsBar.Dock = DockStyle.Top;

        var gap1 = new Panel { Dock = DockStyle.Top, Height = 14 };
        var gap2 = new Panel { Dock = DockStyle.Top, Height = 14 };

        pnlStack.Controls.Add(_pnlActionsBar);
        pnlStack.Controls.Add(gap2);
        pnlStack.Controls.Add(_pnlItemsCard);
        pnlStack.Controls.Add(gap1);
        pnlStack.Controls.Add(_pnlInfoCard);

        pnlScroll.Controls.Add(pnlStack);
        ContentPanel.Controls.Add(pnlScroll);
    }

    private Panel CreateCard(int height)
    {
        var panel = new Panel
        {
            Height = height,
            BackColor = AppTheme.CardBackground,
            Padding = new Padding(18)
        };
        panel.Paint += (s, e) =>
        {
            using var pen = new Pen(AppTheme.CardBorder);
            e.Graphics.DrawRectangle(pen, 0, 0, panel.Width - 1, panel.Height - 1);
        };
        return panel;
    }

    public override void OnNavigatedTo(object? parameter = null)
    {
        base.OnNavigatedTo(parameter);

        int orderNum = 104; // Default order
        if (parameter is int num)
        {
            orderNum = num;
        }

        _currentOrder = _store.FindOrderByNumber(orderNum) ?? _store.Orders.FirstOrDefault();
        DisplayOrder(_currentOrder);
    }

    private void DisplayOrder(Order? order)
    {
        if (order == null) return;

        _lblOrderNumberTitle.Text = $"#{order.OrderNumber} Order Information";
        _lblOrderNumValue.Text = $"#{order.OrderNumber}";
        _lblCustomerValue.Text = order.CustomerName;
        _lblTableValue.Text = $"Table {order.TableNumber}";
        _lblCreatedValue.Text = order.CreatedAt.ToString("h:mm tt");

        UpdateStatusBadge(order.Status);

        // Populate Items Grid
        _gridItems.Rows.Clear();
        foreach (var item in order.Items)
        {
            _gridItems.Rows.Add(
                item.ItemName,
                $"{item.UnitPrice:N0} ETB",
                item.Quantity.ToString(),
                $"{item.Subtotal:N0} ETB"
            );
        }

        int count = order.Items.Count;
        int totalQty = order.TotalItemQuantity;
        _lblItemsCountTitle.Text = $"{count} {(count == 1 ? "item" : "items")}";
        _lblSummaryQty.Text = $"{count} {(count == 1 ? "item" : "items")} • {totalQty} total quantity";
        _lblTotalAmount.Text = $"Total  {order.Total:N0} ETB";

        // Handle Completed/Cancelled Locked States
        if (order.Status == OrderStatus.Completed)
        {
            _lblLockedNotice.Text = "ⓘ Completed orders cannot be edited or cancelled, but remain viewable.";
            _lblLockedNotice.Visible = true;
            _btnEditOrder.Enabled = false;
            _btnCancelOrder.Enabled = false;
        }
        else if (order.Status == OrderStatus.Cancelled)
        {
            _lblLockedNotice.Text = "ⓘ This order has been cancelled and cannot be edited.";
            _lblLockedNotice.Visible = true;
            _btnEditOrder.Enabled = false;
            _btnCancelOrder.Enabled = false;
        }
        else
        {
            _lblLockedNotice.Visible = false;
            _btnEditOrder.Enabled = true;
            _btnCancelOrder.Enabled = true;
        }
    }

    private void UpdateStatusBadge(OrderStatus status)
    {
        _lblStatusBadge.Text = status.ToString();

        switch (status)
        {
            case OrderStatus.Pending:
                _lblStatusBadge.BackColor = AppTheme.StatusPendingBg;
                _lblStatusBadge.ForeColor = AppTheme.StatusPendingText;
                break;
            case OrderStatus.Preparing:
                _lblStatusBadge.BackColor = AppTheme.StatusPreparingBg;
                _lblStatusBadge.ForeColor = AppTheme.StatusPreparingText;
                break;
            case OrderStatus.Ready:
                _lblStatusBadge.BackColor = AppTheme.StatusReadyBg;
                _lblStatusBadge.ForeColor = AppTheme.StatusReadyText;
                break;
            case OrderStatus.Completed:
                _lblStatusBadge.BackColor = AppTheme.StatusCompletedBg;
                _lblStatusBadge.ForeColor = AppTheme.StatusCompletedText;
                break;
            case OrderStatus.Cancelled:
            default:
                _lblStatusBadge.BackColor = AppTheme.StatusCancelledBg;
                _lblStatusBadge.ForeColor = AppTheme.StatusCancelledText;
                break;
        }
    }

    private void CancelCurrentOrder()
    {
        if (_currentOrder == null || !_currentOrder.CanCancel) return;

        string message = $"Are you sure you want to cancel Order #{_currentOrder.OrderNumber}?\n#{_currentOrder.OrderNumber} • {_currentOrder.CustomerName} • Table {_currentOrder.TableNumber} • {_currentOrder.Status}";
        if (ConfirmationDialog.Confirm(this, "Cancel Order?", "Cancel Order?", message, "Yes, Cancel Order", isDanger: true))
        {
            _orderService.CancelOrder(_currentOrder.OrderNumber);
            DisplayOrder(_currentOrder);
        }
    }
}
