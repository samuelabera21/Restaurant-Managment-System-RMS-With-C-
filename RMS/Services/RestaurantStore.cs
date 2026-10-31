using System;
using System.Collections.Generic;
using System.Linq;
using RMS.Models;
using MenuItem = RMS.Models.MenuItem;

namespace RMS.Services;

// Central in-memory repository managing orders, menu, staff, and JSON persistence
public class RestaurantStore
{
    private static RestaurantStore? _instance;
    private static readonly object LockObject = new();

    // Singleton instance access
    public static RestaurantStore Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (LockObject)
                {
                    _instance ??= new RestaurantStore();
                }
            }
            return _instance;
        }
    }

    private readonly MenuPersistenceService _menuPersistence;
    private readonly StaffPersistenceService _staffPersistence;
    private readonly OrderPersistenceService _orderPersistence;

    private readonly List<MenuItem> _menuItems = new();
    private readonly List<StaffMember> _staffMembers = new();
    private readonly List<Order> _orders = new();
    private int _nextOrderNumber = 101;

    // Currently logged-in user
    public StaffMember? CurrentUser { get; set; }

    // Store change notification events
    public event Action? OnOrdersChanged;
    public event Action? OnMenuChanged;
    public event Action? OnStaffChanged;

    // Public read-only access to collections
    public IReadOnlyList<MenuItem> MenuItems => _menuItems.AsReadOnly();
    public IReadOnlyList<StaffMember> StaffMembers => _staffMembers.AsReadOnly();
    public IReadOnlyList<Order> Orders => _orders.AsReadOnly();

    public RestaurantStore(
        MenuPersistenceService? menuPersistence = null, 
        StaffPersistenceService? staffPersistence = null, 
        OrderPersistenceService? orderPersistence = null)
    {
        _menuPersistence = menuPersistence ?? new MenuPersistenceService();
        _staffPersistence = staffPersistence ?? new StaffPersistenceService();
        _orderPersistence = orderPersistence ?? new OrderPersistenceService();

        InitializeMenu();
        InitializeStaff();
        InitializeOrders();
    }

    // ==========================================
    // Menu Management
    // ==========================================

    private void InitializeMenu()
    {
        _menuItems.Clear();
        _menuItems.AddRange(_menuPersistence.LoadOrCreateDefault());
    }

    // Save menu changes to JSON and fire event
    public void SaveMenuChanges()
    {
        _menuPersistence.SaveMenu(_menuItems);
        OnMenuChanged?.Invoke();
    }

    // Add new menu item
    public void AddMenuItem(MenuItem item)
    {
        ArgumentNullException.ThrowIfNull(item);
        if (item.Id <= 0)
        {
            int maxId = _menuItems.Count > 0 ? _menuItems.Max(m => m.Id) : 0;
            item.Id = maxId + 1;
        }

        _menuItems.Add(item);
        SaveMenuChanges();
    }

    // Update existing menu item
    public void UpdateMenuItem(MenuItem updatedItem)
    {
        ArgumentNullException.ThrowIfNull(updatedItem);
        var existing = _menuItems.FirstOrDefault(m => m.Id == updatedItem.Id);
        if (existing != null)
        {
            existing.Name = updatedItem.Name;
            existing.Category = updatedItem.Category;
            existing.Price = updatedItem.Price;
            existing.IsAvailable = updatedItem.IsAvailable;
            SaveMenuChanges();
        }
    }

    // Toggle menu item availability
    public void SetMenuItemAvailability(int menuItemId, bool isAvailable)
    {
        var existing = _menuItems.FirstOrDefault(m => m.Id == menuItemId);
        if (existing != null)
        {
            existing.IsAvailable = isAvailable;
            SaveMenuChanges();
        }
    }

    // ==========================================
    // Staff Management
    // ==========================================

    private void InitializeStaff()
    {
        _staffMembers.Clear();
        _staffMembers.AddRange(_staffPersistence.LoadOrCreateDefault());
    }

    // Save staff changes to JSON and fire event
    public void SaveStaffChanges()
    {
        _staffPersistence.SaveStaff(_staffMembers);
        OnStaffChanged?.Invoke();
    }

    // Peek next available staff ID
    public int PeekNextStaffId() => _staffMembers.Count > 0 ? _staffMembers.Max(s => s.Id) + 1 : 101;

    // Add new waiter/staff member
    public void AddStaffMember(StaffMember member)
    {
        ArgumentNullException.ThrowIfNull(member);
        if (member.Id <= 0) member.Id = PeekNextStaffId();
        _staffMembers.Add(member);
        SaveStaffChanges();
    }

    // Update existing staff details
    public void UpdateStaffMember(StaffMember updated)
    {
        ArgumentNullException.ThrowIfNull(updated);
        var existing = _staffMembers.FirstOrDefault(s => s.Id == updated.Id);
        if (existing != null)
        {
            existing.FullName = updated.FullName;
            existing.Role = updated.Role;
            existing.Shift = updated.Shift;
            existing.IsActive = updated.IsActive;
            SaveStaffChanges();
        }
    }

    // Toggle active status for staff member
    public void SetStaffStatus(int staffId, bool isActive)
    {
        var existing = _staffMembers.FirstOrDefault(s => s.Id == staffId);
        if (existing != null)
        {
            existing.IsActive = isActive;
            SaveStaffChanges();
        }
    }

    // Authenticate staff member by numeric ID
    public StaffMember? AuthenticateStaff(int staffId)
    {
        return _staffMembers.FirstOrDefault(s => s.Id == staffId && s.IsActive);
    }

    // ==========================================
    // Order Management & Persistence
    // ==========================================

    public int PeekNextOrderNumber() => _nextOrderNumber;

    // Thread-safe allocation of next sequential order number
    public int AllocateNextOrderNumber()
    {
        lock (LockObject)
        {
            return _nextOrderNumber++;
        }
    }

    private void InitializeOrders()
    {
        _orders.Clear();
        _orders.AddRange(_orderPersistence.LoadOrders());
        _nextOrderNumber = _orders.Count > 0 ? _orders.Max(o => o.OrderNumber) + 1 : 101;
    }

    // Save orders to JSON and fire event
    public void SaveOrderChanges()
    {
        _orderPersistence.SaveOrders(_orders);
        OnOrdersChanged?.Invoke();
    }

    // Add order and persist
    public void AddOrder(Order order)
    {
        ArgumentNullException.ThrowIfNull(order);
        _orders.Add(order);
        SaveOrderChanges();
    }

    // Notify listeners when orders change
    public void NotifyOrdersChanged() => SaveOrderChanges();

    // Find order by its numeric ID
    public Order? FindOrderByNumber(int orderNumber) => _orders.FirstOrDefault(o => o.OrderNumber == orderNumber);

    // ==========================================
    // Real-Time KPI Metrics
    // ==========================================

    public int ActiveTotalOrdersCount => _orders.Count(o => o.Status != OrderStatus.Cancelled);
    public int TotalOrdersIncludingCancelledCount => _orders.Count;
    public int PendingOrdersCount => _orders.Count(o => o.Status == OrderStatus.Pending);
    public int PreparingOrdersCount => _orders.Count(o => o.Status == OrderStatus.Preparing);
    public int ReadyOrdersCount => _orders.Count(o => o.Status == OrderStatus.Ready);
    public int CompletedOrdersCount => _orders.Count(o => o.Status == OrderStatus.Completed);
    public int CancelledOrdersCount => _orders.Count(o => o.Status == OrderStatus.Cancelled);

    // Total sales revenue from completed orders
    public decimal CompletedOrdersValue => _orders
        .Where(o => o.Status == OrderStatus.Completed)
        .Sum(o => o.Total);
}
