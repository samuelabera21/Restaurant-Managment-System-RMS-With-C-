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

// Dashboard screen: overview KPIs and recent orders table
public partial class DashboardView : BaseView
{
    private readonly RestaurantStore _store = RestaurantStore.Instance;

    public DashboardView()
    {
        InitializeComponent();

        if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

        // Auto reload when orders change
        _store.OnOrdersChanged += () =>
        {
            if (!IsDisposed && !Disposing)
            {
                if (InvokeRequired) Invoke(RefreshDashboard);
                else RefreshDashboard();
            }
        };
    }

    // Refresh KPIs and recent orders when navigated to this view
    public override void OnNavigatedTo(object? parameter = null)
    {
        base.OnNavigatedTo(parameter);
        btnNewOrder.Visible = _store.CurrentUser?.Role != "Manager";
        RefreshDashboard();
    }

    // Update KPI numbers and populate recent orders table
    private void RefreshDashboard()
    {
        if (IsDisposed || Disposing) return;

        // 1. Update KPI overview statistics
        lblTotalCount.Text = _store.ActiveTotalOrdersCount.ToString();
        lblPendingCount.Text = _store.PendingOrdersCount.ToString();
        lblPreparingCount.Text = _store.PreparingOrdersCount.ToString();
        lblReadyCount.Text = _store.ReadyOrdersCount.ToString();
        lblCompletedCount.Text = _store.CompletedOrdersCount.ToString();
        lblCompletedValue.Text = $"{_store.CompletedOrdersValue:N0} ETB";

        // 2. Populate top 5 recent orders into DataGridView
        dgvRecentOrders.Rows.Clear();
        foreach (var order in _store.Orders.Take(5))
        {
            dgvRecentOrders.Rows.Add(
                order.OrderNumber.ToString(),
                order.CustomerName,
                $"Table {order.TableNumber}",
                order.CreatedAt.ToString("h:mm tt"),
                $"{order.Total:N0} ETB",
                order.Status.ToString()
            );
        }

        dgvRecentOrders.ClearSelection();
    }

    // New order button click
    private void btnNewOrder_Click(object? sender, EventArgs e) => Navigate(ViewType.NewOrder);

    // View all orders link click
    private void lnkViewAll_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e) => Navigate(ViewType.Orders);

    // Double click recent order row to open orders view
    private void dgvRecentOrders_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0) Navigate(ViewType.Orders);
    }
}
