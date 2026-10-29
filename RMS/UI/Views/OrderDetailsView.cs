using System;
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
/// Order Details screen view showing the complete order breakdown,
/// line items, unit prices, subtotal, and status-specific actions.
/// </summary>
public partial class OrderDetailsView : BaseView, INavigationAware
{
    private readonly RestaurantStore _store = RestaurantStore.Instance;
    private readonly OrderService _orderService = new();
    private Order? _currentOrder;

    public OrderDetailsView() : base()
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

        _currentOrder = _store.FindOrderByNumber(orderNum) ?? _store.Orders.FirstOrDefault();
        DisplayOrder(_currentOrder);
    }

    private void DisplayOrder(Order? order)
    {
        if (order == null) return;

        lblOrderHeading.Text = $"#{order.OrderNumber} Order Information • Server: {order.WaiterName}";
        lblOrderNum.Text = $"#{order.OrderNumber}";
        lblCustomer.Text = order.CustomerName;
        lblTable.Text = $"Table {order.TableNumber}";
        lblCreated.Text = order.CreatedAt.ToString("h:mm tt");

        lblStatus.Text = order.Status.ToString();
        lblStatus.ForeColor = order.Status switch
        {
            OrderStatus.Pending => AppTheme.StatusPendingText,
            OrderStatus.Preparing => AppTheme.StatusPreparingText,
            OrderStatus.Ready => AppTheme.StatusReadyText,
            OrderStatus.Completed => AppTheme.StatusCompletedText,
            _ => AppTheme.StatusCancelledText
        };

        // Populate items grid
        dgvItems.Rows.Clear();
        foreach (var item in order.Items)
        {
            dgvItems.Rows.Add(
                item.ItemName,
                $"{item.UnitPrice:N0} ETB",
                item.Quantity.ToString(),
                $"{item.Subtotal:N0} ETB"
            );
        }

        int count = order.Items.Count;
        int totalQty = order.TotalItemQuantity;
        lblSummaryQty.Text = $"{count} {(count == 1 ? "item" : "items")} • {totalQty} total quantity";
        lblTotalAmount.Text = $"Total: {order.Total:N0} ETB";

        // Handle locked states
        if (order.Status == OrderStatus.Completed)
        {
            lblLockedNotice.Text = "Completed orders cannot be edited or cancelled, but remain viewable.";
            lblLockedNotice.Visible = true;
            btnEditOrder.Enabled = false;
            btnCancelOrder.Enabled = false;
        }
        else if (order.Status == OrderStatus.Cancelled)
        {
            lblLockedNotice.Text = "This order has been cancelled and cannot be edited.";
            lblLockedNotice.Visible = true;
            btnEditOrder.Enabled = false;
            btnCancelOrder.Enabled = false;
        }
        else
        {
            lblLockedNotice.Visible = false;
            btnEditOrder.Enabled = true;
            btnCancelOrder.Enabled = true;
        }
    }

    private void btnBack_Click(object? sender, EventArgs e)
    {
        Navigate(ViewType.Orders);
    }

    private void btnEditOrder_Click(object? sender, EventArgs e)
    {
        if (_currentOrder != null && _currentOrder.CanEdit)
        {
            Navigate(ViewType.EditOrder, _currentOrder.OrderNumber);
        }
    }

    private void btnCancelOrder_Click(object? sender, EventArgs e)
    {
        if (_currentOrder == null || !_currentOrder.CanCancel) return;

        string message = $"Are you sure you want to cancel Order #{_currentOrder.OrderNumber}?\n#{_currentOrder.OrderNumber} • {_currentOrder.CustomerName} • Table {_currentOrder.TableNumber} • {_currentOrder.Status}";
        if (ConfirmationDialog.Confirm(this, "Cancel Order?", "Cancel Order?", message, "Yes, Cancel Order", isDanger: true))
        {
            _orderService.CancelOrder(_currentOrder.OrderNumber);
            DisplayOrder(_currentOrder);
        }
    }
}
