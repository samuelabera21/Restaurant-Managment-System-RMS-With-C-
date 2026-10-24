namespace RMS.Models;

/// <summary>
/// Represents a specific menu item and quantity associated with an order.
/// Captures a frozen snapshot of the item name and unit price at the time of addition.
/// </summary>
public class OrderItem
{
    public int MenuItemId { get; set; }
    public string ItemName { get; set; } = string.Empty;
    public decimal UnitPrice { get; set; }
    public int Quantity { get; set; }

    public decimal Subtotal => UnitPrice * Quantity;

    public OrderItem() { }

    public OrderItem(int menuItemId, string itemName, decimal unitPrice, int quantity)
    {
        MenuItemId = menuItemId;
        ItemName = itemName;
        UnitPrice = unitPrice;
        Quantity = quantity;
    }

    /// <summary>
    /// Factory method that creates an OrderItem snapshot directly from a MenuItem.
    /// </summary>
    public static OrderItem CreateFromMenuItem(MenuItem menuItem, int quantity)
    {
        ArgumentNullException.ThrowIfNull(menuItem);
        if (quantity <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity must be greater than zero.");
        }

        return new OrderItem(menuItem.Id, menuItem.Name, menuItem.Price, quantity);
    }
}
