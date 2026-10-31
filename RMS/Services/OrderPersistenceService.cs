using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using RMS.Models;

namespace RMS.Services;

/// <summary>
/// Handles local file persistence for restaurant orders using JSON without requiring an external database.
/// </summary>
public class OrderPersistenceService
{
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        WriteIndented = true,
        PropertyNameCaseInsensitive = true
    };

    private readonly string _filePath;

    public OrderPersistenceService(string? customFilePath = null)
    {
        _filePath = customFilePath ?? Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "orders.json");
    }

    /// <summary>
    /// Loads orders from local JSON file. If file does not exist, returns an empty list.
    /// </summary>
    public List<Order> LoadOrders()
    {
        try
        {
            if (File.Exists(_filePath))
            {
                string json = File.ReadAllText(_filePath);
                if (!string.IsNullOrWhiteSpace(json))
                {
                    var orders = JsonSerializer.Deserialize<List<Order>>(json, JsonOptions);
                    if (orders != null)
                    {
                        return orders;
                    }
                }
            }
        }
        catch (Exception)
        {
            // Fall back to empty list safely on read errors
        }

        return new List<Order>();
    }

    /// <summary>
    /// Serializes and saves all orders to local orders.json file.
    /// </summary>
    public void SaveOrders(IEnumerable<Order> orders)
    {
        try
        {
            string? directory = Path.GetDirectoryName(_filePath);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string json = JsonSerializer.Serialize(orders, JsonOptions);
            File.WriteAllText(_filePath, json);
        }
        catch (Exception)
        {
            // Ignore write errors gracefully
        }
    }
}

