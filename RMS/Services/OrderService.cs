using RMS.Models;

namespace RMS.Services;

/// <summary>
/// Encapsulates all domain business rules:
/// - Order validation
/// - Atomic creation with sequential numbering (#116+)
/// - Single-step status progression (Pending -> Preparing -> Ready -> Completed)
/// - Cancellation rules & locking of completed orders
/// - Historical pricing snapshot enforcement
/// </summary>
public class OrderService
{
    private readonly RestaurantStore _store;

    public OrderService(RestaurantStore? store = null)
    {
        _store = store ?? RestaurantStore.Instance;
    }

    #region Validation

    /// <summary>
    /// Validates customer name, table number, and line items.
    /// Returns true if valid; otherwise false with error messages.
    /// </summary>
    public bool ValidateOrder(string? customerName, int tableNumber, IReadOnlyList<OrderItem>? items, out List<string> validationErrors)
    {
        validationErrors = new List<string>();

        if (string.IsNullOrWhiteSpace(customerName))
        {
            validationErrors.Add("Customer name is required.");
        }

        if (tableNumber <= 0)
        {
            validationErrors.Add("Please enter a valid table number.");
        }

        if (items == null || items.Count == 0)
        {
            validationErrors.Add("Add at least one item before saving.");
        }
        else
        {
            foreach (var item in items)
            {
                if (item.Quantity <= 0)
                {
                    validationErrors.Add($"Quantity for '{item.ItemName}' must be greater than zero.");
                }
            }
        }

        return validationErrors.Count == 0;
    }

    #endregion

    #region Order Creation & Modification

    /// <summary>
    /// Creates a new order using the next atomic sequential number (starting at #116),
    /// freezes item snapshots, and saves it in Pending status.
    /// </summary>
    public Order CreateOrder(string customerName, int tableNumber, IEnumerable<OrderItem> items, string? waiterName = null)
    {
        var itemList = items.ToList();

        if (!ValidateOrder(customerName, tableNumber, itemList, out var errors))
        {
            throw new ArgumentException(string.Join(" ", errors));
        }

        int newOrderNumber = _store.AllocateNextOrderNumber();
        var order = new Order(newOrderNumber, customerName.Trim(), tableNumber, OrderStatus.Pending, DateTime.Now)
        {
            WaiterName = !string.IsNullOrWhiteSpace(waiterName) ? waiterName : (_store.CurrentUser?.FullName ?? "Abebe")
        };

        foreach (var item in itemList)
        {
            // Ensure frozen snapshot of line item
            order.Items.Add(new OrderItem(item.MenuItemId, item.ItemName, item.UnitPrice, item.Quantity));
        }

        _store.AddOrder(order);
        return order;
    }

    /// <summary>
    /// Updates customer, table, and items for an active order.
    /// Throws InvalidOperationException if order is completed or cancelled.
    /// </summary>
    public void UpdateOrder(int orderNumber, string customerName, int tableNumber, IEnumerable<OrderItem> newItems)
    {
        var order = _store.FindOrderByNumber(orderNumber)
            ?? throw new KeyNotFoundException($"Order #{orderNumber} not found.");

        if (!order.CanEdit)
        {
            throw new InvalidOperationException($"Order #{orderNumber} has status '{order.Status}' and cannot be edited.");
        }

        var itemList = newItems.ToList();
        if (!ValidateOrder(customerName, tableNumber, itemList, out var errors))
        {
            throw new ArgumentException(string.Join(" ", errors));
        }

        order.CustomerName = customerName.Trim();
        order.TableNumber = tableNumber;
        order.Items.Clear();

        foreach (var item in itemList)
        {
            order.Items.Add(new OrderItem(item.MenuItemId, item.ItemName, item.UnitPrice, item.Quantity));
        }

        _store.NotifyOrdersChanged();
    }

    #endregion

    #region Status Progression & Cancellation

    /// <summary>
    /// Determines whether an order can advance to the next lifecycle stage,
    /// returning the next valid status if permissible.
    /// </summary>
    public bool CanAdvanceStatus(OrderStatus currentStatus, out OrderStatus? nextStatus)
    {
        switch (currentStatus)
        {
            case OrderStatus.Pending:
                nextStatus = OrderStatus.Preparing;
                return true;
            case OrderStatus.Preparing:
                nextStatus = OrderStatus.Ready;
                return true;
            case OrderStatus.Ready:
                nextStatus = OrderStatus.Completed;
                return true;
            case OrderStatus.Completed:
            case OrderStatus.Cancelled:
            default:
                nextStatus = null;
                return false;
        }
    }

    /// <summary>
    /// Advances an order exactly one lifecycle stage (Pending -> Preparing -> Ready -> Completed).
    /// Throws InvalidOperationException if the order cannot be advanced.
    /// </summary>
    public OrderStatus AdvanceOrderStatus(int orderNumber)
    {
        var order = _store.FindOrderByNumber(orderNumber)
            ?? throw new KeyNotFoundException($"Order #{orderNumber} not found.");

        if (!CanAdvanceStatus(order.Status, out var nextStatus) || nextStatus == null)
        {
            throw new InvalidOperationException($"Order #{orderNumber} with status '{order.Status}' cannot advance further.");
        }

        order.Status = nextStatus.Value;
        _store.NotifyOrdersChanged();
        return order.Status;
    }

    /// <summary>
    /// Cancels an active order, updating its status to Cancelled.
    /// Preserves the order in memory while locking it against further changes.
    /// Throws InvalidOperationException if the order is already Completed or Cancelled.
    /// </summary>
    public void CancelOrder(int orderNumber)
    {
        var order = _store.FindOrderByNumber(orderNumber)
            ?? throw new KeyNotFoundException($"Order #{orderNumber} not found.");

        if (!order.CanCancel)
        {
            throw new InvalidOperationException($"Order #{orderNumber} with status '{order.Status}' cannot be cancelled.");
        }

        order.Status = OrderStatus.Cancelled;
        _store.NotifyOrdersChanged();
    }

    #endregion

    #region Search and Filtering

    /// <summary>
    /// Searches and filters the order collection according to query string and status filter.
    /// </summary>
    public IEnumerable<Order> FilterOrders(string? searchQuery, OrderStatus? statusFilter)
    {
        var query = _store.Orders.AsEnumerable();

        if (statusFilter.HasValue)
        {
            query = query.Where(o => o.Status == statusFilter.Value);
        }

        if (!string.IsNullOrWhiteSpace(searchQuery))
        {
            string term = searchQuery.Trim();
            query = query.Where(o =>
                o.OrderNumber.ToString().Contains(term, StringComparison.OrdinalIgnoreCase) ||
                o.CustomerName.Contains(term, StringComparison.OrdinalIgnoreCase) ||
                o.TableNumber.ToString().Equals(term, StringComparison.OrdinalIgnoreCase)
            );
        }

        return query.OrderByDescending(o => o.OrderNumber);
    }

    #endregion
}
