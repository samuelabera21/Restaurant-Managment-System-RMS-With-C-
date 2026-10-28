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
        this.pnlSidebar = new System.Windows.Forms.Panel();
        this.pnlBrand = new System.Windows.Forms.Panel();
        this.lblBrandBadge = new System.Windows.Forms.Label();
        this.lblBrandTitle = new System.Windows.Forms.Label();
        this.lblWorkspace = new System.Windows.Forms.Label();
        this.btnNavDashboard = new System.Windows.Forms.Button();
        this.btnNavMenu = new System.Windows.Forms.Button();
        this.btnNavNewOrder = new System.Windows.Forms.Button();
        this.btnNavOrders = new System.Windows.Forms.Button();
        this.btnNavReports = new System.Windows.Forms.Button();
        this.lblAdmin = new System.Windows.Forms.Label();
        this.btnNavManageMenu = new System.Windows.Forms.Button();
        this.btnExit = new System.Windows.Forms.Button();
        this.pnlHeader = new System.Windows.Forms.Panel();
        this.lblHeaderTitle = new System.Windows.Forms.Label();
        this.lblUserInfo = new System.Windows.Forms.Label();
        this.statusStrip = new System.Windows.Forms.StatusStrip();
        this.lblStatusLeft = new System.Windows.Forms.ToolStripStatusLabel();
        this.lblStatusRight = new System.Windows.Forms.ToolStripStatusLabel();
        this.pnlContentHost = new System.Windows.Forms.Panel();
        this.pnlSidebar.SuspendLayout();
        this.pnlBrand.SuspendLayout();
        this.pnlHeader.SuspendLayout();
        this.statusStrip.SuspendLayout();
        this.SuspendLayout();
        // 
        // pnlSidebar
        // 
        this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
        this.pnlSidebar.Controls.Add(this.btnExit);
        this.pnlSidebar.Controls.Add(this.btnNavManageMenu);
        this.pnlSidebar.Controls.Add(this.lblAdmin);
        this.pnlSidebar.Controls.Add(this.btnNavReports);
        this.pnlSidebar.Controls.Add(this.btnNavOrders);
        this.pnlSidebar.Controls.Add(this.btnNavNewOrder);
        this.pnlSidebar.Controls.Add(this.btnNavMenu);
        this.pnlSidebar.Controls.Add(this.btnNavDashboard);
        this.pnlSidebar.Controls.Add(this.lblWorkspace);
        this.pnlSidebar.Controls.Add(this.pnlBrand);
        this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
        this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
        this.pnlSidebar.Name = "pnlSidebar";
        this.pnlSidebar.Padding = new System.Windows.Forms.Padding(12, 14, 12, 14);
        this.pnlSidebar.Size = new System.Drawing.Size(220, 759);
        this.pnlSidebar.TabIndex = 0;
        // 
        // pnlBrand
        // 
        this.pnlBrand.BackColor = System.Drawing.Color.Transparent;
        this.pnlBrand.Controls.Add(this.lblBrandBadge);
        this.pnlBrand.Controls.Add(this.lblBrandTitle);
        this.pnlBrand.Dock = System.Windows.Forms.DockStyle.Top;
        this.pnlBrand.Location = new System.Drawing.Point(12, 14);
        this.pnlBrand.Name = "pnlBrand";
        this.pnlBrand.Size = new System.Drawing.Size(196, 68);
        this.pnlBrand.TabIndex = 0;
        // 
        // lblBrandBadge
        // 
        this.lblBrandBadge.BackColor = System.Drawing.Color.FromArgb(30, 58, 95);
        this.lblBrandBadge.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        this.lblBrandBadge.ForeColor = System.Drawing.Color.FromArgb(96, 165, 250);
        this.lblBrandBadge.Location = new System.Drawing.Point(4, 4);
        this.lblBrandBadge.Name = "lblBrandBadge";
        this.lblBrandBadge.Size = new System.Drawing.Size(46, 22);
        this.lblBrandBadge.TabIndex = 0;
        this.lblBrandBadge.Text = "RMS";
        this.lblBrandBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblBrandTitle
        // 
        this.lblBrandTitle.AutoSize = true;
        this.lblBrandTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        this.lblBrandTitle.ForeColor = System.Drawing.Color.White;
        this.lblBrandTitle.Location = new System.Drawing.Point(4, 32);
        this.lblBrandTitle.Name = "lblBrandTitle";
        this.lblBrandTitle.Size = new System.Drawing.Size(139, 28);
        this.lblBrandTitle.TabIndex = 1;
        this.lblBrandTitle.Text = "ዉለታ Restaurant";
        // 
        // lblWorkspace
        // 
        this.lblWorkspace.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblWorkspace.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
        this.lblWorkspace.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
        this.lblWorkspace.Location = new System.Drawing.Point(12, 82);
        this.lblWorkspace.Name = "lblWorkspace";
        this.lblWorkspace.Padding = new System.Windows.Forms.Padding(6, 12, 0, 4);
        this.lblWorkspace.Size = new System.Drawing.Size(196, 34);
        this.lblWorkspace.TabIndex = 1;
        this.lblWorkspace.Text = "WORKSPACE";
        // 
        // btnNavDashboard
        // 
        this.btnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnNavDashboard.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnNavDashboard.FlatAppearance.BorderSize = 0;
        this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.btnNavDashboard.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252);
        this.btnNavDashboard.Location = new System.Drawing.Point(12, 116);
        this.btnNavDashboard.Name = "btnNavDashboard";
        this.btnNavDashboard.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
        this.btnNavDashboard.Size = new System.Drawing.Size(196, 40);
        this.btnNavDashboard.TabIndex = 2;
        this.btnNavDashboard.Text = "⊞  Dashboard";
        this.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnNavDashboard.UseVisualStyleBackColor = true;
        this.btnNavDashboard.Click += new System.EventHandler(this.btnNavDashboard_Click);
        // 
        // btnNavMenu
        // 
        this.btnNavMenu.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnNavMenu.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnNavMenu.FlatAppearance.BorderSize = 0;
        this.btnNavMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnNavMenu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.btnNavMenu.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252);
        this.btnNavMenu.Location = new System.Drawing.Point(12, 156);
        this.btnNavMenu.Name = "btnNavMenu";
        this.btnNavMenu.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
        this.btnNavMenu.Size = new System.Drawing.Size(196, 40);
        this.btnNavMenu.TabIndex = 3;
        this.btnNavMenu.Text = "📖  Menu";
        this.btnNavMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnNavMenu.UseVisualStyleBackColor = true;
        this.btnNavMenu.Click += new System.EventHandler(this.btnNavMenu_Click);
        // 
        // btnNavNewOrder
        // 
        this.btnNavNewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnNavNewOrder.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnNavNewOrder.FlatAppearance.BorderSize = 0;
        this.btnNavNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnNavNewOrder.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.btnNavNewOrder.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252);
        this.btnNavNewOrder.Location = new System.Drawing.Point(12, 196);
        this.btnNavNewOrder.Name = "btnNavNewOrder";
        this.btnNavNewOrder.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
        this.btnNavNewOrder.Size = new System.Drawing.Size(196, 40);
        this.btnNavNewOrder.TabIndex = 4;
        this.btnNavNewOrder.Text = "⊕  New Order";
        this.btnNavNewOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnNavNewOrder.UseVisualStyleBackColor = true;
        this.btnNavNewOrder.Click += new System.EventHandler(this.btnNavNewOrder_Click);
        // 
        // btnNavOrders
        // 
        this.btnNavOrders.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnNavOrders.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnNavOrders.FlatAppearance.BorderSize = 0;
        this.btnNavOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnNavOrders.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.btnNavOrders.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252);
        this.btnNavOrders.Location = new System.Drawing.Point(12, 236);
        this.btnNavOrders.Name = "btnNavOrders";
        this.btnNavOrders.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
        this.btnNavOrders.Size = new System.Drawing.Size(196, 40);
        this.btnNavOrders.TabIndex = 5;
        this.btnNavOrders.Text = "📋  Orders";
        this.btnNavOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnNavOrders.UseVisualStyleBackColor = true;
        this.btnNavOrders.Click += new System.EventHandler(this.btnNavOrders_Click);
        // 
        // btnNavReports
        // 
        this.btnNavReports.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnNavReports.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnNavReports.FlatAppearance.BorderSize = 0;
        this.btnNavReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnNavReports.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.btnNavReports.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252);
        this.btnNavReports.Location = new System.Drawing.Point(12, 276);
        this.btnNavReports.Name = "btnNavReports";
        this.btnNavReports.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
        this.btnNavReports.Size = new System.Drawing.Size(196, 40);
        this.btnNavReports.TabIndex = 6;
        this.btnNavReports.Text = "📊  Reports";
        this.btnNavReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnNavReports.UseVisualStyleBackColor = true;
        this.btnNavReports.Click += new System.EventHandler(this.btnNavReports_Click);
        // 
        // lblAdmin
        // 
        this.lblAdmin.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblAdmin.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
        this.lblAdmin.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
        this.lblAdmin.Location = new System.Drawing.Point(12, 316);
        this.lblAdmin.Name = "lblAdmin";
        this.lblAdmin.Padding = new System.Windows.Forms.Padding(6, 14, 0, 4);
        this.lblAdmin.Size = new System.Drawing.Size(196, 36);
        this.lblAdmin.TabIndex = 7;
        this.lblAdmin.Text = "ADMINISTRATION";
        // 
        // btnNavManageMenu
        // 
        this.btnNavManageMenu.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnNavManageMenu.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnNavManageMenu.FlatAppearance.BorderSize = 0;
        this.btnNavManageMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnNavManageMenu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.btnNavManageMenu.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252);
        this.btnNavManageMenu.Location = new System.Drawing.Point(12, 352);
        this.btnNavManageMenu.Name = "btnNavManageMenu";
        this.btnNavManageMenu.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
        this.btnNavManageMenu.Size = new System.Drawing.Size(196, 40);
        this.btnNavManageMenu.TabIndex = 8;
        this.btnNavManageMenu.Text = "⚙  Manage Menu";
        this.btnNavManageMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnNavManageMenu.UseVisualStyleBackColor = true;
        this.btnNavManageMenu.Click += new System.EventHandler(this.btnNavManageMenu_Click);
        // 
        // btnExit
        // 
        this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.btnExit.FlatAppearance.BorderSize = 0;
        this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.btnExit.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
        this.btnExit.Location = new System.Drawing.Point(12, 705);
        this.btnExit.Name = "btnExit";
        this.btnExit.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
        this.btnExit.Size = new System.Drawing.Size(196, 40);
        this.btnExit.TabIndex = 9;
        this.btnExit.Text = "↪  Exit";
        this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnExit.UseVisualStyleBackColor = true;
        this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
        // 
        // pnlHeader
        // 
        this.pnlHeader.BackColor = System.Drawing.Color.White;
        this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlHeader.Controls.Add(this.lblUserInfo);
        this.pnlHeader.Controls.Add(this.lblHeaderTitle);
        this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        this.pnlHeader.Location = new System.Drawing.Point(220, 0);
        this.pnlHeader.Name = "pnlHeader";
        this.pnlHeader.Size = new System.Drawing.Size(1044, 56);
        this.pnlHeader.TabIndex = 1;
        // 
        // lblHeaderTitle
        // 
        this.lblHeaderTitle.AutoSize = true;
        this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.lblHeaderTitle.Location = new System.Drawing.Point(20, 15);
        this.lblHeaderTitle.Name = "lblHeaderTitle";
        this.lblHeaderTitle.Size = new System.Drawing.Size(355, 25);
        this.lblHeaderTitle.TabIndex = 0;
        this.lblHeaderTitle.Text = "Restaurant Order Management System";
        // 
        // lblUserInfo
        // 
        this.lblUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.lblUserInfo.AutoSize = true;
        this.lblUserInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblUserInfo.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblUserInfo.Location = new System.Drawing.Point(850, 17);
        this.lblUserInfo.Name = "lblUserInfo";
        this.lblUserInfo.Size = new System.Drawing.Size(176, 21);
        this.lblUserInfo.TabIndex = 1;
        this.lblUserInfo.Text = "👤 Waiter: Abebe (Staff)";
        // 
        // statusStrip
        // 
        this.statusStrip.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
        this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
        this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusLeft,
            this.lblStatusRight});
        this.statusStrip.Location = new System.Drawing.Point(220, 755);
        this.statusStrip.Name = "statusStrip";
        this.statusStrip.Size = new System.Drawing.Size(1044, 26);
        this.statusStrip.TabIndex = 2;
        this.statusStrip.Text = "statusStrip1";
        // 
        // lblStatusLeft
        // 
        this.lblStatusLeft.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblStatusLeft.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblStatusLeft.Name = "lblStatusLeft";
        this.lblStatusLeft.Size = new System.Drawing.Size(514, 20);
        this.lblStatusLeft.Spring = true;
        this.lblStatusLeft.Text = "● Ready • Viewing Dashboard";
        this.lblStatusLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblStatusRight
        // 
        this.lblStatusRight.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblStatusRight.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
        this.lblStatusRight.Name = "lblStatusRight";
        this.lblStatusRight.Size = new System.Drawing.Size(514, 20);
        this.lblStatusRight.Spring = true;
        this.lblStatusRight.Text = "ዉለታ Restaurant · RMS";
        this.lblStatusRight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // pnlContentHost
        // 
        this.pnlContentHost.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
        this.pnlContentHost.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlContentHost.Location = new System.Drawing.Point(220, 56);
        this.pnlContentHost.Name = "pnlContentHost";
        this.pnlContentHost.Size = new System.Drawing.Size(1044, 699);
        this.pnlContentHost.TabIndex = 3;
        // 
        // MainForm
        // 
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
        this.ClientSize = new System.Drawing.Size(1264, 781);
        this.Controls.Add(this.pnlContentHost);
        this.Controls.Add(this.statusStrip);
        this.Controls.Add(this.pnlHeader);
        this.Controls.Add(this.pnlSidebar);
        this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.MinimumSize = new System.Drawing.Size(1080, 700);
        this.Name = "MainForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "RMS — Restaurant Order Management System";
        this.pnlSidebar.ResumeLayout(false);
        this.pnlSidebar.PerformLayout();
        this.pnlBrand.ResumeLayout(false);
        this.pnlBrand.PerformLayout();
        this.pnlHeader.ResumeLayout(false);
        this.pnlHeader.PerformLayout();
        this.statusStrip.ResumeLayout(false);
        this.statusStrip.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
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
