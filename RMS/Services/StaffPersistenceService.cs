using System.Text.Json;
using RMS.Models;

namespace RMS.Services;

/// <summary>
/// Handles local file persistence for staff members using JSON without requiring an external database.
/// </summary>
public class StaffPersistenceService
{
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        WriteIndented = true,
        PropertyNameCaseInsensitive = true
    };

    private readonly string _filePath;

    public StaffPersistenceService(string? customFilePath = null)
    {
        _filePath = customFilePath ?? Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "staff.json");
    }

    public List<StaffMember> LoadOrCreateDefault()
    {
        try
        {
            if (File.Exists(_filePath))
            {
                string json = File.ReadAllText(_filePath);
                if (!string.IsNullOrWhiteSpace(json))
                {
                    var staff = JsonSerializer.Deserialize<List<StaffMember>>(json, JsonOptions);
                    if (staff != null && staff.Count > 0)
                    {
                        return staff;
                    }
                }
            }
        }
        catch (Exception)
        {
            // Fall back to default staff safely on read error
        }

        var defaultStaff = GetDefaultStaffMembers();
        SaveStaff(defaultStaff);
        return defaultStaff;
    }

    public void SaveStaff(IEnumerable<StaffMember> staff)
    {
        try
        {
            string? directory = Path.GetDirectoryName(_filePath);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string json = JsonSerializer.Serialize(staff, JsonOptions);
            File.WriteAllText(_filePath, json);
        }
        catch (Exception)
        {
            // Ignore write errors gracefully
        }
    }

    public static List<StaffMember> GetDefaultStaffMembers()
    {
        return new List<StaffMember>
        {
            new(100, "Manager (Admin)", "Manager", "All Shifts", true),
            new(101, "Abebe Bikila", "Waiter", "Day Shift", true),
            new(102, "Hana Tadesse", "Waiter", "Evening Shift", true),
            new(103, "Dawit Kebede", "Waiter", "Day Shift", true)
        };
    }
}

