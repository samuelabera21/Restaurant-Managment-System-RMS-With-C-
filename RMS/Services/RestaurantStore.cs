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
    private readonly List<MenuItem> _menuItems = new();
    private readonly List<Order> _orders = new();
    private int _nextOrderNumber = 116;

    public event Action? OnOrdersChanged;
    public event Action? OnMenuChanged;

    public IReadOnlyList<MenuItem> MenuItems => _menuItems.AsReadOnly();
    public IReadOnlyList<Order> Orders => _orders.AsReadOnly();

    public RestaurantStore(MenuPersistenceService? menuPersistence = null)
    {
        _menuPersistence = menuPersistence ?? new MenuPersistenceService();
        InitializeMenu();
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

        DateTime today = DateTime.Today;

        // #104: Hana, Table 4, Pending (Coffee x2 = 80, Burger x1 = 180) -> 260 ETB
        var o104 = new Order(104, "Hana", 4, OrderStatus.Pending, today.AddHours(10).AddMinutes(15));
        o104.Items.Add(new OrderItem(1, "Coffee", 40m, 2));
        o104.Items.Add(new OrderItem(4, "Burger", 180m, 1));
        _orders.Add(o104);

        // #105: Abel, Table 4, Preparing (Pizza x1 = 250) -> 250 ETB
        var o105 = new Order(105, "Abel", 4, OrderStatus.Preparing, today.AddHours(10).AddMinutes(20));
        o105.Items.Add(new OrderItem(5, "Pizza", 250m, 1));
        _orders.Add(o105);

        // #106: Sara, Table 4, Ready (Tea x1 = 30) -> 30 ETB
        var o106 = new Order(106, "Sara", 4, OrderStatus.Ready, today.AddHours(10).AddMinutes(25));
        o106.Items.Add(new OrderItem(2, "Tea", 30m, 1));
        _orders.Add(o106);

        // #107: Dawit, Table 4, Completed (Juice x1 = 60) -> 60 ETB
        var o107 = new Order(107, "Dawit", 4, OrderStatus.Completed, today.AddHours(10).AddMinutes(30));
        o107.Items.Add(new OrderItem(3, "Juice", 60m, 1));
        _orders.Add(o107);

        // #108: Yared, Table 2, Pending (Burger x1 = 180, Tea x1 = 30) -> 210 ETB
        var o108 = new Order(108, "Yared", 2, OrderStatus.Pending, today.AddHours(10).AddMinutes(35));
        o108.Items.Add(new OrderItem(4, "Burger", 180m, 1));
        o108.Items.Add(new OrderItem(2, "Tea", 30m, 1));
        _orders.Add(o108);

        // #109: Bethlehem, Table 1, Preparing (Pizza x1 = 250, Coffee x1 = 40) -> 290 ETB
        var o109 = new Order(109, "Bethlehem", 1, OrderStatus.Preparing, today.AddHours(10).AddMinutes(40));
        o109.Items.Add(new OrderItem(5, "Pizza", 250m, 1));
        o109.Items.Add(new OrderItem(1, "Coffee", 40m, 1));
        _orders.Add(o109);

        // #110: Natnael, Table 5, Preparing (Burger x2 = 360) -> 360 ETB
        var o110 = new Order(110, "Natnael", 5, OrderStatus.Preparing, today.AddHours(10).AddMinutes(45));
        o110.Items.Add(new OrderItem(4, "Burger", 180m, 2));
        _orders.Add(o110);

        // #111: Helen, Table 3, Ready (Coffee x2 = 80) -> 80 ETB
        var o111 = new Order(111, "Helen", 3, OrderStatus.Ready, today.AddHours(10).AddMinutes(50));
        o111.Items.Add(new OrderItem(1, "Coffee", 40m, 2));
        _orders.Add(o111);

        // #112: Daniel, Table 6, Completed (Pizza x2 = 500, Burger x1 = 180, Tea x2 = 60) -> 740 ETB
        var o112 = new Order(112, "Daniel", 6, OrderStatus.Completed, today.AddHours(11).AddMinutes(0));
        o112.Items.Add(new OrderItem(5, "Pizza", 250m, 2));
        o112.Items.Add(new OrderItem(4, "Burger", 180m, 1));
        o112.Items.Add(new OrderItem(2, "Tea", 30m, 2));
        _orders.Add(o112);

        // #113: Tigist, Table 2, Completed (Pizza x1 = 250, Burger x1 = 180, Coffee x1 = 40) -> 470 ETB
        var o113 = new Order(113, "Tigist", 2, OrderStatus.Completed, today.AddHours(11).AddMinutes(10));
        o113.Items.Add(new OrderItem(5, "Pizza", 250m, 1));
        o113.Items.Add(new OrderItem(4, "Burger", 180m, 1));
        o113.Items.Add(new OrderItem(1, "Coffee", 40m, 1));
        _orders.Add(o113);

        // #114: Michael, Table 7, Completed (Pizza x1 = 250, Burger x1 = 180) -> 430 ETB
        var o114 = new Order(114, "Michael", 7, OrderStatus.Completed, today.AddHours(11).AddMinutes(15));
        o114.Items.Add(new OrderItem(5, "Pizza", 250m, 1));
        o114.Items.Add(new OrderItem(4, "Burger", 180m, 1));
        _orders.Add(o114);

        // #115: Rahel, Table 8, Completed (Coffee x3 = 120, Tea x1 = 30) -> 150 ETB
        var o115 = new Order(115, "Rahel", 8, OrderStatus.Completed, today.AddHours(11).AddMinutes(20));
        o115.Items.Add(new OrderItem(1, "Coffee", 40m, 3));
        o115.Items.Add(new OrderItem(2, "Tea", 30m, 1));
        _orders.Add(o115);

        _nextOrderNumber = 116;
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
