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

// Main window: sidebar navigation and view container
public partial class MainForm : Form
{
    private readonly RestaurantStore _store = RestaurantStore.Instance;
    private readonly Dictionary<ViewType, BaseView> _views = new();
    private readonly Dictionary<ViewType, Button> _navButtons = new();

    public MainForm()
    {
        InitializeComponent();

        // Map buttons to views
        _navButtons[ViewType.Dashboard] = btnNavDashboard;
        _navButtons[ViewType.Menu] = btnNavMenu;
        _navButtons[ViewType.NewOrder] = btnNavNewOrder;
        _navButtons[ViewType.Orders] = btnNavOrders;
        _navButtons[ViewType.Reports] = btnNavReports;
        _navButtons[ViewType.MenuManagement] = btnNavManageMenu;
        _navButtons[ViewType.StaffManagement] = btnNavManageStaff;

        // Keep header aligned
        pnlHeader.Resize += (s, e) => AlignUserHeader();
        lblUserInfo.TextChanged += (s, e) => AlignUserHeader();

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        RegisterViews();
    }

    // Check user login on startup
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;

        EnsureUserLoggedIn();
    }

    // Ensure staff member is logged in
    private void EnsureUserLoggedIn()
    {
        if (_store.CurrentUser == null)
            PerformSignOut();
        else
            ApplyRoleLayout(_store.CurrentUser);
    }

    // Sign out user and show login form
    private void PerformSignOut()
    {
        _store.CurrentUser = null;
        pnlContentHost.Controls.Clear();
        Hide();

        using var login = new LoginDialog();
        if (login.ShowDialog() == DialogResult.OK && _store.CurrentUser != null)
        {
            Show();
            ApplyRoleLayout(_store.CurrentUser);
        }
        else
        {
            Application.Exit();
        }
    }

    // Align username and sign out button
    private void AlignUserHeader()
    {
        if (lblUserInfo != null && btnLogout != null && pnlHeader != null)
        {
            lblUserInfo.Left = Math.Max(pnlHeader.Width - 420, btnLogout.Left - lblUserInfo.PreferredWidth - 14);
        }
    }

    // Set visible buttons based on role (Manager vs Waiter)
    private void ApplyRoleLayout(StaffMember user)
    {
        bool isManager = string.Equals(user.Role, "Manager", StringComparison.OrdinalIgnoreCase);
        lblUserInfo.Text = $"{user.Role}: {user.FullName}";
        AlignUserHeader();

        // Manager buttons
        btnNavDashboard.Visible = btnNavReports.Visible = btnNavManageMenu.Visible = btnNavManageStaff.Visible = isManager;

        // Waiter buttons
        btnNavMenu.Visible = btnNavOrders.Visible = btnNavNewOrder.Visible = !isManager;

        // Open starting page
        NavigateTo(isManager ? ViewType.Dashboard : ViewType.NewOrder);
    }

    // Register all application views
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

    // Navigate to selected view
    public void NavigateTo(ViewType targetView, object? context = null)
    {
        // Restrict admin views to Manager
        if ((targetView == ViewType.MenuManagement || targetView == ViewType.StaffManagement || targetView == ViewType.Reports)
            && _store.CurrentUser?.Role != "Manager")
        {
            MessageBox.Show("This section is restricted to Restaurant Managers.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!_views.TryGetValue(targetView, out var nextView)) return;

        // Highlight active sidebar button
        foreach (var (type, btn) in _navButtons)
        {
            bool isActive = (type == targetView);
            btn.BackColor = isActive ? Color.FromArgb(30, 58, 95) : Color.White;
            btn.ForeColor = isActive ? Color.White : Color.FromArgb(30, 41, 59);
            btn.Font = isActive ? AppTheme.NavItemActiveFont : AppTheme.NavItemFont;
            btn.FlatAppearance.BorderSize = isActive ? 0 : 1;
            btn.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btn.FlatAppearance.MouseOverBackColor = isActive ? Color.FromArgb(30, 58, 95) : Color.FromArgb(241, 245, 249);
        }

        // Show view in content panel
        pnlContentHost.SuspendLayout();
        pnlContentHost.Controls.Clear();
        nextView.Dock = DockStyle.Fill;
        pnlContentHost.Controls.Add(nextView);
        pnlContentHost.ResumeLayout();

        nextView.OnNavigatedTo(context);
        Text = $"RMS — {targetView}";
    }

    // Status bar update helper
    public void SetStatus(string message) { }

    // Sidebar navigation button clicks
    private void btnNavDashboard_Click(object? sender, EventArgs e) => NavigateTo(ViewType.Dashboard);
    private void btnNavMenu_Click(object? sender, EventArgs e) => NavigateTo(ViewType.Menu);
    private void btnNavNewOrder_Click(object? sender, EventArgs e) => NavigateTo(ViewType.NewOrder);
    private void btnNavOrders_Click(object? sender, EventArgs e) => NavigateTo(ViewType.Orders);
    private void btnNavReports_Click(object? sender, EventArgs e) => NavigateTo(ViewType.Reports);
    private void btnNavManageMenu_Click(object? sender, EventArgs e) => NavigateTo(ViewType.MenuManagement);
    private void btnNavManageStaff_Click(object? sender, EventArgs e) => NavigateTo(ViewType.StaffManagement);

    // Sign out button click
    private void btnLogout_Click(object? sender, EventArgs e)
    {
        if (MessageBox.Show("Are you sure you want to sign out?", "Sign Out",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            PerformSignOut();
        }
    }

    // Exit application button click
    private void btnExit_Click(object? sender, EventArgs e)
    {
        if (MessageBox.Show("Are you sure you want to exit ዉለታ Restaurant RMS?", "Exit Application",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            Application.Exit();
        }
    }
}
