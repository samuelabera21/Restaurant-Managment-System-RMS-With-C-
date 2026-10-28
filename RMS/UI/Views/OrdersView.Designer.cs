namespace RMS.UI.Views;

partial class OrdersView
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
        btnNewOrder = new Button();
        lblSubtitle = new Label();
        lblTitle = new Label();
        grpFilter = new GroupBox();
        lblOrdersSummary = new Label();
        btnClearFilters = new Button();
        cboStatus = new ComboBox();
        lblStatus = new Label();
        txtSearch = new TextBox();
        lblSearch = new Label();
        grpOrdersTable = new GroupBox();
        dgvOrders = new DataGridView();
        colOrderNum = new DataGridViewTextBoxColumn();
        colCustomer = new DataGridViewTextBoxColumn();
        colTable = new DataGridViewTextBoxColumn();
        colCreated = new DataGridViewTextBoxColumn();
        colTotal = new DataGridViewTextBoxColumn();
        colStatus = new DataGridViewTextBoxColumn();
        pnlOrderActions = new Panel();
        lblLockNote = new Label();
        btnCancelOrder = new Button();
        btnChangeStatus = new Button();
        btnEditOrder = new Button();
        btnViewDetails = new Button();
        pnlHeader.SuspendLayout();
        grpFilter.SuspendLayout();
        grpOrdersTable.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
        pnlOrderActions.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = Color.Transparent;
        pnlHeader.Controls.Add(btnNewOrder);
        pnlHeader.Controls.Add(lblSubtitle);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Location = new Point(24, 16);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new Size(1072, 56);
        pnlHeader.TabIndex = 0;
        // 
        // btnNewOrder
        // 
        btnNewOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnNewOrder.BackColor = Color.FromArgb(30, 58, 95);
        btnNewOrder.Cursor = Cursors.Hand;
        btnNewOrder.FlatAppearance.BorderSize = 0;
        btnNewOrder.FlatStyle = FlatStyle.Flat;
        btnNewOrder.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        btnNewOrder.ForeColor = Color.White;
        btnNewOrder.Location = new Point(942, 8);
        btnNewOrder.Name = "btnNewOrder";
        btnNewOrder.Size = new Size(130, 36);
        btnNewOrder.TabIndex = 2;
        btnNewOrder.Text = "+ New Order";
        btnNewOrder.UseVisualStyleBackColor = false;
        btnNewOrder.Click += btnNewOrder_Click;
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new Font("Segoe UI", 9F);
        lblSubtitle.ForeColor = Color.FromArgb(71, 85, 105);
        lblSubtitle.Location = new Point(0, 32);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(308, 25);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Search and manage restaurant orders";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
        lblTitle.Location = new Point(24, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(121, 45);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Orders";
        // 
        // grpFilter
        // 
        grpFilter.BackColor = Color.Transparent;
        grpFilter.Controls.Add(lblOrdersSummary);
        grpFilter.Controls.Add(btnClearFilters);
        grpFilter.Controls.Add(cboStatus);
        grpFilter.Controls.Add(lblStatus);
        grpFilter.Controls.Add(txtSearch);
        grpFilter.Controls.Add(lblSearch);
        grpFilter.Dock = DockStyle.Top;
        grpFilter.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        grpFilter.ForeColor = Color.FromArgb(15, 23, 42);
        grpFilter.Location = new Point(24, 72);
        grpFilter.Name = "grpFilter";
        grpFilter.Size = new Size(1072, 75);
        grpFilter.TabIndex = 1;
        grpFilter.TabStop = false;
        grpFilter.Text = "Search & Filter Orders";
        // 
        // lblOrdersSummary
        // 
        lblOrdersSummary.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblOrdersSummary.Font = new Font("Segoe UI", 9F);
        lblOrdersSummary.ForeColor = Color.FromArgb(71, 85, 105);
        lblOrdersSummary.Location = new Point(764, 30);
        lblOrdersSummary.Name = "lblOrdersSummary";
        lblOrdersSummary.Size = new Size(296, 25);
        lblOrdersSummary.TabIndex = 5;
        lblOrdersSummary.Text = "Showing 12 of 12 orders today";
        lblOrdersSummary.TextAlign = ContentAlignment.MiddleRight;
        // 
        // btnClearFilters
        // 
        btnClearFilters.BackColor = Color.White;
        btnClearFilters.Cursor = Cursors.Hand;
        btnClearFilters.FlatStyle = FlatStyle.System;
        btnClearFilters.Font = new Font("Segoe UI", 9F);
        btnClearFilters.Location = new Point(580, 27);
        btnClearFilters.Name = "btnClearFilters";
        btnClearFilters.Size = new Size(95, 31);
        btnClearFilters.TabIndex = 4;
        btnClearFilters.Text = "Reset Filter";
        btnClearFilters.UseVisualStyleBackColor = false;
        btnClearFilters.Click += btnClearFilters_Click;
        // 
        // cboStatus
        // 
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        cboStatus.Font = new Font("Segoe UI", 9.5F);
        cboStatus.FormattingEnabled = true;
        cboStatus.Items.AddRange(new object[] { "All Statuses", "Pending", "Preparing", "Ready", "Completed", "Cancelled" });
        cboStatus.Location = new Point(430, 28);
        cboStatus.Name = "cboStatus";
        cboStatus.Size = new Size(140, 33);
        cboStatus.TabIndex = 3;
        cboStatus.SelectedIndexChanged += cboStatus_SelectedIndexChanged;
        // 
        // lblStatus
        // 
        lblStatus.AutoSize = true;
        lblStatus.Font = new Font("Segoe UI", 9.5F);
        lblStatus.Location = new Point(370, 31);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(66, 25);
        lblStatus.TabIndex = 2;
        lblStatus.Text = "Status:";
        // 
        // txtSearch
        // 
        txtSearch.Font = new Font("Segoe UI", 9.5F);
        txtSearch.Location = new Point(75, 28);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Search by order #, customer, table...";
        txtSearch.Size = new Size(270, 33);
        txtSearch.TabIndex = 1;
        txtSearch.TextChanged += txtSearch_TextChanged;
        // 
        // lblSearch
        // 
        lblSearch.AutoSize = true;
        lblSearch.Font = new Font("Segoe UI", 9.5F);
        lblSearch.Location = new Point(14, 31);
        lblSearch.Name = "lblSearch";
        lblSearch.Size = new Size(73, 25);
        lblSearch.TabIndex = 0;
        lblSearch.Text = "Search:";
        // 
        // grpOrdersTable
        // 
        grpOrdersTable.BackColor = Color.Transparent;
        grpOrdersTable.Controls.Add(dgvOrders);
        grpOrdersTable.Controls.Add(pnlOrderActions);
        grpOrdersTable.Dock = DockStyle.Fill;
        grpOrdersTable.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        grpOrdersTable.ForeColor = Color.FromArgb(15, 23, 42);
        grpOrdersTable.Location = new Point(24, 147);
        grpOrdersTable.Name = "grpOrdersTable";
        grpOrdersTable.Padding = new Padding(12, 10, 12, 12);
        grpOrdersTable.Size = new Size(1072, 386);
        grpOrdersTable.TabIndex = 2;
        grpOrdersTable.TabStop = false;
        grpOrdersTable.Text = "Orders List";
        // 
        // dgvOrders
        // 
        dgvOrders.AllowUserToAddRows = false;
        dgvOrders.AllowUserToDeleteRows = false;
        dgvOrders.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
        dgvOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvOrders.BackgroundColor = Color.White;
        dgvOrders.BorderStyle = BorderStyle.Fixed3D;
        dgvOrders.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle2.Padding = new Padding(4, 6, 4, 6);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvOrders.Columns.AddRange(new DataGridViewColumn[] { colOrderNum, colCustomer, colTable, colCreated, colTotal, colStatus });
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.White;
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle3.Padding = new Padding(4);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(219, 234, 254);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        dgvOrders.DefaultCellStyle = dataGridViewCellStyle3;
        dgvOrders.Dock = DockStyle.Fill;
        dgvOrders.EnableHeadersVisualStyles = false;
        dgvOrders.GridColor = Color.FromArgb(226, 232, 240);
        dgvOrders.Location = new Point(12, 37);
        dgvOrders.MultiSelect = false;
        dgvOrders.Name = "dgvOrders";
        dgvOrders.ReadOnly = true;
        dgvOrders.RowHeadersVisible = false;
        dgvOrders.RowHeadersWidth = 51;
        dgvOrders.RowTemplate.Height = 36;
        dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvOrders.Size = new Size(1048, 285);
        dgvOrders.TabIndex = 0;
        dgvOrders.SelectionChanged += dgvOrders_SelectionChanged;
        // 
        // colOrderNum
        // 
        colOrderNum.FillWeight = 85F;
        colOrderNum.HeaderText = "Order #";
        colOrderNum.MinimumWidth = 6;
        colOrderNum.Name = "colOrderNum";
        colOrderNum.ReadOnly = true;
        // 
        // colCustomer
        // 
        colCustomer.FillWeight = 160F;
        colCustomer.HeaderText = "Customer";
        colCustomer.MinimumWidth = 6;
        colCustomer.Name = "colCustomer";
        colCustomer.ReadOnly = true;
        // 
        // colTable
        // 
        colTable.FillWeight = 85F;
        colTable.HeaderText = "Table";
        colTable.MinimumWidth = 6;
        colTable.Name = "colTable";
        colTable.ReadOnly = true;
        // 
        // colCreated
        // 
        colCreated.FillWeight = 95F;
        colCreated.HeaderText = "Created Time";
        colCreated.MinimumWidth = 6;
        colCreated.Name = "colCreated";
        colCreated.ReadOnly = true;
        // 
        // colTotal
        // 
        colTotal.FillWeight = 95F;
        colTotal.HeaderText = "Total (ETB)";
        colTotal.MinimumWidth = 6;
        colTotal.Name = "colTotal";
        colTotal.ReadOnly = true;
        // 
        // colStatus
        // 
        colStatus.FillWeight = 90F;
        colStatus.HeaderText = "Status";
        colStatus.MinimumWidth = 6;
        colStatus.Name = "colStatus";
        colStatus.ReadOnly = true;
        // 
        // pnlOrderActions
        // 
        pnlOrderActions.BackColor = Color.Transparent;
        pnlOrderActions.Controls.Add(lblLockNote);
        pnlOrderActions.Controls.Add(btnCancelOrder);
        pnlOrderActions.Controls.Add(btnChangeStatus);
        pnlOrderActions.Controls.Add(btnEditOrder);
        pnlOrderActions.Controls.Add(btnViewDetails);
        pnlOrderActions.Dock = DockStyle.Bottom;
        pnlOrderActions.Location = new Point(12, 322);
        pnlOrderActions.Name = "pnlOrderActions";
        pnlOrderActions.Padding = new Padding(0, 10, 0, 0);
        pnlOrderActions.Size = new Size(1048, 52);
        pnlOrderActions.TabIndex = 1;
        // 
        // lblLockNote
        // 
        lblLockNote.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblLockNote.AutoSize = true;
        lblLockNote.Font = new Font("Segoe UI", 8.5F);
        lblLockNote.ForeColor = Color.FromArgb(107, 114, 128);
        lblLockNote.Location = new Point(606, 18);
        lblLockNote.Name = "lblLockNote";
        lblLockNote.Size = new Size(518, 23);
        lblLockNote.TabIndex = 4;
        lblLockNote.Text = "ⓘ Completed and Cancelled orders cannot be edited or advanced.";
        // 
        // btnCancelOrder
        // 
        btnCancelOrder.BackColor = Color.White;
        btnCancelOrder.Cursor = Cursors.Hand;
        btnCancelOrder.Enabled = false;
        btnCancelOrder.FlatStyle = FlatStyle.System;
        btnCancelOrder.Font = new Font("Segoe UI", 9F);
        btnCancelOrder.ForeColor = Color.FromArgb(220, 38, 38);
        btnCancelOrder.Location = new Point(400, 10);
        btnCancelOrder.Name = "btnCancelOrder";
        btnCancelOrder.Size = new Size(120, 34);
        btnCancelOrder.TabIndex = 3;
        btnCancelOrder.Text = "✕ Cancel Order";
        btnCancelOrder.UseVisualStyleBackColor = false;
        btnCancelOrder.Click += btnCancelOrder_Click;
        // 
        // btnChangeStatus
        // 
        btnChangeStatus.BackColor = Color.White;
        btnChangeStatus.Cursor = Cursors.Hand;
        btnChangeStatus.Enabled = false;
        btnChangeStatus.FlatStyle = FlatStyle.System;
        btnChangeStatus.Font = new Font("Segoe UI", 9F);
        btnChangeStatus.Location = new Point(260, 10);
        btnChangeStatus.Name = "btnChangeStatus";
        btnChangeStatus.Size = new Size(130, 34);
        btnChangeStatus.TabIndex = 2;
        btnChangeStatus.Text = "➔ Advance Status";
        btnChangeStatus.UseVisualStyleBackColor = false;
        btnChangeStatus.Click += btnChangeStatus_Click;
        // 
        // btnEditOrder
        // 
        btnEditOrder.BackColor = Color.White;
        btnEditOrder.Cursor = Cursors.Hand;
        btnEditOrder.Enabled = false;
        btnEditOrder.FlatStyle = FlatStyle.System;
        btnEditOrder.Font = new Font("Segoe UI", 9F);
        btnEditOrder.Location = new Point(140, 10);
        btnEditOrder.Name = "btnEditOrder";
        btnEditOrder.Size = new Size(110, 34);
        btnEditOrder.TabIndex = 1;
        btnEditOrder.Text = "✏ Edit Order";
        btnEditOrder.UseVisualStyleBackColor = false;
        btnEditOrder.Click += btnEditOrder_Click;
        // 
        // btnViewDetails
        // 
        btnViewDetails.BackColor = Color.FromArgb(30, 58, 95);
        btnViewDetails.Cursor = Cursors.Hand;
        btnViewDetails.Enabled = false;
        btnViewDetails.FlatAppearance.BorderSize = 0;
        btnViewDetails.FlatStyle = FlatStyle.Flat;
        btnViewDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnViewDetails.ForeColor = Color.White;
        btnViewDetails.Location = new Point(0, 10);
        btnViewDetails.Name = "btnViewDetails";
        btnViewDetails.Size = new Size(130, 34);
        btnViewDetails.TabIndex = 0;
        btnViewDetails.Text = "👁 View Details";
        btnViewDetails.UseVisualStyleBackColor = false;
        btnViewDetails.Click += btnViewDetails_Click;
        // 
        // OrdersView
        // 
        AutoScaleDimensions = new SizeF(144F, 144F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.FromArgb(243, 244, 246);
        Controls.Add(grpOrdersTable);
        Controls.Add(grpFilter);
        Controls.Add(lblTitle);
        Controls.Add(pnlHeader);
        Name = "OrdersView";
        Padding = new Padding(24, 16, 24, 20);
        Size = new Size(1120, 553);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        grpFilter.ResumeLayout(false);
        grpFilter.PerformLayout();
        grpOrdersTable.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
        pnlOrderActions.ResumeLayout(false);
        pnlOrderActions.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Button btnNewOrder;
    private System.Windows.Forms.GroupBox grpFilter;
    private System.Windows.Forms.Label lblSearch;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.ComboBox cboStatus;
    private System.Windows.Forms.Button btnClearFilters;
    private System.Windows.Forms.Label lblOrdersSummary;
    private System.Windows.Forms.GroupBox grpOrdersTable;
    private System.Windows.Forms.DataGridView dgvOrders;
    private System.Windows.Forms.DataGridViewTextBoxColumn colOrderNum;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCustomer;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTable;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCreated;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
    private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    private System.Windows.Forms.Panel pnlOrderActions;
    private System.Windows.Forms.Button btnViewDetails;
    private System.Windows.Forms.Button btnEditOrder;
    private System.Windows.Forms.Button btnChangeStatus;
    private System.Windows.Forms.Button btnCancelOrder;
    private System.Windows.Forms.Label lblLockNote;
}

