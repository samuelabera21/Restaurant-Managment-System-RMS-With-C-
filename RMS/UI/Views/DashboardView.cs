using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using RMS.Common;
using RMS.Models;
using RMS.Services;
using RMS.UI.Navigation;

namespace RMS.UI.Views;

/// <summary>
/// Dashboard screen displaying live KPI summary and recent orders in a clean desktop table.
/// </summary>
public partial class DashboardView : BaseView
{
    private readonly RestaurantStore _store = RestaurantStore.Instance;

    public DashboardView()
    {
        InitializeComponent();

        if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
        {
            return;
        }

        dgvRecentOrders.CellDoubleClick += dgvRecentOrders_CellDoubleClick;
        _store.OnOrdersChanged += RefreshDashboard;
    }

    public override void OnNavigatedTo(object? parameter = null)
    {
        base.OnNavigatedTo(parameter);
        RefreshDashboard();
    }

    private void RefreshDashboard()
    {
        if (IsDisposed || Disposing) return;

        if (InvokeRequired)
        {
            Invoke(new Action(RefreshDashboard));
            return;
        }

        // 1. Update KPI overview statistics
        lblTotalCount.Text = _store.ActiveTotalOrdersCount.ToString();
        lblPendingCount.Text = _store.PendingOrdersCount.ToString();
        lblPreparingCount.Text = _store.PreparingOrdersCount.ToString();
        lblReadyCount.Text = _store.ReadyOrdersCount.ToString();
        lblCompletedCount.Text = _store.CompletedOrdersCount.ToString();
        lblCompletedValue.Text = $"{_store.CompletedOrdersValue:N0} ETB";

        // 2. Populate recent orders into DataGridView with clean, uniform plain text (no colors)
        dgvRecentOrders.Rows.Clear();
        var recentOrders = _store.Orders.Take(5);

        foreach (var order in recentOrders)
        {
            int rowIndex = dgvRecentOrders.Rows.Add(
                $"#{order.OrderNumber}",
                order.CustomerName,
                $"Table {order.TableNumber}",
                order.CreatedAt.ToString("h:mm tt"),
                $"{order.Total:N0} ETB",
                order.Status.ToString()
            );
            dgvRecentOrders.Rows[rowIndex].Tag = order;
        }

        dgvRecentOrders.ClearSelection();
    }

    private void dgvRecentOrders_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && dgvRecentOrders.Rows[e.RowIndex].Tag is Order order)
        {
            Navigate(ViewType.OrderDetails, order.OrderNumber);
        }
    }

    private void btnNewOrder_Click(object? sender, EventArgs e)
    {
        Navigate(ViewType.NewOrder);
    }

    private void lnkViewAll_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
    {
        Navigate(ViewType.Orders);
    }
}
