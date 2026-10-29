namespace RMS.Models;

/// <summary>
/// Represents a customer order at a specific table.
/// </summary>
public class Order
{
    public int OrderNumber { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public string WaiterName { get; set; } = "Abebe";
    public int TableNumber { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public OrderStatus Status { get; set; } = OrderStatus.Pending;
    public List<OrderItem> Items { get; set; } = new();

    public decimal Total => Items.Sum(item => item.Subtotal);

    public int TotalItemQuantity => Items.Sum(item => item.Quantity);

    public bool CanEdit => Status != OrderStatus.Completed && Status != OrderStatus.Cancelled;
    public bool CanCancel => Status != OrderStatus.Completed && Status != OrderStatus.Cancelled;

    public Order() { }

    public Order(int orderNumber, string customerName, int tableNumber, OrderStatus status = OrderStatus.Pending, DateTime? createdAt = null)
    {
        OrderNumber = orderNumber;
        CustomerName = customerName;
        TableNumber = tableNumber;
        Status = status;
        CreatedAt = createdAt ?? DateTime.Now;
    }
}
