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

        // 2. Populate recent orders into DataGridView
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

            // Subtle color for the status text
            var row = dgvRecentOrders.Rows[rowIndex];
            row.Cells[colStatus.Index].Style.ForeColor = GetStatusColor(order.Status);
            row.Cells[colStatus.Index].Style.Font = AppTheme.BodyBold;
        }

        dgvRecentOrders.ClearSelection();
    }

    private static Color GetStatusColor(OrderStatus status) => status switch
    {
        OrderStatus.Pending => Color.FromArgb(180, 83, 9),      // Amber
        OrderStatus.Preparing => Color.FromArgb(194, 65, 12),   // Orange
        OrderStatus.Ready => Color.FromArgb(16, 149, 93),       // Green
        OrderStatus.Completed => Color.FromArgb(71, 85, 105),   // Slate
        OrderStatus.Cancelled => Color.FromArgb(220, 38, 38),   // Red
        _ => Color.FromArgb(15, 23, 42)
    };

    // =========================================================================
    // Event Handlers (Visual Studio Designer)
    // =========================================================================

    private void btnNewOrder_Click(object sender, EventArgs e)
    {
        Navigate(ViewType.NewOrder);
    }

    private void lnkViewAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Navigate(ViewType.Orders);
    }

    private void lblCompletedCount_Click(object sender, EventArgs e)
    {

    }
}
