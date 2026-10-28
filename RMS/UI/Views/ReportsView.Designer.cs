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
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
        pnlHeader = new Panel();
        lblSubtitle = new Label();
        lblTitle = new Label();
        grpFilters = new GroupBox();
        lblFilterNote = new Label();
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
        lblSummaryFooter = new Label();
        pnlBreakdownHeader = new Panel();
        lblTimesNote = new Label();
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
        pnlHeader.Controls.Add(lblSubtitle);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Location = new Point(24, 16);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new Size(1072, 56);
        pnlHeader.TabIndex = 0;
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new Font("Segoe UI", 9F);
        lblSubtitle.ForeColor = Color.FromArgb(71, 85, 105);
        lblSubtitle.Location = new Point(218, 17);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(393, 25);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Review order activity and completed order value";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
        lblTitle.Location = new Point(12, -3);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(137, 45);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Reports";
        // 
        // grpFilters
        // 
        grpFilters.BackColor = Color.Transparent;
        grpFilters.Controls.Add(lblFilterNote);
        grpFilters.Controls.Add(btnClearFilters);
        grpFilters.Controls.Add(cboStatusFilter);
        grpFilters.Controls.Add(lblStatusFilter);
        grpFilters.Controls.Add(cboDateFilter);
        grpFilters.Controls.Add(lblDateFilter);
        grpFilters.Dock = DockStyle.Top;
        grpFilters.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        grpFilters.ForeColor = Color.FromArgb(15, 23, 42);
        grpFilters.Location = new Point(24, 72);
        grpFilters.Name = "grpFilters";
        grpFilters.Size = new Size(1072, 75);
        grpFilters.TabIndex = 1;
        grpFilters.TabStop = false;
        grpFilters.Text = "Report Filters";
        // 
        // lblFilterNote
        // 
        lblFilterNote.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblFilterNote.Font = new Font("Segoe UI", 8.5F);
        lblFilterNote.ForeColor = Color.FromArgb(71, 85, 105);
        lblFilterNote.Location = new Point(696, 30);
        lblFilterNote.Name = "lblFilterNote";
        lblFilterNote.Size = new Size(364, 25);
        lblFilterNote.TabIndex = 5;
        lblFilterNote.Text = "Filters apply to summary cards and order breakdown";
        lblFilterNote.TextAlign = ContentAlignment.MiddleRight;
        lblFilterNote.Click += lblFilterNote_Click;
        // 
        // btnClearFilters
        // 
        btnClearFilters.BackColor = Color.White;
        btnClearFilters.Cursor = Cursors.Hand;
        btnClearFilters.FlatStyle = FlatStyle.System;
        btnClearFilters.Font = new Font("Segoe UI", 9F);
        btnClearFilters.Location = new Point(495, 27);
        btnClearFilters.Name = "btnClearFilters";
        btnClearFilters.Size = new Size(124, 31);
        btnClearFilters.TabIndex = 4;
        btnClearFilters.Text = "Reset Filters";
        btnClearFilters.UseVisualStyleBackColor = false;
        btnClearFilters.Click += btnClearFilters_Click;
        // 
        // cboStatusFilter
        // 
        cboStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        cboStatusFilter.Font = new Font("Segoe UI", 9.5F);
        cboStatusFilter.FormattingEnabled = true;
        cboStatusFilter.Items.AddRange(new object[] { "All Statuses", "Pending", "Preparing", "Ready", "Completed" });
        cboStatusFilter.Location = new Point(340, 28);
        cboStatusFilter.Name = "cboStatusFilter";
        cboStatusFilter.Size = new Size(140, 33);
        cboStatusFilter.TabIndex = 3;
        cboStatusFilter.SelectedIndexChanged += cboStatusFilter_SelectedIndexChanged;
        // 
        // lblStatusFilter
        // 
        lblStatusFilter.AutoSize = true;
        lblStatusFilter.Font = new Font("Segoe UI", 9.5F);
        lblStatusFilter.Location = new Point(280, 31);
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
        cboDateFilter.Location = new Point(105, 28);
        cboDateFilter.Name = "cboDateFilter";
        cboDateFilter.Size = new Size(150, 33);
        cboDateFilter.TabIndex = 1;
        cboDateFilter.SelectedIndexChanged += cboDateFilter_SelectedIndexChanged;
        // 
        // lblDateFilter
        // 
        lblDateFilter.AutoSize = true;
        lblDateFilter.Font = new Font("Segoe UI", 9.5F);
        lblDateFilter.Location = new Point(14, 31);
        lblDateFilter.Name = "lblDateFilter";
        lblDateFilter.Size = new Size(113, 25);
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
        grpSummaryCards.Location = new Point(24, 147);
        grpSummaryCards.Name = "grpSummaryCards";
        grpSummaryCards.Padding = new Padding(12, 10, 12, 12);
        grpSummaryCards.Size = new Size(1072, 175);
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
        tlpKpi.Location = new Point(12, 37);
        tlpKpi.Name = "tlpKpi";
        tlpKpi.RowCount = 2;
        tlpKpi.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tlpKpi.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tlpKpi.Size = new Size(1048, 126);
        tlpKpi.TabIndex = 0;
        // 
        // pnlKpiTotal
        // 
        pnlKpiTotal.BackColor = Color.White;
        pnlKpiTotal.BorderStyle = BorderStyle.FixedSingle;
        pnlKpiTotal.Controls.Add(lblTotalOrders);
        pnlKpiTotal.Controls.Add(lblKpiTotalTitle);
        pnlKpiTotal.Dock = DockStyle.Fill;
        pnlKpiTotal.Location = new Point(4, 4);
        pnlKpiTotal.Margin = new Padding(4);
        pnlKpiTotal.Name = "pnlKpiTotal";
        pnlKpiTotal.Padding = new Padding(10, 6, 10, 6);
        pnlKpiTotal.Size = new Size(341, 55);
        pnlKpiTotal.TabIndex = 0;
        // 
        // lblTotalOrders
        // 
        lblTotalOrders.AutoSize = true;
        lblTotalOrders.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        lblTotalOrders.ForeColor = Color.FromArgb(30, 58, 95);
        lblTotalOrders.Location = new Point(8, 22);
        lblTotalOrders.Name = "lblTotalOrders";
        lblTotalOrders.Size = new Size(52, 41);
        lblTotalOrders.TabIndex = 1;
        lblTotalOrders.Text = "12";
        // 
        // lblKpiTotalTitle
        // 
        lblKpiTotalTitle.AutoSize = true;
        lblKpiTotalTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblKpiTotalTitle.ForeColor = Color.FromArgb(71, 85, 105);
        lblKpiTotalTitle.Location = new Point(8, 4);
        lblKpiTotalTitle.Name = "lblKpiTotalTitle";
        lblKpiTotalTitle.Size = new Size(108, 23);
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
        pnlKpiPending.Location = new Point(353, 4);
        pnlKpiPending.Margin = new Padding(4);
        pnlKpiPending.Name = "pnlKpiPending";
        pnlKpiPending.Padding = new Padding(10, 6, 10, 6);
        pnlKpiPending.Size = new Size(341, 55);
        pnlKpiPending.TabIndex = 1;
        // 
        // lblPendingOrders
        // 
        lblPendingOrders.AutoSize = true;
        lblPendingOrders.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        lblPendingOrders.ForeColor = Color.FromArgb(180, 83, 9);
        lblPendingOrders.Location = new Point(8, 22);
        lblPendingOrders.Name = "lblPendingOrders";
        lblPendingOrders.Size = new Size(35, 41);
        lblPendingOrders.TabIndex = 1;
        lblPendingOrders.Text = "2";
        // 
        // lblKpiPendingTitle
        // 
        lblKpiPendingTitle.AutoSize = true;
        lblKpiPendingTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblKpiPendingTitle.ForeColor = Color.FromArgb(71, 85, 105);
        lblKpiPendingTitle.Location = new Point(8, 4);
        lblKpiPendingTitle.Name = "lblKpiPendingTitle";
        lblKpiPendingTitle.Size = new Size(134, 23);
        lblKpiPendingTitle.TabIndex = 0;
        lblKpiPendingTitle.Text = "Pending Orders";
        // 
        // pnlKpiPreparing
        // 
        pnlKpiPreparing.BackColor = Color.White;
        pnlKpiPreparing.BorderStyle = BorderStyle.FixedSingle;
        pnlKpiPreparing.Controls.Add(lblPreparingOrders);
        pnlKpiPreparing.Controls.Add(lblKpiPrepTitle);
        pnlKpiPreparing.Dock = DockStyle.Fill;
        pnlKpiPreparing.Location = new Point(702, 4);
        pnlKpiPreparing.Margin = new Padding(4);
        pnlKpiPreparing.Name = "pnlKpiPreparing";
        pnlKpiPreparing.Padding = new Padding(10, 6, 10, 6);
        pnlKpiPreparing.Size = new Size(342, 55);
        pnlKpiPreparing.TabIndex = 2;
        // 
        // lblPreparingOrders
        // 
        lblPreparingOrders.AutoSize = true;
        lblPreparingOrders.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        lblPreparingOrders.ForeColor = Color.FromArgb(194, 65, 12);
        lblPreparingOrders.Location = new Point(8, 22);
        lblPreparingOrders.Name = "lblPreparingOrders";
        lblPreparingOrders.Size = new Size(35, 41);
        lblPreparingOrders.TabIndex = 1;
        lblPreparingOrders.Text = "3";
        // 
        // lblKpiPrepTitle
        // 
        lblKpiPrepTitle.AutoSize = true;
        lblKpiPrepTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblKpiPrepTitle.ForeColor = Color.FromArgb(71, 85, 105);
        lblKpiPrepTitle.Location = new Point(8, 4);
        lblKpiPrepTitle.Name = "lblKpiPrepTitle";
        lblKpiPrepTitle.Size = new Size(148, 23);
        lblKpiPrepTitle.TabIndex = 0;
        lblKpiPrepTitle.Text = "Preparing Orders";
        // 
        // pnlKpiReady
        // 
        pnlKpiReady.BackColor = Color.White;
        pnlKpiReady.BorderStyle = BorderStyle.FixedSingle;
        pnlKpiReady.Controls.Add(lblReadyOrders);
        pnlKpiReady.Controls.Add(lblKpiReadyTitle);
        pnlKpiReady.Dock = DockStyle.Fill;
        pnlKpiReady.Location = new Point(4, 67);
        pnlKpiReady.Margin = new Padding(4);
        pnlKpiReady.Name = "pnlKpiReady";
        pnlKpiReady.Padding = new Padding(10, 6, 10, 6);
        pnlKpiReady.Size = new Size(341, 55);
        pnlKpiReady.TabIndex = 3;
        // 
        // lblReadyOrders
        // 
        lblReadyOrders.AutoSize = true;
        lblReadyOrders.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        lblReadyOrders.ForeColor = Color.FromArgb(16, 149, 93);
        lblReadyOrders.Location = new Point(8, 22);
        lblReadyOrders.Name = "lblReadyOrders";
        lblReadyOrders.Size = new Size(35, 41);
        lblReadyOrders.TabIndex = 1;
        lblReadyOrders.Text = "2";
        // 
        // lblKpiReadyTitle
        // 
        lblKpiReadyTitle.AutoSize = true;
        lblKpiReadyTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblKpiReadyTitle.ForeColor = Color.FromArgb(71, 85, 105);
        lblKpiReadyTitle.Location = new Point(8, 4);
        lblKpiReadyTitle.Name = "lblKpiReadyTitle";
        lblKpiReadyTitle.Size = new Size(118, 23);
        lblKpiReadyTitle.TabIndex = 0;
        lblKpiReadyTitle.Text = "Ready Orders";
        // 
        // pnlKpiCompleted
        // 
        pnlKpiCompleted.BackColor = Color.White;
        pnlKpiCompleted.BorderStyle = BorderStyle.FixedSingle;
        pnlKpiCompleted.Controls.Add(lblCompletedOrders);
        pnlKpiCompleted.Controls.Add(lblKpiCompTitle);
        pnlKpiCompleted.Dock = DockStyle.Fill;
        pnlKpiCompleted.Location = new Point(353, 67);
        pnlKpiCompleted.Margin = new Padding(4);
        pnlKpiCompleted.Name = "pnlKpiCompleted";
        pnlKpiCompleted.Padding = new Padding(10, 6, 10, 6);
        pnlKpiCompleted.Size = new Size(341, 55);
        pnlKpiCompleted.TabIndex = 4;
        // 
        // lblCompletedOrders
        // 
        lblCompletedOrders.AutoSize = true;
        lblCompletedOrders.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        lblCompletedOrders.ForeColor = Color.FromArgb(71, 85, 105);
        lblCompletedOrders.Location = new Point(8, 22);
        lblCompletedOrders.Name = "lblCompletedOrders";
        lblCompletedOrders.Size = new Size(35, 41);
        lblCompletedOrders.TabIndex = 1;
        lblCompletedOrders.Text = "5";
        // 
        // lblKpiCompTitle
        // 
        lblKpiCompTitle.AutoSize = true;
        lblKpiCompTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblKpiCompTitle.ForeColor = Color.FromArgb(71, 85, 105);
        lblKpiCompTitle.Location = new Point(8, 4);
        lblKpiCompTitle.Name = "lblKpiCompTitle";
        lblKpiCompTitle.Size = new Size(158, 23);
        lblKpiCompTitle.TabIndex = 0;
        lblKpiCompTitle.Text = "Completed Orders";
        // 
        // pnlKpiValue
        // 
        pnlKpiValue.BackColor = Color.White;
        pnlKpiValue.BorderStyle = BorderStyle.FixedSingle;
        pnlKpiValue.Controls.Add(lblCompletedValue);
        pnlKpiValue.Controls.Add(lblKpiValTitle);
        pnlKpiValue.Dock = DockStyle.Fill;
        pnlKpiValue.Location = new Point(702, 67);
        pnlKpiValue.Margin = new Padding(4);
        pnlKpiValue.Name = "pnlKpiValue";
        pnlKpiValue.Padding = new Padding(10, 6, 10, 6);
        pnlKpiValue.Size = new Size(342, 55);
        pnlKpiValue.TabIndex = 5;
        // 
        // lblCompletedValue
        // 
        lblCompletedValue.AutoSize = true;
        lblCompletedValue.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        lblCompletedValue.ForeColor = Color.FromArgb(30, 58, 95);
        lblCompletedValue.Location = new Point(8, 22);
        lblCompletedValue.Name = "lblCompletedValue";
        lblCompletedValue.Size = new Size(155, 41);
        lblCompletedValue.TabIndex = 1;
        lblCompletedValue.Text = "1,850 ETB";
        // 
        // lblKpiValTitle
        // 
        lblKpiValTitle.AutoSize = true;
        lblKpiValTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblKpiValTitle.ForeColor = Color.FromArgb(71, 85, 105);
        lblKpiValTitle.Location = new Point(8, 4);
        lblKpiValTitle.Name = "lblKpiValTitle";
        lblKpiValTitle.Size = new Size(147, 23);
        lblKpiValTitle.TabIndex = 0;
        lblKpiValTitle.Text = "Completed Value";
        // 
        // grpOrderSummary
        // 
        grpOrderSummary.BackColor = Color.Transparent;
        grpOrderSummary.Controls.Add(dgvSummary);
        grpOrderSummary.Controls.Add(lblSummaryFooter);
        grpOrderSummary.Controls.Add(pnlBreakdownHeader);
        grpOrderSummary.Dock = DockStyle.Fill;
        grpOrderSummary.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        grpOrderSummary.ForeColor = Color.FromArgb(15, 23, 42);
        grpOrderSummary.Location = new Point(24, 322);
        grpOrderSummary.Name = "grpOrderSummary";
        grpOrderSummary.Padding = new Padding(12, 10, 12, 12);
        grpOrderSummary.Size = new Size(1072, 211);
        grpOrderSummary.TabIndex = 3;
        grpOrderSummary.TabStop = false;
        grpOrderSummary.Text = "Order Breakdown";
        // 
        // dgvSummary
        // 
        dgvSummary.AllowUserToAddRows = false;
        dgvSummary.AllowUserToDeleteRows = false;
        dgvSummary.AllowUserToResizeRows = false;
        dataGridViewCellStyle4.BackColor = Color.FromArgb(248, 250, 252);
        dgvSummary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
        dgvSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvSummary.BackgroundColor = Color.White;
        dgvSummary.BorderStyle = BorderStyle.Fixed3D;
        dgvSummary.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle5.BackColor = Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        dataGridViewCellStyle5.ForeColor = Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle5.Padding = new Padding(4, 6, 4, 6);
        dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
        dgvSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
        dgvSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvSummary.Columns.AddRange(new DataGridViewColumn[] { colOrderNum, colCustomer, colTable, colCreated, colTotal, colStatus });
        dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle6.BackColor = Color.White;
        dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.5F);
        dataGridViewCellStyle6.ForeColor = Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle6.Padding = new Padding(4);
        dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(219, 234, 254);
        dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
        dgvSummary.DefaultCellStyle = dataGridViewCellStyle6;
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
        dgvSummary.Size = new Size(1048, 110);
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
        // lblSummaryFooter
        // 
        lblSummaryFooter.Dock = DockStyle.Bottom;
        lblSummaryFooter.Font = new Font("Segoe UI", 8.5F);
        lblSummaryFooter.ForeColor = Color.FromArgb(107, 114, 128);
        lblSummaryFooter.Location = new Point(12, 173);
        lblSummaryFooter.Name = "lblSummaryFooter";
        lblSummaryFooter.Size = new Size(1048, 26);
        lblSummaryFooter.TabIndex = 2;
        lblSummaryFooter.Text = "Summary cards cover all orders; completed order value totals completed orders only.";
        lblSummaryFooter.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // pnlBreakdownHeader
        // 
        pnlBreakdownHeader.Controls.Add(lblTimesNote);
        pnlBreakdownHeader.Controls.Add(lblBreakdownSubtitle);
        pnlBreakdownHeader.Dock = DockStyle.Top;
        pnlBreakdownHeader.Location = new Point(12, 37);
        pnlBreakdownHeader.Name = "pnlBreakdownHeader";
        pnlBreakdownHeader.Size = new Size(1048, 26);
        pnlBreakdownHeader.TabIndex = 0;
        // 
        // lblTimesNote
        // 
        lblTimesNote.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblTimesNote.AutoSize = true;
        lblTimesNote.Font = new Font("Segoe UI", 8.5F);
        lblTimesNote.ForeColor = Color.FromArgb(107, 114, 128);
        lblTimesNote.Location = new Point(898, 3);
        lblTimesNote.Name = "lblTimesNote";
        lblTimesNote.Size = new Size(185, 23);
        lblTimesNote.TabIndex = 1;
        lblTimesNote.Text = "Created times are local";
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
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.GroupBox grpFilters;
    private System.Windows.Forms.Label lblDateFilter;
    private System.Windows.Forms.ComboBox cboDateFilter;
    private System.Windows.Forms.Label lblStatusFilter;
    private System.Windows.Forms.ComboBox cboStatusFilter;
    private System.Windows.Forms.Button btnClearFilters;
    private System.Windows.Forms.Label lblFilterNote;
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
    private System.Windows.Forms.Label lblTimesNote;
    private System.Windows.Forms.DataGridView dgvSummary;
    private System.Windows.Forms.DataGridViewTextBoxColumn colOrderNum;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCustomer;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTable;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCreated;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
    private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    private System.Windows.Forms.Label lblSummaryFooter;
}

