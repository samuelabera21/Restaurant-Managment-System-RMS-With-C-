namespace RMS.UI.Views;

partial class StaffManagementView
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
        lblSubtitle = new Label();
        lblTitle = new Label();
        grpFilter = new GroupBox();
        btnClearSearch = new Button();
        txtSearch = new TextBox();
        lblSearch = new Label();
        grpStaffTable = new GroupBox();
        dgvStaff = new DataGridView();
        colId = new DataGridViewTextBoxColumn();
        colName = new DataGridViewTextBoxColumn();
        colRole = new DataGridViewTextBoxColumn();
        colShift = new DataGridViewTextBoxColumn();
        colStatus = new DataGridViewTextBoxColumn();
        pnlStaffActions = new Panel();
        lblSummary = new Label();
        btnToggleStatus = new Button();
        btnEditStaff = new Button();
        btnAddStaff = new Button();
        pnlHeader.SuspendLayout();
        grpFilter.SuspendLayout();
        grpStaffTable.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvStaff).BeginInit();
        pnlStaffActions.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = Color.Transparent;
        pnlHeader.Controls.Add(lblSubtitle);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Location = new Point(24, 16);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new Size(1072, 50);
        pnlHeader.TabIndex = 0;
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new Font("Segoe UI", 9F);
        lblSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
        lblSubtitle.Location = new Point(0, 30);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(335, 20);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Manage restaurant staff and waiter accounts";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
        lblTitle.Location = new Point(0, -2);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(254, 37);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Staff Management";
        // 
        // grpFilter
        // 
        grpFilter.BackColor = Color.Transparent;
        grpFilter.Controls.Add(btnClearSearch);
        grpFilter.Controls.Add(txtSearch);
        grpFilter.Controls.Add(lblSearch);
        grpFilter.Dock = DockStyle.Top;
        grpFilter.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        grpFilter.ForeColor = Color.FromArgb(15, 23, 42);
        grpFilter.Location = new Point(24, 66);
        grpFilter.Name = "grpFilter";
        grpFilter.Padding = new Padding(12, 8, 12, 10);
        grpFilter.Size = new Size(1072, 64);
        grpFilter.TabIndex = 1;
        grpFilter.TabStop = false;
        grpFilter.Text = "Search Staff";
        // 
        // btnClearSearch
        // 
        btnClearSearch.BackColor = Color.White;
        btnClearSearch.Cursor = Cursors.Hand;
        btnClearSearch.FlatStyle = FlatStyle.System;
        btnClearSearch.Font = new Font("Segoe UI", 9F);
        btnClearSearch.Location = new Point(410, 24);
        btnClearSearch.Name = "btnClearSearch";
        btnClearSearch.Size = new Size(80, 30);
        btnClearSearch.TabIndex = 2;
        btnClearSearch.Text = "Clear";
        btnClearSearch.UseVisualStyleBackColor = false;
        btnClearSearch.Click += btnClearSearch_Click;
        // 
        // txtSearch
        // 
        txtSearch.Font = new Font("Segoe UI", 9F);
        txtSearch.Location = new Point(78, 25);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Search by staff ID or name...";
        txtSearch.Size = new Size(320, 27);
        txtSearch.TabIndex = 1;
        txtSearch.TextChanged += txtSearch_TextChanged;
        // 
        // lblSearch
        // 
        lblSearch.AutoSize = true;
        lblSearch.Font = new Font("Segoe UI", 9F);
        lblSearch.ForeColor = Color.FromArgb(71, 85, 105);
        lblSearch.Location = new Point(16, 28);
        lblSearch.Name = "lblSearch";
        lblSearch.Size = new Size(56, 20);
        lblSearch.TabIndex = 0;
        lblSearch.Text = "Search:";
        // 
        // grpStaffTable
        // 
        grpStaffTable.BackColor = Color.Transparent;
        grpStaffTable.Controls.Add(dgvStaff);
        grpStaffTable.Controls.Add(pnlStaffActions);
        grpStaffTable.Dock = DockStyle.Fill;
        grpStaffTable.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        grpStaffTable.ForeColor = Color.FromArgb(15, 23, 42);
        grpStaffTable.Location = new Point(24, 130);
        grpStaffTable.Name = "grpStaffTable";
        grpStaffTable.Padding = new Padding(12, 8, 12, 10);
        grpStaffTable.Size = new Size(1072, 403);
        grpStaffTable.TabIndex = 2;
        grpStaffTable.TabStop = false;
        grpStaffTable.Text = "Staff Directory";
        // 
        // dgvStaff
        // 
        dgvStaff.AllowUserToAddRows = false;
        dgvStaff.AllowUserToDeleteRows = false;
        dgvStaff.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
        dgvStaff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvStaff.BackgroundColor = Color.White;
        dgvStaff.BorderStyle = BorderStyle.Fixed3D;
        dgvStaff.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(71, 85, 105);
        dataGridViewCellStyle2.Padding = new Padding(8, 0, 8, 0);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(71, 85, 105);
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dgvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvStaff.ColumnHeadersHeight = 38;
        dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvStaff.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colRole, colShift, colStatus });
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.White;
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle3.Padding = new Padding(8, 0, 8, 0);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        dgvStaff.DefaultCellStyle = dataGridViewCellStyle3;
        dgvStaff.Dock = DockStyle.Fill;
        dgvStaff.EnableHeadersVisualStyles = false;
        dgvStaff.GridColor = Color.FromArgb(226, 232, 240);
        dgvStaff.Location = new Point(12, 30);
        dgvStaff.MultiSelect = false;
        dgvStaff.Name = "dgvStaff";
        dgvStaff.ReadOnly = true;
        dgvStaff.RowHeadersVisible = false;
        dgvStaff.RowHeadersWidth = 51;
        dgvStaff.RowTemplate.Height = 36;
        dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvStaff.Size = new Size(1048, 316);
        dgvStaff.TabIndex = 0;
        dgvStaff.SelectionChanged += dgvStaff_SelectionChanged;
        // 
        // colId
        // 
        colId.FillWeight = 60F;
        colId.HeaderText = "Staff ID";
        colId.MinimumWidth = 6;
        colId.Name = "colId";
        colId.ReadOnly = true;
        // 
        // colName
        // 
        colName.FillWeight = 160F;
        colName.HeaderText = "Full Name";
        colName.MinimumWidth = 6;
        colName.Name = "colName";
        colName.ReadOnly = true;
        // 
        // colRole
        // 
        colRole.FillWeight = 80F;
        colRole.HeaderText = "Role";
        colRole.MinimumWidth = 6;
        colRole.Name = "colRole";
        colRole.ReadOnly = true;
        // 
        // colShift
        // 
        colShift.FillWeight = 100F;
        colShift.HeaderText = "Working Shift";
        colShift.MinimumWidth = 6;
        colShift.Name = "colShift";
        colShift.ReadOnly = true;
        // 
        // colStatus
        // 
        colStatus.FillWeight = 80F;
        colStatus.HeaderText = "Status";
        colStatus.MinimumWidth = 6;
        colStatus.Name = "colStatus";
        colStatus.ReadOnly = true;
        // 
        // pnlStaffActions
        // 
        pnlStaffActions.BackColor = Color.Transparent;
        pnlStaffActions.Controls.Add(lblSummary);
        pnlStaffActions.Controls.Add(btnToggleStatus);
        pnlStaffActions.Controls.Add(btnEditStaff);
        pnlStaffActions.Controls.Add(btnAddStaff);
        pnlStaffActions.Dock = DockStyle.Bottom;
        pnlStaffActions.Location = new Point(12, 346);
        pnlStaffActions.Name = "pnlStaffActions";
        pnlStaffActions.Size = new Size(1048, 47);
        pnlStaffActions.TabIndex = 1;
        // 
        // lblSummary
        // 
        lblSummary.AutoSize = true;
        lblSummary.Font = new Font("Segoe UI", 9F);
        lblSummary.ForeColor = Color.FromArgb(100, 116, 139);
        lblSummary.Location = new Point(0, 14);
        lblSummary.Name = "lblSummary";
        lblSummary.Size = new Size(244, 20);
        lblSummary.TabIndex = 0;
        lblSummary.Text = "Showing 4 registered staff members";
        // 
        // btnToggleStatus
        // 
        btnToggleStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnToggleStatus.BackColor = Color.White;
        btnToggleStatus.Cursor = Cursors.Hand;
        btnToggleStatus.Enabled = false;
        btnToggleStatus.FlatStyle = FlatStyle.System;
        btnToggleStatus.Font = new Font("Segoe UI", 9F);
        btnToggleStatus.Location = new Point(660, 8);
        btnToggleStatus.Name = "btnToggleStatus";
        btnToggleStatus.Size = new Size(130, 32);
        btnToggleStatus.TabIndex = 1;
        btnToggleStatus.Text = "Toggle Status";
        btnToggleStatus.UseVisualStyleBackColor = false;
        btnToggleStatus.Click += btnToggleStatus_Click;
        // 
        // btnEditStaff
        // 
        btnEditStaff.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnEditStaff.BackColor = Color.White;
        btnEditStaff.Cursor = Cursors.Hand;
        btnEditStaff.Enabled = false;
        btnEditStaff.FlatStyle = FlatStyle.System;
        btnEditStaff.Font = new Font("Segoe UI", 9F);
        btnEditStaff.Location = new Point(800, 8);
        btnEditStaff.Name = "btnEditStaff";
        btnEditStaff.Size = new Size(110, 32);
        btnEditStaff.TabIndex = 2;
        btnEditStaff.Text = "Edit Waiter";
        btnEditStaff.UseVisualStyleBackColor = false;
        btnEditStaff.Click += btnEditStaff_Click;
        // 
        // btnAddStaff
        // 
        btnAddStaff.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnAddStaff.UseVisualStyleBackColor = true;
        btnAddStaff.Cursor = Cursors.Hand;
        btnAddStaff.FlatAppearance.BorderSize = 0;
        btnAddStaff.FlatStyle = FlatStyle.System;
        btnAddStaff.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnAddStaff.ForeColor = SystemColors.ControlText;
        btnAddStaff.Location = new Point(920, 8);
        btnAddStaff.Name = "btnAddStaff";
        btnAddStaff.Size = new Size(128, 32);
        btnAddStaff.TabIndex = 3;
        btnAddStaff.Text = "+ Add Waiter";
        btnAddStaff.UseVisualStyleBackColor = false;
        btnAddStaff.Click += btnAddStaff_Click;
        // 
        // StaffManagementView
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(243, 244, 246);
        Controls.Add(grpStaffTable);
        Controls.Add(grpFilter);
        Controls.Add(pnlHeader);
        Font = new Font("Segoe UI", 9.5F);
        Name = "StaffManagementView";
        Padding = new Padding(24, 16, 24, 20);
        Size = new Size(1120, 553);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        grpFilter.ResumeLayout(false);
        grpFilter.PerformLayout();
        grpStaffTable.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvStaff).EndInit();
        pnlStaffActions.ResumeLayout(false);
        pnlStaffActions.PerformLayout();
        ResumeLayout(false);
    }

    private Panel pnlHeader;
    private Label lblTitle;
    private Label lblSubtitle;
    private GroupBox grpFilter;
    private Label lblSearch;
    private TextBox txtSearch;
    private Button btnClearSearch;
    private GroupBox grpStaffTable;
    private DataGridView dgvStaff;
    private DataGridViewTextBoxColumn colId;
    private DataGridViewTextBoxColumn colName;
    private DataGridViewTextBoxColumn colRole;
    private DataGridViewTextBoxColumn colShift;
    private DataGridViewTextBoxColumn colStatus;
    private Panel pnlStaffActions;
    private Label lblSummary;
    private Button btnAddStaff;
    private Button btnEditStaff;
    private Button btnToggleStatus;
}

