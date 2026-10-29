using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RMS.Common;
using RMS.Models;
using RMS.Services;
using RMS.UI.Dialogs;
using RMS.UI.Navigation;
using RMS.UI.Views;

namespace RMS.UI;

/// <summary>
/// Main application shell providing the left navigation panel,
/// top application header, bottom status bar, dynamic view host container,
/// and role-based workspace layouts for Waiters and Managers.
/// </summary>
public partial class MainForm : Form
{
    private readonly RestaurantStore _store = RestaurantStore.Instance;
    private readonly Dictionary<ViewType, BaseView> _views = new();
    private readonly Dictionary<ViewType, Button> _navButtons = new();
    private ViewType _currentViewType = ViewType.Dashboard;

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
        _navButtons[ViewType.StaffManagement] = btnNavManageStaff;

        // Configure clean dark slate hover states
        foreach (var btn in new[] { btnNavDashboard, btnNavMenu, btnNavNewOrder, btnNavOrders, btnNavReports, btnNavManageMenu, btnNavManageStaff, btnExit })
        {
            btn.UseVisualStyleBackColor = false;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = AppTheme.SidebarHover;
            btn.FlatAppearance.MouseDownBackColor = AppTheme.SidebarActive;
        }

        // Align header elements dynamically to avoid high-DPI truncation
        pnlHeader.Resize += (s, e) => AlignUserHeader();
        lblUserInfo.TextChanged += (s, e) => AlignUserHeader();

        // In design mode, stop here so Visual Studio Designer loads cleanly
        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
        {
            return;
        }

        // Register application views
        RegisterViews();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
        {
            return;
        }

        // Prompt for Staff ID login on application startup
        EnsureUserLoggedIn();
    }

    private void EnsureUserLoggedIn()
    {
        if (_store.CurrentUser == null)
        {
            PerformSignOut();
            return;
        }

        ApplyRoleLayout(_store.CurrentUser);
    }

    private void PerformSignOut()
    {
        _store.CurrentUser = null;
        pnlContentHost.Controls.Clear();
        this.Hide();

        using var login = new LoginDialog();
        if (login.ShowDialog() == DialogResult.OK && _store.CurrentUser != null)
        {
            this.Show();
            ApplyRoleLayout(_store.CurrentUser);
        }
        else
        {
            Application.Exit();
        }
    }

    private void AlignUserHeader()
    {
        if (lblUserInfo != null && btnLogout != null && pnlHeader != null)
        {
            lblUserInfo.Left = Math.Max(pnlHeader.Width - 420, btnLogout.Left - lblUserInfo.PreferredWidth - 14);
        }
    }

    private void ApplyRoleLayout(StaffMember user)
    {
        bool isManager = string.Equals(user.Role, "Manager", StringComparison.OrdinalIgnoreCase);

        if (isManager)
        {
            lblUserInfo.Text = $"Manager: {user.FullName}";
            AlignUserHeader();

            // Manager workspace strictly: Dashboard, Reports, Manage Menu, Manage Waiters
            btnNavDashboard.Visible = true;
            btnNavReports.Visible = true;
            btnNavMenu.Visible = false;
            btnNavOrders.Visible = false;
            btnNavNewOrder.Visible = false;

            lblAdmin.Visible = true;
            btnNavManageMenu.Visible = true;
            btnNavManageStaff.Visible = true;

            NavigateTo(ViewType.Dashboard);
        }
        else
        {
            lblUserInfo.Text = $"Waiter: {user.FullName}";
            AlignUserHeader();

            // Waiter workspace strictly: Menu, New Order, Orders
            btnNavMenu.Visible = true;
            btnNavNewOrder.Visible = true;
            btnNavOrders.Visible = true;

            // Hide Manager-only views from Waiter
            btnNavDashboard.Visible = false;
            btnNavReports.Visible = false;
            lblAdmin.Visible = false;
            btnNavManageMenu.Visible = false;
            btnNavManageStaff.Visible = false;

            NavigateTo(ViewType.NewOrder);
        }
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
        _views[ViewType.StaffManagement] = new StaffManagementView { NavigateAction = NavigateTo };
    }

    public void NavigateTo(ViewType targetView, object? context = null)
    {
        // Guard: Prevent non-managers from navigating to admin views
        if ((targetView == ViewType.MenuManagement || targetView == ViewType.StaffManagement || targetView == ViewType.Reports)
            && _store.CurrentUser?.Role != "Manager")
        {
            MessageBox.Show("This section is restricted to Restaurant Managers.",
                "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
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
        SetStatus($"Ready - Viewing {targetView}");
    }

    public void SetStatus(string message)
    {
        if (lblStatusLeft != null)
        {
            lblStatusLeft.Text = message;
        }
    }

    // =========================================================================
    // Button Click Event Handlers (Visual Studio Designer)
    // =========================================================================

    private void btnNavDashboard_Click(object? sender, EventArgs e)
    {
        NavigateTo(ViewType.Dashboard);
    }

    private void btnNavMenu_Click(object? sender, EventArgs e)
    {
        NavigateTo(ViewType.Menu);
    }

    private void btnNavNewOrder_Click(object? sender, EventArgs e)
    {
        NavigateTo(ViewType.NewOrder);
    }

    private void btnNavOrders_Click(object? sender, EventArgs e)
    {
        NavigateTo(ViewType.Orders);
    }

    private void btnNavReports_Click(object? sender, EventArgs e)
    {
        NavigateTo(ViewType.Reports);
    }

    private void btnNavManageMenu_Click(object? sender, EventArgs e)
    {
        NavigateTo(ViewType.MenuManagement);
    }

    private void btnNavManageStaff_Click(object? sender, EventArgs e)
    {
        NavigateTo(ViewType.StaffManagement);
    }

    private void btnLogout_Click(object? sender, EventArgs e)
    {
        if (MessageBox.Show("Are you sure you want to sign out?", "Sign Out",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            PerformSignOut();
        }
    }

    private void btnExit_Click(object? sender, EventArgs e)
    {
        if (MessageBox.Show("Are you sure you want to exit ዉለታ Restaurant RMS?", "Exit Application",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            Application.Exit();
        }
    }
}
