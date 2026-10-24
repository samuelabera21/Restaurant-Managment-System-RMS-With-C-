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
/// Order creation screen view.
/// Handles sequential order numbering (#116+), item selection with available items only,
/// real-time total calculations, validation alerts, and save confirmations.
/// Matches all 7 states in UI/new-order/.
/// </summary>
public class NewOrderView : BaseView
{
    private readonly RestaurantStore _store = RestaurantStore.Instance;
    private readonly OrderService _orderService = new();

    // In-memory line items for the new order
    private readonly List<OrderItem> _lineItems = new();
    private bool _isOrderSaved = false;

    // UI Panels & Banners
    private readonly Panel _pnlAlertBanner;
    private readonly Panel _pnlAlertSpacing;
    private readonly Label _lblAlertMessage;

    // Order Information Controls
    private readonly Label _lblOrderNumberBadge;
    private readonly TextBox _txtCustomerName;
    private readonly Label _lblCustomerNameError;
    private readonly NumericUpDown _numTableNumber;
    private readonly Label _lblTableNumberError;
    private readonly Label _lblOrderDateTime;

    // Add Items Controls
    private readonly ComboBox _cboMenuItems;
    private readonly NumericUpDown _numQuantity;
    private readonly Label _lblQuantityError;
    private readonly Button _btnAddItem;

    // Order Items Table & Totals
    private readonly Panel _pnlTableCard;
    private readonly Label _lblItemCountSubtitle;
    private readonly DataGridView _gridItems;
    private readonly Panel _pnlEmptyItemsState;
    private readonly Label _lblTotalAmount;

    // Bottom Action Buttons
    private readonly Button _btnSaveOrder;
    private readonly Button _btnClearForm;
    private readonly Button _btnCancel;
    private readonly Button _btnViewOrders;

    public NewOrderView() : base("New Order", "Create a new restaurant order")
    {
        // ----------------------------------------------------
        // 1. Top Alert Banner (for Validation Errors & Success)
        // ----------------------------------------------------
        _pnlAlertBanner = new Panel
        {
            Dock = DockStyle.Top,
            Height = 42,
            BackColor = Color.FromArgb(254, 226, 226), // Default light red
            Padding = new Padding(16, 10, 16, 10),
            Visible = false
        };
        _pnlAlertBanner.Paint += (s, e) =>
        {
            Color borderColor = (_lblAlertMessage?.ForeColor == AppTheme.DangerButton)
                ? Color.FromArgb(252, 165, 165)
                : Color.FromArgb(187, 247, 208);
            using var pen = new Pen(borderColor);
            e.Graphics.DrawRectangle(pen, 0, 0, _pnlAlertBanner.Width - 1, _pnlAlertBanner.Height - 1);
        };
        _lblAlertMessage = new Label
        {
            Text = string.Empty,
            Font = AppTheme.SmallBold,
            ForeColor = AppTheme.DangerButton,
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleLeft
        };
        _pnlAlertBanner.Controls.Add(_lblAlertMessage);

        _pnlAlertSpacing = new Panel
        {
            Dock = DockStyle.Top,
            Height = 12,
            BackColor = AppTheme.ContentBackground,
            Visible = false
        };

        // Required fields label on header
        var lblRequiredNote = new Label
        {
            Text = "* Required fields",
            Font = AppTheme.SmallRegular,
            ForeColor = AppTheme.TextSecondary,
            AutoSize = true,
            Anchor = AnchorStyles.Top | AnchorStyles.Right,
            Location = new Point(HeaderPanel.Width - 140, 20)
        };
        HeaderPanel.Controls.Add(lblRequiredNote);
        HeaderPanel.Resize += (s, e) =>
        {
            lblRequiredNote.Location = new Point(HeaderPanel.Width - 140, 20);
        };

        // Main scrollable canvas container
        var pnlScrollCanvas = new Panel
        {
            Dock = DockStyle.Fill,
            AutoScroll = true,
            BackColor = AppTheme.ContentBackground
        };

        // ----------------------------------------------------
        // 2. Order Information Card
        // ----------------------------------------------------
        var cardOrderInfo = CreateCardPanel(128);
        var lblInfoTitle = new Label
        {
            Text = "Order information",
            Font = AppTheme.SectionTitle,
            ForeColor = AppTheme.TextPrimary,
            Location = new Point(18, 14),
            AutoSize = true
        };

        // Order Number (Read-only badge)
        var lblOrderNumCaption = new Label { Text = "Order Number", Font = AppTheme.SmallBold, ForeColor = AppTheme.TextSecondary, Location = new Point(18, 42), AutoSize = true };
        _lblOrderNumberBadge = new Label
        {
            Text = "#116  🔒",
            Font = AppTheme.BodyBold,
            ForeColor = AppTheme.TextPrimary,
            BackColor = Color.FromArgb(243, 244, 246),
            Size = new Size(110, 32),
            Location = new Point(18, 62),
            TextAlign = ContentAlignment.MiddleCenter
        };

        // Customer Name
        var lblCustCaption = new Label { Text = "Customer Name *", Font = AppTheme.SmallBold, ForeColor = AppTheme.TextSecondary, Location = new Point(148, 42), AutoSize = true };
        _txtCustomerName = new TextBox
        {
            Font = AppTheme.BodyRegular,
            Location = new Point(148, 64),
            Width = 240,
            PlaceholderText = "Enter customer name"
        };
        _txtCustomerName.TextChanged += (s, e) => ClearValidationErrors();
        _lblCustomerNameError = new Label
        {
            Text = "Customer name is required.",
            Font = AppTheme.SmallRegular,
            ForeColor = AppTheme.DangerButton,
            Location = new Point(148, 96),
            AutoSize = true,
            Visible = false
        };

        // Table Number
        var lblTableCaption = new Label { Text = "Table Number *", Font = AppTheme.SmallBold, ForeColor = AppTheme.TextSecondary, Location = new Point(410, 42), AutoSize = true };
        _numTableNumber = new NumericUpDown
        {
            Font = AppTheme.BodyRegular,
            Location = new Point(410, 64),
            Width = 100,
            Minimum = 1,
            Maximum = 99,
            Value = 4
        };
        _lblTableNumberError = new Label
        {
            Text = "Please enter a valid table number.",
            Font = AppTheme.SmallRegular,
            ForeColor = AppTheme.DangerButton,
            Location = new Point(410, 96),
            AutoSize = true,
            Visible = false
        };

        // Order Date / Time
        var lblDateTimeCaption = new Label { Text = "Order Date / Time", Font = AppTheme.SmallBold, ForeColor = AppTheme.TextSecondary, Location = new Point(550, 42), AutoSize = true };
        _lblOrderDateTime = new Label
        {
            Text = DateTime.Now.ToString("dd MMM yyyy, h:mm tt") + "  🔒",
            Font = AppTheme.BodyRegular,
            ForeColor = AppTheme.TextSecondary,
            BackColor = Color.FromArgb(243, 244, 246),
            Size = new Size(180, 32),
            Location = new Point(550, 62),
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
        cardOrderInfo.Controls.Add(lblDateTimeCaption);
        cardOrderInfo.Controls.Add(_lblOrderDateTime);

        // ----------------------------------------------------
        // 3. Add Items Card
        // ----------------------------------------------------
        var cardAddItems = CreateCardPanel(128);
        var lblAddTitle = new Label
        {
            Text = "Add items",
            Font = AppTheme.SectionTitle,
            ForeColor = AppTheme.TextPrimary,
            Location = new Point(18, 12),
            AutoSize = true
        };

        var lblMenuItemCaption = new Label { Text = "Menu Item", Font = AppTheme.SmallBold, ForeColor = AppTheme.TextSecondary, Location = new Point(18, 38), AutoSize = true };
        _cboMenuItems = new ComboBox
        {
            Font = AppTheme.BodyRegular,
            Location = new Point(18, 60),
            Width = 370,
            DropDownStyle = ComboBoxStyle.DropDownList,
            FormattingEnabled = true
        };

        var lblAvailabilityHint = new Label
        {
            Text = "Available: Coffee 40 · Burger 180 · Tea 30 · Pizza 250 ETB | Juice 60 ETB — Unavailable",
            Font = AppTheme.SmallRegular,
            ForeColor = AppTheme.TextMuted,
            Location = new Point(18, 96),
            AutoSize = true
        };

        var lblQtyCaption = new Label { Text = "Quantity", Font = AppTheme.SmallBold, ForeColor = AppTheme.TextSecondary, Location = new Point(410, 38), AutoSize = true };
        _numQuantity = new NumericUpDown
        {
            Font = AppTheme.BodyRegular,
            Location = new Point(410, 60),
            Width = 90,
            Minimum = 1,
            Maximum = 100,
            Value = 1
        };
        _lblQuantityError = new Label
        {
            Text = "Quantity must be greater than zero.",
            Font = AppTheme.SmallRegular,
            ForeColor = AppTheme.DangerButton,
            Location = new Point(410, 96),
            AutoSize = true,
            Visible = false
        };

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
        cardAddItems.Controls.Add(lblAvailabilityHint);
        cardAddItems.Controls.Add(lblQtyCaption);
        cardAddItems.Controls.Add(_numQuantity);
        cardAddItems.Controls.Add(_lblQuantityError);
        cardAddItems.Controls.Add(_btnAddItem);

        // ----------------------------------------------------
        // 4. Order Items Card & Table
        // ----------------------------------------------------
        _pnlTableCard = CreateCardPanel(240);
        var lblItemsCardTitle = new Label
        {
            Text = "Order Items",
            Font = AppTheme.SectionTitle,
            ForeColor = AppTheme.TextPrimary,
            Location = new Point(18, 14),
            AutoSize = true
        };

        _lblItemCountSubtitle = new Label
        {
            Text = "0 items",
            Font = AppTheme.SmallRegular,
            ForeColor = AppTheme.TextSecondary,
            Anchor = AnchorStyles.Top | AnchorStyles.Right,
            Location = new Point(_pnlTableCard.Width - 90, 16),
            AutoSize = true
        };
        _pnlTableCard.Resize += (s, e) =>
        {
            _lblItemCountSubtitle.Location = new Point(_pnlTableCard.Width - 90, 16);
        };

        _gridItems = new DataGridView
        {
            Location = new Point(18, 44),
            Size = new Size(_pnlTableCard.Width - 36, 140),
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

        _gridItems.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColItem", HeaderText = "Item Name", FillWeight = 38, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
        _gridItems.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColPrice", HeaderText = "Unit Price", FillWeight = 20, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
        _gridItems.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColQty", HeaderText = "Quantity", FillWeight = 16, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
        _gridItems.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColSubtotal", HeaderText = "Subtotal", FillWeight = 20, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });

        var colRemove = new DataGridViewLinkColumn
        {
            Name = "ColRemove",
            HeaderText = "Remove",
            Text = "🗑 Remove",
            UseColumnTextForLinkValue = true,
            LinkColor = AppTheme.DangerButton,
            ActiveLinkColor = AppTheme.DangerButtonHover,
            TrackVisitedState = false,
            Width = 90
        };
        _gridItems.Columns.Add(colRemove);
        _gridItems.CellContentClick += GridItems_CellContentClick;

        // Empty state overlay for Items Table
        _pnlEmptyItemsState = new Panel
        {
            Location = new Point(18, 44),
            Size = new Size(_pnlTableCard.Width - 36, 140),
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom,
            BackColor = Color.White
        };
        var lblEmptyText = new Label
        {
            Text = "No items added yet\nSelect a menu item and quantity, then click Add Item.",
            Font = AppTheme.BodyRegular,
            ForeColor = AppTheme.TextSecondary,
            TextAlign = ContentAlignment.MiddleCenter,
            Dock = DockStyle.Fill
        };
        _pnlEmptyItemsState.Controls.Add(lblEmptyText);

        // Total label
        _lblTotalAmount = new Label
        {
            Text = "Total  0 ETB",
            Font = new Font("Segoe UI", 15f, FontStyle.Bold),
            ForeColor = AppTheme.PrimaryButton,
            Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
            Location = new Point(_pnlTableCard.Width - 220, 196),
            Size = new Size(200, 36),
            TextAlign = ContentAlignment.MiddleRight
        };
        _pnlTableCard.Resize += (s, e) =>
        {
            _lblTotalAmount.Location = new Point(_pnlTableCard.Width - 220, 196);
        };

        var lblSubtotalNote = new Label
        {
            Text = "Subtotals and total update automatically when quantities change.",
            Font = AppTheme.SmallRegular,
            ForeColor = AppTheme.TextMuted,
            Anchor = AnchorStyles.Bottom | AnchorStyles.Left,
            Location = new Point(18, 204),
            AutoSize = true
        };

        _pnlTableCard.Controls.Add(lblItemsCardTitle);
        _pnlTableCard.Controls.Add(_lblItemCountSubtitle);
        _pnlTableCard.Controls.Add(_gridItems);
        _pnlTableCard.Controls.Add(_pnlEmptyItemsState);
        _pnlTableCard.Controls.Add(lblSubtotalNote);
        _pnlTableCard.Controls.Add(_lblTotalAmount);

        // ----------------------------------------------------
        // 5. Bottom Action Buttons Bar
        // ----------------------------------------------------
        var pnlActions = new Panel
        {
            Dock = DockStyle.Bottom,
            Height = 60,
            BackColor = AppTheme.ContentBackground,
            Padding = new Padding(0, 10, 0, 10)
        };

        _btnSaveOrder = new Button
        {
            Text = "💾 Save Order",
            Font = AppTheme.BodyBold,
            ForeColor = Color.White,
            BackColor = AppTheme.PrimaryButton,
            FlatStyle = FlatStyle.Flat,
            Size = new Size(130, 40),
            Location = new Point(0, 10),
            Cursor = Cursors.Hand
        };
        _btnSaveOrder.FlatAppearance.BorderSize = 0;
        _btnSaveOrder.Click += (s, e) => SaveOrder();

        _btnClearForm = new Button
        {
            Text = "Clear Form",
            Font = AppTheme.BodyRegular,
            ForeColor = AppTheme.TextPrimary,
            BackColor = Color.White,
            FlatStyle = FlatStyle.Flat,
            Size = new Size(110, 40),
            Location = new Point(140, 10),
            Cursor = Cursors.Hand
        };
        _btnClearForm.FlatAppearance.BorderColor = AppTheme.CardBorder;
        _btnClearForm.Click += (s, e) => PromptOrResetForm();

        _btnViewOrders = new Button
        {
            Text = "📋 View Orders",
            Font = AppTheme.BodyBold,
            ForeColor = Color.White,
            BackColor = AppTheme.PrimaryButton,
            FlatStyle = FlatStyle.Flat,
            Size = new Size(130, 40),
            Location = new Point(260, 10),
            Cursor = Cursors.Hand,
            Visible = false
        };
        _btnViewOrders.FlatAppearance.BorderSize = 0;
        _btnViewOrders.Click += (s, e) => Navigate(ViewType.Orders);

        var lblAutoNumberNote = new Label
        {
            Text = "Order number is generated automatically.",
            Font = AppTheme.SmallRegular,
            ForeColor = AppTheme.TextMuted,
            Anchor = AnchorStyles.Top | AnchorStyles.Right,
            Location = new Point(pnlActions.Width - 360, 20),
            AutoSize = true
        };

        _btnCancel = new Button
        {
            Text = "Cancel",
            Font = AppTheme.BodyRegular,
            ForeColor = AppTheme.TextPrimary,
            BackColor = Color.White,
            FlatStyle = FlatStyle.Flat,
            Size = new Size(90, 40),
            Anchor = AnchorStyles.Top | AnchorStyles.Right,
            Location = new Point(pnlActions.Width - 100, 10),
            Cursor = Cursors.Hand
        };
        _btnCancel.FlatAppearance.BorderColor = AppTheme.CardBorder;
        _btnCancel.Click += (s, e) => HandleCancel();

        pnlActions.Controls.Add(_btnSaveOrder);
        pnlActions.Controls.Add(_btnClearForm);
        pnlActions.Controls.Add(_btnViewOrders);
        pnlActions.Controls.Add(lblAutoNumberNote);
        pnlActions.Controls.Add(_btnCancel);

        pnlActions.Resize += (s, e) =>
        {
            lblAutoNumberNote.Location = new Point(pnlActions.Width - 360, 20);
            _btnCancel.Location = new Point(pnlActions.Width - 100, 10);
        };

        // Stack Cards into Scroll Canvas
        var pnlStack = new Panel
        {
            Dock = DockStyle.Top,
            AutoSize = true,
            BackColor = AppTheme.ContentBackground
        };

        cardOrderInfo.Dock = DockStyle.Top;
        cardAddItems.Dock = DockStyle.Top;
        _pnlTableCard.Dock = DockStyle.Top;

        var gap1 = new Panel { Dock = DockStyle.Top, Height = 14 };
        var gap2 = new Panel { Dock = DockStyle.Top, Height = 14 };

        pnlStack.Controls.Add(_pnlTableCard);
        pnlStack.Controls.Add(gap2);
        pnlStack.Controls.Add(cardAddItems);
        pnlStack.Controls.Add(gap1);
        pnlStack.Controls.Add(cardOrderInfo);

        pnlScrollCanvas.Controls.Add(pnlStack);

        ContentPanel.Controls.Add(pnlScrollCanvas);
        ContentPanel.Controls.Add(pnlActions);
        ContentPanel.Controls.Add(_pnlAlertSpacing);
        ContentPanel.Controls.Add(_pnlAlertBanner);

        // Load Menu Items into Dropdown
        PopulateAvailableMenuItems();
        ResetForm();
    }

    private Panel CreateCardPanel(int height)
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
        PopulateAvailableMenuItems();
        if (_isOrderSaved)
        {
            ResetForm();
        }
        else
        {
            UpdateOrderNumberBadge();
        }
    }

    private void PopulateAvailableMenuItems()
    {
        _cboMenuItems.Items.Clear();

        // Strictly filter to available menu items only
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

    private void UpdateOrderNumberBadge()
    {
        _lblOrderNumberBadge.Text = $"#{_store.PeekNextOrderNumber()}  🔒";
        _lblOrderDateTime.Text = DateTime.Now.ToString("dd MMM yyyy, h:mm tt") + "  🔒";
    }

    private void AddSelectedItem()
    {
        if (_isOrderSaved) return;

        if (_cboMenuItems.SelectedItem is not MenuItem selectedMenu)
        {
            ShowAlert("Please select an available menu item.", isSuccess: false);
            return;
        }

        int qty = (int)_numQuantity.Value;
        if (qty <= 0)
        {
            _lblQuantityError.Visible = true;
            return;
        }
        _lblQuantityError.Visible = false;

        // Check if item already in order; if so, increment quantity
        var existing = _lineItems.FirstOrDefault(i => i.MenuItemId == selectedMenu.Id);
        if (existing != null)
        {
            existing.Quantity += qty;
        }
        else
        {
            // Create frozen snapshot of item name and price
            _lineItems.Add(OrderItem.CreateFromMenuItem(selectedMenu, qty));
        }

        _numQuantity.Value = 1;
        RefreshItemsTable();
        ClearValidationErrors();
    }

    private void RefreshItemsTable()
    {
        _gridItems.Rows.Clear();

        if (_lineItems.Count == 0)
        {
            _gridItems.Visible = false;
            _pnlEmptyItemsState.Visible = true;
            _lblItemCountSubtitle.Text = "0 items";
            _lblTotalAmount.Text = "Total  0 ETB";
        }
        else
        {
            _pnlEmptyItemsState.Visible = false;
            _gridItems.Visible = true;

            decimal total = 0m;
            foreach (var item in _lineItems)
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
            }

            int count = _lineItems.Count;
            _lblItemCountSubtitle.Text = $"{count} {(count == 1 ? "item" : "items")}";
            _lblTotalAmount.Text = $"Total  {total:N0} ETB";
        }
    }

    private void GridItems_CellContentClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || _isOrderSaved) return;

        int removeColIndex = _gridItems.Columns["ColRemove"]?.Index ?? -1;
        if (removeColIndex >= 0 && e.ColumnIndex == removeColIndex)
        {
            if (_gridItems.Rows[e.RowIndex].Tag is OrderItem item)
            {
                _lineItems.Remove(item);
                RefreshItemsTable();
            }
        }
    }

    private void SaveOrder()
    {
        if (_isOrderSaved) return;

        string custName = _txtCustomerName.Text.Trim();
        int tableNum = (int)_numTableNumber.Value;

        // Domain validation
        if (!_orderService.ValidateOrder(custName, tableNum, _lineItems, out var errors))
        {
            if (string.IsNullOrWhiteSpace(custName))
            {
                _lblCustomerNameError.Visible = true;
            }
            if (tableNum <= 0)
            {
                _lblTableNumberError.Visible = true;
            }
            if (_lineItems.Count == 0)
            {
                ShowAlert("Add at least one item before saving.", isSuccess: false);
            }
            else
            {
                ShowAlert("Please correct the required fields below.", isSuccess: false);
            }
            return;
        }

        // Create Order via OrderService (allocates atomic sequential # starting at #116)
        var createdOrder = _orderService.CreateOrder(custName, tableNum, _lineItems);
        _isOrderSaved = true;

        // Display Success State
        ShowAlert($"✓ Order #{createdOrder.OrderNumber} created successfully.", isSuccess: true);
        LockInputsAfterSave(createdOrder.OrderNumber);
    }

    private void LockInputsAfterSave(int orderNumber)
    {
        _txtCustomerName.ReadOnly = true;
        _numTableNumber.Enabled = false;
        _cboMenuItems.Enabled = false;
        _numQuantity.Enabled = false;
        _btnAddItem.Enabled = false;

        _btnSaveOrder.Text = "✓ Order Saved";
        _btnSaveOrder.Enabled = false;
        _btnViewOrders.Visible = true;
        _btnClearForm.Text = "+ New Order";
    }

    private void PromptOrResetForm()
    {
        if (!_isOrderSaved && HasUnsavedChanges())
        {
            if (ConfirmationDialog.Confirm(
                    this,
                    "New Order",
                    "Discard unsaved order?",
                    $"Your unsaved changes to Order #{_store.PeekNextOrderNumber()} will be lost.",
                    "Discard Order"))
            {
                ResetForm();
            }
        }
        else
        {
            ResetForm();
        }
    }

    private void HandleCancel()
    {
        if (!_isOrderSaved && HasUnsavedChanges())
        {
            if (ConfirmationDialog.Confirm(
                    this,
                    "New Order",
                    "Discard unsaved order?",
                    $"Your unsaved changes to Order #{_store.PeekNextOrderNumber()} will be lost.",
                    "Discard Order"))
            {
                ResetForm();
                Navigate(ViewType.Orders);
            }
        }
        else
        {
            Navigate(ViewType.Orders);
        }
    }

    private bool HasUnsavedChanges()
    {
        return !string.IsNullOrWhiteSpace(_txtCustomerName.Text) || _lineItems.Count > 0;
    }

    private void ResetForm()
    {
        _isOrderSaved = false;
        _txtCustomerName.ReadOnly = false;
        _txtCustomerName.Text = string.Empty;
        _numTableNumber.Enabled = true;
        _numTableNumber.Value = 4;
        _cboMenuItems.Enabled = true;
        _numQuantity.Enabled = true;
        _numQuantity.Value = 1;
        _btnAddItem.Enabled = true;

        _btnSaveOrder.Text = "💾 Save Order";
        _btnSaveOrder.Enabled = true;
        _btnViewOrders.Visible = false;
        _btnClearForm.Text = "Clear Form";

        _lineItems.Clear();
        ClearValidationErrors();
        RefreshItemsTable();
        UpdateOrderNumberBadge();
        _pnlAlertBanner.Visible = false;
        _pnlAlertSpacing.Visible = false;
    }

    private void ClearValidationErrors()
    {
        _lblCustomerNameError.Visible = false;
        _lblTableNumberError.Visible = false;
        _lblQuantityError.Visible = false;
        if (!_isOrderSaved && _pnlAlertBanner.Visible && _lblAlertMessage.ForeColor == AppTheme.DangerButton)
        {
            _pnlAlertBanner.Visible = false;
            _pnlAlertSpacing.Visible = false;
        }
    }

    private void ShowAlert(string message, bool isSuccess)
    {
        _pnlAlertBanner.Visible = true;
        _pnlAlertSpacing.Visible = true;
        _lblAlertMessage.Text = message;

        if (isSuccess)
        {
            _pnlAlertBanner.BackColor = AppTheme.StatusReadyBg;
            _lblAlertMessage.ForeColor = AppTheme.StatusReadyText;
        }
        else
        {
            _pnlAlertBanner.BackColor = Color.FromArgb(254, 226, 226);
            _lblAlertMessage.ForeColor = AppTheme.DangerButton;
        }
        _pnlAlertBanner.Invalidate();
    }
}
