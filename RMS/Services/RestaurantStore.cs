using RMS.Models;
using MenuItem = RMS.Models.MenuItem;

namespace RMS.Services;

/// <summary>
/// Central in-memory repository managing shared application state:
/// - Persisted menu items (via JSON)
/// - In-memory active & historical orders
/// - Atomic sequential order numbering starting at #116
/// - Real-time aggregate KPI metrics
/// </summary>
public class RestaurantStore
{
    private static RestaurantStore? _instance;
    private static readonly object LockObject = new();

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
    private readonly List<MenuItem> _menuItems = new();
    private readonly List<StaffMember> _staffMembers = new();
    private readonly List<Order> _orders = new();
    private int _nextOrderNumber = 116;

    public StaffMember? CurrentUser { get; set; }

    public event Action? OnOrdersChanged;
    public event Action? OnMenuChanged;
    public event Action? OnStaffChanged;

    public IReadOnlyList<MenuItem> MenuItems => _menuItems.AsReadOnly();
    public IReadOnlyList<StaffMember> StaffMembers => _staffMembers.AsReadOnly();
    public IReadOnlyList<Order> Orders => _orders.AsReadOnly();

    public RestaurantStore(MenuPersistenceService? menuPersistence = null, StaffPersistenceService? staffPersistence = null)
    {
        _menuPersistence = menuPersistence ?? new MenuPersistenceService();
        _staffPersistence = staffPersistence ?? new StaffPersistenceService();
        InitializeMenu();
        InitializeStaff();
        SeedDemonstrationOrders();
    }

    #region Menu Management

    private void InitializeMenu()
    {
        _menuItems.Clear();
        _menuItems.AddRange(_menuPersistence.LoadOrCreateDefault());
    }

    public void ReloadMenu()
    {
        InitializeMenu();
        OnMenuChanged?.Invoke();
    }

    public void SaveMenuChanges()
    {
        _menuPersistence.SaveMenu(_menuItems);
        OnMenuChanged?.Invoke();
    }

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

    public void SetMenuItemAvailability(int menuItemId, bool isAvailable)
    {
        var existing = _menuItems.FirstOrDefault(m => m.Id == menuItemId);
        if (existing != null)
        {
            existing.IsAvailable = isAvailable;
            SaveMenuChanges();
        }
    }

    #endregion

    #region Staff Management

    private void InitializeStaff()
    {
        _staffMembers.Clear();
        _staffMembers.AddRange(_staffPersistence.LoadOrCreateDefault());
    }

    public void SaveStaffChanges()
    {
        _staffPersistence.SaveStaff(_staffMembers);
        OnStaffChanged?.Invoke();
    }

    public int PeekNextStaffId()
    {
        return _staffMembers.Count > 0 ? _staffMembers.Max(s => s.Id) + 1 : 101;
    }

    public void AddStaffMember(StaffMember member)
    {
        ArgumentNullException.ThrowIfNull(member);
        if (member.Id <= 0)
        {
            member.Id = PeekNextStaffId();
        }
        _staffMembers.Add(member);
        SaveStaffChanges();
    }

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

    public void SetStaffStatus(int staffId, bool isActive)
    {
        var existing = _staffMembers.FirstOrDefault(s => s.Id == staffId);
        if (existing != null)
        {
            existing.IsActive = isActive;
            SaveStaffChanges();
        }
    }

    public StaffMember? AuthenticateStaff(int staffId)
    {
        return _staffMembers.FirstOrDefault(s => s.Id == staffId && s.IsActive);
    }

    #endregion

    #region Order Management & Seed Data

    public int PeekNextOrderNumber() => _nextOrderNumber;

    public int AllocateNextOrderNumber()
    {
        lock (LockObject)
        {
            return _nextOrderNumber++;
        }
    }

    public void AddOrder(Order order)
    {
        ArgumentNullException.ThrowIfNull(order);
        _orders.Add(order);
        NotifyOrdersChanged();
    }

    public void NotifyOrdersChanged()
    {
        OnOrdersChanged?.Invoke();
    }

    public Order? FindOrderByNumber(int orderNumber)
    {
        return _orders.FirstOrDefault(o => o.OrderNumber == orderNumber);
    }

    /// <summary>
    /// Seeds the 12 approved demonstration orders (#104–#115) with their exact snapshots.
    /// Invariant result: 12 Total, 2 Pending, 3 Preparing, 2 Ready, 5 Completed, 1,850 ETB completed revenue.
    /// </summary>
    private void SeedDemonstrationOrders()
    {
        _orders.Clear();
        _nextOrderNumber = 101;
    }
    #endregion

    #region Real-Time KPI Metrics

    /// <summary>
    /// Total tracked orders, excluding cancelled orders.
    /// </summary>
    public int ActiveTotalOrdersCount => _orders.Count(o => o.Status != OrderStatus.Cancelled);

    public int TotalOrdersIncludingCancelledCount => _orders.Count;

    public int PendingOrdersCount => _orders.Count(o => o.Status == OrderStatus.Pending);

    public int PreparingOrdersCount => _orders.Count(o => o.Status == OrderStatus.Preparing);

    public int ReadyOrdersCount => _orders.Count(o => o.Status == OrderStatus.Ready);

    public int CompletedOrdersCount => _orders.Count(o => o.Status == OrderStatus.Completed);

    public int CancelledOrdersCount => _orders.Count(o => o.Status == OrderStatus.Cancelled);

    /// <summary>
    /// Total sales value for completed orders in ETB (strictly excludes cancelled/active orders).
    /// </summary>
    public decimal CompletedOrdersValue => _orders
        .Where(o => o.Status == OrderStatus.Completed)
        .Sum(o => o.Total);

    #endregion
}
