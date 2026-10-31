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

// Order details screen: displays line items, prices, and status actions
public partial class OrderDetailsView : BaseView, INavigationAware
{
    private readonly RestaurantStore _store = RestaurantStore.Instance;
    private readonly OrderService _orderService = new();
    private Order? _currentOrder;

    public OrderDetailsView() : base()
    {
        InitializeComponent();
    }

    // Load and display selected order on navigation
    public override void OnNavigatedTo(object? parameter = null)
    {
        base.OnNavigatedTo(parameter);
        if (DesignMode) return;

        int orderNum = parameter is int num ? num : 101;
        _currentOrder = _store.FindOrderByNumber(orderNum) ?? _store.Orders.FirstOrDefault();
        DisplayOrder(_currentOrder);
    }

    // Populate order header, item grid, and action button states
    private void DisplayOrder(Order? order)
    {
        if (order == null) return;

        lblOrderHeading.Text = $"Order {order.OrderNumber} Information - Server: {order.WaiterName}";
        lblOrderNum.Text = order.OrderNumber.ToString();
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
            dgvItems.Rows.Add(item.ItemName, $"{item.UnitPrice:N0} ETB", item.Quantity, $"{item.Subtotal:N0} ETB");
        }

        lblTotalAmount.Text = $"Total: {order.Total:N0} ETB";

        // Enable or disable actions based on order status
        btnEditOrder.Enabled = order.CanEdit;
        btnCancelOrder.Enabled = order.CanCancel;
    }

    // Return to orders list
    private void btnBack_Click(object? sender, EventArgs e) => Navigate(ViewType.Orders);

    // Edit current order
    private void btnEditOrder_Click(object? sender, EventArgs e)
    {
        if (_currentOrder?.CanEdit == true) Navigate(ViewType.EditOrder, _currentOrder.OrderNumber);
    }

    // Cancel current order with confirmation dialog
    private void btnCancelOrder_Click(object? sender, EventArgs e)
    {
        if (_currentOrder == null || !_currentOrder.CanCancel) return;

        string message = $"Are you sure you want to cancel Order {_currentOrder.OrderNumber}?\n{_currentOrder.CustomerName} • Table {_currentOrder.TableNumber}";
        if (ConfirmationDialog.Confirm(this, "Cancel Order?", "Cancel Order?", message, "Yes, Cancel Order", isDanger: true))
        {
            _orderService.CancelOrder(_currentOrder.OrderNumber);
            DisplayOrder(_currentOrder);
        }
    }
}
