namespace RMS.UI.Views;

partial class MenuManagementView
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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        this.pnlHeader = new System.Windows.Forms.Panel();
        this.lblAdminBadge = new System.Windows.Forms.Label();
        this.lblSubtitle = new System.Windows.Forms.Label();
        this.lblTitle = new System.Windows.Forms.Label();
        this.grpFilter = new System.Windows.Forms.GroupBox();
        this.btnClearSearch = new System.Windows.Forms.Button();
        this.cboAvailabilityFilter = new System.Windows.Forms.ComboBox();
        this.lblAvailability = new System.Windows.Forms.Label();
        this.cboCategoryFilter = new System.Windows.Forms.ComboBox();
        this.lblCategory = new System.Windows.Forms.Label();
        this.txtSearch = new System.Windows.Forms.TextBox();
        this.lblSearch = new System.Windows.Forms.Label();
        this.grpMenuItems = new System.Windows.Forms.GroupBox();
        this.dgvMenuItems = new System.Windows.Forms.DataGridView();
        this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.pnlActions = new System.Windows.Forms.Panel();
        this.lblHint = new System.Windows.Forms.Label();
        this.btnToggleStatus = new System.Windows.Forms.Button();
        this.btnEditItem = new System.Windows.Forms.Button();
        this.btnAddItem = new System.Windows.Forms.Button();
        this.pnlGridHeader = new System.Windows.Forms.Panel();
        this.lblSummary = new System.Windows.Forms.Label();
        this.pnlHeader.SuspendLayout();
        this.grpFilter.SuspendLayout();
        this.grpMenuItems.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).BeginInit();
        this.pnlActions.SuspendLayout();
        this.pnlGridHeader.SuspendLayout();
        this.SuspendLayout();
        // 
        // pnlHeader
        // 
        this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
        this.pnlHeader.Controls.Add(this.lblAdminBadge);
        this.pnlHeader.Controls.Add(this.lblSubtitle);
        this.pnlHeader.Controls.Add(this.lblTitle);
        this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        this.pnlHeader.Location = new System.Drawing.Point(24, 16);
        this.pnlHeader.Name = "pnlHeader";
        this.pnlHeader.Size = new System.Drawing.Size(996, 56);
        this.pnlHeader.TabIndex = 0;
        // 
        // lblAdminBadge
        // 
        this.lblAdminBadge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.lblAdminBadge.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.lblAdminBadge.ForeColor = System.Drawing.Color.FromArgb(67, 56, 202);
        this.lblAdminBadge.Location = new System.Drawing.Point(746, 16);
        this.lblAdminBadge.Name = "lblAdminBadge";
        this.lblAdminBadge.Size = new System.Drawing.Size(250, 24);
        this.lblAdminBadge.TabIndex = 2;
        this.lblAdminBadge.Text = "🔒 Admin Mode Active";
        this.lblAdminBadge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblSubtitle
        // 
        this.lblSubtitle.AutoSize = true;
        this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblSubtitle.Location = new System.Drawing.Point(0, 32);
        this.lblSubtitle.Name = "lblSubtitle";
        this.lblSubtitle.Size = new System.Drawing.Size(306, 20);
        this.lblSubtitle.TabIndex = 1;
        this.lblSubtitle.Text = "Administer menu items, prices, and availability";
        // 
        // lblTitle
        // 
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.lblTitle.Location = new System.Drawing.Point(-2, 0);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(262, 37);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Menu Management";
        // 
        // grpFilter
        // 
        this.grpFilter.BackColor = System.Drawing.Color.Transparent;
        this.grpFilter.Controls.Add(this.btnClearSearch);
        this.grpFilter.Controls.Add(this.cboAvailabilityFilter);
        this.grpFilter.Controls.Add(this.lblAvailability);
        this.grpFilter.Controls.Add(this.cboCategoryFilter);
        this.grpFilter.Controls.Add(this.lblCategory);
        this.grpFilter.Controls.Add(this.txtSearch);
        this.grpFilter.Controls.Add(this.lblSearch);
        this.grpFilter.Dock = System.Windows.Forms.DockStyle.Top;
        this.grpFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.grpFilter.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.grpFilter.Location = new System.Drawing.Point(24, 72);
        this.grpFilter.Name = "grpFilter";
        this.grpFilter.Size = new System.Drawing.Size(996, 75);
        this.grpFilter.TabIndex = 1;
        this.grpFilter.TabStop = false;
        this.grpFilter.Text = "Search & Filter Items";
        // 
        // btnClearSearch
        // 
        this.btnClearSearch.BackColor = System.Drawing.Color.White;
        this.btnClearSearch.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.btnClearSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.btnClearSearch.Location = new System.Drawing.Point(780, 27);
        this.btnClearSearch.Name = "btnClearSearch";
        this.btnClearSearch.Size = new System.Drawing.Size(80, 31);
        this.btnClearSearch.TabIndex = 6;
        this.btnClearSearch.Text = "Reset";
        this.btnClearSearch.UseVisualStyleBackColor = false;
        this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
        // 
        // cboAvailabilityFilter
        // 
        this.cboAvailabilityFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboAvailabilityFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.cboAvailabilityFilter.FormattingEnabled = true;
        this.cboAvailabilityFilter.Items.AddRange(new object[] {
            "All Items",
            "Available Only",
            "Unavailable Only"});
        this.cboAvailabilityFilter.Location = new System.Drawing.Point(620, 28);
        this.cboAvailabilityFilter.Name = "cboAvailabilityFilter";
        this.cboAvailabilityFilter.Size = new System.Drawing.Size(145, 29);
        this.cboAvailabilityFilter.TabIndex = 5;
        this.cboAvailabilityFilter.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
        // 
        // lblAvailability
        // 
        this.lblAvailability.AutoSize = true;
        this.lblAvailability.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblAvailability.Location = new System.Drawing.Point(535, 31);
        this.lblAvailability.Name = "lblAvailability";
        this.lblAvailability.Size = new System.Drawing.Size(78, 21);
        this.lblAvailability.TabIndex = 4;
        this.lblAvailability.Text = "Availability:";
        // 
        // cboCategoryFilter
        // 
        this.cboCategoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboCategoryFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.cboCategoryFilter.FormattingEnabled = true;
        this.cboCategoryFilter.Location = new System.Drawing.Point(365, 28);
        this.cboCategoryFilter.Name = "cboCategoryFilter";
        this.cboCategoryFilter.Size = new System.Drawing.Size(150, 29);
        this.cboCategoryFilter.TabIndex = 3;
        this.cboCategoryFilter.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
        // 
        // lblCategory
        // 
        this.lblCategory.AutoSize = true;
        this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblCategory.Location = new System.Drawing.Point(290, 31);
        this.lblCategory.Name = "lblCategory";
        this.lblCategory.Size = new System.Drawing.Size(71, 21);
        this.lblCategory.TabIndex = 2;
        this.lblCategory.Text = "Category:";
        // 
        // txtSearch
        // 
        this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.txtSearch.Location = new System.Drawing.Point(65, 28);
        this.txtSearch.Name = "txtSearch";
        this.txtSearch.PlaceholderText = "Search item name...";
        this.txtSearch.Size = new System.Drawing.Size(205, 29);
        this.txtSearch.TabIndex = 1;
        this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
        // 
        // lblSearch
        // 
        this.lblSearch.AutoSize = true;
        this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblSearch.Location = new System.Drawing.Point(10, 31);
        this.lblSearch.Name = "lblSearch";
        this.lblSearch.Size = new System.Drawing.Size(51, 21);
        this.lblSearch.TabIndex = 0;
        this.lblSearch.Text = "Search:";
        // 
        // grpMenuItems
        // 
        this.grpMenuItems.BackColor = System.Drawing.Color.Transparent;
        this.grpMenuItems.Controls.Add(this.dgvMenuItems);
        this.grpMenuItems.Controls.Add(this.pnlActions);
        this.grpMenuItems.Controls.Add(this.pnlGridHeader);
        this.grpMenuItems.Dock = System.Windows.Forms.DockStyle.Fill;
        this.grpMenuItems.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.grpMenuItems.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.grpMenuItems.Location = new System.Drawing.Point(24, 147);
        this.grpMenuItems.Name = "grpMenuItems";
        this.grpMenuItems.Padding = new System.Windows.Forms.Padding(12, 8, 12, 10);
        this.grpMenuItems.Size = new System.Drawing.Size(996, 513);
        this.grpMenuItems.TabIndex = 2;
        this.grpMenuItems.TabStop = false;
        this.grpMenuItems.Text = "Menu Items List";
        // 
        // dgvMenuItems
        // 
        this.dgvMenuItems.AllowUserToAddRows = false;
        this.dgvMenuItems.AllowUserToDeleteRows = false;
        this.dgvMenuItems.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        this.dgvMenuItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        this.dgvMenuItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvMenuItems.BackgroundColor = System.Drawing.Color.White;
        this.dgvMenuItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.dgvMenuItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        this.dgvMenuItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        this.dgvMenuItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvMenuItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colCategory,
            this.colPrice,
            this.colStatus});
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        this.dgvMenuItems.DefaultCellStyle = dataGridViewCellStyle3;
        this.dgvMenuItems.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvMenuItems.EnableHeadersVisualStyles = false;
        this.dgvMenuItems.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
        this.dgvMenuItems.Location = new System.Drawing.Point(12, 57);
        this.dgvMenuItems.MultiSelect = false;
        this.dgvMenuItems.Name = "dgvMenuItems";
        this.dgvMenuItems.ReadOnly = true;
        this.dgvMenuItems.RowHeadersVisible = false;
        this.dgvMenuItems.RowHeadersWidth = 51;
        this.dgvMenuItems.RowTemplate.Height = 36;
        this.dgvMenuItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvMenuItems.Size = new System.Drawing.Size(972, 396);
        this.dgvMenuItems.TabIndex = 1;
        this.dgvMenuItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenuItems_CellDoubleClick);
        this.dgvMenuItems.SelectionChanged += new System.EventHandler(this.dgvMenuItems_SelectionChanged);
        // 
        // colId
        // 
        this.colId.FillWeight = 10F;
        this.colId.HeaderText = "ID";
        this.colId.MinimumWidth = 6;
        this.colId.Name = "colId";
        this.colId.ReadOnly = true;
        // 
        // colName
        // 
        this.colName.FillWeight = 38F;
        this.colName.HeaderText = "Item Name";
        this.colName.MinimumWidth = 6;
        this.colName.Name = "colName";
        this.colName.ReadOnly = true;
        // 
        // colCategory
        // 
        this.colCategory.FillWeight = 22F;
        this.colCategory.HeaderText = "Category";
        this.colCategory.MinimumWidth = 6;
        this.colCategory.Name = "colCategory";
        this.colCategory.ReadOnly = true;
        // 
        // colPrice
        // 
        this.colPrice.FillWeight = 16F;
        this.colPrice.HeaderText = "Price (ETB)";
        this.colPrice.MinimumWidth = 6;
        this.colPrice.Name = "colPrice";
        this.colPrice.ReadOnly = true;
        // 
        // colStatus
        // 
        this.colStatus.FillWeight = 14F;
        this.colStatus.HeaderText = "Status";
        this.colStatus.MinimumWidth = 6;
        this.colStatus.Name = "colStatus";
        this.colStatus.ReadOnly = true;
        // 
        // pnlActions
        // 
        this.pnlActions.Controls.Add(this.lblHint);
        this.pnlActions.Controls.Add(this.btnToggleStatus);
        this.pnlActions.Controls.Add(this.btnEditItem);
        this.pnlActions.Controls.Add(this.btnAddItem);
        this.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.pnlActions.Location = new System.Drawing.Point(12, 453);
        this.pnlActions.Name = "pnlActions";
        this.pnlActions.Size = new System.Drawing.Size(972, 50);
        this.pnlActions.TabIndex = 2;
        // 
        // lblHint
        // 
        this.lblHint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.lblHint.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        this.lblHint.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
        this.lblHint.Location = new System.Drawing.Point(620, 15);
        this.lblHint.Name = "lblHint";
        this.lblHint.Size = new System.Drawing.Size(350, 24);
        this.lblHint.TabIndex = 3;
        this.lblHint.Text = "💡 Double-click any row to edit item details";
        this.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // btnToggleStatus
        // 
        this.btnToggleStatus.BackColor = System.Drawing.Color.White;
        this.btnToggleStatus.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnToggleStatus.Enabled = false;
        this.btnToggleStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.btnToggleStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.btnToggleStatus.Location = new System.Drawing.Point(300, 10);
        this.btnToggleStatus.Name = "btnToggleStatus";
        this.btnToggleStatus.Size = new System.Drawing.Size(165, 34);
        this.btnToggleStatus.TabIndex = 2;
        this.btnToggleStatus.Text = "🔄 Toggle Availability";
        this.btnToggleStatus.UseVisualStyleBackColor = false;
        this.btnToggleStatus.Click += new System.EventHandler(this.btnToggleStatus_Click);
        // 
        // btnEditItem
        // 
        this.btnEditItem.BackColor = System.Drawing.Color.White;
        this.btnEditItem.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnEditItem.Enabled = false;
        this.btnEditItem.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.btnEditItem.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.btnEditItem.Location = new System.Drawing.Point(175, 10);
        this.btnEditItem.Name = "btnEditItem";
        this.btnEditItem.Size = new System.Drawing.Size(115, 34);
        this.btnEditItem.TabIndex = 1;
        this.btnEditItem.Text = "✏ Edit Item";
        this.btnEditItem.UseVisualStyleBackColor = false;
        this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
        // 
        // btnAddItem
        // 
        this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(30, 58, 95);
        this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.btnAddItem.ForeColor = System.Drawing.Color.White;
        this.btnAddItem.Location = new System.Drawing.Point(0, 10);
        this.btnAddItem.Name = "btnAddItem";
        this.btnAddItem.Size = new System.Drawing.Size(165, 34);
        this.btnAddItem.TabIndex = 0;
        this.btnAddItem.Text = "+ Add Menu Item";
        this.btnAddItem.UseVisualStyleBackColor = false;
        this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
        // 
        // pnlGridHeader
        // 
        this.pnlGridHeader.Controls.Add(this.lblSummary);
        this.pnlGridHeader.Dock = System.Windows.Forms.DockStyle.Top;
        this.pnlGridHeader.Location = new System.Drawing.Point(12, 31);
        this.pnlGridHeader.Name = "pnlGridHeader";
        this.pnlGridHeader.Size = new System.Drawing.Size(972, 26);
        this.pnlGridHeader.TabIndex = 0;
        // 
        // lblSummary
        // 
        this.lblSummary.AutoSize = true;
        this.lblSummary.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblSummary.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblSummary.Location = new System.Drawing.Point(0, 3);
        this.lblSummary.Name = "lblSummary";
        this.lblSummary.Size = new System.Drawing.Size(126, 20);
        this.lblSummary.TabIndex = 0;
        this.lblSummary.Text = "Showing all items";
        // 
        // MenuManagementView
        // 
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
        this.Controls.Add(this.grpMenuItems);
        this.Controls.Add(this.grpFilter);
        this.Controls.Add(this.pnlHeader);
        this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.Name = "MenuManagementView";
        this.Padding = new System.Windows.Forms.Padding(24, 16, 24, 20);
        this.Size = new System.Drawing.Size(1044, 680);
        this.pnlHeader.ResumeLayout(false);
        this.pnlHeader.PerformLayout();
        this.grpFilter.ResumeLayout(false);
        this.grpFilter.PerformLayout();
        this.grpMenuItems.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).EndInit();
        this.pnlActions.ResumeLayout(false);
        this.pnlGridHeader.ResumeLayout(false);
        this.pnlGridHeader.PerformLayout();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Label lblAdminBadge;
    private System.Windows.Forms.GroupBox grpFilter;
    private System.Windows.Forms.Label lblSearch;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.Label lblCategory;
    private System.Windows.Forms.ComboBox cboCategoryFilter;
    private System.Windows.Forms.Label lblAvailability;
    private System.Windows.Forms.ComboBox cboAvailabilityFilter;
    private System.Windows.Forms.Button btnClearSearch;
    private System.Windows.Forms.GroupBox grpMenuItems;
    private System.Windows.Forms.Panel pnlGridHeader;
    private System.Windows.Forms.Label lblSummary;
    private System.Windows.Forms.DataGridView dgvMenuItems;
    private System.Windows.Forms.DataGridViewTextBoxColumn colId;
    private System.Windows.Forms.DataGridViewTextBoxColumn colName;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
    private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
    private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    private System.Windows.Forms.Panel pnlActions;
    private System.Windows.Forms.Button btnAddItem;
    private System.Windows.Forms.Button btnEditItem;
    private System.Windows.Forms.Button btnToggleStatus;
    private System.Windows.Forms.Label lblHint;
}
