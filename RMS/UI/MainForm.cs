using System.Drawing;
using System.Windows.Forms;
using RMS.Common;
using RMS.UI.Dialogs;
using RMS.UI.Navigation;
using RMS.UI.Views;

namespace RMS.UI;

/// <summary>
/// Main application shell providing the left navigation panel,
/// top application header, bottom status bar, and dynamic view host container.
/// </summary>
public partial class MainForm : Form
{
    private readonly Dictionary<ViewType, BaseView> _views = new();
    private readonly Dictionary<ViewType, Button> _navButtons = new();
    private ViewType _currentViewType = ViewType.Dashboard;
    private bool _isAdminAuthenticated = false;

    public MainForm()
    {
        InitializeComponent();

        // Map navigation buttons
        _navButtons[ViewType.Dashboard] = btnNavDashboard;
        _navButtons[ViewType.Menu] = btnNavMenu;
        _navButtons[ViewType.NewOrder] = btnNavNewOrder;
        _navButtons[ViewType.Orders] = btnNavOrders;
        _navButtons[ViewType.Reports] = btnNavReports;
        _navButtons[ViewType.MenuManagement] = btnNavManageMenu;

        // Configure clean dark slate hover states
        foreach (var btn in new[] { btnNavDashboard, btnNavMenu, btnNavNewOrder, btnNavOrders, btnNavReports, btnNavManageMenu, btnExit })
        {
            btn.UseVisualStyleBackColor = false;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = AppTheme.SidebarHover;
            btn.FlatAppearance.MouseDownBackColor = AppTheme.SidebarActive;
        }

        // In design mode, stop here so Visual Studio Designer loads cleanly
        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
        {
            return;
        }

        // Register application views
        RegisterViews();

        // Start on Dashboard
        NavigateTo(ViewType.Dashboard);
    }

    private void RegisterViews()
    {
        _views[ViewType.Dashboard] = new DashboardView { NavigateAction = NavigateTo };
        _views[ViewType.Menu] = new MenuView { NavigateAction = NavigateTo };
        _views[ViewType.NewOrder] = new NewOrderView { NavigateAction = NavigateTo };
        _views[ViewType.Orders] = new OrdersView { NavigateAction = NavigateTo };
        _views[ViewType.OrderDetails] = new OrderDetailsView { NavigateAction = NavigateTo };
        _views[ViewType.EditOrder] = new EditOrderView { NavigateAction = NavigateTo };
        _views[ViewType.Reports] = new ReportsView { NavigateAction = NavigateTo };
        _views[ViewType.MenuManagement] = new MenuManagementView { NavigateAction = NavigateTo };
    }

    public void NavigateTo(ViewType targetView, object? context = null)
    {
        // PIN protection guard for Admin Menu Management
        if (targetView == ViewType.MenuManagement && !_isAdminAuthenticated)
        {
            using var pinDialog = new PinEntryDialog();
            if (pinDialog.ShowDialog(this) == DialogResult.OK && pinDialog.IsAuthenticated)
            {
                _isAdminAuthenticated = true;
                SetStatus("Admin authenticated • Access granted to Menu Management");
            }
            else
            {
                SetStatus("Menu Management access cancelled");
                return;
            }
        }

        if (!_views.TryGetValue(targetView, out var nextView))
        {
            return;
        }

        _currentViewType = targetView;

        // Update active navigation button styling
        foreach (var (type, btn) in _navButtons)
        {
            bool isActive = (type == targetView);
            btn.BackColor = isActive ? AppTheme.SidebarActive : Color.Transparent;
            btn.Font = isActive ? AppTheme.NavItemActiveFont : AppTheme.NavItemFont;
            btn.FlatAppearance.MouseOverBackColor = isActive ? AppTheme.SidebarActive : AppTheme.SidebarHover;
        }

        // Swap View inside Content Host panel
        pnlContentHost.SuspendLayout();
        pnlContentHost.Controls.Clear();
        nextView.Dock = DockStyle.Fill;
        pnlContentHost.Controls.Add(nextView);
        pnlContentHost.ResumeLayout();

        // Lifecycle callback
        nextView.OnNavigatedTo(context);

        // Update window title and status bar
        Text = $"RMS — {targetView}";
        SetStatus($"Ready • Viewing {targetView}");
    }

    public void SetStatus(string message)
    {
        if (lblStatusLeft != null)
        {
            lblStatusLeft.Text = $"● {message}";
        }
    }

    // =========================================================================
    // Button Click Event Handlers (Created via Visual Studio Designer)
    // =========================================================================

    private void btnNavDashboard_Click(object sender, EventArgs e)
    {
        NavigateTo(ViewType.Dashboard);
    }

    private void btnNavMenu_Click(object sender, EventArgs e)
    {
        NavigateTo(ViewType.Menu);
    }

    private void btnNavNewOrder_Click(object sender, EventArgs e)
    {
        NavigateTo(ViewType.NewOrder);
    }

    private void btnNavOrders_Click(object sender, EventArgs e)
    {
        NavigateTo(ViewType.Orders);
    }

    private void btnNavReports_Click(object sender, EventArgs e)
    {
        NavigateTo(ViewType.Reports);
    }

    private void btnNavManageMenu_Click(object sender, EventArgs e)
    {
        NavigateTo(ViewType.MenuManagement);
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Are you sure you want to exit ዉለታ Restaurant RMS?", "Exit Application",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            Application.Exit();
        }
    }
}
