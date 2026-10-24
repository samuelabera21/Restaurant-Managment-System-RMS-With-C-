using System.Drawing;
using System.Windows.Forms;
using RMS.Common;
using RMS.UI.Dialogs;
using RMS.UI.Navigation;
using RMS.UI.Views;

namespace RMS.UI;

/// <summary>
/// Main application shell providing the persistent burgundy sidebar,
/// top application header, bottom status bar, and dynamic view host container.
/// </summary>
public partial class MainForm : Form
{
    private readonly Panel _pnlSidebar;
    private readonly Panel _pnlHeader;
    private readonly Panel _pnlStatusBar;
    private readonly Panel _pnlContentHost;
    private readonly Label _lblStatusLeft;
    private readonly Label _lblStatusRight;

    private readonly Dictionary<ViewType, BaseView> _views = new();
    private readonly Dictionary<ViewType, Button> _navButtons = new();
    private ViewType _currentViewType = ViewType.Dashboard;
    private bool _isAdminAuthenticated = false;

    public MainForm()
    {
        InitializeComponent();

        Text = "RMS — Restaurant Order Management System";
        Size = new Size(1280, 820);
        MinimumSize = new Size(1080, 700);
        StartPosition = FormStartPosition.CenterScreen;
        BackColor = AppTheme.ContentBackground;
        Font = AppTheme.BodyRegular;

        // 1. Content Host Panel (Dock = Fill, docked LAST to take remaining canvas)
        _pnlContentHost = new Panel
        {
            Dock = DockStyle.Fill,
            BackColor = AppTheme.ContentBackground
        };
        Controls.Add(_pnlContentHost);

        // 2. Status Bar (Dock = Bottom)
        _pnlStatusBar = CreateStatusBar(out _lblStatusLeft, out _lblStatusRight);
        Controls.Add(_pnlStatusBar);

        // 3. Top Header (Dock = Top)
        _pnlHeader = CreateHeader();
        Controls.Add(_pnlHeader);

        // 4. Sidebar (Dock = Left, docked FIRST to take full height)
        _pnlSidebar = CreateSidebar();
        Controls.Add(_pnlSidebar);

        // Register View instances
        RegisterViews();

        // Navigate to initial view (Dashboard)
        NavigateTo(ViewType.Dashboard);
    }

    private Panel CreateSidebar()
    {
        var sidebar = new Panel
        {
            Dock = DockStyle.Left,
            Width = 230,
            BackColor = AppTheme.SidebarBackground,
            Padding = new Padding(12, 16, 12, 16)
        };

        // Brand section
        var pnlBrand = new Panel
        {
            Dock = DockStyle.Top,
            Height = 70,
            BackColor = Color.Transparent
        };

        var lblBadge = new Label
        {
            Text = "RMS",
            Font = AppTheme.SmallBold,
            ForeColor = AppTheme.GoldAccent,
            BackColor = AppTheme.GoldBadgeBackground,
            AutoSize = false,
            Size = new Size(44, 22),
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(6, 6)
        };

        var lblBrandName = new Label
        {
            Text = "ዉለታ Restaurant",
            Font = AppTheme.HeaderMedium,
            ForeColor = Color.White,
            AutoSize = true,
            Location = new Point(6, 34)
        };

        pnlBrand.Controls.Add(lblBadge);
        pnlBrand.Controls.Add(lblBrandName);

        // Section label: WORKSPACE
        var lblWorkspace = new Label
        {
            Text = "WORKSPACE",
            Font = AppTheme.SmallBold,
            ForeColor = AppTheme.SidebarMutedText,
            Dock = DockStyle.Top,
            Height = 28,
            TextAlign = ContentAlignment.BottomLeft,
            Padding = new Padding(8, 0, 0, 4)
        };

        // Nav Buttons Container
        var pnlNav = new FlowLayoutPanel
        {
            Dock = DockStyle.Fill,
            FlowDirection = FlowDirection.TopDown,
            WrapContents = false,
            BackColor = Color.Transparent,
            AutoScroll = false,
            Padding = new Padding(0, 8, 0, 0)
        };

        // Main Navigation buttons
        _navButtons[ViewType.Dashboard] = CreateNavButton(ViewType.Dashboard, "⊞  Dashboard");
        _navButtons[ViewType.Menu] = CreateNavButton(ViewType.Menu, "📖  Menu");
        _navButtons[ViewType.NewOrder] = CreateNavButton(ViewType.NewOrder, "⊕  New Order");
        _navButtons[ViewType.Orders] = CreateNavButton(ViewType.Orders, "📋  Orders");
        _navButtons[ViewType.Reports] = CreateNavButton(ViewType.Reports, "📊  Reports");

        pnlNav.Controls.Add(_navButtons[ViewType.Dashboard]);
        pnlNav.Controls.Add(_navButtons[ViewType.Menu]);
        pnlNav.Controls.Add(_navButtons[ViewType.NewOrder]);
        pnlNav.Controls.Add(_navButtons[ViewType.Orders]);
        pnlNav.Controls.Add(_navButtons[ViewType.Reports]);

        // Section label: ADMIN
        var lblAdmin = new Label
        {
            Text = "ADMINISTRATION",
            Font = AppTheme.SmallBold,
            ForeColor = AppTheme.SidebarMutedText,
            Size = new Size(206, 32),
            TextAlign = ContentAlignment.BottomLeft,
            Padding = new Padding(8, 0, 0, 4)
        };
        pnlNav.Controls.Add(lblAdmin);

        _navButtons[ViewType.MenuManagement] = CreateNavButton(ViewType.MenuManagement, "⚙  Manage Menu");
        pnlNav.Controls.Add(_navButtons[ViewType.MenuManagement]);

        // Bottom Exit Button
        var btnExit = new Button
        {
            Text = "↪  Exit",
            Font = AppTheme.NavItemFont,
            ForeColor = AppTheme.SidebarMutedText,
            BackColor = Color.Transparent,
            FlatStyle = FlatStyle.Flat,
            Size = new Size(206, 42),
            Dock = DockStyle.Bottom,
            TextAlign = ContentAlignment.MiddleLeft,
            Padding = new Padding(12, 0, 0, 0),
            Cursor = Cursors.Hand
        };
        btnExit.FlatAppearance.BorderSize = 0;
        btnExit.FlatAppearance.MouseOverBackColor = AppTheme.SidebarHover;
        btnExit.Click += (s, e) =>
        {
            if (MessageBox.Show("Are you sure you want to exit ዉለታ Restaurant RMS?", "Exit Application",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        };

        // Docking order: pnlBrand (Topmost), lblWorkspace (Top), btnExit (Bottom), pnlNav (Fill)
        sidebar.Controls.Add(pnlNav);
        sidebar.Controls.Add(btnExit);
        sidebar.Controls.Add(lblWorkspace);
        sidebar.Controls.Add(pnlBrand);

        return sidebar;
    }

    private Button CreateNavButton(ViewType viewType, string text)
    {
        var btn = new Button
        {
            Text = text,
            Font = AppTheme.NavItemFont,
            ForeColor = AppTheme.SidebarText,
            BackColor = Color.Transparent,
            FlatStyle = FlatStyle.Flat,
            Size = new Size(206, 42),
            Margin = new Padding(0, 2, 0, 2),
            TextAlign = ContentAlignment.MiddleLeft,
            Padding = new Padding(12, 0, 0, 0),
            Cursor = Cursors.Hand
        };
        btn.FlatAppearance.BorderSize = 0;
        btn.FlatAppearance.MouseOverBackColor = AppTheme.SidebarHover;

        btn.Click += (s, e) => NavigateTo(viewType);
        return btn;
    }

    private Panel CreateHeader()
    {
        var header = new Panel
        {
            Dock = DockStyle.Top,
            Height = 60,
            BackColor = AppTheme.HeaderBackground,
            Padding = new Padding(28, 0, 28, 0)
        };
        header.Paint += (s, e) =>
        {
            using var pen = new Pen(AppTheme.CardBorder);
            e.Graphics.DrawLine(pen, 0, header.Height - 1, header.Width, header.Height - 1);
        };

        var lblSysTitle = new Label
        {
            Text = "Restaurant Order Management System",
            Font = AppTheme.BodyBold,
            ForeColor = AppTheme.TextPrimary,
            AutoSize = true,
            Location = new Point(28, 20)
        };

        // User profile badge on the right
        var pnlProfile = new Panel
        {
            Size = new Size(160, 44),
            Dock = DockStyle.Right,
            BackColor = Color.Transparent
        };

        var lblUserName = new Label
        {
            Text = "Waiter: Abebe",
            Font = AppTheme.SmallBold,
            ForeColor = AppTheme.TextPrimary,
            AutoSize = true,
            Location = new Point(48, 8)
        };

        var lblUserRole = new Label
        {
            Text = "Staff account",
            Font = AppTheme.SmallRegular,
            ForeColor = AppTheme.TextSecondary,
            AutoSize = true,
            Location = new Point(48, 24)
        };

        var pnlAvatar = new Panel
        {
            Size = new Size(34, 34),
            Location = new Point(6, 6),
            BackColor = Color.FromArgb(243, 232, 234)
        };
        pnlAvatar.Paint += (s, e) =>
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using var brush = new SolidBrush(AppTheme.PrimaryButton);
            using var font = new Font("Segoe UI", 11f, FontStyle.Bold);
            using var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            e.Graphics.DrawString("A", font, brush, new Rectangle(0, 0, pnlAvatar.Width, pnlAvatar.Height), sf);
        };

        pnlProfile.Controls.Add(pnlAvatar);
        pnlProfile.Controls.Add(lblUserName);
        pnlProfile.Controls.Add(lblUserRole);

        header.Controls.Add(lblSysTitle);
        header.Controls.Add(pnlProfile);

        return header;
    }

    private Panel CreateStatusBar(out Label leftStatus, out Label rightStatus)
    {
        var statusBar = new Panel
        {
            Dock = DockStyle.Bottom,
            Height = 28,
            BackColor = AppTheme.StatusStripBackground,
            Padding = new Padding(16, 0, 16, 0)
        };
        statusBar.Paint += (s, e) =>
        {
            using var pen = new Pen(AppTheme.CardBorder);
            e.Graphics.DrawLine(pen, 0, 0, statusBar.Width, 0);
        };

        leftStatus = new Label
        {
            Text = "● Ready",
            Font = AppTheme.SmallRegular,
            ForeColor = AppTheme.TextSecondary,
            AutoSize = true,
            Dock = DockStyle.Left,
            TextAlign = ContentAlignment.MiddleLeft
        };

        rightStatus = new Label
        {
            Text = "ዉለታ Restaurant · RMS",
            Font = AppTheme.SmallRegular,
            ForeColor = AppTheme.TextMuted,
            AutoSize = true,
            Dock = DockStyle.Right,
            TextAlign = ContentAlignment.MiddleRight
        };

        statusBar.Controls.Add(leftStatus);
        statusBar.Controls.Add(rightStatus);

        return statusBar;
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

        // Update active navigation button visual state
        foreach (var (type, btn) in _navButtons)
        {
            if (type == targetView)
            {
                btn.BackColor = AppTheme.SidebarActive;
                btn.ForeColor = Color.White;
                btn.Font = AppTheme.NavItemActiveFont;
            }
            else
            {
                btn.BackColor = Color.Transparent;
                btn.ForeColor = AppTheme.SidebarText;
                btn.Font = AppTheme.NavItemFont;
            }
        }

        // Swap View in Content Host
        _pnlContentHost.SuspendLayout();
        _pnlContentHost.Controls.Clear();
        nextView.Dock = DockStyle.Fill;
        _pnlContentHost.Controls.Add(nextView);
        _pnlContentHost.ResumeLayout();

        // Notify view of navigation lifecycle
        nextView.OnNavigatedTo(context);

        // Update window title & status
        Text = $"RMS — {targetView}";
        SetStatus($"Ready • Viewing {targetView}");
    }

    public void SetStatus(string message)
    {
        if (_lblStatusLeft != null)
        {
            _lblStatusLeft.Text = $"● {message}";
        }
    }
}
