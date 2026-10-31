using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using RMS.Common;
using RMS.Models;
using RMS.Services;
using RMS.UI.Dialogs;
using RMS.UI.Navigation;

namespace RMS.UI.Views;

// Orders screen: view, search, advance status, and cancel orders
public partial class OrdersView : BaseView
{
    private readonly RestaurantStore _store = RestaurantStore.Instance;
    private readonly OrderService _orderService = new();

    public OrdersView()
    {
        InitializeComponent();

        if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

        dgvOrders.CellDoubleClick += dgvOrders_CellDoubleClick;
        cboStatus.SelectedIndex = 0;

        // Auto reload when orders change
        _store.OnOrdersChanged += () =>
        {
            if (!IsDisposed && !Disposing)
            {
                if (InvokeRequired) Invoke(ApplyFilters);
                else ApplyFilters();
            }
        };

        ApplyFilters();
    }

    // Called when navigated to this view
    public override void OnNavigatedTo(object? parameter = null)
    {
        base.OnNavigatedTo(parameter);
        ApplyFilters();
    }

    // Filter orders and populate DataGridView
    private void ApplyFilters()
    {
        if (IsDisposed || Disposing || dgvOrders.IsDisposed) return;

        string query = txtSearch.Text.Trim();
        OrderStatus? statusFilter = null;

        if (cboStatus.SelectedIndex > 0 && Enum.TryParse<OrderStatus>(cboStatus.SelectedItem?.ToString(), out var parsedStatus))
        {
            statusFilter = parsedStatus;
        }

        var filteredList = _orderService.FilterOrders(query, statusFilter).ToList();

        dgvOrders.Rows.Clear();
        foreach (var order in filteredList)
        {
            int rowIndex = dgvOrders.Rows.Add(
                order.OrderNumber.ToString(),
                order.CustomerName,
                $"Table {order.TableNumber}",
                order.CreatedAt.ToString("h:mm tt"),
                $"{order.Total:N0} ETB",
                order.Status.ToString()
            );

            dgvOrders.Rows[rowIndex].Tag = order;
        }

        UpdateActionButtonsState();
    }

    // Enable/disable buttons based on selected order state
    private void UpdateActionButtonsState()
    {
        var order = GetSelectedOrder();
        btnViewDetails.Enabled = order != null;
        btnEditOrder.Enabled = order?.CanEdit == true;
        btnChangeStatus.Enabled = order != null && _orderService.CanAdvanceStatus(order.Status, out _);
        btnCancelOrder.Enabled = order?.CanCancel == true;
    }

    // Helper to get currently selected order
    private Order? GetSelectedOrder() => dgvOrders.CurrentRow?.Tag as Order;

    // Navigate to create new order
    private void btnNewOrder_Click(object sender, EventArgs e) => Navigate(ViewType.NewOrder);

    // Live search input change
    private void txtSearch_TextChanged(object sender, EventArgs e) => ApplyFilters();

    // Status filter dropdown change
    private void cboStatus_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();

    // Reset search and filters
    private void btnClearFilters_Click(object sender, EventArgs e)
    {
        txtSearch.Clear();
        cboStatus.SelectedIndex = 0;
        txtSearch.Focus();
    }

    // Update button states on selection change
    private void dgvOrders_SelectionChanged(object sender, EventArgs e) => UpdateActionButtonsState();

    // Double click table row to view order details
    private void dgvOrders_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0) btnViewDetails_Click(sender ?? this, EventArgs.Empty);
    }

    // View order details
    private void btnViewDetails_Click(object sender, EventArgs e)
    {
        var order = GetSelectedOrder();
        if (order != null) Navigate(ViewType.OrderDetails, order.OrderNumber);
    }

    // Edit pending order
    private void btnEditOrder_Click(object sender, EventArgs e)
    {
        var order = GetSelectedOrder();
        if (order != null && order.CanEdit) Navigate(ViewType.EditOrder, order.OrderNumber);
    }

    // Advance order to next status
    private void btnChangeStatus_Click(object sender, EventArgs e)
    {
        var order = GetSelectedOrder();
        if (order == null) return;

        if (!_orderService.CanAdvanceStatus(order.Status, out var nextStatus) || nextStatus == null)
        {
            MessageBox.Show($"Order {order.OrderNumber} is already '{order.Status}' and cannot advance further.",
                "Status Limit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        using var dlg = new ChangeStatusDialog(order, nextStatus.Value);
        if (dlg.ShowDialog(this) == DialogResult.OK && dlg.IsConfirmed)
        {
            _orderService.AdvanceOrderStatus(order.OrderNumber);
            ApplyFilters();
        }
    }

    // Cancel order with confirmation prompt
    private void btnCancelOrder_Click(object sender, EventArgs e)
    {
        var order = GetSelectedOrder();
        if (order == null || !order.CanCancel) return;

        string message = $"Are you sure you want to cancel Order {order.OrderNumber}?\n{order.CustomerName} • Table {order.TableNumber}";
        if (ConfirmationDialog.Confirm(this, "Cancel Order?", "Cancel Order?", message, "Yes, Cancel Order", isDanger: true))
        {
            _orderService.CancelOrder(order.OrderNumber);
            ApplyFilters();
        }
    }
}
