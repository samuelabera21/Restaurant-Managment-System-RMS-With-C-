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

/// <summary>
/// Edit Order screen view for modifying an active order:
/// customer name, table number, item additions, quantity adjustments, and removal.
/// </summary>
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

    public override void OnNavigatedTo(object? parameter = null)
    {
        base.OnNavigatedTo(parameter);

        if (DesignMode) return;

        int orderNum = 104;
        if (parameter is int num)
        {
            orderNum = num;
        }

        PopulateAvailableMenuItems();
        _originalOrder = _store.FindOrderByNumber(orderNum) ?? _store.Orders.FirstOrDefault();
        LoadOrderForEditing(_originalOrder);
    }

    private void PopulateAvailableMenuItems()
    {
        cboMenuItems.Items.Clear();
        var availableItems = _store.MenuItems.Where(m => m.IsAvailable).ToList();
        foreach (var item in availableItems)
        {
            cboMenuItems.Items.Add(item);
        }

        if (cboMenuItems.Items.Count > 0)
        {
            cboMenuItems.SelectedIndex = 0;
        }
    }

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
            txtCustomerName.ReadOnly = true;
            numTableNumber.Enabled = false;
            cboMenuItems.Enabled = false;
            numQuantity.Enabled = false;
            btnAddItem.Enabled = false;
            btnSaveChanges.Enabled = false;
            btnCancelChanges.Enabled = false;
            btnBackToDetails.Visible = true;

            ShowAlert("Completed orders cannot be edited.", isError: true);
        }
        else
        {
            txtCustomerName.ReadOnly = false;
            numTableNumber.Enabled = true;
            cboMenuItems.Enabled = true;
            numQuantity.Enabled = true;
            btnAddItem.Enabled = true;
            btnSaveChanges.Enabled = true;
            btnCancelChanges.Enabled = true;
            btnBackToDetails.Visible = false;

            ShowAlert("Update customer details, add items or change quantities, then save.", isError: false);
        }
    }

    private void MarkDirty()
    {
        if (_isOrderCompleted) return;

        _hasUnsavedChanges = true;
        if (_originalOrder != null)
        {
            lblSubheaderContext.Text = $"Order {_originalOrder.OrderNumber} - {txtCustomerName.Text.Trim()} • Table {numTableNumber.Value} • Unsaved changes";
        }
        ShowAlert($"You have unsaved changes to Order {_originalOrder?.OrderNumber}. Save Changes to apply them.", isError: false);
    }

    private void AddSelectedItem()
    {
        if (_isOrderCompleted) return;

        string custName = txtCustomerName.Text.Trim();
        if (string.IsNullOrWhiteSpace(custName))
        {
            txtCustomerName.BackColor = Color.FromArgb(254, 242, 242);
            ShowAlert("Please enter customer name before adding items.", isError: true);
            txtCustomerName.Focus();
            return;
        }

        if (cboMenuItems.SelectedItem is not MenuItem selectedMenu) return;

        int qty = (int)numQuantity.Value;
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

        numQuantity.Value = 1;
        RefreshItemsTable();
        MarkDirty();
    }

    private void RefreshItemsTable()
    {
        dgvItems.Rows.Clear();
        decimal total = 0m;
        int totalQty = 0;

        foreach (var item in _editItems)
        {
            int rowIndex = dgvItems.Rows.Add(
                item.ItemName,
                $"{item.UnitPrice:N0} ETB",
                item.Quantity.ToString(),
                $"{item.Subtotal:N0} ETB",
                "Remove"
            );
            dgvItems.Rows[rowIndex].Tag = item;
            total += item.Subtotal;
            totalQty += item.Quantity;
        }

        int count = _editItems.Count;
        lblSummaryQty.Text = $"{count} {(count == 1 ? "item" : "items")} • {totalQty} total quantity";
        lblTotalAmount.Text = $"Total: {total:N0} ETB";
    }

    private void dgvItems_CellContentClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || _isOrderCompleted) return;

        int actionColIndex = dgvItems.Columns["colAction"]?.Index ?? -1;
        if (actionColIndex >= 0 && e.ColumnIndex == actionColIndex)
        {
            if (dgvItems.Rows[e.RowIndex].Tag is OrderItem item)
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

        string custName = txtCustomerName.Text.Trim();
        int tableNum = (int)numTableNumber.Value;

        if (!_orderService.ValidateOrder(custName, tableNum, _editItems, out _))
        {
            lblCustomerNameError.Visible = string.IsNullOrWhiteSpace(custName);
            lblTableNumberError.Visible = tableNum <= 0;
            ShowAlert($"Please correct the required fields before saving Order {_originalOrder.OrderNumber}.", isError: true);
            return;
        }

        _orderService.UpdateOrder(_originalOrder.OrderNumber, custName, tableNum, _editItems);
        _hasUnsavedChanges = false;

        ShowAlert($"Order {_originalOrder.OrderNumber} updated successfully.", isError: false, isSuccess: true);
        lblSubheaderContext.Text = $"Order {_originalOrder.OrderNumber} - {custName} • Table {tableNum} • All changes saved";
        btnBackToDetails.Visible = true;
    }

    private void CancelChanges()
    {
        if (_hasUnsavedChanges && _originalOrder != null)
        {
            if (ConfirmationDialog.Confirm(
                    this,
                    "Edit Order",
                    "Discard unsaved changes?",
                    $"Your changes to Order {_originalOrder.OrderNumber} will be lost.",
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

    private void ShowAlert(string message, bool isError = false, bool isSuccess = false)
    {
        pnlAlertBanner.Visible = true;
        lblAlertMessage.Text = message;

        if (isSuccess)
        {
            pnlAlertBanner.BackColor = AppTheme.StatusReadyBg;
            lblAlertMessage.ForeColor = AppTheme.StatusReadyText;
        }
        else if (isError)
        {
            pnlAlertBanner.BackColor = Color.FromArgb(254, 226, 226);
            lblAlertMessage.ForeColor = AppTheme.DangerButton;
        }
        else
        {
            pnlAlertBanner.BackColor = Color.FromArgb(241, 245, 249);
            lblAlertMessage.ForeColor = AppTheme.TextSecondary;
        }
    }

    private void Input_Changed(object? sender, EventArgs e)
    {
        MarkDirty();
    }

    private void btnAddItem_Click(object? sender, EventArgs e)
    {
        AddSelectedItem();
    }

    private void btnSaveChanges_Click(object? sender, EventArgs e)
    {
        SaveChanges();
    }

    private void btnCancelChanges_Click(object? sender, EventArgs e)
    {
        CancelChanges();
    }

    private void btnBackToDetails_Click(object? sender, EventArgs e)
    {
        if (_originalOrder != null)
        {
            Navigate(ViewType.OrderDetails, _originalOrder.OrderNumber);
        }
    }
}
