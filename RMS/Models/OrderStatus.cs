namespace RMS.Models;

/// <summary>
/// Represents the distinct lifecycle stages of a restaurant order.
/// </summary>
public enum OrderStatus
{
    Pending,
    Preparing,
    Ready,
    Completed,
    Cancelled
}
