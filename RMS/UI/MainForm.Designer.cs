namespace RMS.UI;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        pnlSidebar = new Panel();
        btnExit = new Button();
        btnNavManageMenu = new Button();
        lblAdmin = new Label();
        btnNavReports = new Button();
        btnNavOrders = new Button();
        btnNavNewOrder = new Button();
        btnNavMenu = new Button();
        btnNavDashboard = new Button();
        lblWorkspace = new Label();
        pnlBrand = new Panel();
        lblBrandBadge = new Label();
        lblBrandTitle = new Label();
        pnlHeader = new Panel();
        lblUserInfo = new Label();
        lblHeaderTitle = new Label();
        statusStrip = new StatusStrip();
        lblStatusLeft = new ToolStripStatusLabel();
        lblStatusRight = new ToolStripStatusLabel();
        pnlContentHost = new Panel();
        pnlSidebar.SuspendLayout();
        pnlBrand.SuspendLayout();
        pnlHeader.SuspendLayout();
        statusStrip.SuspendLayout();
        SuspendLayout();
        // 
        // pnlSidebar
        // 
        pnlSidebar.BackColor = Color.FromArgb(30, 41, 59);
        pnlSidebar.Controls.Add(btnExit);
        pnlSidebar.Controls.Add(btnNavManageMenu);
        pnlSidebar.Controls.Add(lblAdmin);
        pnlSidebar.Controls.Add(btnNavReports);
        pnlSidebar.Controls.Add(btnNavOrders);
        pnlSidebar.Controls.Add(btnNavNewOrder);
        pnlSidebar.Controls.Add(btnNavMenu);
        pnlSidebar.Controls.Add(btnNavDashboard);
        pnlSidebar.Controls.Add(lblWorkspace);
        pnlSidebar.Controls.Add(pnlBrand);
        pnlSidebar.Dock = DockStyle.Left;
        pnlSidebar.Location = new Point(0, 0);
        pnlSidebar.Name = "pnlSidebar";
        pnlSidebar.Padding = new Padding(12, 14, 12, 14);
        pnlSidebar.Size = new Size(276, 781);
        pnlSidebar.TabIndex = 0;
        // 
        // btnExit
        // 
        btnExit.Cursor = Cursors.Hand;
        btnExit.Dock = DockStyle.Bottom;
        btnExit.FlatAppearance.BorderSize = 0;
        btnExit.FlatStyle = FlatStyle.Flat;
        btnExit.Font = new Font("Segoe UI", 9.5F);
        btnExit.ForeColor = Color.FromArgb(148, 163, 184);
        btnExit.Location = new Point(12, 727);
        btnExit.Name = "btnExit";
        btnExit.Padding = new Padding(8, 0, 0, 0);
        btnExit.Size = new Size(252, 40);
        btnExit.TabIndex = 9;
        btnExit.Text = "↪  Exit";
        btnExit.TextAlign = ContentAlignment.MiddleLeft;
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += btnExit_Click;
        // 
        // btnNavManageMenu
        // 
        btnNavManageMenu.Cursor = Cursors.Hand;
        btnNavManageMenu.Dock = DockStyle.Top;
        btnNavManageMenu.FlatAppearance.BorderSize = 0;
        btnNavManageMenu.FlatStyle = FlatStyle.Flat;
        btnNavManageMenu.Font = new Font("Segoe UI", 9.5F);
        btnNavManageMenu.ForeColor = Color.FromArgb(248, 250, 252);
        btnNavManageMenu.Location = new Point(12, 352);
        btnNavManageMenu.Name = "btnNavManageMenu";
        btnNavManageMenu.Padding = new Padding(8, 0, 0, 0);
        btnNavManageMenu.Size = new Size(252, 40);
        btnNavManageMenu.TabIndex = 8;
        btnNavManageMenu.Text = "⚙  Manage Menu";
        btnNavManageMenu.TextAlign = ContentAlignment.MiddleLeft;
        btnNavManageMenu.UseVisualStyleBackColor = true;
        btnNavManageMenu.Click += btnNavManageMenu_Click;
        // 
        // lblAdmin
        // 
        lblAdmin.Dock = DockStyle.Top;
        lblAdmin.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
        lblAdmin.ForeColor = Color.FromArgb(148, 163, 184);
        lblAdmin.Location = new Point(12, 316);
        lblAdmin.Name = "lblAdmin";
        lblAdmin.Padding = new Padding(6, 14, 0, 4);
        lblAdmin.Size = new Size(252, 36);
        lblAdmin.TabIndex = 7;
        lblAdmin.Text = "ADMINISTRATION";
        // 
        // btnNavReports
        // 
        btnNavReports.Cursor = Cursors.Hand;
        btnNavReports.Dock = DockStyle.Top;
        btnNavReports.FlatAppearance.BorderSize = 0;
        btnNavReports.FlatStyle = FlatStyle.Flat;
        btnNavReports.Font = new Font("Segoe UI", 9.5F);
        btnNavReports.ForeColor = Color.FromArgb(248, 250, 252);
        btnNavReports.Location = new Point(12, 276);
        btnNavReports.Name = "btnNavReports";
        btnNavReports.Padding = new Padding(8, 0, 0, 0);
        btnNavReports.Size = new Size(252, 40);
        btnNavReports.TabIndex = 6;
        btnNavReports.Text = "📊  Reports";
        btnNavReports.TextAlign = ContentAlignment.MiddleLeft;
        btnNavReports.UseVisualStyleBackColor = true;
        btnNavReports.Click += btnNavReports_Click;
        // 
        // btnNavOrders
        // 
        btnNavOrders.Cursor = Cursors.Hand;
        btnNavOrders.Dock = DockStyle.Top;
        btnNavOrders.FlatAppearance.BorderSize = 0;
        btnNavOrders.FlatStyle = FlatStyle.Flat;
        btnNavOrders.Font = new Font("Segoe UI", 9.5F);
        btnNavOrders.ForeColor = Color.FromArgb(248, 250, 252);
        btnNavOrders.Location = new Point(12, 236);
        btnNavOrders.Name = "btnNavOrders";
        btnNavOrders.Padding = new Padding(8, 0, 0, 0);
        btnNavOrders.Size = new Size(252, 40);
        btnNavOrders.TabIndex = 5;
        btnNavOrders.Text = "📋  Orders";
        btnNavOrders.TextAlign = ContentAlignment.MiddleLeft;
        btnNavOrders.UseVisualStyleBackColor = true;
        btnNavOrders.Click += btnNavOrders_Click;
        // 
        // btnNavNewOrder
        // 
        btnNavNewOrder.Cursor = Cursors.Hand;
        btnNavNewOrder.Dock = DockStyle.Top;
        btnNavNewOrder.FlatAppearance.BorderSize = 0;
        btnNavNewOrder.FlatStyle = FlatStyle.Flat;
        btnNavNewOrder.Font = new Font("Segoe UI", 9.5F);
        btnNavNewOrder.ForeColor = Color.FromArgb(248, 250, 252);
        btnNavNewOrder.Location = new Point(12, 196);
        btnNavNewOrder.Name = "btnNavNewOrder";
        btnNavNewOrder.Padding = new Padding(8, 0, 0, 0);
        btnNavNewOrder.Size = new Size(252, 40);
        btnNavNewOrder.TabIndex = 4;
        btnNavNewOrder.Text = "⊕  New Order";
        btnNavNewOrder.TextAlign = ContentAlignment.MiddleLeft;
        btnNavNewOrder.UseVisualStyleBackColor = true;
        btnNavNewOrder.Click += btnNavNewOrder_Click;
        // 
        // btnNavMenu
        // 
        btnNavMenu.Cursor = Cursors.Hand;
        btnNavMenu.Dock = DockStyle.Top;
        btnNavMenu.FlatAppearance.BorderSize = 0;
        btnNavMenu.FlatStyle = FlatStyle.Flat;
        btnNavMenu.Font = new Font("Segoe UI", 9.5F);
        btnNavMenu.ForeColor = Color.FromArgb(248, 250, 252);
        btnNavMenu.Location = new Point(12, 156);
        btnNavMenu.Name = "btnNavMenu";
        btnNavMenu.Padding = new Padding(8, 0, 0, 0);
        btnNavMenu.Size = new Size(252, 40);
        btnNavMenu.TabIndex = 3;
        btnNavMenu.Text = "📖  Menu";
        btnNavMenu.TextAlign = ContentAlignment.MiddleLeft;
        btnNavMenu.UseVisualStyleBackColor = true;
        btnNavMenu.Click += btnNavMenu_Click;
        // 
        // btnNavDashboard
        // 
        btnNavDashboard.Cursor = Cursors.Hand;
        btnNavDashboard.Dock = DockStyle.Top;
        btnNavDashboard.FlatAppearance.BorderSize = 0;
        btnNavDashboard.FlatStyle = FlatStyle.Flat;
        btnNavDashboard.Font = new Font("Segoe UI", 9.5F);
        btnNavDashboard.ForeColor = Color.FromArgb(248, 250, 252);
        btnNavDashboard.Location = new Point(12, 116);
        btnNavDashboard.Name = "btnNavDashboard";
        btnNavDashboard.Padding = new Padding(8, 0, 0, 0);
        btnNavDashboard.Size = new Size(252, 40);
        btnNavDashboard.TabIndex = 2;
        btnNavDashboard.Text = "⊞  Dashboard";
        btnNavDashboard.TextAlign = ContentAlignment.MiddleLeft;
        btnNavDashboard.UseVisualStyleBackColor = true;
        btnNavDashboard.Click += btnNavDashboard_Click;
        // 
        // lblWorkspace
        // 
        lblWorkspace.Dock = DockStyle.Top;
        lblWorkspace.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
        lblWorkspace.ForeColor = Color.FromArgb(148, 163, 184);
        lblWorkspace.Location = new Point(12, 82);
        lblWorkspace.Name = "lblWorkspace";
        lblWorkspace.Padding = new Padding(6, 12, 0, 4);
        lblWorkspace.Size = new Size(252, 34);
        lblWorkspace.TabIndex = 1;
        lblWorkspace.Text = "WORKSPACE";
        // 
        // pnlBrand
        // 
        pnlBrand.BackColor = Color.Transparent;
        pnlBrand.Controls.Add(lblBrandBadge);
        pnlBrand.Controls.Add(lblBrandTitle);
        pnlBrand.Dock = DockStyle.Top;
        pnlBrand.Location = new Point(12, 14);
        pnlBrand.Name = "pnlBrand";
        pnlBrand.Size = new Size(252, 68);
        pnlBrand.TabIndex = 0;
        // 
        // lblBrandBadge
        // 
        lblBrandBadge.BackColor = Color.FromArgb(30, 58, 95);
        lblBrandBadge.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblBrandBadge.ForeColor = Color.FromArgb(96, 165, 250);
        lblBrandBadge.Location = new Point(4, 4);
        lblBrandBadge.Name = "lblBrandBadge";
        lblBrandBadge.Size = new Size(46, 22);
        lblBrandBadge.TabIndex = 0;
        lblBrandBadge.Text = "RMS";
        lblBrandBadge.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblBrandTitle
        // 
        lblBrandTitle.AutoSize = true;
        lblBrandTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblBrandTitle.ForeColor = Color.White;
        lblBrandTitle.Location = new Point(4, 32);
        lblBrandTitle.Name = "lblBrandTitle";
        lblBrandTitle.Size = new Size(206, 32);
        lblBrandTitle.TabIndex = 1;
        lblBrandTitle.Text = "ዉለታ Restaurant";
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = Color.White;
        pnlHeader.BorderStyle = BorderStyle.FixedSingle;
        pnlHeader.Controls.Add(lblUserInfo);
        pnlHeader.Controls.Add(lblHeaderTitle);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Location = new Point(276, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new Size(988, 56);
        pnlHeader.TabIndex = 1;
        // 
        // lblUserInfo
        // 
        lblUserInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblUserInfo.AutoSize = true;
        lblUserInfo.Font = new Font("Segoe UI", 9.5F);
        lblUserInfo.ForeColor = Color.FromArgb(71, 85, 105);
        lblUserInfo.Location = new Point(794, 17);
        lblUserInfo.Name = "lblUserInfo";
        lblUserInfo.Size = new Size(210, 25);
        lblUserInfo.TabIndex = 1;
        lblUserInfo.Text = "👤 Waiter: Abebe (Staff)";
        // 
        // lblHeaderTitle
        // 
        lblHeaderTitle.AutoSize = true;
        lblHeaderTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblHeaderTitle.ForeColor = Color.FromArgb(15, 23, 42);
        lblHeaderTitle.Location = new Point(20, 15);
        lblHeaderTitle.Name = "lblHeaderTitle";
        lblHeaderTitle.Size = new Size(416, 30);
        lblHeaderTitle.TabIndex = 0;
        lblHeaderTitle.Text = "Restaurant Order Management System";
        // 
        // statusStrip
        // 
        statusStrip.BackColor = Color.FromArgb(241, 245, 249);
        statusStrip.ImageScalingSize = new Size(20, 20);
        statusStrip.Items.AddRange(new ToolStripItem[] { lblStatusLeft, lblStatusRight });
        statusStrip.Location = new Point(276, 749);
        statusStrip.Name = "statusStrip";
        statusStrip.Size = new Size(988, 32);
        statusStrip.TabIndex = 2;
        statusStrip.Text = "statusStrip1";
        // 
        // lblStatusLeft
        // 
        lblStatusLeft.Font = new Font("Segoe UI", 9F);
        lblStatusLeft.ForeColor = Color.FromArgb(71, 85, 105);
        lblStatusLeft.Name = "lblStatusLeft";
        lblStatusLeft.Size = new Size(780, 25);
        lblStatusLeft.Spring = true;
        lblStatusLeft.Text = "● Ready • Viewing Dashboard";
        lblStatusLeft.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblStatusRight
        // 
        lblStatusRight.Font = new Font("Segoe UI", 9F);
        lblStatusRight.ForeColor = Color.FromArgb(148, 163, 184);
        lblStatusRight.Name = "lblStatusRight";
        lblStatusRight.Size = new Size(193, 25);
        lblStatusRight.Spring = true;
        lblStatusRight.Text = "ዉለታ Restaurant · RMS";
        lblStatusRight.TextAlign = ContentAlignment.MiddleRight;
        // 
        // pnlContentHost
        // 
        pnlContentHost.BackColor = Color.FromArgb(243, 244, 246);
        pnlContentHost.Dock = DockStyle.Fill;
        pnlContentHost.Location = new Point(276, 56);
        pnlContentHost.Name = "pnlContentHost";
        pnlContentHost.Size = new Size(988, 693);
        pnlContentHost.TabIndex = 3;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(144F, 144F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.FromArgb(243, 244, 246);
        ClientSize = new Size(1264, 781);
        Controls.Add(pnlContentHost);
        Controls.Add(statusStrip);
        Controls.Add(pnlHeader);
        Controls.Add(pnlSidebar);
        Font = new Font("Segoe UI", 9.5F);
        MinimumSize = new Size(1080, 700);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "RMS — Restaurant Order Management System";
        pnlSidebar.ResumeLayout(false);
        pnlBrand.ResumeLayout(false);
        pnlBrand.PerformLayout();
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        statusStrip.ResumeLayout(false);
        statusStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Panel pnlSidebar;
    private System.Windows.Forms.Panel pnlBrand;
    private System.Windows.Forms.Label lblBrandBadge;
    private System.Windows.Forms.Label lblBrandTitle;
    private System.Windows.Forms.Label lblWorkspace;
    private System.Windows.Forms.Button btnNavDashboard;
    private System.Windows.Forms.Button btnNavMenu;
    private System.Windows.Forms.Button btnNavNewOrder;
    private System.Windows.Forms.Button btnNavOrders;
    private System.Windows.Forms.Button btnNavReports;
    private System.Windows.Forms.Label lblAdmin;
    private System.Windows.Forms.Button btnNavManageMenu;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblHeaderTitle;
    private System.Windows.Forms.Label lblUserInfo;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripStatusLabel lblStatusLeft;
    private System.Windows.Forms.ToolStripStatusLabel lblStatusRight;
    private System.Windows.Forms.Panel pnlContentHost;
}
