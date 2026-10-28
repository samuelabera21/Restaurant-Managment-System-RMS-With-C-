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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        this.pnlHeader = new System.Windows.Forms.Panel();
        this.btnNewOrder = new System.Windows.Forms.Button();
        this.lblSubtitle = new System.Windows.Forms.Label();
        this.lblTitle = new System.Windows.Forms.Label();
        this.grpFilter = new System.Windows.Forms.GroupBox();
        this.lblOrdersSummary = new System.Windows.Forms.Label();
        this.btnClearFilters = new System.Windows.Forms.Button();
        this.cboStatus = new System.Windows.Forms.ComboBox();
        this.lblStatus = new System.Windows.Forms.Label();
        this.txtSearch = new System.Windows.Forms.TextBox();
        this.lblSearch = new System.Windows.Forms.Label();
        this.grpOrdersTable = new System.Windows.Forms.GroupBox();
        this.dgvOrders = new System.Windows.Forms.DataGridView();
        this.colOrderNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.pnlOrderActions = new System.Windows.Forms.Panel();
        this.lblLockNote = new System.Windows.Forms.Label();
        this.btnCancelOrder = new System.Windows.Forms.Button();
        this.btnChangeStatus = new System.Windows.Forms.Button();
        this.btnEditOrder = new System.Windows.Forms.Button();
        this.btnViewDetails = new System.Windows.Forms.Button();
        this.pnlHeader.SuspendLayout();
        this.grpFilter.SuspendLayout();
        this.grpOrdersTable.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
        this.pnlOrderActions.SuspendLayout();
        this.SuspendLayout();
        // 
        // pnlHeader
        // 
        this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
        this.pnlHeader.Controls.Add(this.btnNewOrder);
        this.pnlHeader.Controls.Add(this.lblSubtitle);
        this.pnlHeader.Controls.Add(this.lblTitle);
        this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        this.pnlHeader.Location = new System.Drawing.Point(24, 16);
        this.pnlHeader.Name = "pnlHeader";
        this.pnlHeader.Size = new System.Drawing.Size(996, 56);
        this.pnlHeader.TabIndex = 0;
        // 
        // btnNewOrder
        // 
        this.btnNewOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnNewOrder.BackColor = System.Drawing.Color.FromArgb(30, 58, 95);
        this.btnNewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnNewOrder.FlatAppearance.BorderSize = 0;
        this.btnNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnNewOrder.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.btnNewOrder.ForeColor = System.Drawing.Color.White;
        this.btnNewOrder.Location = new System.Drawing.Point(866, 8);
        this.btnNewOrder.Name = "btnNewOrder";
        this.btnNewOrder.Size = new System.Drawing.Size(130, 36);
        this.btnNewOrder.TabIndex = 2;
        this.btnNewOrder.Text = "+ New Order";
        this.btnNewOrder.UseVisualStyleBackColor = false;
        this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
        // 
        // lblSubtitle
        // 
        this.lblSubtitle.AutoSize = true;
        this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblSubtitle.Location = new System.Drawing.Point(0, 32);
        this.lblSubtitle.Name = "lblSubtitle";
        this.lblSubtitle.Size = new System.Drawing.Size(225, 20);
        this.lblSubtitle.TabIndex = 1;
        this.lblSubtitle.Text = "Search and manage restaurant orders";
        // 
        // lblTitle
        // 
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.lblTitle.Location = new System.Drawing.Point(-2, 0);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(104, 37);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Orders";
        // 
        // grpFilter
        // 
        this.grpFilter.BackColor = System.Drawing.Color.Transparent;
        this.grpFilter.Controls.Add(this.lblOrdersSummary);
        this.grpFilter.Controls.Add(this.btnClearFilters);
        this.grpFilter.Controls.Add(this.cboStatus);
        this.grpFilter.Controls.Add(this.lblStatus);
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
        this.grpFilter.Text = "Search & Filter Orders";
        // 
        // lblOrdersSummary
        // 
        this.lblOrdersSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.lblOrdersSummary.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblOrdersSummary.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblOrdersSummary.Location = new System.Drawing.Point(688, 30);
        this.lblOrdersSummary.Name = "lblOrdersSummary";
        this.lblOrdersSummary.Size = new System.Drawing.Size(296, 25);
        this.lblOrdersSummary.TabIndex = 5;
        this.lblOrdersSummary.Text = "Showing 12 of 12 orders today";
        this.lblOrdersSummary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // btnClearFilters
        // 
        this.btnClearFilters.BackColor = System.Drawing.Color.White;
        this.btnClearFilters.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.btnClearFilters.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.btnClearFilters.Location = new System.Drawing.Point(580, 27);
        this.btnClearFilters.Name = "btnClearFilters";
        this.btnClearFilters.Size = new System.Drawing.Size(95, 31);
        this.btnClearFilters.TabIndex = 4;
        this.btnClearFilters.Text = "Reset Filter";
        this.btnClearFilters.UseVisualStyleBackColor = false;
        this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
        // 
        // cboStatus
        // 
        this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.cboStatus.FormattingEnabled = true;
        this.cboStatus.Items.AddRange(new object[] {
            "All Statuses",
            "Pending",
            "Preparing",
            "Ready",
            "Completed",
            "Cancelled"});
        this.cboStatus.Location = new System.Drawing.Point(430, 28);
        this.cboStatus.Name = "cboStatus";
        this.cboStatus.Size = new System.Drawing.Size(140, 29);
        this.cboStatus.TabIndex = 3;
        this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
        // 
        // lblStatus
        // 
        this.lblStatus.AutoSize = true;
        this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblStatus.Location = new System.Drawing.Point(370, 31);
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Size = new System.Drawing.Size(55, 21);
        this.lblStatus.TabIndex = 2;
        this.lblStatus.Text = "Status:";
        // 
        // txtSearch
        // 
        this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.txtSearch.Location = new System.Drawing.Point(75, 28);
        this.txtSearch.Name = "txtSearch";
        this.txtSearch.PlaceholderText = "Search by order #, customer, table...";
        this.txtSearch.Size = new System.Drawing.Size(270, 29);
        this.txtSearch.TabIndex = 1;
        this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
        // 
        // lblSearch
        // 
        this.lblSearch.AutoSize = true;
        this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblSearch.Location = new System.Drawing.Point(14, 31);
        this.lblSearch.Name = "lblSearch";
        this.lblSearch.Size = new System.Drawing.Size(60, 21);
        this.lblSearch.TabIndex = 0;
        this.lblSearch.Text = "Search:";
        // 
        // grpOrdersTable
        // 
        this.grpOrdersTable.BackColor = System.Drawing.Color.Transparent;
        this.grpOrdersTable.Controls.Add(this.dgvOrders);
        this.grpOrdersTable.Controls.Add(this.pnlOrderActions);
        this.grpOrdersTable.Dock = System.Windows.Forms.DockStyle.Fill;
        this.grpOrdersTable.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.grpOrdersTable.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.grpOrdersTable.Location = new System.Drawing.Point(24, 147);
        this.grpOrdersTable.Name = "grpOrdersTable";
        this.grpOrdersTable.Padding = new System.Windows.Forms.Padding(12, 10, 12, 12);
        this.grpOrdersTable.Size = new System.Drawing.Size(996, 513);
        this.grpOrdersTable.TabIndex = 2;
        this.grpOrdersTable.TabStop = false;
        this.grpOrdersTable.Text = "Orders List";
        // 
        // dgvOrders
        // 
        this.dgvOrders.AllowUserToAddRows = false;
        this.dgvOrders.AllowUserToDeleteRows = false;
        this.dgvOrders.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        this.dgvOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvOrders.BackgroundColor = System.Drawing.Color.White;
        this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.dgvOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        this.dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderNum,
            this.colCustomer,
            this.colTable,
            this.colCreated,
            this.colTotal,
            this.colStatus});
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        this.dgvOrders.DefaultCellStyle = dataGridViewCellStyle3;
        this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvOrders.EnableHeadersVisualStyles = false;
        this.dgvOrders.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
        this.dgvOrders.Location = new System.Drawing.Point(12, 33);
        this.dgvOrders.MultiSelect = false;
        this.dgvOrders.Name = "dgvOrders";
        this.dgvOrders.ReadOnly = true;
        this.dgvOrders.RowHeadersVisible = false;
        this.dgvOrders.RowHeadersWidth = 51;
        this.dgvOrders.RowTemplate.Height = 36;
        this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvOrders.Size = new System.Drawing.Size(972, 416);
        this.dgvOrders.TabIndex = 0;
        this.dgvOrders.SelectionChanged += new System.EventHandler(this.dgvOrders_SelectionChanged);
        // 
        // colOrderNum
        // 
        this.colOrderNum.FillWeight = 85F;
        this.colOrderNum.HeaderText = "Order #";
        this.colOrderNum.MinimumWidth = 6;
        this.colOrderNum.Name = "colOrderNum";
        this.colOrderNum.ReadOnly = true;
        // 
        // colCustomer
        // 
        this.colCustomer.FillWeight = 160F;
        this.colCustomer.HeaderText = "Customer";
        this.colCustomer.MinimumWidth = 6;
        this.colCustomer.Name = "colCustomer";
        this.colCustomer.ReadOnly = true;
        // 
        // colTable
        // 
        this.colTable.FillWeight = 85F;
        this.colTable.HeaderText = "Table";
        this.colTable.MinimumWidth = 6;
        this.colTable.Name = "colTable";
        this.colTable.ReadOnly = true;
        // 
        // colCreated
        // 
        this.colCreated.FillWeight = 95F;
        this.colCreated.HeaderText = "Created Time";
        this.colCreated.MinimumWidth = 6;
        this.colCreated.Name = "colCreated";
        this.colCreated.ReadOnly = true;
        // 
        // colTotal
        // 
        this.colTotal.FillWeight = 95F;
        this.colTotal.HeaderText = "Total (ETB)";
        this.colTotal.MinimumWidth = 6;
        this.colTotal.Name = "colTotal";
        this.colTotal.ReadOnly = true;
        // 
        // colStatus
        // 
        this.colStatus.FillWeight = 90F;
        this.colStatus.HeaderText = "Status";
        this.colStatus.MinimumWidth = 6;
        this.colStatus.Name = "colStatus";
        this.colStatus.ReadOnly = true;
        // 
        // pnlOrderActions
        // 
        this.pnlOrderActions.BackColor = System.Drawing.Color.Transparent;
        this.pnlOrderActions.Controls.Add(this.lblLockNote);
        this.pnlOrderActions.Controls.Add(this.btnCancelOrder);
        this.pnlOrderActions.Controls.Add(this.btnChangeStatus);
        this.pnlOrderActions.Controls.Add(this.btnEditOrder);
        this.pnlOrderActions.Controls.Add(this.btnViewDetails);
        this.pnlOrderActions.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.pnlOrderActions.Location = new System.Drawing.Point(12, 449);
        this.pnlOrderActions.Name = "pnlOrderActions";
        this.pnlOrderActions.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
        this.pnlOrderActions.Size = new System.Drawing.Size(972, 52);
        this.pnlOrderActions.TabIndex = 1;
        // 
        // lblLockNote
        // 
        this.lblLockNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.lblLockNote.AutoSize = true;
        this.lblLockNote.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        this.lblLockNote.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
        this.lblLockNote.Location = new System.Drawing.Point(530, 18);
        this.lblLockNote.Name = "lblLockNote";
        this.lblLockNote.Size = new System.Drawing.Size(438, 20);
        this.lblLockNote.TabIndex = 4;
        this.lblLockNote.Text = "ⓘ Completed and Cancelled orders cannot be edited or advanced.";
        // 
        // btnCancelOrder
        // 
        this.btnCancelOrder.BackColor = System.Drawing.Color.White;
        this.btnCancelOrder.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnCancelOrder.Enabled = false;
        this.btnCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.btnCancelOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.btnCancelOrder.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
        this.btnCancelOrder.Location = new System.Drawing.Point(400, 10);
        this.btnCancelOrder.Name = "btnCancelOrder";
        this.btnCancelOrder.Size = new System.Drawing.Size(120, 34);
        this.btnCancelOrder.TabIndex = 3;
        this.btnCancelOrder.Text = "✕ Cancel Order";
        this.btnCancelOrder.UseVisualStyleBackColor = false;
        this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
        // 
        // btnChangeStatus
        // 
        this.btnChangeStatus.BackColor = System.Drawing.Color.White;
        this.btnChangeStatus.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnChangeStatus.Enabled = false;
        this.btnChangeStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.btnChangeStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.btnChangeStatus.Location = new System.Drawing.Point(260, 10);
        this.btnChangeStatus.Name = "btnChangeStatus";
        this.btnChangeStatus.Size = new System.Drawing.Size(130, 34);
        this.btnChangeStatus.TabIndex = 2;
        this.btnChangeStatus.Text = "➔ Advance Status";
        this.btnChangeStatus.UseVisualStyleBackColor = false;
        this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
        // 
        // btnEditOrder
        // 
        this.btnEditOrder.BackColor = System.Drawing.Color.White;
        this.btnEditOrder.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnEditOrder.Enabled = false;
        this.btnEditOrder.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.btnEditOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.btnEditOrder.Location = new System.Drawing.Point(140, 10);
        this.btnEditOrder.Name = "btnEditOrder";
        this.btnEditOrder.Size = new System.Drawing.Size(110, 34);
        this.btnEditOrder.TabIndex = 1;
        this.btnEditOrder.Text = "✏ Edit Order";
        this.btnEditOrder.UseVisualStyleBackColor = false;
        this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
        // 
        // btnViewDetails
        // 
        this.btnViewDetails.BackColor = System.Drawing.Color.FromArgb(30, 58, 95);
        this.btnViewDetails.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnViewDetails.Enabled = false;
        this.btnViewDetails.FlatAppearance.BorderSize = 0;
        this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnViewDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.btnViewDetails.ForeColor = System.Drawing.Color.White;
        this.btnViewDetails.Location = new System.Drawing.Point(0, 10);
        this.btnViewDetails.Name = "btnViewDetails";
        this.btnViewDetails.Size = new System.Drawing.Size(130, 34);
        this.btnViewDetails.TabIndex = 0;
        this.btnViewDetails.Text = "👁 View Details";
        this.btnViewDetails.UseVisualStyleBackColor = false;
        this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
        // 
        // OrdersView
        // 
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
        this.Controls.Add(this.grpOrdersTable);
        this.Controls.Add(this.grpFilter);
        this.Controls.Add(this.pnlHeader);
        this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.Name = "OrdersView";
        this.Padding = new System.Windows.Forms.Padding(24, 16, 24, 20);
        this.Size = new System.Drawing.Size(1044, 680);
        this.pnlHeader.ResumeLayout(false);
        this.pnlHeader.PerformLayout();
        this.grpFilter.ResumeLayout(false);
        this.grpFilter.PerformLayout();
        this.grpOrdersTable.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
        this.pnlOrderActions.ResumeLayout(false);
        this.pnlOrderActions.PerformLayout();
        this.ResumeLayout(false);
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
