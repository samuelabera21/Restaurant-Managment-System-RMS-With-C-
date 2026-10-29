using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using RMS.Common;
using RMS.Models;
using RMS.Services;
using RMS.UI.Navigation;

namespace RMS.UI.Views;

/// <summary>
/// Reports screen view displaying order activity summary,
/// dynamic KPI metric cards, date and status filters, and order breakdown table.
/// </summary>
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

            _store.OnOrdersChanged += () =>
            {
                if (IsHandleCreated)
                {
                    BeginInvoke(new Action(RefreshReports));
                }
            };
        }
    }

    public override void OnNavigatedTo(object? parameter = null)
    {
        RefreshReports();
    }

    public void RefreshReports()
    {
        if (DesignMode) return;

        // 1. Date Filter
        bool isTodayOnly = cboDateFilter.SelectedIndex == 1;
        DateTime today = DateTime.Today;

        // 2. Status Filter
        OrderStatus? selectedStatus = cboStatusFilter.SelectedIndex switch
        {
            1 => OrderStatus.Pending,
            2 => OrderStatus.Preparing,
            3 => OrderStatus.Ready,
            4 => OrderStatus.Completed,
            _ => null
        };

        // 3. Base order set (excluding cancelled from general stats)
        var allOrders = _store.Orders.Where(o => o.Status != OrderStatus.Cancelled).ToList();

        if (isTodayOnly)
        {
            allOrders = allOrders.Where(o => o.CreatedAt.Date == today).ToList();
        }

        // Apply status filter for table breakdown
        var filteredOrders = allOrders.AsEnumerable();
        if (selectedStatus.HasValue)
        {
            filteredOrders = filteredOrders.Where(o => o.Status == selectedStatus.Value);
        }
        var filteredList = filteredOrders.OrderByDescending(o => o.CreatedAt).ToList();

        // 4. Update KPI Summary Cards
        int totalCount = allOrders.Count;
        int pendingCount = allOrders.Count(o => o.Status == OrderStatus.Pending);
        int preparingCount = allOrders.Count(o => o.Status == OrderStatus.Preparing);
        int readyCount = allOrders.Count(o => o.Status == OrderStatus.Ready);
        int completedCount = allOrders.Count(o => o.Status == OrderStatus.Completed);
        decimal completedRevenue = allOrders.Where(o => o.Status == OrderStatus.Completed).Sum(o => o.Total);

        lblTotalOrders.Text = totalCount.ToString();
        lblPendingOrders.Text = pendingCount.ToString();
        lblPreparingOrders.Text = preparingCount.ToString();
        lblReadyOrders.Text = readyCount.ToString();
        lblCompletedOrders.Text = completedCount.ToString();
        lblCompletedValue.Text = $"{completedRevenue:N0} ETB";

        // 5. Update Breakdown Subtitle
        string dateText = isTodayOnly ? "Today" : "All dates";
        string statusText = selectedStatus.HasValue ? selectedStatus.Value.ToString() : "All Statuses";
        lblBreakdownSubtitle.Text = $"{filteredList.Count} orders listed • {dateText} • {statusText}";
        lblSummaryFooter.Text = string.Empty;

        // 6. Populate Breakdown Table
        dgvSummary.Rows.Clear();
        foreach (var order in filteredList)
        {
            int rowIndex = dgvSummary.Rows.Add(
                order.OrderNumber.ToString(),
                order.CustomerName,
                $"Table {order.TableNumber}",
                order.CreatedAt.ToString("h:mm tt"),
                $"{order.Total:N0} ETB",
                order.Status.ToString()
            );

            var row = dgvSummary.Rows[rowIndex];
            row.Tag = order;
        }
    }

    private void cboDateFilter_SelectedIndexChanged(object? sender, EventArgs e)
    {
        RefreshReports();
    }

    private void cboStatusFilter_SelectedIndexChanged(object? sender, EventArgs e)
    {
        RefreshReports();
    }

    private void btnClearFilters_Click(object? sender, EventArgs e)
    {
        cboDateFilter.SelectedIndex = 0;
        cboStatusFilter.SelectedIndex = 0;
        RefreshReports();
    }

    private void dgvSummary_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && dgvSummary.Rows[e.RowIndex].Tag is Order order)
        {
            Navigate(ViewType.OrderDetails, order.OrderNumber);
        }
    }
}
