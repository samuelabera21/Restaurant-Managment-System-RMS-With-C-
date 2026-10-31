using System;
using System.Collections.Generic;
using System.Linq;
using RMS.Models;

namespace RMS.Services;

// Order service: business rules for order validation, creation, status transitions, and search
public class OrderService
{
    private readonly RestaurantStore _store;

    public OrderService(RestaurantStore? store = null)
    {
        _store = store ?? RestaurantStore.Instance;
    }

    // Validate order inputs (name, table, and items)
    public bool ValidateOrder(string? customerName, int tableNumber, IReadOnlyList<OrderItem>? items, out List<string> errors)
    {
        errors = new List<string>();
        if (string.IsNullOrWhiteSpace(customerName)) errors.Add("Customer name is required.");
        if (tableNumber <= 0) errors.Add("Please enter a valid table number.");
        if (items == null || items.Count == 0) errors.Add("Add at least one item before saving.");
        else if (items.Any(i => i.Quantity <= 0)) errors.Add("All item quantities must be greater than zero.");
        return errors.Count == 0;
    }

    // Create new order with sequential order number
    public Order CreateOrder(string customerName, int tableNumber, IEnumerable<OrderItem> items, string? waiterName = null)
    {
        var itemList = items.ToList();
        if (!ValidateOrder(customerName, tableNumber, itemList, out var errors))
            throw new ArgumentException(string.Join(" ", errors));

        int newOrderNumber = _store.AllocateNextOrderNumber();
        var order = new Order(newOrderNumber, customerName.Trim(), tableNumber, OrderStatus.Pending, DateTime.Now)
        {
            WaiterName = !string.IsNullOrWhiteSpace(waiterName) ? waiterName : (_store.CurrentUser?.FullName ?? "Abebe")
        };

        foreach (var item in itemList)
            order.Items.Add(new OrderItem(item.MenuItemId, item.ItemName, item.UnitPrice, item.Quantity));

        _store.AddOrder(order);
        return order;
    }

    // Update active order customer, table, and items
    public void UpdateOrder(int orderNumber, string customerName, int tableNumber, IEnumerable<OrderItem> newItems)
    {
        var order = _store.FindOrderByNumber(orderNumber) ?? throw new KeyNotFoundException($"Order {orderNumber} not found.");
        if (!order.CanEdit) throw new InvalidOperationException($"Order {orderNumber} cannot be edited.");

        var itemList = newItems.ToList();
        if (!ValidateOrder(customerName, tableNumber, itemList, out var errors))
            throw new ArgumentException(string.Join(" ", errors));

        order.CustomerName = customerName.Trim();
        order.TableNumber = tableNumber;
        order.Items.Clear();
        foreach (var item in itemList)
            order.Items.Add(new OrderItem(item.MenuItemId, item.ItemName, item.UnitPrice, item.Quantity));

        _store.NotifyOrdersChanged();
    }

    // Check if order status can advance to next stage
    public bool CanAdvanceStatus(OrderStatus currentStatus, out OrderStatus? nextStatus)
    {
        nextStatus = currentStatus switch
        {
            OrderStatus.Pending => OrderStatus.Preparing,
            OrderStatus.Preparing => OrderStatus.Ready,
            OrderStatus.Ready => OrderStatus.Completed,
            _ => null
        };
        return nextStatus != null;
    }

    // Advance order to next status stage
    public OrderStatus AdvanceOrderStatus(int orderNumber)
    {
        var order = _store.FindOrderByNumber(orderNumber) ?? throw new KeyNotFoundException($"Order {orderNumber} not found.");
        if (!CanAdvanceStatus(order.Status, out var nextStatus) || nextStatus == null)
            throw new InvalidOperationException($"Order {orderNumber} cannot advance further.");

        order.Status = nextStatus.Value;
        _store.NotifyOrdersChanged();
        return order.Status;
    }

    // Cancel active order
    public void CancelOrder(int orderNumber)
    {
        var order = _store.FindOrderByNumber(orderNumber) ?? throw new KeyNotFoundException($"Order {orderNumber} not found.");
        if (!order.CanCancel) throw new InvalidOperationException($"Order {orderNumber} cannot be cancelled.");

        order.Status = OrderStatus.Cancelled;
        _store.NotifyOrdersChanged();
    }

    // Search and filter orders by query string and status
    public IEnumerable<Order> FilterOrders(string? searchQuery, OrderStatus? statusFilter)
    {
        string term = searchQuery?.Trim() ?? string.Empty;
        return _store.Orders
            .Where(o => (!statusFilter.HasValue || o.Status == statusFilter.Value) &&
                        (string.IsNullOrEmpty(term) ||
                         o.OrderNumber.ToString().Contains(term, StringComparison.OrdinalIgnoreCase) ||
                         o.CustomerName.Contains(term, StringComparison.OrdinalIgnoreCase) ||
                         o.TableNumber.ToString().Equals(term, StringComparison.OrdinalIgnoreCase)))
            .OrderByDescending(o => o.OrderNumber);
    }
}
