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
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Location = new Point(33, 20);
        pnlHeader.Margin = new Padding(4);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new Size(1054, 61);
        pnlHeader.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
        lblTitle.Location = new Point(20, 12);
        lblTitle.Margin = new Padding(4, 0, 4, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(297, 45);
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
        grpFilter.Location = new Point(33, 81);
        grpFilter.Margin = new Padding(4);
        grpFilter.Name = "grpFilter";
        grpFilter.Padding = new Padding(16, 10, 16, 12);
        grpFilter.Size = new Size(1054, 134);
        grpFilter.TabIndex = 1;
        grpFilter.TabStop = false;
        // 
        // btnClearSearch
        // 
        btnClearSearch.BackColor = Color.White;
        btnClearSearch.Cursor = Cursors.Hand;
        btnClearSearch.FlatStyle = FlatStyle.System;
        btnClearSearch.Font = new Font("Segoe UI", 9F);
        btnClearSearch.Location = new Point(830, 62);
        btnClearSearch.Margin = new Padding(4);
        btnClearSearch.Name = "btnClearSearch";
        btnClearSearch.Size = new Size(110, 38);
        btnClearSearch.TabIndex = 2;
        btnClearSearch.Text = "Clear";
        btnClearSearch.UseVisualStyleBackColor = false;
        btnClearSearch.Click += btnClearSearch_Click;
        // 
        // txtSearch
        // 
        txtSearch.Font = new Font("Segoe UI", 9F);
        txtSearch.Location = new Point(121, 62);
        txtSearch.Margin = new Padding(4);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Search by staff ID or name...";
        txtSearch.Size = new Size(624, 31);
        txtSearch.TabIndex = 1;
        txtSearch.TextChanged += txtSearch_TextChanged;
        // 
        // lblSearch
        // 
        lblSearch.AutoSize = true;
        lblSearch.Font = new Font("Segoe UI", 9F);
        lblSearch.ForeColor = Color.FromArgb(71, 85, 105);
        lblSearch.Location = new Point(20, 62);
        lblSearch.Margin = new Padding(4, 0, 4, 0);
        lblSearch.Name = "lblSearch";
        lblSearch.Size = new Size(68, 25);
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
        grpStaffTable.Location = new Point(33, 215);
        grpStaffTable.Margin = new Padding(4);
        grpStaffTable.Name = "grpStaffTable";
        grpStaffTable.Padding = new Padding(16, 10, 16, 12);
        grpStaffTable.Size = new Size(1054, 245);
        grpStaffTable.TabIndex = 2;
        grpStaffTable.TabStop = false;
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
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
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
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle3.Padding = new Padding(8, 0, 8, 0);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        dgvStaff.DefaultCellStyle = dataGridViewCellStyle3;
        dgvStaff.Dock = DockStyle.Fill;
        dgvStaff.EnableHeadersVisualStyles = false;
        dgvStaff.GridColor = Color.FromArgb(226, 232, 240);
        dgvStaff.Location = new Point(16, 36);
        dgvStaff.Margin = new Padding(4);
        dgvStaff.MultiSelect = false;
        dgvStaff.Name = "dgvStaff";
        dgvStaff.ReadOnly = true;
        dgvStaff.RowHeadersVisible = false;
        dgvStaff.RowHeadersWidth = 51;
        dgvStaff.RowTemplate.Height = 36;
        dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvStaff.Size = new Size(1022, 87);
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
        pnlStaffActions.Controls.Add(btnToggleStatus);
        pnlStaffActions.Controls.Add(btnEditStaff);
        pnlStaffActions.Controls.Add(btnAddStaff);
        pnlStaffActions.Dock = DockStyle.Bottom;
        pnlStaffActions.Location = new Point(16, 123);
        pnlStaffActions.Margin = new Padding(4);
        pnlStaffActions.Name = "pnlStaffActions";
        pnlStaffActions.Size = new Size(1022, 110);
        pnlStaffActions.TabIndex = 1;
        // 
        // btnToggleStatus
        // 
        btnToggleStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnToggleStatus.BackColor = Color.White;
        btnToggleStatus.Cursor = Cursors.Hand;
        btnToggleStatus.Enabled = false;
        btnToggleStatus.FlatStyle = FlatStyle.System;
        btnToggleStatus.Font = new Font("Segoe UI", 9F);
        btnToggleStatus.Location = new Point(149, 22);
        btnToggleStatus.Margin = new Padding(4);
        btnToggleStatus.Name = "btnToggleStatus";
        btnToggleStatus.Size = new Size(179, 71);
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
        btnEditStaff.Location = new Point(451, 22);
        btnEditStaff.Margin = new Padding(4);
        btnEditStaff.Name = "btnEditStaff";
        btnEditStaff.Size = new Size(151, 71);
        btnEditStaff.TabIndex = 2;
        btnEditStaff.Text = "Edit Waiter";
        btnEditStaff.UseVisualStyleBackColor = false;
        btnEditStaff.Click += btnEditStaff_Click;
        // 
        // btnAddStaff
        // 
        btnAddStaff.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnAddStaff.Cursor = Cursors.Hand;
        btnAddStaff.FlatAppearance.BorderSize = 0;
        btnAddStaff.FlatStyle = FlatStyle.System;
        btnAddStaff.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnAddStaff.ForeColor = SystemColors.ControlText;
        btnAddStaff.Location = new Point(792, 22);
        btnAddStaff.Margin = new Padding(4);
        btnAddStaff.Name = "btnAddStaff";
        btnAddStaff.Size = new Size(176, 71);
        btnAddStaff.TabIndex = 3;
        btnAddStaff.Text = "+ Add Waiter";
        btnAddStaff.UseVisualStyleBackColor = false;
        btnAddStaff.Click += btnAddStaff_Click;
        // 
        // StaffManagementView
        // 
        AutoScaleDimensions = new SizeF(11F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(243, 244, 246);
        Controls.Add(grpStaffTable);
        Controls.Add(grpFilter);
        Controls.Add(pnlHeader);
        Margin = new Padding(4);
        Name = "StaffManagementView";
        Padding = new Padding(33, 20, 33, 25);
        Size = new Size(1120, 485);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        grpFilter.ResumeLayout(false);
        grpFilter.PerformLayout();
        grpStaffTable.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvStaff).EndInit();
        pnlStaffActions.ResumeLayout(false);
        ResumeLayout(false);
    }

    private Panel pnlHeader;
    private Label lblTitle;
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
    private Button btnAddStaff;
    private Button btnEditStaff;
    private Button btnToggleStatus;
}

