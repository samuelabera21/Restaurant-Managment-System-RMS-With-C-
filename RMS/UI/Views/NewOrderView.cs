using System;
using System.Collections.Generic;
using System.ComponentModel;
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

// Order creation screen: handles table selection, customer name, items, and total calculation
public partial class NewOrderView : BaseView
{
    private readonly RestaurantStore _store = RestaurantStore.Instance;
    private readonly OrderService _orderService = new();
    private readonly List<OrderItem> _lineItems = new();
    private bool _isOrderSaved = false;

    public NewOrderView()
    {
        InitializeComponent();

        if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

        PopulateAvailableMenuItems();
        ResetForm();
    }

    // Called when navigated to this view
    public override void OnNavigatedTo(object? parameter = null)
    {
        base.OnNavigatedTo(parameter);
        PopulateAvailableMenuItems();

        if (_isOrderSaved) ResetForm();
        else UpdateOrderNumberBadge();
    }

    // Load available menu items into dropdown
    private void PopulateAvailableMenuItems()
    {
        cboMenuItems.Items.Clear();
        var available = _store.MenuItems.Where(m => m.IsAvailable).ToList();
        foreach (var item in available) cboMenuItems.Items.Add(item);
        if (cboMenuItems.Items.Count > 0) cboMenuItems.SelectedIndex = 0;
    }

    // Update order number and timestamp displays
    private void UpdateOrderNumberBadge()
    {
        txtOrderNumber.Text = _store.PeekNextOrderNumber().ToString();
        txtOrderDateTime.Text = DateTime.Now.ToString("dd MMM yyyy, h:mm tt");
    }

    // Refresh the order items table and total price
    private void RefreshItemsTable()
    {
        dgvOrderItems.Rows.Clear();
        decimal total = 0m;

        foreach (var item in _lineItems)
        {
            int row = dgvOrderItems.Rows.Add(item.ItemName, $"{item.UnitPrice:N0} ETB", item.Quantity, $"{item.Subtotal:N0} ETB", "Remove");
            dgvOrderItems.Rows[row].Tag = item;
            total += item.Subtotal;
        }

        lblTotal.Text = $"Total: {total:N0} ETB";
        dgvOrderItems.ClearSelection();
    }

    // Reset order form fields to empty defaults
    private void ResetForm()
    {
        _isOrderSaved = false;
        txtCustomerName.ReadOnly = false;
        txtCustomerName.Clear();
        numTableNumber.Enabled = true;
        numTableNumber.Value = 4;
        cboMenuItems.Enabled = true;
        numQuantity.Enabled = true;
        numQuantity.Value = 1;
        btnAddItem.Enabled = true;

        btnSaveOrder.Text = "Save Order";
        btnSaveOrder.Enabled = true;
        btnViewOrders.Visible = false;
        btnClearForm.Text = "Clear Form";

        _lineItems.Clear();
        RefreshItemsTable();
        UpdateOrderNumberBadge();
        lblAlertMessage.Visible = false;
    }

    // Lock inputs after saving so order cannot be accidentally modified
    private void LockInputsAfterSave()
    {
        txtCustomerName.ReadOnly = true;
        numTableNumber.Enabled = cboMenuItems.Enabled = numQuantity.Enabled = btnAddItem.Enabled = false;

        btnSaveOrder.Text = "Order Saved";
        btnSaveOrder.Enabled = false;
        btnViewOrders.Visible = true;
        btnClearForm.Text = "New Order";
    }

    // Display alert message with success or error styling
    private void ShowAlert(string message, bool isSuccess)
    {
        lblAlertMessage.Visible = true;
        lblAlertMessage.Text = message;
        lblAlertMessage.BackColor = isSuccess ? Color.FromArgb(240, 253, 244) : Color.FromArgb(254, 242, 242);
        lblAlertMessage.ForeColor = isSuccess ? Color.FromArgb(22, 101, 52) : Color.FromArgb(220, 38, 38);
    }

    // Check if form has unsaved customer or items
    private bool HasUnsavedChanges() => !string.IsNullOrWhiteSpace(txtCustomerName.Text) || _lineItems.Count > 0;

    // Add selected menu item to the order list
    private void btnAddItem_Click(object sender, EventArgs e)
    {
        if (_isOrderSaved) return;

        string custName = txtCustomerName.Text.Trim();
        if (string.IsNullOrWhiteSpace(custName))
        {
            txtCustomerName.BackColor = Color.FromArgb(254, 242, 242);
            ShowAlert("Please enter customer name before adding items.", isSuccess: false);
            txtCustomerName.Focus();
            return;
        }

        if (numTableNumber.Value <= 0)
        {
            ShowAlert("Please enter a valid table number.", isSuccess: false);
            numTableNumber.Focus();
            return;
        }

        if (cboMenuItems.SelectedItem is not MenuItem selectedMenu)
        {
            ShowAlert("Please select an available menu item.", isSuccess: false);
            return;
        }

        int qty = (int)numQuantity.Value;
        if (qty <= 0)
        {
            ShowAlert("Quantity must be greater than zero.", isSuccess: false);
            numQuantity.Focus();
            return;
        }

        // Add item or increment existing item quantity
        var existing = _lineItems.FirstOrDefault(i => i.MenuItemId == selectedMenu.Id);
        if (existing != null) existing.Quantity += qty;
        else _lineItems.Add(OrderItem.CreateFromMenuItem(selectedMenu, qty));

        numQuantity.Value = 1;
        RefreshItemsTable();
        lblAlertMessage.Visible = false;
    }

    // Remove item when Remove button in table is clicked
    private void dgvOrderItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && !_isOrderSaved && e.ColumnIndex == colRemove.Index && dgvOrderItems.Rows[e.RowIndex].Tag is OrderItem item)
        {
            _lineItems.Remove(item);
            RefreshItemsTable();
        }
    }

    // Validate inputs and save order
    private void btnSaveOrder_Click(object sender, EventArgs e)
    {
        if (_isOrderSaved) return;

        string custName = txtCustomerName.Text.Trim();
        int tableNum = (int)numTableNumber.Value;

        if (string.IsNullOrWhiteSpace(custName))
        {
            txtCustomerName.BackColor = Color.FromArgb(254, 242, 242);
            ShowAlert("Please enter customer name before saving the order.", isSuccess: false);
            txtCustomerName.Focus();
            return;
        }

        if (tableNum <= 0)
        {
            ShowAlert("Please enter a valid table number.", isSuccess: false);
            numTableNumber.Focus();
            return;
        }

        if (_lineItems.Count == 0)
        {
            ShowAlert("Add at least one menu item before saving the order.", isSuccess: false);
            return;
        }

        // Create order and persist
        var created = _orderService.CreateOrder(custName, tableNum, _lineItems);
        _isOrderSaved = true;

        ShowAlert($"Order {created.OrderNumber} created successfully!", isSuccess: true);
        LockInputsAfterSave();
    }

    // Clear form or discard order
    private void btnClearForm_Click(object sender, EventArgs e)
    {
        if (!_isOrderSaved && HasUnsavedChanges())
        {
            if (ConfirmationDialog.Confirm(this, "New Order", "Discard unsaved order?",
                $"Your unsaved changes to Order {_store.PeekNextOrderNumber()} will be lost.", "Discard Order"))
            {
                ResetForm();
            }
        }
        else ResetForm();
    }

    // Cancel and return to orders list
    private void btnCancel_Click(object sender, EventArgs e)
    {
        if (!_isOrderSaved && HasUnsavedChanges())
        {
            if (ConfirmationDialog.Confirm(this, "New Order", "Discard unsaved order?",
                $"Your unsaved changes to Order {_store.PeekNextOrderNumber()} will be lost.", "Discard Order"))
            {
                ResetForm();
                Navigate(ViewType.Orders);
            }
        }
        else Navigate(ViewType.Orders);
    }

    // Navigate to orders list
    private void btnViewOrders_Click(object sender, EventArgs e)
    {
        Navigate(ViewType.Orders);
    }

    // Clear alert on name text changed
    private void txtCustomerName_TextChanged(object sender, EventArgs e)
    {
        txtCustomerName.BackColor = Color.White;
        if (!_isOrderSaved && lblAlertMessage.Visible) lblAlertMessage.Visible = false;
    }
}
