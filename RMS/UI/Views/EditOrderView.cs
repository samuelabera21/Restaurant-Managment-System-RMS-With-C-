using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using RMS.Common;
using RMS.Models;
using RMS.Services;
using RMS.UI.Dialogs;
using RMS.UI.Navigation;
using MenuItem = RMS.Models.MenuItem;

namespace RMS.UI.Views;

// Edit order screen: modify active order customer, table, and items
public partial class EditOrderView : BaseView, INavigationAware
{
    private readonly RestaurantStore _store = RestaurantStore.Instance;
    private readonly OrderService _orderService = new();

    private Order? _originalOrder;
    private readonly List<OrderItem> _editItems = new();
    private bool _hasUnsavedChanges = false;
    private bool _isOrderCompleted = false;

    public EditOrderView() : base()
    {
        InitializeComponent();
    }

    // Load order data when navigated to this view
    public override void OnNavigatedTo(object? parameter = null)
    {
        base.OnNavigatedTo(parameter);
        if (DesignMode) return;

        int orderNum = parameter is int num ? num : 101;
        PopulateAvailableMenuItems();
        _originalOrder = _store.FindOrderByNumber(orderNum) ?? _store.Orders.FirstOrDefault();
        LoadOrderForEditing(_originalOrder);
    }

    // Load available menu items into dropdown
    private void PopulateAvailableMenuItems()
    {
        cboMenuItems.Items.Clear();
        foreach (var item in _store.MenuItems.Where(m => m.IsAvailable)) cboMenuItems.Items.Add(item);
        if (cboMenuItems.Items.Count > 0) cboMenuItems.SelectedIndex = 0;
    }

    // Populate form with existing order data
    private void LoadOrderForEditing(Order? order)
    {
        if (order == null) return;

        _hasUnsavedChanges = false;
        _isOrderCompleted = order.Status == OrderStatus.Completed || order.Status == OrderStatus.Cancelled;

        lblOrderNumberBadge.Text = order.CanEdit ? order.OrderNumber.ToString() : $"{order.OrderNumber} (Locked)";
        txtCustomerName.Text = order.CustomerName;
        numTableNumber.Value = order.TableNumber;
        lblSubheaderContext.Text = $"Order {order.OrderNumber} - {order.CustomerName} • Table {order.TableNumber} • {(order.CanEdit ? "Existing order" : "Read-only order")}";

        UpdateStatusBadge(order.Status);

        // Copy existing items into edit buffer
        _editItems.Clear();
        foreach (var item in order.Items)
            _editItems.Add(new OrderItem(item.MenuItemId, item.ItemName, item.UnitPrice, item.Quantity));

        RefreshItemsTable();

        // Lock controls if order is completed or cancelled
        txtCustomerName.ReadOnly = _isOrderCompleted;
        numTableNumber.Enabled = cboMenuItems.Enabled = numQuantity.Enabled = btnAddItem.Enabled = !_isOrderCompleted;
        btnSaveChanges.Enabled = btnCancelChanges.Enabled = !_isOrderCompleted;
        btnBackToDetails.Visible = _isOrderCompleted;
    }

    // Flag that unsaved edits exist
    private void MarkDirty()
    {
        if (_isOrderCompleted) return;
        _hasUnsavedChanges = true;
        if (_originalOrder != null)
        {
            lblSubheaderContext.Text = $"Order {_originalOrder.OrderNumber} - {txtCustomerName.Text.Trim()} • Table {numTableNumber.Value} • Unsaved changes";
        }
    }

    // Add selected item into the order edit buffer
    private void AddSelectedItem()
    {
        if (_isOrderCompleted) return;

        string custName = txtCustomerName.Text.Trim();
        if (string.IsNullOrWhiteSpace(custName))
        {
            txtCustomerName.BackColor = Color.FromArgb(254, 242, 242);
            txtCustomerName.Focus();
            return;
        }

        if (cboMenuItems.SelectedItem is not MenuItem selectedMenu) return;

        int qty = (int)numQuantity.Value;
        if (qty <= 0) return;

        var existing = _editItems.FirstOrDefault(i => i.MenuItemId == selectedMenu.Id);
        if (existing != null) existing.Quantity += qty;
        else _editItems.Add(OrderItem.CreateFromMenuItem(selectedMenu, qty));

        numQuantity.Value = 1;
        RefreshItemsTable();
        MarkDirty();
    }

    // Refresh table rows and order total
    private void RefreshItemsTable()
    {
        dgvItems.Rows.Clear();
        decimal total = 0m;

        foreach (var item in _editItems)
        {
            int row = dgvItems.Rows.Add(item.ItemName, $"{item.UnitPrice:N0} ETB", item.Quantity, $"{item.Subtotal:N0} ETB", "Remove");
            dgvItems.Rows[row].Tag = item;
            total += item.Subtotal;
        }

        lblTotalAmount.Text = $"Total: {total:N0} ETB";
    }

    // Remove item from edited order
    private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && !_isOrderCompleted && e.ColumnIndex == colAction.Index && dgvItems.Rows[e.RowIndex].Tag is OrderItem item)
        {
            _editItems.Remove(item);
            RefreshItemsTable();
            MarkDirty();
        }
    }

    // Validate and save updated order details
    private void SaveChanges()
    {
        if (_originalOrder == null || _isOrderCompleted) return;

        string custName = txtCustomerName.Text.Trim();
        int tableNum = (int)numTableNumber.Value;

        if (!_orderService.ValidateOrder(custName, tableNum, _editItems, out _))
        {
            lblCustomerNameError.Visible = string.IsNullOrWhiteSpace(custName);
            lblTableNumberError.Visible = tableNum <= 0;
            return;
        }

        _orderService.UpdateOrder(_originalOrder.OrderNumber, custName, tableNum, _editItems);
        _hasUnsavedChanges = false;
        lblSubheaderContext.Text = $"Order {_originalOrder.OrderNumber} - {custName} • Table {tableNum} • All changes saved";
        btnBackToDetails.Visible = true;
    }

    // Revert changes or navigate back to details
    private void CancelChanges()
    {
        if (_hasUnsavedChanges && _originalOrder != null)
        {
            if (ConfirmationDialog.Confirm(this, "Edit Order", "Discard unsaved changes?",
                $"Your changes to Order {_originalOrder.OrderNumber} will be lost.", "Discard Changes"))
            {
                LoadOrderForEditing(_originalOrder);
            }
        }
        else if (_originalOrder != null)
        {
            Navigate(ViewType.OrderDetails, _originalOrder.OrderNumber);
        }
    }

    // Update status badge color and text
    private void UpdateStatusBadge(OrderStatus status)
    {
        lblCurrentStatusBadge.Text = status.ToString();
        lblCurrentStatusBadge.ForeColor = status switch
        {
            OrderStatus.Pending => AppTheme.StatusPendingText,
            OrderStatus.Preparing => AppTheme.StatusPreparingText,
            OrderStatus.Ready => AppTheme.StatusReadyText,
            OrderStatus.Completed => AppTheme.StatusCompletedText,
            _ => AppTheme.StatusCancelledText
        };
    }

    // Input changed handler
    private void Input_Changed(object sender, EventArgs e)
    {
        MarkDirty();
    }

    // Add item button click
    private void btnAddItem_Click(object sender, EventArgs e)
    {
        AddSelectedItem();
    }

    // Save changes button click
    private void btnSaveChanges_Click(object sender, EventArgs e)
    {
        SaveChanges();
    }

    // Cancel changes button click
    private void btnCancelChanges_Click(object sender, EventArgs e)
    {
        CancelChanges();
    }

    // Return to order details button click
    private void btnBackToDetails_Click(object sender, EventArgs e)
    {
        if (_originalOrder != null) Navigate(ViewType.OrderDetails, _originalOrder.OrderNumber);
    }
}
