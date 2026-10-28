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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        this.pnlHeader = new System.Windows.Forms.Panel();
        this.lblSubtitle = new System.Windows.Forms.Label();
        this.lblTitle = new System.Windows.Forms.Label();
        this.grpFilters = new System.Windows.Forms.GroupBox();
        this.lblFilterNote = new System.Windows.Forms.Label();
        this.btnClearFilters = new System.Windows.Forms.Button();
        this.cboStatusFilter = new System.Windows.Forms.ComboBox();
        this.lblStatusFilter = new System.Windows.Forms.Label();
        this.cboDateFilter = new System.Windows.Forms.ComboBox();
        this.lblDateFilter = new System.Windows.Forms.Label();
        this.grpSummaryCards = new System.Windows.Forms.GroupBox();
        this.tlpKpi = new System.Windows.Forms.TableLayoutPanel();
        this.pnlKpiTotal = new System.Windows.Forms.Panel();
        this.lblTotalOrders = new System.Windows.Forms.Label();
        this.lblKpiTotalTitle = new System.Windows.Forms.Label();
        this.pnlKpiPending = new System.Windows.Forms.Panel();
        this.lblPendingOrders = new System.Windows.Forms.Label();
        this.lblKpiPendingTitle = new System.Windows.Forms.Label();
        this.pnlKpiPreparing = new System.Windows.Forms.Panel();
        this.lblPreparingOrders = new System.Windows.Forms.Label();
        this.lblKpiPrepTitle = new System.Windows.Forms.Label();
        this.pnlKpiReady = new System.Windows.Forms.Panel();
        this.lblReadyOrders = new System.Windows.Forms.Label();
        this.lblKpiReadyTitle = new System.Windows.Forms.Label();
        this.pnlKpiCompleted = new System.Windows.Forms.Panel();
        this.lblCompletedOrders = new System.Windows.Forms.Label();
        this.lblKpiCompTitle = new System.Windows.Forms.Label();
        this.pnlKpiValue = new System.Windows.Forms.Panel();
        this.lblCompletedValue = new System.Windows.Forms.Label();
        this.lblKpiValTitle = new System.Windows.Forms.Label();
        this.grpOrderSummary = new System.Windows.Forms.GroupBox();
        this.dgvSummary = new System.Windows.Forms.DataGridView();
        this.colOrderNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.lblSummaryFooter = new System.Windows.Forms.Label();
        this.pnlBreakdownHeader = new System.Windows.Forms.Panel();
        this.lblTimesNote = new System.Windows.Forms.Label();
        this.lblBreakdownSubtitle = new System.Windows.Forms.Label();
        this.pnlHeader.SuspendLayout();
        this.grpFilters.SuspendLayout();
        this.grpSummaryCards.SuspendLayout();
        this.tlpKpi.SuspendLayout();
        this.pnlKpiTotal.SuspendLayout();
        this.pnlKpiPending.SuspendLayout();
        this.pnlKpiPreparing.SuspendLayout();
        this.pnlKpiReady.SuspendLayout();
        this.pnlKpiCompleted.SuspendLayout();
        this.pnlKpiValue.SuspendLayout();
        this.grpOrderSummary.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).BeginInit();
        this.pnlBreakdownHeader.SuspendLayout();
        this.SuspendLayout();
        // 
        // pnlHeader
        // 
        this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
        this.pnlHeader.Controls.Add(this.lblSubtitle);
        this.pnlHeader.Controls.Add(this.lblTitle);
        this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        this.pnlHeader.Location = new System.Drawing.Point(24, 16);
        this.pnlHeader.Name = "pnlHeader";
        this.pnlHeader.Size = new System.Drawing.Size(996, 56);
        this.pnlHeader.TabIndex = 0;
        // 
        // lblSubtitle
        // 
        this.lblSubtitle.AutoSize = true;
        this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblSubtitle.Location = new System.Drawing.Point(0, 32);
        this.lblSubtitle.Name = "lblSubtitle";
        this.lblSubtitle.Size = new System.Drawing.Size(325, 20);
        this.lblSubtitle.TabIndex = 1;
        this.lblSubtitle.Text = "Review order activity and completed order value";
        // 
        // lblTitle
        // 
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.lblTitle.Location = new System.Drawing.Point(-2, 0);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(117, 37);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Reports";
        // 
        // grpFilters
        // 
        this.grpFilters.BackColor = System.Drawing.Color.Transparent;
        this.grpFilters.Controls.Add(this.lblFilterNote);
        this.grpFilters.Controls.Add(this.btnClearFilters);
        this.grpFilters.Controls.Add(this.cboStatusFilter);
        this.grpFilters.Controls.Add(this.lblStatusFilter);
        this.grpFilters.Controls.Add(this.cboDateFilter);
        this.grpFilters.Controls.Add(this.lblDateFilter);
        this.grpFilters.Dock = System.Windows.Forms.DockStyle.Top;
        this.grpFilters.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.grpFilters.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.grpFilters.Location = new System.Drawing.Point(24, 72);
        this.grpFilters.Name = "grpFilters";
        this.grpFilters.Size = new System.Drawing.Size(996, 75);
        this.grpFilters.TabIndex = 1;
        this.grpFilters.TabStop = false;
        this.grpFilters.Text = "Report Filters";
        // 
        // lblFilterNote
        // 
        this.lblFilterNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.lblFilterNote.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        this.lblFilterNote.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblFilterNote.Location = new System.Drawing.Point(620, 30);
        this.lblFilterNote.Name = "lblFilterNote";
        this.lblFilterNote.Size = new System.Drawing.Size(364, 25);
        this.lblFilterNote.TabIndex = 5;
        this.lblFilterNote.Text = "Filters apply to summary cards and order breakdown";
        this.lblFilterNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // btnClearFilters
        // 
        this.btnClearFilters.BackColor = System.Drawing.Color.White;
        this.btnClearFilters.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.btnClearFilters.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.btnClearFilters.Location = new System.Drawing.Point(495, 27);
        this.btnClearFilters.Name = "btnClearFilters";
        this.btnClearFilters.Size = new System.Drawing.Size(95, 31);
        this.btnClearFilters.TabIndex = 4;
        this.btnClearFilters.Text = "Reset Filters";
        this.btnClearFilters.UseVisualStyleBackColor = false;
        this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
        // 
        // cboStatusFilter
        // 
        this.cboStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboStatusFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.cboStatusFilter.FormattingEnabled = true;
        this.cboStatusFilter.Items.AddRange(new object[] {
            "All Statuses",
            "Pending",
            "Preparing",
            "Ready",
            "Completed"});
        this.cboStatusFilter.Location = new System.Drawing.Point(340, 28);
        this.cboStatusFilter.Name = "cboStatusFilter";
        this.cboStatusFilter.Size = new System.Drawing.Size(140, 29);
        this.cboStatusFilter.TabIndex = 3;
        this.cboStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cboStatusFilter_SelectedIndexChanged);
        // 
        // lblStatusFilter
        // 
        this.lblStatusFilter.AutoSize = true;
        this.lblStatusFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblStatusFilter.Location = new System.Drawing.Point(280, 31);
        this.lblStatusFilter.Name = "lblStatusFilter";
        this.lblStatusFilter.Size = new System.Drawing.Size(55, 21);
        this.lblStatusFilter.TabIndex = 2;
        this.lblStatusFilter.Text = "Status:";
        // 
        // cboDateFilter
        // 
        this.cboDateFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboDateFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.cboDateFilter.FormattingEnabled = true;
        this.cboDateFilter.Items.AddRange(new object[] {
            "All dates",
            "Today"});
        this.cboDateFilter.Location = new System.Drawing.Point(105, 28);
        this.cboDateFilter.Name = "cboDateFilter";
        this.cboDateFilter.Size = new System.Drawing.Size(150, 29);
        this.cboDateFilter.TabIndex = 1;
        this.cboDateFilter.SelectedIndexChanged += new System.EventHandler(this.cboDateFilter_SelectedIndexChanged);
        // 
        // lblDateFilter
        // 
        this.lblDateFilter.AutoSize = true;
        this.lblDateFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblDateFilter.Location = new System.Drawing.Point(14, 31);
        this.lblDateFilter.Name = "lblDateFilter";
        this.lblDateFilter.Size = new System.Drawing.Size(87, 21);
        this.lblDateFilter.TabIndex = 0;
        this.lblDateFilter.Text = "Date Range:";
        // 
        // grpSummaryCards
        // 
        this.grpSummaryCards.BackColor = System.Drawing.Color.Transparent;
        this.grpSummaryCards.Controls.Add(this.tlpKpi);
        this.grpSummaryCards.Dock = System.Windows.Forms.DockStyle.Top;
        this.grpSummaryCards.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.grpSummaryCards.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.grpSummaryCards.Location = new System.Drawing.Point(24, 147);
        this.grpSummaryCards.Name = "grpSummaryCards";
        this.grpSummaryCards.Padding = new System.Windows.Forms.Padding(12, 10, 12, 12);
        this.grpSummaryCards.Size = new System.Drawing.Size(996, 175);
        this.grpSummaryCards.TabIndex = 2;
        this.grpSummaryCards.TabStop = false;
        this.grpSummaryCards.Text = "Performance Summary";
        // 
        // tlpKpi
        // 
        this.tlpKpi.ColumnCount = 3;
        this.tlpKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
        this.tlpKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
        this.tlpKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
        this.tlpKpi.Controls.Add(this.pnlKpiTotal, 0, 0);
        this.tlpKpi.Controls.Add(this.pnlKpiPending, 1, 0);
        this.tlpKpi.Controls.Add(this.pnlKpiPreparing, 2, 0);
        this.tlpKpi.Controls.Add(this.pnlKpiReady, 0, 1);
        this.tlpKpi.Controls.Add(this.pnlKpiCompleted, 1, 1);
        this.tlpKpi.Controls.Add(this.pnlKpiValue, 2, 1);
        this.tlpKpi.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tlpKpi.Location = new System.Drawing.Point(12, 33);
        this.tlpKpi.Name = "tlpKpi";
        this.tlpKpi.RowCount = 2;
        this.tlpKpi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tlpKpi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tlpKpi.Size = new System.Drawing.Size(972, 130);
        this.tlpKpi.TabIndex = 0;
        // 
        // pnlKpiTotal
        // 
        this.pnlKpiTotal.BackColor = System.Drawing.Color.White;
        this.pnlKpiTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlKpiTotal.Controls.Add(this.lblTotalOrders);
        this.pnlKpiTotal.Controls.Add(this.lblKpiTotalTitle);
        this.pnlKpiTotal.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlKpiTotal.Location = new System.Drawing.Point(4, 4);
        this.pnlKpiTotal.Margin = new System.Windows.Forms.Padding(4);
        this.pnlKpiTotal.Name = "pnlKpiTotal";
        this.pnlKpiTotal.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
        this.pnlKpiTotal.Size = new System.Drawing.Size(315, 57);
        this.pnlKpiTotal.TabIndex = 0;
        // 
        // lblTotalOrders
        // 
        this.lblTotalOrders.AutoSize = true;
        this.lblTotalOrders.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        this.lblTotalOrders.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
        this.lblTotalOrders.Location = new System.Drawing.Point(8, 22);
        this.lblTotalOrders.Name = "lblTotalOrders";
        this.lblTotalOrders.Size = new System.Drawing.Size(43, 35);
        this.lblTotalOrders.TabIndex = 1;
        this.lblTotalOrders.Text = "12";
        // 
        // lblKpiTotalTitle
        // 
        this.lblKpiTotalTitle.AutoSize = true;
        this.lblKpiTotalTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        this.lblKpiTotalTitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblKpiTotalTitle.Location = new System.Drawing.Point(8, 4);
        this.lblKpiTotalTitle.Name = "lblKpiTotalTitle";
        this.lblKpiTotalTitle.Size = new System.Drawing.Size(95, 20);
        this.lblKpiTotalTitle.TabIndex = 0;
        this.lblKpiTotalTitle.Text = "Total Orders";
        // 
        // pnlKpiPending
        // 
        this.pnlKpiPending.BackColor = System.Drawing.Color.White;
        this.pnlKpiPending.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlKpiPending.Controls.Add(this.lblPendingOrders);
        this.pnlKpiPending.Controls.Add(this.lblKpiPendingTitle);
        this.pnlKpiPending.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlKpiPending.Location = new System.Drawing.Point(327, 4);
        this.pnlKpiPending.Margin = new System.Windows.Forms.Padding(4);
        this.pnlKpiPending.Name = "pnlKpiPending";
        this.pnlKpiPending.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
        this.pnlKpiPending.Size = new System.Drawing.Size(315, 57);
        this.pnlKpiPending.TabIndex = 1;
        // 
        // lblPendingOrders
        // 
        this.lblPendingOrders.AutoSize = true;
        this.lblPendingOrders.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        this.lblPendingOrders.ForeColor = System.Drawing.Color.FromArgb(180, 83, 9);
        this.lblPendingOrders.Location = new System.Drawing.Point(8, 22);
        this.lblPendingOrders.Name = "lblPendingOrders";
        this.lblPendingOrders.Size = new System.Drawing.Size(29, 35);
        this.lblPendingOrders.TabIndex = 1;
        this.lblPendingOrders.Text = "2";
        // 
        // lblKpiPendingTitle
        // 
        this.lblKpiPendingTitle.AutoSize = true;
        this.lblKpiPendingTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        this.lblKpiPendingTitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblKpiPendingTitle.Location = new System.Drawing.Point(8, 4);
        this.lblKpiPendingTitle.Name = "lblKpiPendingTitle";
        this.lblKpiPendingTitle.Size = new System.Drawing.Size(117, 20);
        this.lblKpiPendingTitle.TabIndex = 0;
        this.lblKpiPendingTitle.Text = "Pending Orders";
        // 
        // pnlKpiPreparing
        // 
        this.pnlKpiPreparing.BackColor = System.Drawing.Color.White;
        this.pnlKpiPreparing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlKpiPreparing.Controls.Add(this.lblPreparingOrders);
        this.pnlKpiPreparing.Controls.Add(this.lblKpiPrepTitle);
        this.pnlKpiPreparing.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlKpiPreparing.Location = new System.Drawing.Point(650, 4);
        this.pnlKpiPreparing.Margin = new System.Windows.Forms.Padding(4);
        this.pnlKpiPreparing.Name = "pnlKpiPreparing";
        this.pnlKpiPreparing.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
        this.pnlKpiPreparing.Size = new System.Drawing.Size(318, 57);
        this.pnlKpiPreparing.TabIndex = 2;
        // 
        // lblPreparingOrders
        // 
        this.lblPreparingOrders.AutoSize = true;
        this.lblPreparingOrders.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        this.lblPreparingOrders.ForeColor = System.Drawing.Color.FromArgb(194, 65, 12);
        this.lblPreparingOrders.Location = new System.Drawing.Point(8, 22);
        this.lblPreparingOrders.Name = "lblPreparingOrders";
        this.lblPreparingOrders.Size = new System.Drawing.Size(29, 35);
        this.lblPreparingOrders.TabIndex = 1;
        this.lblPreparingOrders.Text = "3";
        // 
        // lblKpiPrepTitle
        // 
        this.lblKpiPrepTitle.AutoSize = true;
        this.lblKpiPrepTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        this.lblKpiPrepTitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblKpiPrepTitle.Location = new System.Drawing.Point(8, 4);
        this.lblKpiPrepTitle.Name = "lblKpiPrepTitle";
        this.lblKpiPrepTitle.Size = new System.Drawing.Size(127, 20);
        this.lblKpiPrepTitle.TabIndex = 0;
        this.lblKpiPrepTitle.Text = "Preparing Orders";
        // 
        // pnlKpiReady
        // 
        this.pnlKpiReady.BackColor = System.Drawing.Color.White;
        this.pnlKpiReady.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlKpiReady.Controls.Add(this.lblReadyOrders);
        this.pnlKpiReady.Controls.Add(this.lblKpiReadyTitle);
        this.pnlKpiReady.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlKpiReady.Location = new System.Drawing.Point(4, 69);
        this.pnlKpiReady.Margin = new System.Windows.Forms.Padding(4);
        this.pnlKpiReady.Name = "pnlKpiReady";
        this.pnlKpiReady.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
        this.pnlKpiReady.Size = new System.Drawing.Size(315, 57);
        this.pnlKpiReady.TabIndex = 3;
        // 
        // lblReadyOrders
        // 
        this.lblReadyOrders.AutoSize = true;
        this.lblReadyOrders.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        this.lblReadyOrders.ForeColor = System.Drawing.Color.FromArgb(16, 149, 93);
        this.lblReadyOrders.Location = new System.Drawing.Point(8, 22);
        this.lblReadyOrders.Name = "lblReadyOrders";
        this.lblReadyOrders.Size = new System.Drawing.Size(29, 35);
        this.lblReadyOrders.TabIndex = 1;
        this.lblReadyOrders.Text = "2";
        // 
        // lblKpiReadyTitle
        // 
        this.lblKpiReadyTitle.AutoSize = true;
        this.lblKpiReadyTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        this.lblKpiReadyTitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblKpiReadyTitle.Location = new System.Drawing.Point(8, 4);
        this.lblKpiReadyTitle.Name = "lblKpiReadyTitle";
        this.lblKpiReadyTitle.Size = new System.Drawing.Size(102, 20);
        this.lblKpiReadyTitle.TabIndex = 0;
        this.lblKpiReadyTitle.Text = "Ready Orders";
        // 
        // pnlKpiCompleted
        // 
        this.pnlKpiCompleted.BackColor = System.Drawing.Color.White;
        this.pnlKpiCompleted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlKpiCompleted.Controls.Add(this.lblCompletedOrders);
        this.pnlKpiCompleted.Controls.Add(this.lblKpiCompTitle);
        this.pnlKpiCompleted.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlKpiCompleted.Location = new System.Drawing.Point(327, 69);
        this.pnlKpiCompleted.Margin = new System.Windows.Forms.Padding(4);
        this.pnlKpiCompleted.Name = "pnlKpiCompleted";
        this.pnlKpiCompleted.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
        this.pnlKpiCompleted.Size = new System.Drawing.Size(315, 57);
        this.pnlKpiCompleted.TabIndex = 4;
        // 
        // lblCompletedOrders
        // 
        this.lblCompletedOrders.AutoSize = true;
        this.lblCompletedOrders.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        this.lblCompletedOrders.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblCompletedOrders.Location = new System.Drawing.Point(8, 22);
        this.lblCompletedOrders.Name = "lblCompletedOrders";
        this.lblCompletedOrders.Size = new System.Drawing.Size(29, 35);
        this.lblCompletedOrders.TabIndex = 1;
        this.lblCompletedOrders.Text = "5";
        // 
        // lblKpiCompTitle
        // 
        this.lblKpiCompTitle.AutoSize = true;
        this.lblKpiCompTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        this.lblKpiCompTitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblKpiCompTitle.Location = new System.Drawing.Point(8, 4);
        this.lblKpiCompTitle.Name = "lblKpiCompTitle";
        this.lblKpiCompTitle.Size = new System.Drawing.Size(137, 20);
        this.lblKpiCompTitle.TabIndex = 0;
        this.lblKpiCompTitle.Text = "Completed Orders";
        // 
        // pnlKpiValue
        // 
        this.pnlKpiValue.BackColor = System.Drawing.Color.White;
        this.pnlKpiValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlKpiValue.Controls.Add(this.lblCompletedValue);
        this.pnlKpiValue.Controls.Add(this.lblKpiValTitle);
        this.pnlKpiValue.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlKpiValue.Location = new System.Drawing.Point(650, 69);
        this.pnlKpiValue.Margin = new System.Windows.Forms.Padding(4);
        this.pnlKpiValue.Name = "pnlKpiValue";
        this.pnlKpiValue.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
        this.pnlKpiValue.Size = new System.Drawing.Size(318, 57);
        this.pnlKpiValue.TabIndex = 5;
        // 
        // lblCompletedValue
        // 
        this.lblCompletedValue.AutoSize = true;
        this.lblCompletedValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        this.lblCompletedValue.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
        this.lblCompletedValue.Location = new System.Drawing.Point(8, 22);
        this.lblCompletedValue.Name = "lblCompletedValue";
        this.lblCompletedValue.Size = new System.Drawing.Size(130, 35);
        this.lblCompletedValue.TabIndex = 1;
        this.lblCompletedValue.Text = "1,850 ETB";
        // 
        // lblKpiValTitle
        // 
        this.lblKpiValTitle.AutoSize = true;
        this.lblKpiValTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        this.lblKpiValTitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblKpiValTitle.Location = new System.Drawing.Point(8, 4);
        this.lblKpiValTitle.Name = "lblKpiValTitle";
        this.lblKpiValTitle.Size = new System.Drawing.Size(127, 20);
        this.lblKpiValTitle.TabIndex = 0;
        this.lblKpiValTitle.Text = "Completed Value";
        // 
        // grpOrderSummary
        // 
        this.grpOrderSummary.BackColor = System.Drawing.Color.Transparent;
        this.grpOrderSummary.Controls.Add(this.dgvSummary);
        this.grpOrderSummary.Controls.Add(this.lblSummaryFooter);
        this.grpOrderSummary.Controls.Add(this.pnlBreakdownHeader);
        this.grpOrderSummary.Dock = System.Windows.Forms.DockStyle.Fill;
        this.grpOrderSummary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.grpOrderSummary.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.grpOrderSummary.Location = new System.Drawing.Point(24, 322);
        this.grpOrderSummary.Name = "grpOrderSummary";
        this.grpOrderSummary.Padding = new System.Windows.Forms.Padding(12, 10, 12, 12);
        this.grpOrderSummary.Size = new System.Drawing.Size(996, 338);
        this.grpOrderSummary.TabIndex = 3;
        this.grpOrderSummary.TabStop = false;
        this.grpOrderSummary.Text = "Order Breakdown";
        // 
        // dgvSummary
        // 
        this.dgvSummary.AllowUserToAddRows = false;
        this.dgvSummary.AllowUserToDeleteRows = false;
        this.dgvSummary.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        this.dgvSummary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        this.dgvSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvSummary.BackgroundColor = System.Drawing.Color.White;
        this.dgvSummary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.dgvSummary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        this.dgvSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        this.dgvSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
        this.dgvSummary.DefaultCellStyle = dataGridViewCellStyle3;
        this.dgvSummary.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvSummary.EnableHeadersVisualStyles = false;
        this.dgvSummary.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
        this.dgvSummary.Location = new System.Drawing.Point(12, 59);
        this.dgvSummary.MultiSelect = false;
        this.dgvSummary.Name = "dgvSummary";
        this.dgvSummary.ReadOnly = true;
        this.dgvSummary.RowHeadersVisible = false;
        this.dgvSummary.RowHeadersWidth = 51;
        this.dgvSummary.RowTemplate.Height = 36;
        this.dgvSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvSummary.Size = new System.Drawing.Size(972, 241);
        this.dgvSummary.TabIndex = 1;
        this.dgvSummary.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSummary_CellDoubleClick);
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
        // lblSummaryFooter
        // 
        this.lblSummaryFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.lblSummaryFooter.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        this.lblSummaryFooter.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
        this.lblSummaryFooter.Location = new System.Drawing.Point(12, 300);
        this.lblSummaryFooter.Name = "lblSummaryFooter";
        this.lblSummaryFooter.Size = new System.Drawing.Size(972, 26);
        this.lblSummaryFooter.TabIndex = 2;
        this.lblSummaryFooter.Text = "Summary cards cover all orders; completed order value totals completed orders only.";
        this.lblSummaryFooter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // pnlBreakdownHeader
        // 
        this.pnlBreakdownHeader.Controls.Add(this.lblTimesNote);
        this.pnlBreakdownHeader.Controls.Add(this.lblBreakdownSubtitle);
        this.pnlBreakdownHeader.Dock = System.Windows.Forms.DockStyle.Top;
        this.pnlBreakdownHeader.Location = new System.Drawing.Point(12, 33);
        this.pnlBreakdownHeader.Name = "pnlBreakdownHeader";
        this.pnlBreakdownHeader.Size = new System.Drawing.Size(972, 26);
        this.pnlBreakdownHeader.TabIndex = 0;
        // 
        // lblTimesNote
        // 
        this.lblTimesNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.lblTimesNote.AutoSize = true;
        this.lblTimesNote.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        this.lblTimesNote.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
        this.lblTimesNote.Location = new System.Drawing.Point(822, 3);
        this.lblTimesNote.Name = "lblTimesNote";
        this.lblTimesNote.Size = new System.Drawing.Size(150, 20);
        this.lblTimesNote.TabIndex = 1;
        this.lblTimesNote.Text = "Created times are local";
        // 
        // lblBreakdownSubtitle
        // 
        this.lblBreakdownSubtitle.AutoSize = true;
        this.lblBreakdownSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblBreakdownSubtitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblBreakdownSubtitle.Location = new System.Drawing.Point(0, 3);
        this.lblBreakdownSubtitle.Name = "lblBreakdownSubtitle";
        this.lblBreakdownSubtitle.Size = new System.Drawing.Size(188, 20);
        this.lblBreakdownSubtitle.TabIndex = 0;
        this.lblBreakdownSubtitle.Text = "Filtered orders list breakdown";
        // 
        // ReportsView
        // 
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
        this.Controls.Add(this.grpOrderSummary);
        this.Controls.Add(this.grpSummaryCards);
        this.Controls.Add(this.grpFilters);
        this.Controls.Add(this.pnlHeader);
        this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.Name = "ReportsView";
        this.Padding = new System.Windows.Forms.Padding(24, 16, 24, 20);
        this.Size = new System.Drawing.Size(1044, 680);
        this.pnlHeader.ResumeLayout(false);
        this.pnlHeader.PerformLayout();
        this.grpFilters.ResumeLayout(false);
        this.grpFilters.PerformLayout();
        this.grpSummaryCards.ResumeLayout(false);
        this.tlpKpi.ResumeLayout(false);
        this.pnlKpiTotal.ResumeLayout(false);
        this.pnlKpiTotal.PerformLayout();
        this.pnlKpiPending.ResumeLayout(false);
        this.pnlKpiPending.PerformLayout();
        this.pnlKpiPreparing.ResumeLayout(false);
        this.pnlKpiPreparing.PerformLayout();
        this.pnlKpiReady.ResumeLayout(false);
        this.pnlKpiReady.PerformLayout();
        this.pnlKpiCompleted.ResumeLayout(false);
        this.pnlKpiCompleted.PerformLayout();
        this.pnlKpiValue.ResumeLayout(false);
        this.pnlKpiValue.PerformLayout();
        this.grpOrderSummary.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).EndInit();
        this.pnlBreakdownHeader.ResumeLayout(false);
        this.pnlBreakdownHeader.PerformLayout();
        this.ResumeLayout(false);
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
