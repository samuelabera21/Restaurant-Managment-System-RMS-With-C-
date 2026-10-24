namespace RMS.Models;

/// <summary>
/// Represents a food or beverage product offered by the restaurant.
/// </summary>
public class MenuItem
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; } = true;

    public MenuItem() { }

    public MenuItem(int id, string name, string category, decimal price, bool isAvailable = true)
    {
        Id = id;
        Name = name;
        Category = category;
        Price = price;
        IsAvailable = isAvailable;
    }

    public override string ToString() => $"{Name} — {Price:N0} ETB";
}
