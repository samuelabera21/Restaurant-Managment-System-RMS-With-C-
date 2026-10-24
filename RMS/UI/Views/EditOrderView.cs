using System.Drawing;
using System.Windows.Forms;
using RMS.Common;
using RMS.Models;
using RMS.Services;
using RMS.UI.Dialogs;
using RMS.UI.Navigation;
using MenuItem = RMS.Models.MenuItem;

namespace RMS.UI.Views;

/// <summary>
/// Edit Order screen view for modifying an active order:
/// customer name, table number, item additions, quantity adjustments, and removal.
/// Enforces business rules and locked states for completed orders.
/// Matches UI/orders/Orders6.jpg through Orders12.jpg.
/// </summary>
public class EditOrderView : BaseView
{
    private readonly RestaurantStore _store = RestaurantStore.Instance;
    private readonly OrderService _orderService = new();

    private Order? _originalOrder;
    private readonly List<OrderItem> _editItems = new();
    private bool _hasUnsavedChanges = false;
    private bool _isOrderCompleted = false;

    // Controls
    private readonly Label _lblSubheaderContext;
    private readonly Panel _pnlAlertBanner;
    private readonly Panel _pnlAlertSpacing;
    private readonly Label _lblAlertMessage;

    // Order Information Controls
    private readonly Label _lblOrderNumberBadge;
    private readonly TextBox _txtCustomerName;
    private readonly Label _lblCustomerNameError;
    private readonly NumericUpDown _numTableNumber;
    private readonly Label _lblTableNumberError;
    private readonly Label _lblCurrentStatusBadge;

    // Add Items Controls
    private readonly ComboBox _cboMenuItems;
    private readonly NumericUpDown _numQuantity;
    private readonly Button _btnAddItem;

    // Order Items Table & Totals
    private readonly Panel _pnlTableCard;
    private readonly DataGridView _gridItems;
    private readonly Label _lblSummaryQty;
    private readonly Label _lblTotalAmount;

    // Bottom Action Buttons
    private readonly Button _btnSaveChanges;
    private readonly Button _btnCancelChanges;
    private readonly Button _btnBackToDetails;

    public EditOrderView() : base("Edit Order", "Update an existing restaurant order")
    {
        // Top right context subheader (#104 • Hana • Table 4)
        _lblSubheaderContext = new Label
        {
            Text = "#104 • Hana • Table 4 • Existing order",
            Font = AppTheme.SmallBold,
            ForeColor = AppTheme.TextSecondary,
            Anchor = AnchorStyles.Top | AnchorStyles.Right,
            Location = new Point(HeaderPanel.Width - 320, 20),
            AutoSize = true
        };
        HeaderPanel.Controls.Add(_lblSubheaderContext);
        HeaderPanel.Resize += (s, e) =>
        {
            _lblSubheaderContext.Location = new Point(HeaderPanel.Width - 320, 20);
        };

        // Alert Banner
        _pnlAlertBanner = new Panel
        {
            Dock = DockStyle.Top,
            Height = 42,
            BackColor = Color.FromArgb(243, 244, 246),
            Padding = new Padding(16, 10, 16, 10)
        };
        _pnlAlertBanner.Paint += (s, e) =>
        {
            Color borderColor = (_lblAlertMessage?.ForeColor == AppTheme.DangerButton)
                ? Color.FromArgb(252, 165, 165)
                : (_lblAlertMessage?.ForeColor == AppTheme.StatusReadyText)
                    ? Color.FromArgb(187, 247, 208)
                    : AppTheme.CardBorder;
            using var pen = new Pen(borderColor);
            e.Graphics.DrawRectangle(pen, 0, 0, _pnlAlertBanner.Width - 1, _pnlAlertBanner.Height - 1);
        };
        _lblAlertMessage = new Label
        {
            Text = "ⓘ Update customer details, add items or change quantities, then save.",
            Font = AppTheme.SmallRegular,
            ForeColor = AppTheme.TextSecondary,
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleLeft
        };
        _pnlAlertBanner.Controls.Add(_lblAlertMessage);

        _pnlAlertSpacing = new Panel
        {
            Dock = DockStyle.Top,
            Height = 12,
            BackColor = AppTheme.ContentBackground
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
        var cardOrderInfo = CreateCard(128);
        var lblInfoTitle = new Label { Text = "Order information", Font = AppTheme.SectionTitle, ForeColor = AppTheme.TextPrimary, Location = new Point(18, 14), AutoSize = true };

        var lblOrderNumCaption = new Label { Text = "Order Number", Font = AppTheme.SmallBold, ForeColor = AppTheme.TextSecondary, Location = new Point(18, 42), AutoSize = true };
        _lblOrderNumberBadge = new Label
        {
            Text = "#104  🔒",
            Font = AppTheme.BodyBold,
            ForeColor = AppTheme.TextPrimary,
            BackColor = Color.FromArgb(243, 244, 246),
            Size = new Size(110, 32),
            Location = new Point(18, 62),
            TextAlign = ContentAlignment.MiddleCenter
        };

        var lblCustCaption = new Label { Text = "Customer Name *", Font = AppTheme.SmallBold, ForeColor = AppTheme.TextSecondary, Location = new Point(148, 42), AutoSize = true };
        _txtCustomerName = new TextBox { Font = AppTheme.BodyRegular, Location = new Point(148, 64), Width = 240 };
        _txtCustomerName.TextChanged += (s, e) => MarkDirty();
        _lblCustomerNameError = new Label { Text = "Customer name is required.", Font = AppTheme.SmallRegular, ForeColor = AppTheme.DangerButton, Location = new Point(148, 96), AutoSize = true, Visible = false };

        var lblTableCaption = new Label { Text = "Table Number *", Font = AppTheme.SmallBold, ForeColor = AppTheme.TextSecondary, Location = new Point(410, 42), AutoSize = true };
        _numTableNumber = new NumericUpDown { Font = AppTheme.BodyRegular, Location = new Point(410, 64), Width = 100, Minimum = 1, Maximum = 99 };
        _numTableNumber.ValueChanged += (s, e) => MarkDirty();
        _lblTableNumberError = new Label { Text = "Please enter a valid table number.", Font = AppTheme.SmallRegular, ForeColor = AppTheme.DangerButton, Location = new Point(410, 96), AutoSize = true, Visible = false };

        var lblStatusCaption = new Label { Text = "Current status", Font = AppTheme.SmallBold, ForeColor = AppTheme.TextSecondary, Location = new Point(540, 42), AutoSize = true };
        _lblCurrentStatusBadge = new Label
        {
            Text = "Pending",
            Font = AppTheme.SmallBold,
            ForeColor = AppTheme.StatusPendingText,
            BackColor = AppTheme.StatusPendingBg,
            Size = new Size(86, 24),
            Location = new Point(540, 64),
            TextAlign = ContentAlignment.MiddleCenter
        };

        cardOrderInfo.Controls.Add(lblInfoTitle);
        cardOrderInfo.Controls.Add(lblOrderNumCaption);
        cardOrderInfo.Controls.Add(_lblOrderNumberBadge);
        cardOrderInfo.Controls.Add(lblCustCaption);
        cardOrderInfo.Controls.Add(_txtCustomerName);
        cardOrderInfo.Controls.Add(_lblCustomerNameError);
        cardOrderInfo.Controls.Add(lblTableCaption);
        cardOrderInfo.Controls.Add(_numTableNumber);
        cardOrderInfo.Controls.Add(_lblTableNumberError);
        cardOrderInfo.Controls.Add(lblStatusCaption);
        cardOrderInfo.Controls.Add(_lblCurrentStatusBadge);

        // ----------------------------------------------------
        // 2. Add Items Card
        // ----------------------------------------------------
        var cardAddItems = CreateCard(120);
        var lblAddTitle = new Label { Text = "Add items", Font = AppTheme.SectionTitle, ForeColor = AppTheme.TextPrimary, Location = new Point(18, 12), AutoSize = true };

        var lblMenuItemCaption = new Label { Text = "Menu Item", Font = AppTheme.SmallBold, ForeColor = AppTheme.TextSecondary, Location = new Point(18, 38), AutoSize = true };
        _cboMenuItems = new ComboBox
        {
            Font = AppTheme.BodyRegular,
            Location = new Point(18, 60),
            Width = 370,
            DropDownStyle = ComboBoxStyle.DropDownList,
            FormattingEnabled = true
        };

        var lblQtyCaption = new Label { Text = "Quantity", Font = AppTheme.SmallBold, ForeColor = AppTheme.TextSecondary, Location = new Point(410, 38), AutoSize = true };
        _numQuantity = new NumericUpDown { Font = AppTheme.BodyRegular, Location = new Point(410, 60), Width = 90, Minimum = 1, Maximum = 100, Value = 1 };

        _btnAddItem = new Button
        {
            Text = "+ Add Item",
            Font = AppTheme.BodyBold,
            ForeColor = Color.White,
            BackColor = AppTheme.PrimaryButton,
            FlatStyle = FlatStyle.Flat,
            Size = new Size(120, 34),
            Location = new Point(520, 58),
            Cursor = Cursors.Hand
        };
        _btnAddItem.FlatAppearance.BorderSize = 0;
        _btnAddItem.Click += (s, e) => AddSelectedItem();

        cardAddItems.Controls.Add(lblAddTitle);
        cardAddItems.Controls.Add(lblMenuItemCaption);
        cardAddItems.Controls.Add(_cboMenuItems);
        cardAddItems.Controls.Add(lblQtyCaption);
        cardAddItems.Controls.Add(_numQuantity);
        cardAddItems.Controls.Add(_btnAddItem);

        // ----------------------------------------------------
        // 3. Order Items Table Card
        // ----------------------------------------------------
        _pnlTableCard = CreateCard(260);
        var lblItemsCardTitle = new Label { Text = "Order items", Font = AppTheme.SectionTitle, ForeColor = AppTheme.TextPrimary, Location = new Point(18, 14), AutoSize = true };

        _gridItems = new DataGridView
        {
            Location = new Point(18, 44),
            Size = new Size(_pnlTableCard.Width - 36, 150),
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
            FillWeight = 28,
            MinimumWidth = 150, 
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill 
        });
        _gridItems.Columns.Add(new DataGridViewTextBoxColumn 
        { 
            Name = "ColPrice", 
            HeaderText = "Unit Price", 
            FillWeight = 20,
            MinimumWidth = 110, 
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill 
        });
        _gridItems.Columns.Add(new DataGridViewTextBoxColumn 
        { 
            Name = "ColQty", 
            HeaderText = "Quantity", 
            FillWeight = 16,
            MinimumWidth = 100, 
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill 
        });
        _gridItems.Columns.Add(new DataGridViewTextBoxColumn 
        { 
            Name = "ColSubtotal", 
            HeaderText = "Subtotal", 
            FillWeight = 20,
            MinimumWidth = 110, 
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill 
        });

        var colAction = new DataGridViewLinkColumn
        {
            Name = "ColAction",
            HeaderText = "Action",
            Text = "🗑 Remove",
            UseColumnTextForLinkValue = true,
            LinkColor = AppTheme.DangerButton,
            ActiveLinkColor = AppTheme.DangerButtonHover,
            TrackVisitedState = false,
            FillWeight = 16,
            MinimumWidth = 110,
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        };
        _gridItems.Columns.Add(colAction);
        _gridItems.CellContentClick += GridItems_CellContentClick;

        _lblSummaryQty = new Label
        {
            Text = "2 items • 3 total quantity | Subtotals and total update automatically.",
            Font = AppTheme.SmallRegular,
            ForeColor = AppTheme.TextMuted,
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
            Location = new Point(_pnlTableCard.Width - 240, 208),
            Size = new Size(220, 36),
            TextAlign = ContentAlignment.MiddleRight
        };
        _pnlTableCard.Resize += (s, e) =>
        {
            _lblTotalAmount.Location = new Point(_pnlTableCard.Width - 240, 208);
        };

        _pnlTableCard.Controls.Add(lblItemsCardTitle);
        _pnlTableCard.Controls.Add(_gridItems);
        _pnlTableCard.Controls.Add(_lblSummaryQty);
        _pnlTableCard.Controls.Add(_lblTotalAmount);

        // ----------------------------------------------------
        // 4. Bottom Action Buttons Bar
        // ----------------------------------------------------
        var pnlActions = new Panel
        {
            Dock = DockStyle.Top,
            Height = 70,
            BackColor = AppTheme.ContentBackground,
            Padding = new Padding(0, 10, 0, 10)
        };

        _btnSaveChanges = new Button
        {
            Text = "💾 Save Changes",
            Font = AppTheme.BodyBold,
            ForeColor = Color.White,
            BackColor = AppTheme.PrimaryButton,
            FlatStyle = FlatStyle.Flat,
            Size = new Size(140, 38),
            Location = new Point(0, 12),
            Cursor = Cursors.Hand
        };
        _btnSaveChanges.FlatAppearance.BorderSize = 0;
        _btnSaveChanges.Click += (s, e) => SaveChanges();

        _btnCancelChanges = new Button
        {
            Text = "Cancel Changes",
            Font = AppTheme.BodyRegular,
            ForeColor = AppTheme.TextPrimary,
            BackColor = Color.White,
            FlatStyle = FlatStyle.Flat,
            Size = new Size(130, 38),
            Location = new Point(150, 12),
            Cursor = Cursors.Hand
        };
        _btnCancelChanges.FlatAppearance.BorderColor = AppTheme.CardBorder;
        _btnCancelChanges.Click += (s, e) => CancelChanges();

        _btnBackToDetails = new Button
        {
            Text = "← Back to Order Details",
            Font = AppTheme.BodyBold,
            ForeColor = Color.White,
            BackColor = AppTheme.PrimaryButton,
            FlatStyle = FlatStyle.Flat,
            Size = new Size(180, 38),
            Anchor = AnchorStyles.Top | AnchorStyles.Right,
            Location = new Point(pnlActions.Width - 200, 12),
            Cursor = Cursors.Hand,
            Visible = false
        };
        _btnBackToDetails.FlatAppearance.BorderSize = 0;
        _btnBackToDetails.Click += (s, e) =>
        {
            if (_originalOrder != null)
            {
                Navigate(ViewType.OrderDetails, _originalOrder.OrderNumber);
            }
        };

        pnlActions.Controls.Add(_btnSaveChanges);
        pnlActions.Controls.Add(_btnCancelChanges);
        pnlActions.Controls.Add(_btnBackToDetails);
        pnlActions.Resize += (s, e) =>
        {
            _btnBackToDetails.Location = new Point(pnlActions.Width - 200, 12);
        };

        // Assemble Layout
        var pnlStack = new Panel
        {
            Dock = DockStyle.Top,
            AutoSize = true,
            BackColor = AppTheme.ContentBackground
        };

        cardOrderInfo.Dock = DockStyle.Top;
        cardAddItems.Dock = DockStyle.Top;
        _pnlTableCard.Dock = DockStyle.Top;
        pnlActions.Dock = DockStyle.Top;

        var gap1 = new Panel { Dock = DockStyle.Top, Height = 14 };
        var gap2 = new Panel { Dock = DockStyle.Top, Height = 14 };

        pnlStack.Controls.Add(pnlActions);
        pnlStack.Controls.Add(_pnlTableCard);
        pnlStack.Controls.Add(gap2);
        pnlStack.Controls.Add(cardAddItems);
        pnlStack.Controls.Add(gap1);
        pnlStack.Controls.Add(cardOrderInfo);

        pnlScroll.Controls.Add(pnlStack);
        ContentPanel.Controls.Add(pnlScroll);
        ContentPanel.Controls.Add(_pnlAlertSpacing);
        ContentPanel.Controls.Add(_pnlAlertBanner);

        PopulateAvailableMenuItems();
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

        int orderNum = 104;
        if (parameter is int num)
        {
            orderNum = num;
        }

        _originalOrder = _store.FindOrderByNumber(orderNum) ?? _store.Orders.FirstOrDefault();
        LoadOrderForEditing(_originalOrder);
    }

    private void PopulateAvailableMenuItems()
    {
        _cboMenuItems.Items.Clear();
        var availableItems = _store.MenuItems.Where(m => m.IsAvailable).ToList();
        foreach (var item in availableItems)
        {
            _cboMenuItems.Items.Add(item);
        }

        if (_cboMenuItems.Items.Count > 0)
        {
            _cboMenuItems.SelectedIndex = 0;
        }
    }

    private void LoadOrderForEditing(Order? order)
    {
        if (order == null) return;

        _hasUnsavedChanges = false;
        _isOrderCompleted = order.Status == OrderStatus.Completed || order.Status == OrderStatus.Cancelled;

        _lblOrderNumberBadge.Text = $"#{order.OrderNumber}  🔒";
        _txtCustomerName.Text = order.CustomerName;
        _numTableNumber.Value = order.TableNumber;
        _lblSubheaderContext.Text = $"#{order.OrderNumber} • {order.CustomerName} • Table {order.TableNumber} • {(order.CanEdit ? "Existing order" : "Read-only order")}";

        UpdateStatusBadge(order.Status);

        // Copy items snapshot
        _editItems.Clear();
        foreach (var item in order.Items)
        {
            _editItems.Add(new OrderItem(item.MenuItemId, item.ItemName, item.UnitPrice, item.Quantity));
        }

        RefreshItemsTable();

        // Lock / Unlock based on order status
        if (_isOrderCompleted)
        {
            _txtCustomerName.ReadOnly = true;
            _numTableNumber.Enabled = false;
            _cboMenuItems.Enabled = false;
            _numQuantity.Enabled = false;
            _btnAddItem.Enabled = false;
            _btnSaveChanges.Enabled = false;
            _btnCancelChanges.Enabled = false;
            _btnBackToDetails.Visible = true;

            ShowAlert("🔒 Completed orders cannot be edited.", isError: true);
        }
        else
        {
            _txtCustomerName.ReadOnly = false;
            _numTableNumber.Enabled = true;
            _cboMenuItems.Enabled = true;
            _numQuantity.Enabled = true;
            _btnAddItem.Enabled = true;
            _btnSaveChanges.Enabled = true;
            _btnCancelChanges.Enabled = true;
            _btnBackToDetails.Visible = false;

            ShowAlert("ⓘ Update customer details, add items or change quantities, then save.", isError: false);
        }
    }

    private void MarkDirty()
    {
        if (_isOrderCompleted) return;

        _hasUnsavedChanges = true;
        if (_originalOrder != null)
        {
            _lblSubheaderContext.Text = $"#{_originalOrder.OrderNumber} • {_txtCustomerName.Text.Trim()} • Table {_numTableNumber.Value} • Unsaved changes";
        }
        ShowAlert($"ⓘ You have unsaved changes to Order #{_originalOrder?.OrderNumber}. Save Changes to apply them.", isError: false);
    }

    private void AddSelectedItem()
    {
        if (_isOrderCompleted) return;

        if (_cboMenuItems.SelectedItem is not MenuItem selectedMenu) return;

        int qty = (int)_numQuantity.Value;
        if (qty <= 0) return;

        var existing = _editItems.FirstOrDefault(i => i.MenuItemId == selectedMenu.Id);
        if (existing != null)
        {
            existing.Quantity += qty;
        }
        else
        {
            _editItems.Add(OrderItem.CreateFromMenuItem(selectedMenu, qty));
        }

        _numQuantity.Value = 1;
        RefreshItemsTable();
        MarkDirty();
    }

    private void RefreshItemsTable()
    {
        _gridItems.Rows.Clear();
        decimal total = 0m;
        int totalQty = 0;

        foreach (var item in _editItems)
        {
            int rowIndex = _gridItems.Rows.Add(
                item.ItemName,
                $"{item.UnitPrice:N0} ETB",
                item.Quantity.ToString(),
                $"{item.Subtotal:N0} ETB",
                "🗑 Remove"
            );
            _gridItems.Rows[rowIndex].Tag = item;
            total += item.Subtotal;
            totalQty += item.Quantity;
        }

        int count = _editItems.Count;
        _lblSummaryQty.Text = $"{count} {(count == 1 ? "item" : "items")} • {totalQty} total quantity | Subtotals and total update automatically.";
        _lblTotalAmount.Text = $"Total  {total:N0} ETB";
    }

    private void GridItems_CellContentClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || _isOrderCompleted) return;

        int actionColIndex = _gridItems.Columns["ColAction"]?.Index ?? -1;
        if (actionColIndex >= 0 && e.ColumnIndex == actionColIndex)
        {
            if (_gridItems.Rows[e.RowIndex].Tag is OrderItem item)
            {
                _editItems.Remove(item);
                RefreshItemsTable();
                MarkDirty();
            }
        }
    }

    private void SaveChanges()
    {
        if (_originalOrder == null || _isOrderCompleted) return;

        string custName = _txtCustomerName.Text.Trim();
        int tableNum = (int)_numTableNumber.Value;

        if (!_orderService.ValidateOrder(custName, tableNum, _editItems, out var errors))
        {
            _lblCustomerNameError.Visible = string.IsNullOrWhiteSpace(custName);
            _lblTableNumberError.Visible = tableNum <= 0;
            ShowAlert($"⚠️ Please correct the highlighted fields before saving Order #{_originalOrder.OrderNumber}.", isError: true);
            return;
        }

        _orderService.UpdateOrder(_originalOrder.OrderNumber, custName, tableNum, _editItems);
        _hasUnsavedChanges = false;

        ShowAlert($"✓ Order #{_originalOrder.OrderNumber} updated successfully.", isError: false, isSuccess: true);
        _lblSubheaderContext.Text = $"#{_originalOrder.OrderNumber} • {custName} • Table {tableNum} • All changes saved";
        _btnBackToDetails.Visible = true;
    }

    private void CancelChanges()
    {
        if (_hasUnsavedChanges && _originalOrder != null)
        {
            if (ConfirmationDialog.Confirm(
                    this,
                    "Edit Order",
                    "Discard unsaved changes?",
                    $"Your changes to Order #{_originalOrder.OrderNumber} will be lost.",
                    "Discard Changes"))
            {
                LoadOrderForEditing(_originalOrder);
            }
        }
        else if (_originalOrder != null)
        {
            Navigate(ViewType.OrderDetails, _originalOrder.OrderNumber);
        }
    }

    private void UpdateStatusBadge(OrderStatus status)
    {
        _lblCurrentStatusBadge.Text = status.ToString();
        switch (status)
        {
            case OrderStatus.Pending:
                _lblCurrentStatusBadge.BackColor = AppTheme.StatusPendingBg;
                _lblCurrentStatusBadge.ForeColor = AppTheme.StatusPendingText;
                break;
            case OrderStatus.Preparing:
                _lblCurrentStatusBadge.BackColor = AppTheme.StatusPreparingBg;
                _lblCurrentStatusBadge.ForeColor = AppTheme.StatusPreparingText;
                break;
            case OrderStatus.Ready:
                _lblCurrentStatusBadge.BackColor = AppTheme.StatusReadyBg;
                _lblCurrentStatusBadge.ForeColor = AppTheme.StatusReadyText;
                break;
            case OrderStatus.Completed:
                _lblCurrentStatusBadge.BackColor = AppTheme.StatusCompletedBg;
                _lblCurrentStatusBadge.ForeColor = AppTheme.StatusCompletedText;
                break;
            case OrderStatus.Cancelled:
            default:
                _lblCurrentStatusBadge.BackColor = AppTheme.StatusCancelledBg;
                _lblCurrentStatusBadge.ForeColor = AppTheme.StatusCancelledText;
                break;
        }
    }

    private void ShowAlert(string message, bool isError = false, bool isSuccess = false)
    {
        _pnlAlertBanner.Visible = true;
        _lblAlertMessage.Text = message;

        if (isSuccess)
        {
            _pnlAlertBanner.BackColor = AppTheme.StatusReadyBg;
            _lblAlertMessage.ForeColor = AppTheme.StatusReadyText;
        }
        else if (isError)
        {
            _pnlAlertBanner.BackColor = Color.FromArgb(254, 226, 226);
            _lblAlertMessage.ForeColor = AppTheme.DangerButton;
        }
        else
        {
            _pnlAlertBanner.BackColor = Color.FromArgb(243, 244, 246);
            _lblAlertMessage.ForeColor = AppTheme.TextSecondary;
        }
        _pnlAlertBanner.Invalidate();
    }
}
