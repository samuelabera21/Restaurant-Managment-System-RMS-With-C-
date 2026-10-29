namespace RMS.Models;

/// <summary>
/// Represents a restaurant employee (Waiter or Manager) with Staff ID access.
/// </summary>
public class StaffMember
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Role { get; set; } = "Waiter"; // "Manager" or "Waiter"
    public string Shift { get; set; } = "Day Shift";
    public bool IsActive { get; set; } = true;

    public StaffMember() { }

    public StaffMember(int id, string fullName, string role = "Waiter", string shift = "Day Shift", bool isActive = true)
    {
        Id = id;
        FullName = fullName;
        Role = role;
        Shift = shift;
        IsActive = isActive;
    }
}
