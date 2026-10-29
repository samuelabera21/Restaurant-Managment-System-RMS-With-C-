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

/// <summary>
/// Order creation screen view.
/// Handles sequential order numbering, item selection, real-time total calculations,
/// validation alerts, and save confirmations in a clean desktop layout.
/// </summary>
public partial class NewOrderView : BaseView
{
    private readonly RestaurantStore _store = RestaurantStore.Instance;
    private readonly OrderService _orderService = new();
    private readonly List<OrderItem> _lineItems = new();
    private bool _isOrderSaved = false;

    public NewOrderView()
    {
        InitializeComponent();

        if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
        {
            return;
        }

        PopulateAvailableMenuItems();
        ResetForm();
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

    private void UpdateOrderNumberBadge()
    {
        txtOrderNumber.Text = _store.PeekNextOrderNumber().ToString();
        txtOrderDateTime.Text = DateTime.Now.ToString("dd MMM yyyy, h:mm tt");
    }

    private void RefreshItemsTable()
    {
        dgvOrderItems.Rows.Clear();
        decimal total = 0m;

        foreach (var item in _lineItems)
        {
            int rowIndex = dgvOrderItems.Rows.Add(
                item.ItemName,
                $"{item.UnitPrice:N0} ETB",
                item.Quantity.ToString(),
                $"{item.Subtotal:N0} ETB",
                "Remove"
            );
            dgvOrderItems.Rows[rowIndex].Tag = item;
            total += item.Subtotal;
        }

        lblTotal.Text = $"Total: {total:N0} ETB";
        dgvOrderItems.ClearSelection();
    }

    private void ResetForm()
    {
        _isOrderSaved = false;
        txtCustomerName.ReadOnly = false;
        txtCustomerName.Text = string.Empty;
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

    private void LockInputsAfterSave(int orderNumber)
    {
        txtCustomerName.ReadOnly = true;
        numTableNumber.Enabled = false;
        cboMenuItems.Enabled = false;
        numQuantity.Enabled = false;
        btnAddItem.Enabled = false;

        btnSaveOrder.Text = "Order Saved";
        btnSaveOrder.Enabled = false;
        btnViewOrders.Visible = true;
        btnClearForm.Text = "New Order";
    }

    private void ShowAlert(string message, bool isSuccess)
    {
        lblAlertMessage.Visible = true;
        lblAlertMessage.Text = message;

        if (isSuccess)
        {
            lblAlertMessage.BackColor = Color.FromArgb(240, 253, 244); // Light green
            lblAlertMessage.ForeColor = Color.FromArgb(22, 101, 52);    // Dark green
        }
        else
        {
            lblAlertMessage.BackColor = Color.FromArgb(254, 242, 242); // Light red
            lblAlertMessage.ForeColor = Color.FromArgb(220, 38, 38);   // Dark red
        }
    }

    private bool HasUnsavedChanges()
    {
        return !string.IsNullOrWhiteSpace(txtCustomerName.Text) || _lineItems.Count > 0;
    }

    // =========================================================================
    // Event Handlers (Visual Studio Designer)
    // =========================================================================

    private void btnAddItem_Click(object sender, EventArgs e)
    {
        if (_isOrderSaved) return;

        // 1. Validate Customer Name
        string custName = txtCustomerName.Text.Trim();
        if (string.IsNullOrWhiteSpace(custName))
        {
            txtCustomerName.BackColor = Color.FromArgb(254, 242, 242);
            ShowAlert("Please enter customer name before adding items.", isSuccess: false);
            txtCustomerName.Focus();
            return;
        }

        // 2. Validate Table Number
        if (numTableNumber.Value <= 0)
        {
            ShowAlert("Please enter a valid table number.", isSuccess: false);
            numTableNumber.Focus();
            return;
        }

        // 3. Validate Item Selection
        if (cboMenuItems.SelectedItem is not MenuItem selectedMenu)
        {
            ShowAlert("Please select an available menu item.", isSuccess: false);
            return;
        }

        // 4. Validate Quantity
        int qty = (int)numQuantity.Value;
        if (qty <= 0)
        {
            ShowAlert("Quantity must be greater than zero.", isSuccess: false);
            numQuantity.Focus();
            return;
        }

        // Add or increment quantity
        var existing = _lineItems.FirstOrDefault(i => i.MenuItemId == selectedMenu.Id);
        if (existing != null)
        {
            existing.Quantity += qty;
        }
        else
        {
            _lineItems.Add(OrderItem.CreateFromMenuItem(selectedMenu, qty));
        }

        numQuantity.Value = 1;
        RefreshItemsTable();
        lblAlertMessage.Visible = false;
    }

    private void dgvOrderItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || _isOrderSaved) return;

        if (e.ColumnIndex == colRemove.Index && dgvOrderItems.Rows[e.RowIndex].Tag is OrderItem item)
        {
            _lineItems.Remove(item);
            RefreshItemsTable();
        }
    }

    private void btnSaveOrder_Click(object sender, EventArgs e)
    {
        if (_isOrderSaved) return;

        string custName = txtCustomerName.Text.Trim();
        int tableNum = (int)numTableNumber.Value;

        // Validation
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

        // Save Order via OrderService
        var createdOrder = _orderService.CreateOrder(custName, tableNum, _lineItems);
        _isOrderSaved = true;

        ShowAlert($"Order {createdOrder.OrderNumber} created successfully!", isSuccess: true);
        LockInputsAfterSave(createdOrder.OrderNumber);
    }

    private void btnClearForm_Click(object sender, EventArgs e)
    {
        if (!_isOrderSaved && HasUnsavedChanges())
        {
            if (ConfirmationDialog.Confirm(
                    this,
                    "New Order",
                    "Discard unsaved order?",
                    $"Your unsaved changes to Order {_store.PeekNextOrderNumber()} will be lost.",
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

    private void btnCancel_Click(object sender, EventArgs e)
    {
        if (!_isOrderSaved && HasUnsavedChanges())
        {
            if (ConfirmationDialog.Confirm(
                    this,
                    "New Order",
                    "Discard unsaved order?",
                    $"Your unsaved changes to Order {_store.PeekNextOrderNumber()} will be lost.",
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

    private void btnViewOrders_Click(object sender, EventArgs e)
    {
        Navigate(ViewType.Orders);
    }

    private void txtCustomerName_TextChanged(object sender, EventArgs e)
    {
        txtCustomerName.BackColor = Color.White;
        if (!_isOrderSaved && lblAlertMessage.Visible)
        {
            lblAlertMessage.Visible = false;
        }
    }
}
