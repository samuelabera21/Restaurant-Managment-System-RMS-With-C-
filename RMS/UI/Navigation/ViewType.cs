namespace RMS.UI.Navigation;

/// <summary>
/// Identifies the distinct screen views supported by the application shell.
/// </summary>
public enum ViewType
{
    Dashboard,
    Menu,
    NewOrder,
    Orders,
    OrderDetails,
    EditOrder,
    Reports,
    MenuManagement
}

/// <summary>
/// Allows UserControl screen views to receive lifecycle parameters upon navigation.
/// </summary>
public interface INavigationAware
{
    void OnNavigatedTo(object? parameter = null);
}
