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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        pnlHeader = new Panel();
        lblAdminBadge = new Label();
        lblTitle = new Label();
        grpFilter = new GroupBox();
        btnClearSearch = new Button();
        cboAvailabilityFilter = new ComboBox();
        lblAvailability = new Label();
        cboCategoryFilter = new ComboBox();
        lblCategory = new Label();
        txtSearch = new TextBox();
        lblSearch = new Label();
        grpMenuItems = new GroupBox();
        dgvMenuItems = new DataGridView();
        colId = new DataGridViewTextBoxColumn();
        colName = new DataGridViewTextBoxColumn();
        colCategory = new DataGridViewTextBoxColumn();
        colPrice = new DataGridViewTextBoxColumn();
        colStatus = new DataGridViewTextBoxColumn();
        pnlActions = new Panel();
        lblHint = new Label();
        btnToggleStatus = new Button();
        btnEditItem = new Button();
        btnAddItem = new Button();
        pnlGridHeader = new Panel();
        lblSummary = new Label();
        pnlHeader.SuspendLayout();
        grpFilter.SuspendLayout();
        grpMenuItems.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvMenuItems).BeginInit();
        pnlActions.SuspendLayout();
        pnlGridHeader.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = Color.Transparent;
        pnlHeader.Controls.Add(lblAdminBadge);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Location = new Point(24, 16);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new Size(1072, 44);
        pnlHeader.TabIndex = 0;
        // 
        // lblAdminBadge
        // 
        lblAdminBadge.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblAdminBadge.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        lblAdminBadge.ForeColor = Color.FromArgb(71, 85, 105);
        lblAdminBadge.Location = new Point(822, 10);
        lblAdminBadge.Name = "lblAdminBadge";
        lblAdminBadge.Size = new Size(250, 24);
        lblAdminBadge.TabIndex = 1;
        lblAdminBadge.Text = "Admin Mode Active";
        lblAdminBadge.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
        lblTitle.Location = new Point(0, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(313, 45);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Menu Management";
        // 
        // grpFilter
        // 
        grpFilter.BackColor = Color.Transparent;
        grpFilter.Controls.Add(btnClearSearch);
        grpFilter.Controls.Add(cboAvailabilityFilter);
        grpFilter.Controls.Add(lblAvailability);
        grpFilter.Controls.Add(cboCategoryFilter);
        grpFilter.Controls.Add(lblCategory);
        grpFilter.Controls.Add(txtSearch);
        grpFilter.Controls.Add(lblSearch);
        grpFilter.Dock = DockStyle.Top;
        grpFilter.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        grpFilter.ForeColor = Color.FromArgb(15, 23, 42);
        grpFilter.Location = new Point(24, 60);
        grpFilter.Name = "grpFilter";
        grpFilter.Size = new Size(1072, 72);
        grpFilter.TabIndex = 1;
        grpFilter.TabStop = false;
        grpFilter.Text = "Search & Filter";
        // 
        // btnClearSearch
        // 
        btnClearSearch.BackColor = Color.White;
        btnClearSearch.Cursor = Cursors.Hand;
        btnClearSearch.FlatStyle = FlatStyle.System;
        btnClearSearch.Font = new Font("Segoe UI", 9F);
        btnClearSearch.Location = new Point(750, 24);
        btnClearSearch.Name = "btnClearSearch";
        btnClearSearch.Size = new Size(75, 31);
        btnClearSearch.TabIndex = 6;
        btnClearSearch.Text = "Clear";
        btnClearSearch.UseVisualStyleBackColor = false;
        btnClearSearch.Click += btnClearSearch_Click;
        // 
        // cboAvailabilityFilter
        // 
        cboAvailabilityFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        cboAvailabilityFilter.Font = new Font("Segoe UI", 9.5F);
        cboAvailabilityFilter.FormattingEnabled = true;
        cboAvailabilityFilter.Items.AddRange(new object[] { "All Items", "Available Only", "Unavailable Only" });
        cboAvailabilityFilter.Location = new Point(595, 25);
        cboAvailabilityFilter.Name = "cboAvailabilityFilter";
        cboAvailabilityFilter.Size = new Size(140, 33);
        cboAvailabilityFilter.TabIndex = 5;
        cboAvailabilityFilter.SelectedIndexChanged += Filter_Changed;
        // 
        // lblAvailability
        // 
        lblAvailability.AutoSize = true;
        lblAvailability.Font = new Font("Segoe UI", 9.5F);
        lblAvailability.Location = new Point(510, 28);
        lblAvailability.Name = "lblAvailability";
        lblAvailability.Size = new Size(108, 25);
        lblAvailability.TabIndex = 4;
        lblAvailability.Text = "Availability:";
        // 
        // cboCategoryFilter
        // 
        cboCategoryFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        cboCategoryFilter.Font = new Font("Segoe UI", 9.5F);
        cboCategoryFilter.FormattingEnabled = true;
        cboCategoryFilter.Location = new Point(355, 25);
        cboCategoryFilter.Name = "cboCategoryFilter";
        cboCategoryFilter.Size = new Size(140, 33);
        cboCategoryFilter.TabIndex = 3;
        cboCategoryFilter.SelectedIndexChanged += Filter_Changed;
        // 
        // lblCategory
        // 
        lblCategory.AutoSize = true;
        lblCategory.Font = new Font("Segoe UI", 9.5F);
        lblCategory.Location = new Point(280, 28);
        lblCategory.Name = "lblCategory";
        lblCategory.Size = new Size(92, 25);
        lblCategory.TabIndex = 2;
        lblCategory.Text = "Category:";
        // 
        // txtSearch
        // 
        txtSearch.Font = new Font("Segoe UI", 9.5F);
        txtSearch.Location = new Point(75, 25);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Search item name...";
        txtSearch.Size = new Size(190, 33);
        txtSearch.TabIndex = 1;
        txtSearch.TextChanged += txtSearch_TextChanged;
        // 
        // lblSearch
        // 
        lblSearch.AutoSize = true;
        lblSearch.Font = new Font("Segoe UI", 9.5F);
        lblSearch.Location = new Point(16, 28);
        lblSearch.Name = "lblSearch";
        lblSearch.Size = new Size(73, 25);
        lblSearch.TabIndex = 0;
        lblSearch.Text = "Search:";
        // 
        // grpMenuItems
        // 
        grpMenuItems.BackColor = Color.Transparent;
        grpMenuItems.Controls.Add(dgvMenuItems);
        grpMenuItems.Controls.Add(pnlActions);
        grpMenuItems.Controls.Add(pnlGridHeader);
        grpMenuItems.Dock = DockStyle.Fill;
        grpMenuItems.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        grpMenuItems.ForeColor = Color.FromArgb(15, 23, 42);
        grpMenuItems.Location = new Point(24, 132);
        grpMenuItems.Name = "grpMenuItems";
        grpMenuItems.Padding = new Padding(12, 8, 12, 10);
        grpMenuItems.Size = new Size(1072, 401);
        grpMenuItems.TabIndex = 2;
        grpMenuItems.TabStop = false;
        grpMenuItems.Text = "Menu Items List";
        // 
        // dgvMenuItems
        // 
        dgvMenuItems.AllowUserToAddRows = false;
        dgvMenuItems.AllowUserToDeleteRows = false;
        dgvMenuItems.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
        dgvMenuItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvMenuItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvMenuItems.BackgroundColor = Color.White;
        dgvMenuItems.BorderStyle = BorderStyle.Fixed3D;
        dgvMenuItems.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle2.Padding = new Padding(4, 6, 4, 6);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        dgvMenuItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvMenuItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvMenuItems.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colCategory, colPrice, colStatus });
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.White;
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle3.Padding = new Padding(4);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(219, 234, 254);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        dgvMenuItems.DefaultCellStyle = dataGridViewCellStyle3;
        dgvMenuItems.Dock = DockStyle.Fill;
        dgvMenuItems.EnableHeadersVisualStyles = false;
        dgvMenuItems.GridColor = Color.FromArgb(226, 232, 240);
        dgvMenuItems.Location = new Point(12, 61);
        dgvMenuItems.MultiSelect = false;
        dgvMenuItems.Name = "dgvMenuItems";
        dgvMenuItems.ReadOnly = true;
        dgvMenuItems.RowHeadersVisible = false;
        dgvMenuItems.RowHeadersWidth = 51;
        dgvMenuItems.RowTemplate.Height = 36;
        dgvMenuItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvMenuItems.Size = new Size(1048, 280);
        dgvMenuItems.TabIndex = 1;
        dgvMenuItems.SelectionChanged += dgvMenuItems_SelectionChanged;
        // 
        // colId
        // 
        colId.FillWeight = 10F;
        colId.HeaderText = "ID";
        colId.MinimumWidth = 6;
        colId.Name = "colId";
        colId.ReadOnly = true;
        // 
        // colName
        // 
        colName.FillWeight = 38F;
        colName.HeaderText = "Item Name";
        colName.MinimumWidth = 6;
        colName.Name = "colName";
        colName.ReadOnly = true;
        // 
        // colCategory
        // 
        colCategory.FillWeight = 22F;
        colCategory.HeaderText = "Category";
        colCategory.MinimumWidth = 6;
        colCategory.Name = "colCategory";
        colCategory.ReadOnly = true;
        // 
        // colPrice
        // 
        colPrice.FillWeight = 16F;
        colPrice.HeaderText = "Price (ETB)";
        colPrice.MinimumWidth = 6;
        colPrice.Name = "colPrice";
        colPrice.ReadOnly = true;
        // 
        // colStatus
        // 
        colStatus.FillWeight = 14F;
        colStatus.HeaderText = "Status";
        colStatus.MinimumWidth = 6;
        colStatus.Name = "colStatus";
        colStatus.ReadOnly = true;
        // 
        // pnlActions
        // 
        pnlActions.Controls.Add(lblHint);
        pnlActions.Controls.Add(btnToggleStatus);
        pnlActions.Controls.Add(btnEditItem);
        pnlActions.Controls.Add(btnAddItem);
        pnlActions.Dock = DockStyle.Bottom;
        pnlActions.Location = new Point(12, 341);
        pnlActions.Name = "pnlActions";
        pnlActions.Size = new Size(1048, 50);
        pnlActions.TabIndex = 2;
        // 
        // lblHint
        // 
        lblHint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblHint.Font = new Font("Segoe UI", 8.5F);
        lblHint.ForeColor = Color.FromArgb(107, 114, 128);
        lblHint.Location = new Point(696, 15);
        lblHint.Name = "lblHint";
        lblHint.Size = new Size(350, 24);
        lblHint.TabIndex = 3;
        lblHint.Text = "Double-click any row to edit item details";
        lblHint.TextAlign = ContentAlignment.MiddleRight;
        // 
        // btnToggleStatus
        // 
        btnToggleStatus.BackColor = Color.White;
        btnToggleStatus.Cursor = Cursors.Hand;
        btnToggleStatus.Enabled = false;
        btnToggleStatus.FlatStyle = FlatStyle.System;
        btnToggleStatus.Font = new Font("Segoe UI", 9F);
        btnToggleStatus.Location = new Point(255, 8);
        btnToggleStatus.Name = "btnToggleStatus";
        btnToggleStatus.Size = new Size(150, 34);
        btnToggleStatus.TabIndex = 2;
        btnToggleStatus.Text = "Toggle Availability";
        btnToggleStatus.UseVisualStyleBackColor = false;
        btnToggleStatus.Click += btnToggleStatus_Click;
        // 
        // btnEditItem
        // 
        btnEditItem.BackColor = Color.White;
        btnEditItem.Cursor = Cursors.Hand;
        btnEditItem.Enabled = false;
        btnEditItem.FlatStyle = FlatStyle.System;
        btnEditItem.Font = new Font("Segoe UI", 9F);
        btnEditItem.Location = new Point(135, 8);
        btnEditItem.Name = "btnEditItem";
        btnEditItem.Size = new Size(110, 34);
        btnEditItem.TabIndex = 1;
        btnEditItem.Text = "Edit Item";
        btnEditItem.UseVisualStyleBackColor = false;
        btnEditItem.Click += btnEditItem_Click;
        // 
        // btnAddItem
        // 
        btnAddItem.BackColor = Color.White;
        btnAddItem.Cursor = Cursors.Hand;
        btnAddItem.FlatStyle = FlatStyle.System;
        btnAddItem.Font = new Font("Segoe UI", 9F);
        btnAddItem.Location = new Point(0, 8);
        btnAddItem.Name = "btnAddItem";
        btnAddItem.Size = new Size(125, 34);
        btnAddItem.TabIndex = 0;
        btnAddItem.Text = "+ Add Item";
        btnAddItem.UseVisualStyleBackColor = false;
        btnAddItem.Click += btnAddItem_Click;
        // 
        // pnlGridHeader
        // 
        pnlGridHeader.Controls.Add(lblSummary);
        pnlGridHeader.Dock = DockStyle.Top;
        pnlGridHeader.Location = new Point(12, 35);
        pnlGridHeader.Name = "pnlGridHeader";
        pnlGridHeader.Size = new Size(1048, 26);
        pnlGridHeader.TabIndex = 0;
        // 
        // lblSummary
        // 
        lblSummary.AutoSize = true;
        lblSummary.Font = new Font("Segoe UI", 9F);
        lblSummary.ForeColor = Color.FromArgb(71, 85, 105);
        lblSummary.Location = new Point(0, 3);
        lblSummary.Name = "lblSummary";
        lblSummary.Size = new Size(151, 25);
        lblSummary.TabIndex = 0;
        lblSummary.Text = "Showing all items";
        // 
        // MenuManagementView
        // 
        AutoScaleDimensions = new SizeF(144F, 144F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.FromArgb(243, 244, 246);
        Controls.Add(grpMenuItems);
        Controls.Add(grpFilter);
        Controls.Add(pnlHeader);
        Name = "MenuManagementView";
        Padding = new Padding(24, 16, 24, 20);
        Size = new Size(1120, 553);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        grpFilter.ResumeLayout(false);
        grpFilter.PerformLayout();
        grpMenuItems.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvMenuItems).EndInit();
        pnlActions.ResumeLayout(false);
        pnlGridHeader.ResumeLayout(false);
        pnlGridHeader.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
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
