using System.Text.Json;
using RMS.Models;
using MenuItem = RMS.Models.MenuItem;

namespace RMS.Services;

/// <summary>
/// Handles local file persistence for menu items using JSON without requiring an external database.
/// </summary>
public class MenuPersistenceService
{
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        WriteIndented = true,
        PropertyNameCaseInsensitive = true
    };

    private readonly string _filePath;

    public MenuPersistenceService(string? customFilePath = null)
    {
        _filePath = customFilePath ?? Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "menu.json");
    }

    /// <summary>
    /// Loads menu items from the local JSON file. If the file does not exist or contains invalid data,
    /// initializes the default 5 menu items, saves them to disk, and returns them.
    /// </summary>
    public List<MenuItem> LoadOrCreateDefault()
    {
        try
        {
            if (File.Exists(_filePath))
            {
                string json = File.ReadAllText(_filePath);
                if (!string.IsNullOrWhiteSpace(json))
                {
                    var items = JsonSerializer.Deserialize<List<MenuItem>>(json, JsonOptions);
                    if (items != null && items.Count > 0)
                    {
                        return items;
                    }
                }
            }
        }
        catch (Exception)
        {
            // If the existing file is corrupted or unreadable, fall back to defaults safely.
        }

        var defaultMenu = GetDefaultMenuItems();
        SaveMenu(defaultMenu);
        return defaultMenu;
    }

    /// <summary>
    /// Serializes and writes the given menu items to the local JSON file.
    /// </summary>
    public void SaveMenu(IEnumerable<MenuItem> items)
    {
        string? directory = Path.GetDirectoryName(_filePath);
        if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
        }

        string json = JsonSerializer.Serialize(items, JsonOptions);
        File.WriteAllText(_filePath, json);
    }

    /// <summary>
    /// Returns the initial five approved menu items.
    /// </summary>
    public static List<MenuItem> GetDefaultMenuItems()
    {
        return new List<MenuItem>
        {
            new(1, "Coffee", "Drinks", 40m, isAvailable: true),
            new(2, "Tea", "Drinks", 30m, isAvailable: true),
            new(3, "Juice", "Drinks", 60m, isAvailable: false),
            new(4, "Burger", "Main Course", 180m, isAvailable: true),
            new(5, "Pizza", "Main Course", 250m, isAvailable: true)
        };
    }
}
