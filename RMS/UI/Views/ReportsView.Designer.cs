namespace RMS.UI.Views;

partial class ReportsView
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
        grpFilters = new GroupBox();
        btnClearFilters = new Button();
        cboStatusFilter = new ComboBox();
        lblStatusFilter = new Label();
        cboDateFilter = new ComboBox();
        lblDateFilter = new Label();
        grpSummaryCards = new GroupBox();
        tlpKpi = new TableLayoutPanel();
        pnlKpiTotal = new Panel();
        lblTotalOrders = new Label();
        lblKpiTotalTitle = new Label();
        pnlKpiPending = new Panel();
        lblPendingOrders = new Label();
        lblKpiPendingTitle = new Label();
        pnlKpiPreparing = new Panel();
        lblPreparingOrders = new Label();
        lblKpiPrepTitle = new Label();
        pnlKpiReady = new Panel();
        lblReadyOrders = new Label();
        lblKpiReadyTitle = new Label();
        pnlKpiCompleted = new Panel();
        lblCompletedOrders = new Label();
        lblKpiCompTitle = new Label();
        pnlKpiValue = new Panel();
        lblCompletedValue = new Label();
        lblKpiValTitle = new Label();
        grpOrderSummary = new GroupBox();
        dgvSummary = new DataGridView();
        colOrderNum = new DataGridViewTextBoxColumn();
        colCustomer = new DataGridViewTextBoxColumn();
        colTable = new DataGridViewTextBoxColumn();
        colCreated = new DataGridViewTextBoxColumn();
        colTotal = new DataGridViewTextBoxColumn();
        colStatus = new DataGridViewTextBoxColumn();
        pnlBreakdownHeader = new Panel();
        lblBreakdownSubtitle = new Label();
        pnlHeader.SuspendLayout();
        grpFilters.SuspendLayout();
        grpSummaryCards.SuspendLayout();
        tlpKpi.SuspendLayout();
        pnlKpiTotal.SuspendLayout();
        pnlKpiPending.SuspendLayout();
        pnlKpiPreparing.SuspendLayout();
        pnlKpiReady.SuspendLayout();
        pnlKpiCompleted.SuspendLayout();
        pnlKpiValue.SuspendLayout();
        grpOrderSummary.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvSummary).BeginInit();
        pnlBreakdownHeader.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = Color.Transparent;
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Location = new Point(24, 16);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new Size(1072, 44);
        pnlHeader.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
        lblTitle.Location = new Point(0, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(137, 45);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Reports";
        // 
        // grpFilters
        // 
        grpFilters.BackColor = Color.Transparent;
        grpFilters.Controls.Add(btnClearFilters);
        grpFilters.Controls.Add(cboStatusFilter);
        grpFilters.Controls.Add(lblStatusFilter);
        grpFilters.Controls.Add(cboDateFilter);
        grpFilters.Controls.Add(lblDateFilter);
        grpFilters.Dock = DockStyle.Top;
        grpFilters.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        grpFilters.ForeColor = Color.FromArgb(15, 23, 42);
        grpFilters.Location = new Point(24, 60);
        grpFilters.Name = "grpFilters";
        grpFilters.Size = new Size(1072, 72);
        grpFilters.TabIndex = 1;
        grpFilters.TabStop = false;
        grpFilters.Text = "Filters";
        // 
        // btnClearFilters
        // 
        btnClearFilters.BackColor = Color.White;
        btnClearFilters.Cursor = Cursors.Hand;
        btnClearFilters.FlatStyle = FlatStyle.System;
        btnClearFilters.Font = new Font("Segoe UI", 9F);
        btnClearFilters.Location = new Point(500, 24);
        btnClearFilters.Name = "btnClearFilters";
        btnClearFilters.Size = new Size(75, 31);
        btnClearFilters.TabIndex = 4;
        btnClearFilters.Text = "Clear";
        btnClearFilters.UseVisualStyleBackColor = false;
        btnClearFilters.Click += btnClearFilters_Click;
        // 
        // cboStatusFilter
        // 
        cboStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        cboStatusFilter.Font = new Font("Segoe UI", 9.5F);
        cboStatusFilter.FormattingEnabled = true;
        cboStatusFilter.Items.AddRange(new object[] { "All Statuses", "Pending", "Preparing", "Ready", "Completed" });
        cboStatusFilter.Location = new Point(345, 25);
        cboStatusFilter.Name = "cboStatusFilter";
        cboStatusFilter.Size = new Size(135, 33);
        cboStatusFilter.TabIndex = 3;
        cboStatusFilter.SelectedIndexChanged += cboStatusFilter_SelectedIndexChanged;
        // 
        // lblStatusFilter
        // 
        lblStatusFilter.AutoSize = true;
        lblStatusFilter.Font = new Font("Segoe UI", 9.5F);
        lblStatusFilter.Location = new Point(280, 28);
        lblStatusFilter.Name = "lblStatusFilter";
        lblStatusFilter.Size = new Size(66, 25);
        lblStatusFilter.TabIndex = 2;
        lblStatusFilter.Text = "Status:";
        // 
        // cboDateFilter
        // 
        cboDateFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        cboDateFilter.Font = new Font("Segoe UI", 9.5F);
        cboDateFilter.FormattingEnabled = true;
        cboDateFilter.Items.AddRange(new object[] { "All dates", "Today" });
        cboDateFilter.Location = new Point(125, 25);
        cboDateFilter.Name = "cboDateFilter";
        cboDateFilter.Size = new Size(135, 33);
        cboDateFilter.TabIndex = 1;
        cboDateFilter.SelectedIndexChanged += cboDateFilter_SelectedIndexChanged;
        // 
        // lblDateFilter
        // 
        lblDateFilter.AutoSize = true;
        lblDateFilter.Font = new Font("Segoe UI", 9.5F);
        lblDateFilter.Location = new Point(16, 28);
        lblDateFilter.Name = "lblDateFilter";
        lblDateFilter.Size = new Size(97, 25);
        lblDateFilter.TabIndex = 0;
        lblDateFilter.Text = "Date Range:";
        // 
        // grpSummaryCards
        // 
        grpSummaryCards.BackColor = Color.Transparent;
        grpSummaryCards.Controls.Add(tlpKpi);
        grpSummaryCards.Dock = DockStyle.Top;
        grpSummaryCards.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        grpSummaryCards.ForeColor = Color.FromArgb(15, 23, 42);
        grpSummaryCards.Location = new Point(24, 132);
        grpSummaryCards.Name = "grpSummaryCards";
        grpSummaryCards.Padding = new Padding(12, 8, 12, 10);
        grpSummaryCards.Size = new Size(1072, 140);
        grpSummaryCards.TabIndex = 2;
        grpSummaryCards.TabStop = false;
        grpSummaryCards.Text = "Performance Summary";
        // 
        // tlpKpi
        // 
        tlpKpi.ColumnCount = 3;
        tlpKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
        tlpKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
        tlpKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
        tlpKpi.Controls.Add(pnlKpiTotal, 0, 0);
        tlpKpi.Controls.Add(pnlKpiPending, 1, 0);
        tlpKpi.Controls.Add(pnlKpiPreparing, 2, 0);
        tlpKpi.Controls.Add(pnlKpiReady, 0, 1);
        tlpKpi.Controls.Add(pnlKpiCompleted, 1, 1);
        tlpKpi.Controls.Add(pnlKpiValue, 2, 1);
        tlpKpi.Dock = DockStyle.Fill;
        tlpKpi.Location = new Point(12, 35);
        tlpKpi.Name = "tlpKpi";
        tlpKpi.RowCount = 2;
        tlpKpi.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tlpKpi.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tlpKpi.Size = new Size(1048, 95);
        tlpKpi.TabIndex = 0;
        // 
        // pnlKpiTotal
        // 
        pnlKpiTotal.BackColor = Color.White;
        pnlKpiTotal.BorderStyle = BorderStyle.FixedSingle;
        pnlKpiTotal.Controls.Add(lblTotalOrders);
        pnlKpiTotal.Controls.Add(lblKpiTotalTitle);
        pnlKpiTotal.Dock = DockStyle.Fill;
        pnlKpiTotal.Location = new Point(3, 3);
        pnlKpiTotal.Margin = new Padding(3);
        pnlKpiTotal.Name = "pnlKpiTotal";
        pnlKpiTotal.Padding = new Padding(8, 4, 8, 4);
        pnlKpiTotal.Size = new Size(343, 41);
        pnlKpiTotal.TabIndex = 0;
        // 
        // lblTotalOrders
        // 
        lblTotalOrders.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblTotalOrders.AutoSize = true;
        lblTotalOrders.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblTotalOrders.ForeColor = Color.FromArgb(15, 23, 42);
        lblTotalOrders.Location = new Point(265, 5);
        lblTotalOrders.Name = "lblTotalOrders";
        lblTotalOrders.Size = new Size(42, 32);
        lblTotalOrders.TabIndex = 1;
        lblTotalOrders.Text = "12";
        // 
        // lblKpiTotalTitle
        // 
        lblKpiTotalTitle.AutoSize = true;
        lblKpiTotalTitle.Font = new Font("Segoe UI", 9F);
        lblKpiTotalTitle.ForeColor = Color.FromArgb(71, 85, 105);
        lblKpiTotalTitle.Location = new Point(8, 8);
        lblKpiTotalTitle.Name = "lblKpiTotalTitle";
        lblKpiTotalTitle.Size = new Size(108, 25);
        lblKpiTotalTitle.TabIndex = 0;
        lblKpiTotalTitle.Text = "Total Orders";
        // 
        // pnlKpiPending
        // 
        pnlKpiPending.BackColor = Color.White;
        pnlKpiPending.BorderStyle = BorderStyle.FixedSingle;
        pnlKpiPending.Controls.Add(lblPendingOrders);
        pnlKpiPending.Controls.Add(lblKpiPendingTitle);
        pnlKpiPending.Dock = DockStyle.Fill;
        pnlKpiPending.Location = new Point(352, 3);
        pnlKpiPending.Margin = new Padding(3);
        pnlKpiPending.Name = "pnlKpiPending";
        pnlKpiPending.Padding = new Padding(8, 4, 8, 4);
        pnlKpiPending.Size = new Size(343, 41);
        pnlKpiPending.TabIndex = 1;
        // 
        // lblPendingOrders
        // 
        lblPendingOrders.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblPendingOrders.AutoSize = true;
        lblPendingOrders.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblPendingOrders.ForeColor = Color.FromArgb(15, 23, 42);
        lblPendingOrders.Location = new Point(280, 5);
        lblPendingOrders.Name = "lblPendingOrders";
        lblPendingOrders.Size = new Size(28, 32);
        lblPendingOrders.TabIndex = 1;
        lblPendingOrders.Text = "2";
        // 
        // lblKpiPendingTitle
        // 
        lblKpiPendingTitle.AutoSize = true;
        lblKpiPendingTitle.Font = new Font("Segoe UI", 9F);
        lblKpiPendingTitle.ForeColor = Color.FromArgb(71, 85, 105);
        lblKpiPendingTitle.Location = new Point(8, 8);
        lblKpiPendingTitle.Name = "lblKpiPendingTitle";
        lblKpiPendingTitle.Size = new Size(77, 25);
        lblKpiPendingTitle.TabIndex = 0;
        lblKpiPendingTitle.Text = "Pending";
        // 
        // pnlKpiPreparing
        // 
        pnlKpiPreparing.BackColor = Color.White;
        pnlKpiPreparing.BorderStyle = BorderStyle.FixedSingle;
        pnlKpiPreparing.Controls.Add(lblPreparingOrders);
        pnlKpiPreparing.Controls.Add(lblKpiPrepTitle);
        pnlKpiPreparing.Dock = DockStyle.Fill;
        pnlKpiPreparing.Location = new Point(701, 3);
        pnlKpiPreparing.Margin = new Padding(3);
        pnlKpiPreparing.Name = "pnlKpiPreparing";
        pnlKpiPreparing.Padding = new Padding(8, 4, 8, 4);
        pnlKpiPreparing.Size = new Size(344, 41);
        pnlKpiPreparing.TabIndex = 2;
        // 
        // lblPreparingOrders
        // 
        lblPreparingOrders.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblPreparingOrders.AutoSize = true;
        lblPreparingOrders.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblPreparingOrders.ForeColor = Color.FromArgb(15, 23, 42);
        lblPreparingOrders.Location = new Point(280, 5);
        lblPreparingOrders.Name = "lblPreparingOrders";
        lblPreparingOrders.Size = new Size(28, 32);
        lblPreparingOrders.TabIndex = 1;
        lblPreparingOrders.Text = "3";
        // 
        // lblKpiPrepTitle
        // 
        lblKpiPrepTitle.AutoSize = true;
        lblKpiPrepTitle.Font = new Font("Segoe UI", 9F);
        lblKpiPrepTitle.ForeColor = Color.FromArgb(71, 85, 105);
        lblKpiPrepTitle.Location = new Point(8, 8);
        lblKpiPrepTitle.Name = "lblKpiPrepTitle";
        lblKpiPrepTitle.Size = new Size(87, 25);
        lblKpiPrepTitle.TabIndex = 0;
        lblKpiPrepTitle.Text = "Preparing";
        // 
        // pnlKpiReady
        // 
        pnlKpiReady.BackColor = Color.White;
        pnlKpiReady.BorderStyle = BorderStyle.FixedSingle;
        pnlKpiReady.Controls.Add(lblReadyOrders);
        pnlKpiReady.Controls.Add(lblKpiReadyTitle);
        pnlKpiReady.Dock = DockStyle.Fill;
        pnlKpiReady.Location = new Point(3, 50);
        pnlKpiReady.Margin = new Padding(3);
        pnlKpiReady.Name = "pnlKpiReady";
        pnlKpiReady.Padding = new Padding(8, 4, 8, 4);
        pnlKpiReady.Size = new Size(343, 42);
        pnlKpiReady.TabIndex = 3;
        // 
        // lblReadyOrders
        // 
        lblReadyOrders.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblReadyOrders.AutoSize = true;
        lblReadyOrders.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblReadyOrders.ForeColor = Color.FromArgb(15, 23, 42);
        lblReadyOrders.Location = new Point(280, 5);
        lblReadyOrders.Name = "lblReadyOrders";
        lblReadyOrders.Size = new Size(28, 32);
        lblReadyOrders.TabIndex = 1;
        lblReadyOrders.Text = "2";
        // 
        // lblKpiReadyTitle
        // 
        lblKpiReadyTitle.AutoSize = true;
        lblKpiReadyTitle.Font = new Font("Segoe UI", 9F);
        lblKpiReadyTitle.ForeColor = Color.FromArgb(71, 85, 105);
        lblKpiReadyTitle.Location = new Point(8, 8);
        lblKpiReadyTitle.Name = "lblKpiReadyTitle";
        lblKpiReadyTitle.Size = new Size(61, 25);
        lblKpiReadyTitle.TabIndex = 0;
        lblKpiReadyTitle.Text = "Ready";
        // 
        // pnlKpiCompleted
        // 
        pnlKpiCompleted.BackColor = Color.White;
        pnlKpiCompleted.BorderStyle = BorderStyle.FixedSingle;
        pnlKpiCompleted.Controls.Add(lblCompletedOrders);
        pnlKpiCompleted.Controls.Add(lblKpiCompTitle);
        pnlKpiCompleted.Dock = DockStyle.Fill;
        pnlKpiCompleted.Location = new Point(352, 50);
        pnlKpiCompleted.Margin = new Padding(3);
        pnlKpiCompleted.Name = "pnlKpiCompleted";
        pnlKpiCompleted.Padding = new Padding(8, 4, 8, 4);
        pnlKpiCompleted.Size = new Size(343, 42);
        pnlKpiCompleted.TabIndex = 4;
        // 
        // lblCompletedOrders
        // 
        lblCompletedOrders.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblCompletedOrders.AutoSize = true;
        lblCompletedOrders.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblCompletedOrders.ForeColor = Color.FromArgb(15, 23, 42);
        lblCompletedOrders.Location = new Point(280, 5);
        lblCompletedOrders.Name = "lblCompletedOrders";
        lblCompletedOrders.Size = new Size(28, 32);
        lblCompletedOrders.TabIndex = 1;
        lblCompletedOrders.Text = "5";
        // 
        // lblKpiCompTitle
        // 
        lblKpiCompTitle.AutoSize = true;
        lblKpiCompTitle.Font = new Font("Segoe UI", 9F);
        lblKpiCompTitle.ForeColor = Color.FromArgb(71, 85, 105);
        lblKpiCompTitle.Location = new Point(8, 8);
        lblKpiCompTitle.Name = "lblKpiCompTitle";
        lblKpiCompTitle.Size = new Size(100, 25);
        lblKpiCompTitle.TabIndex = 0;
        lblKpiCompTitle.Text = "Completed";
        // 
        // pnlKpiValue
        // 
        pnlKpiValue.BackColor = Color.White;
        pnlKpiValue.BorderStyle = BorderStyle.FixedSingle;
        pnlKpiValue.Controls.Add(lblCompletedValue);
        pnlKpiValue.Controls.Add(lblKpiValTitle);
        pnlKpiValue.Dock = DockStyle.Fill;
        pnlKpiValue.Location = new Point(701, 50);
        pnlKpiValue.Margin = new Padding(3);
        pnlKpiValue.Name = "pnlKpiValue";
        pnlKpiValue.Padding = new Padding(8, 4, 8, 4);
        pnlKpiValue.Size = new Size(344, 42);
        pnlKpiValue.TabIndex = 5;
        // 
        // lblCompletedValue
        // 
        lblCompletedValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblCompletedValue.AutoSize = true;
        lblCompletedValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblCompletedValue.ForeColor = Color.FromArgb(15, 23, 42);
        lblCompletedValue.Location = new Point(190, 5);
        lblCompletedValue.Name = "lblCompletedValue";
        lblCompletedValue.Size = new Size(125, 32);
        lblCompletedValue.TabIndex = 1;
        lblCompletedValue.Text = "1,850 ETB";
        // 
        // lblKpiValTitle
        // 
        lblKpiValTitle.AutoSize = true;
        lblKpiValTitle.Font = new Font("Segoe UI", 9F);
        lblKpiValTitle.ForeColor = Color.FromArgb(71, 85, 105);
        lblKpiValTitle.Location = new Point(8, 8);
        lblKpiValTitle.Name = "lblKpiValTitle";
        lblKpiValTitle.Size = new Size(147, 25);
        lblKpiValTitle.TabIndex = 0;
        lblKpiValTitle.Text = "Completed Value";
        // 
        // grpOrderSummary
        // 
        grpOrderSummary.BackColor = Color.Transparent;
        grpOrderSummary.Controls.Add(dgvSummary);
        grpOrderSummary.Controls.Add(pnlBreakdownHeader);
        grpOrderSummary.Dock = DockStyle.Fill;
        grpOrderSummary.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        grpOrderSummary.ForeColor = Color.FromArgb(15, 23, 42);
        grpOrderSummary.Location = new Point(24, 272);
        grpOrderSummary.Name = "grpOrderSummary";
        grpOrderSummary.Padding = new Padding(12, 10, 12, 12);
        grpOrderSummary.Size = new Size(1072, 261);
        grpOrderSummary.TabIndex = 3;
        grpOrderSummary.TabStop = false;
        grpOrderSummary.Text = "Order Breakdown";
        // 
        // dgvSummary
        // 
        dgvSummary.AllowUserToAddRows = false;
        dgvSummary.AllowUserToDeleteRows = false;
        dgvSummary.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
        dgvSummary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvSummary.BackgroundColor = Color.White;
        dgvSummary.BorderStyle = BorderStyle.Fixed3D;
        dgvSummary.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle2.Padding = new Padding(4, 6, 4, 6);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        dgvSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvSummary.Columns.AddRange(new DataGridViewColumn[] { colOrderNum, colCustomer, colTable, colCreated, colTotal, colStatus });
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.White;
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle3.Padding = new Padding(4);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(219, 234, 254);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        dgvSummary.DefaultCellStyle = dataGridViewCellStyle3;
        dgvSummary.Dock = DockStyle.Fill;
        dgvSummary.EnableHeadersVisualStyles = false;
        dgvSummary.GridColor = Color.FromArgb(226, 232, 240);
        dgvSummary.Location = new Point(12, 63);
        dgvSummary.MultiSelect = false;
        dgvSummary.Name = "dgvSummary";
        dgvSummary.ReadOnly = true;
        dgvSummary.RowHeadersVisible = false;
        dgvSummary.RowHeadersWidth = 51;
        dgvSummary.RowTemplate.Height = 36;
        dgvSummary.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvSummary.Size = new Size(1048, 186);
        dgvSummary.TabIndex = 1;
        dgvSummary.CellDoubleClick += dgvSummary_CellDoubleClick;
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
        // pnlBreakdownHeader
        // 
        pnlBreakdownHeader.Controls.Add(lblBreakdownSubtitle);
        pnlBreakdownHeader.Dock = DockStyle.Top;
        pnlBreakdownHeader.Location = new Point(12, 37);
        pnlBreakdownHeader.Name = "pnlBreakdownHeader";
        pnlBreakdownHeader.Size = new Size(1048, 26);
        pnlBreakdownHeader.TabIndex = 0;
        // 
        // lblBreakdownSubtitle
        // 
        lblBreakdownSubtitle.AutoSize = true;
        lblBreakdownSubtitle.Font = new Font("Segoe UI", 9F);
        lblBreakdownSubtitle.ForeColor = Color.FromArgb(71, 85, 105);
        lblBreakdownSubtitle.Location = new Point(0, 3);
        lblBreakdownSubtitle.Name = "lblBreakdownSubtitle";
        lblBreakdownSubtitle.Size = new Size(247, 25);
        lblBreakdownSubtitle.TabIndex = 0;
        lblBreakdownSubtitle.Text = "Filtered orders list breakdown";
        // 
        // ReportsView
        // 
        AutoScaleDimensions = new SizeF(144F, 144F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.FromArgb(243, 244, 246);
        Controls.Add(grpOrderSummary);
        Controls.Add(grpSummaryCards);
        Controls.Add(grpFilters);
        Controls.Add(pnlHeader);
        Name = "ReportsView";
        Padding = new Padding(24, 16, 24, 20);
        Size = new Size(1120, 553);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        grpFilters.ResumeLayout(false);
        grpFilters.PerformLayout();
        grpSummaryCards.ResumeLayout(false);
        tlpKpi.ResumeLayout(false);
        pnlKpiTotal.ResumeLayout(false);
        pnlKpiTotal.PerformLayout();
        pnlKpiPending.ResumeLayout(false);
        pnlKpiPending.PerformLayout();
        pnlKpiPreparing.ResumeLayout(false);
        pnlKpiPreparing.PerformLayout();
        pnlKpiReady.ResumeLayout(false);
        pnlKpiReady.PerformLayout();
        pnlKpiCompleted.ResumeLayout(false);
        pnlKpiCompleted.PerformLayout();
        pnlKpiValue.ResumeLayout(false);
        pnlKpiValue.PerformLayout();
        grpOrderSummary.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvSummary).EndInit();
        pnlBreakdownHeader.ResumeLayout(false);
        pnlBreakdownHeader.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.GroupBox grpFilters;
    private System.Windows.Forms.Label lblDateFilter;
    private System.Windows.Forms.ComboBox cboDateFilter;
    private System.Windows.Forms.Label lblStatusFilter;
    private System.Windows.Forms.ComboBox cboStatusFilter;
    private System.Windows.Forms.Button btnClearFilters;
    private System.Windows.Forms.GroupBox grpSummaryCards;
    private System.Windows.Forms.TableLayoutPanel tlpKpi;
    private System.Windows.Forms.Panel pnlKpiTotal;
    private System.Windows.Forms.Label lblTotalOrders;
    private System.Windows.Forms.Label lblKpiTotalTitle;
    private System.Windows.Forms.Panel pnlKpiPending;
    private System.Windows.Forms.Label lblPendingOrders;
    private System.Windows.Forms.Label lblKpiPendingTitle;
    private System.Windows.Forms.Panel pnlKpiPreparing;
    private System.Windows.Forms.Label lblPreparingOrders;
    private System.Windows.Forms.Label lblKpiPrepTitle;
    private System.Windows.Forms.Panel pnlKpiReady;
    private System.Windows.Forms.Label lblReadyOrders;
    private System.Windows.Forms.Label lblKpiReadyTitle;
    private System.Windows.Forms.Panel pnlKpiCompleted;
    private System.Windows.Forms.Label lblCompletedOrders;
    private System.Windows.Forms.Label lblKpiCompTitle;
    private System.Windows.Forms.Panel pnlKpiValue;
    private System.Windows.Forms.Label lblCompletedValue;
    private System.Windows.Forms.Label lblKpiValTitle;
    private System.Windows.Forms.GroupBox grpOrderSummary;
    private System.Windows.Forms.Panel pnlBreakdownHeader;
    private System.Windows.Forms.Label lblBreakdownSubtitle;
    private System.Windows.Forms.DataGridView dgvSummary;
    private System.Windows.Forms.DataGridViewTextBoxColumn colOrderNum;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCustomer;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTable;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCreated;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
    private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
}
