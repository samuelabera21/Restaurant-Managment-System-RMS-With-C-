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

/// <summary>
/// Orders management screen view providing search, status filtering,
/// order status advancement, and cancellation in a clean desktop layout.
/// </summary>
public partial class OrdersView : BaseView
{
    private readonly RestaurantStore _store = RestaurantStore.Instance;
    private readonly OrderService _orderService = new();

    public OrdersView()
    {
        InitializeComponent();

        if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
        {
            return;
        }

        cboStatus.SelectedIndex = 0; // "All Statuses"

        _store.OnOrdersChanged += () =>
        {
            if (IsDisposed || Disposing) return;
            if (InvokeRequired)
            {
                Invoke(new Action(ApplyFilters));
            }
            else
            {
                ApplyFilters();
            }
        };

        ApplyFilters();
    }

    public override void OnNavigatedTo(object? parameter = null)
    {
        base.OnNavigatedTo(parameter);
        ApplyFilters();
    }

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
        int totalOrders = _store.Orders.Count;

        lblOrdersSummary.Text = $"Showing {filteredList.Count} of {totalOrders} orders";

        dgvOrders.Rows.Clear();
        foreach (var order in filteredList)
        {
            int rowIndex = dgvOrders.Rows.Add(
                $"#{order.OrderNumber}",
                order.CustomerName,
                $"Table {order.TableNumber}",
                order.CreatedAt.ToString("h:mm tt"),
                $"{order.Total:N0} ETB",
                order.Status.ToString()
            );

            var row = dgvOrders.Rows[rowIndex];
            row.Tag = order;
        }

        UpdateActionButtonsState();
    }

    private void UpdateActionButtonsState()
    {
        if (dgvOrders.CurrentRow?.Tag is Order selectedOrder)
        {
            btnViewDetails.Enabled = true;
            btnEditOrder.Enabled = selectedOrder.CanEdit;
            btnChangeStatus.Enabled = _orderService.CanAdvanceStatus(selectedOrder.Status, out _);
            btnCancelOrder.Enabled = selectedOrder.CanCancel;
        }
        else
        {
            btnViewDetails.Enabled = false;
            btnEditOrder.Enabled = false;
            btnChangeStatus.Enabled = false;
            btnCancelOrder.Enabled = false;
        }
    }

    private Order? GetSelectedOrder()
    {
        return dgvOrders.CurrentRow?.Tag as Order;
    }

    // =========================================================================
    // Event Handlers (Visual Studio Designer)
    // =========================================================================

    private void btnNewOrder_Click(object sender, EventArgs e)
    {
        Navigate(ViewType.NewOrder);
    }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        ApplyFilters();
    }

    private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        ApplyFilters();
    }

    private void btnClearFilters_Click(object sender, EventArgs e)
    {
        txtSearch.Text = string.Empty;
        cboStatus.SelectedIndex = 0;
        txtSearch.Focus();
    }

    private void dgvOrders_SelectionChanged(object sender, EventArgs e)
    {
        UpdateActionButtonsState();
    }

    private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            btnViewDetails_Click(sender, EventArgs.Empty);
        }
    }

    private void btnViewDetails_Click(object sender, EventArgs e)
    {
        var order = GetSelectedOrder();
        if (order != null)
        {
            Navigate(ViewType.OrderDetails, order.OrderNumber);
        }
    }

    private void btnEditOrder_Click(object sender, EventArgs e)
    {
        var order = GetSelectedOrder();
        if (order != null && order.CanEdit)
        {
            Navigate(ViewType.EditOrder, order.OrderNumber);
        }
    }

    private void btnChangeStatus_Click(object sender, EventArgs e)
    {
        var order = GetSelectedOrder();
        if (order == null) return;

        if (!_orderService.CanAdvanceStatus(order.Status, out var nextStatus) || nextStatus == null)
        {
            MessageBox.Show($"Order #{order.OrderNumber} is already '{order.Status}' and cannot advance further.",
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

    private void btnCancelOrder_Click(object sender, EventArgs e)
    {
        var order = GetSelectedOrder();
        if (order == null || !order.CanCancel) return;

        string message = $"Are you sure you want to cancel Order #{order.OrderNumber}?\n#{order.OrderNumber} • {order.CustomerName} • Table {order.TableNumber} • {order.Status}";
        if (ConfirmationDialog.Confirm(this, "Cancel Order?", "Cancel Order?", message, "Yes, Cancel Order", isDanger: true))
        {
            _orderService.CancelOrder(order.OrderNumber);
            ApplyFilters();
        }
    }
}
