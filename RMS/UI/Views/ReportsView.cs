using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using RMS.Common;
using RMS.Models;
using RMS.Services;
using RMS.UI.Navigation;

namespace RMS.UI.Views;

// Reports screen: order activity summary, KPI metrics, and breakdown table
public partial class ReportsView : BaseView, INavigationAware
{
    private readonly RestaurantStore _store = RestaurantStore.Instance;

    public ReportsView() : base()
    {
        InitializeComponent();

        if (!DesignMode)
        {
            dgvSummary.CellDoubleClick += dgvSummary_CellDoubleClick;
            cboDateFilter.SelectedIndex = 0;
            cboStatusFilter.SelectedIndex = 0;

            // Auto reload when orders change
            _store.OnOrdersChanged += () =>
            {
                if (IsHandleCreated) BeginInvoke(RefreshReports);
            };
        }
    }

    // Reload reports when navigated to this view
    public override void OnNavigatedTo(object? parameter = null)
    {
        base.OnNavigatedTo(parameter);
        RefreshReports();
    }

    // Filter orders and refresh summary KPIs and breakdown table
    public void RefreshReports()
    {
        if (DesignMode || Disposing || IsDisposed || dgvSummary.IsDisposed) return;

        bool isTodayOnly = cboDateFilter.SelectedIndex == 1;
        DateTime today = DateTime.Today;

        OrderStatus? selectedStatus = cboStatusFilter.SelectedIndex switch
        {
            1 => OrderStatus.Pending,
            2 => OrderStatus.Preparing,
            3 => OrderStatus.Ready,
            4 => OrderStatus.Completed,
            _ => null
        };

        var allOrders = _store.Orders
            .Where(o => o.Status != OrderStatus.Cancelled && (!isTodayOnly || o.CreatedAt.Date == today))
            .ToList();

        var filteredList = allOrders
            .Where(o => !selectedStatus.HasValue || o.Status == selectedStatus.Value)
            .OrderByDescending(o => o.CreatedAt)
            .ToList();

        // Update KPI summary cards
        lblTotalOrders.Text = allOrders.Count.ToString();
        lblPendingOrders.Text = allOrders.Count(o => o.Status == OrderStatus.Pending).ToString();
        lblPreparingOrders.Text = allOrders.Count(o => o.Status == OrderStatus.Preparing).ToString();
        lblReadyOrders.Text = allOrders.Count(o => o.Status == OrderStatus.Ready).ToString();
        lblCompletedOrders.Text = allOrders.Count(o => o.Status == OrderStatus.Completed).ToString();
        lblCompletedValue.Text = $"{allOrders.Where(o => o.Status == OrderStatus.Completed).Sum(o => o.Total):N0} ETB";

        // Populate breakdown table
        dgvSummary.Rows.Clear();
        foreach (var order in filteredList)
        {
            int row = dgvSummary.Rows.Add(
                order.OrderNumber.ToString(),
                order.CustomerName,
                $"Table {order.TableNumber}",
                order.CreatedAt.ToString("h:mm tt"),
                $"{order.Total:N0} ETB",
                order.Status.ToString()
            );
            dgvSummary.Rows[row].Tag = order;
        }

        lblSummaryFooter.Text = string.Empty;
    }

    // Date filter dropdown changed
    private void cboDateFilter_SelectedIndexChanged(object? sender, EventArgs e) => RefreshReports();

    // Status filter dropdown changed
    private void cboStatusFilter_SelectedIndexChanged(object? sender, EventArgs e) => RefreshReports();

    // Reset report filters
    private void btnClearFilters_Click(object? sender, EventArgs e)
    {
        cboDateFilter.SelectedIndex = 0;
        cboStatusFilter.SelectedIndex = 0;
        RefreshReports();
    }

    // Double click row to view order details
    private void dgvSummary_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && dgvSummary.Rows[e.RowIndex].Tag is Order order)
        {
            Navigate(ViewType.OrderDetails, order.OrderNumber);
        }
    }
}
