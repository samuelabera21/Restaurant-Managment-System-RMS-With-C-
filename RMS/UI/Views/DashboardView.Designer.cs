namespace RMS.UI.Views;

partial class DashboardView
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
        this.grpOverview = new System.Windows.Forms.GroupBox();
        this.tlpKpis = new System.Windows.Forms.TableLayoutPanel();
        this.pnlKpiTotal = new System.Windows.Forms.Panel();
        this.lblTotalCount = new System.Windows.Forms.Label();
        this.lblKpiTotalTitle = new System.Windows.Forms.Label();
        this.pnlKpiPending = new System.Windows.Forms.Panel();
        this.lblPendingCount = new System.Windows.Forms.Label();
        this.lblKpiPendingTitle = new System.Windows.Forms.Label();
        this.pnlKpiPreparing = new System.Windows.Forms.Panel();
        this.lblPreparingCount = new System.Windows.Forms.Label();
        this.lblKpiPrepTitle = new System.Windows.Forms.Label();
        this.pnlKpiReady = new System.Windows.Forms.Panel();
        this.lblReadyCount = new System.Windows.Forms.Label();
        this.lblKpiReadyTitle = new System.Windows.Forms.Label();
        this.pnlKpiCompleted = new System.Windows.Forms.Panel();
        this.lblCompletedCount = new System.Windows.Forms.Label();
        this.lblKpiCompTitle = new System.Windows.Forms.Label();
        this.pnlKpiValue = new System.Windows.Forms.Panel();
        this.lblCompletedValue = new System.Windows.Forms.Label();
        this.lblKpiValTitle = new System.Windows.Forms.Label();
        this.grpRecentOrders = new System.Windows.Forms.GroupBox();
        this.dgvRecentOrders = new System.Windows.Forms.DataGridView();
        this.colOrderNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.pnlRecentHeader = new System.Windows.Forms.Panel();
        this.lnkViewAll = new System.Windows.Forms.LinkLabel();
        this.lblRecentSubtitle = new System.Windows.Forms.Label();
        this.pnlHeader.SuspendLayout();
        this.grpOverview.SuspendLayout();
        this.tlpKpis.SuspendLayout();
        this.pnlKpiTotal.SuspendLayout();
        this.pnlKpiPending.SuspendLayout();
        this.pnlKpiPreparing.SuspendLayout();
        this.pnlKpiReady.SuspendLayout();
        this.pnlKpiCompleted.SuspendLayout();
        this.pnlKpiValue.SuspendLayout();
        this.grpRecentOrders.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvRecentOrders)).BeginInit();
        this.pnlRecentHeader.SuspendLayout();
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
        this.pnlHeader.Size = new System.Drawing.Size(996, 60);
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
        this.btnNewOrder.Location = new System.Drawing.Point(860, 10);
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
        this.lblSubtitle.Size = new System.Drawing.Size(252, 20);
        this.lblSubtitle.TabIndex = 1;
        this.lblSubtitle.Text = "Overview of today\'s restaurant orders";
        // 
        // lblTitle
        // 
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.lblTitle.Location = new System.Drawing.Point(-2, 0);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(157, 37);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Dashboard";
        // 
        // grpOverview
        // 
        this.grpOverview.BackColor = System.Drawing.Color.Transparent;
        this.grpOverview.Controls.Add(this.tlpKpis);
        this.grpOverview.Dock = System.Windows.Forms.DockStyle.Top;
        this.grpOverview.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.grpOverview.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.grpOverview.Location = new System.Drawing.Point(24, 76);
        this.grpOverview.Name = "grpOverview";
        this.grpOverview.Padding = new System.Windows.Forms.Padding(12, 10, 12, 12);
        this.grpOverview.Size = new System.Drawing.Size(996, 175);
        this.grpOverview.TabIndex = 1;
        this.grpOverview.TabStop = false;
        this.grpOverview.Text = "Today\'s Overview";
        // 
        // tlpKpis
        // 
        this.tlpKpis.ColumnCount = 3;
        this.tlpKpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
        this.tlpKpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
        this.tlpKpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
        this.tlpKpis.Controls.Add(this.pnlKpiTotal, 0, 0);
        this.tlpKpis.Controls.Add(this.pnlKpiPending, 1, 0);
        this.tlpKpis.Controls.Add(this.pnlKpiPreparing, 2, 0);
        this.tlpKpis.Controls.Add(this.pnlKpiReady, 0, 1);
        this.tlpKpis.Controls.Add(this.pnlKpiCompleted, 1, 1);
        this.tlpKpis.Controls.Add(this.pnlKpiValue, 2, 1);
        this.tlpKpis.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tlpKpis.Location = new System.Drawing.Point(12, 33);
        this.tlpKpis.Name = "tlpKpis";
        this.tlpKpis.RowCount = 2;
        this.tlpKpis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tlpKpis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tlpKpis.Size = new System.Drawing.Size(972, 130);
        this.tlpKpis.TabIndex = 0;
        // 
        // pnlKpiTotal
        // 
        this.pnlKpiTotal.BackColor = System.Drawing.Color.White;
        this.pnlKpiTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlKpiTotal.Controls.Add(this.lblTotalCount);
        this.pnlKpiTotal.Controls.Add(this.lblKpiTotalTitle);
        this.pnlKpiTotal.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlKpiTotal.Location = new System.Drawing.Point(4, 4);
        this.pnlKpiTotal.Margin = new System.Windows.Forms.Padding(4);
        this.pnlKpiTotal.Name = "pnlKpiTotal";
        this.pnlKpiTotal.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
        this.pnlKpiTotal.Size = new System.Drawing.Size(315, 57);
        this.pnlKpiTotal.TabIndex = 0;
        // 
        // lblTotalCount
        // 
        this.lblTotalCount.AutoSize = true;
        this.lblTotalCount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        this.lblTotalCount.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
        this.lblTotalCount.Location = new System.Drawing.Point(8, 22);
        this.lblTotalCount.Name = "lblTotalCount";
        this.lblTotalCount.Size = new System.Drawing.Size(43, 35);
        this.lblTotalCount.TabIndex = 1;
        this.lblTotalCount.Text = "12";
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
        this.pnlKpiPending.Controls.Add(this.lblPendingCount);
        this.pnlKpiPending.Controls.Add(this.lblKpiPendingTitle);
        this.pnlKpiPending.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlKpiPending.Location = new System.Drawing.Point(327, 4);
        this.pnlKpiPending.Margin = new System.Windows.Forms.Padding(4);
        this.pnlKpiPending.Name = "pnlKpiPending";
        this.pnlKpiPending.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
        this.pnlKpiPending.Size = new System.Drawing.Size(315, 57);
        this.pnlKpiPending.TabIndex = 1;
        // 
        // lblPendingCount
        // 
        this.lblPendingCount.AutoSize = true;
        this.lblPendingCount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        this.lblPendingCount.ForeColor = System.Drawing.Color.FromArgb(180, 83, 9);
        this.lblPendingCount.Location = new System.Drawing.Point(8, 22);
        this.lblPendingCount.Name = "lblPendingCount";
        this.lblPendingCount.Size = new System.Drawing.Size(29, 35);
        this.lblPendingCount.TabIndex = 1;
        this.lblPendingCount.Text = "2";
        // 
        // lblKpiPendingTitle
        // 
        this.lblKpiPendingTitle.AutoSize = true;
        this.lblKpiPendingTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        this.lblKpiPendingTitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblKpiPendingTitle.Location = new System.Drawing.Point(8, 4);
        this.lblKpiPendingTitle.Name = "lblKpiPendingTitle";
        this.lblKpiPendingTitle.Size = new System.Drawing.Size(66, 20);
        this.lblKpiPendingTitle.TabIndex = 0;
        this.lblKpiPendingTitle.Text = "Pending";
        // 
        // pnlKpiPreparing
        // 
        this.pnlKpiPreparing.BackColor = System.Drawing.Color.White;
        this.pnlKpiPreparing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlKpiPreparing.Controls.Add(this.lblPreparingCount);
        this.pnlKpiPreparing.Controls.Add(this.lblKpiPrepTitle);
        this.pnlKpiPreparing.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlKpiPreparing.Location = new System.Drawing.Point(650, 4);
        this.pnlKpiPreparing.Margin = new System.Windows.Forms.Padding(4);
        this.pnlKpiPreparing.Name = "pnlKpiPreparing";
        this.pnlKpiPreparing.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
        this.pnlKpiPreparing.Size = new System.Drawing.Size(318, 57);
        this.pnlKpiPreparing.TabIndex = 2;
        // 
        // lblPreparingCount
        // 
        this.lblPreparingCount.AutoSize = true;
        this.lblPreparingCount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        this.lblPreparingCount.ForeColor = System.Drawing.Color.FromArgb(194, 65, 12);
        this.lblPreparingCount.Location = new System.Drawing.Point(8, 22);
        this.lblPreparingCount.Name = "lblPreparingCount";
        this.lblPreparingCount.Size = new System.Drawing.Size(29, 35);
        this.lblPreparingCount.TabIndex = 1;
        this.lblPreparingCount.Text = "3";
        // 
        // lblKpiPrepTitle
        // 
        this.lblKpiPrepTitle.AutoSize = true;
        this.lblKpiPrepTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        this.lblKpiPrepTitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblKpiPrepTitle.Location = new System.Drawing.Point(8, 4);
        this.lblKpiPrepTitle.Name = "lblKpiPrepTitle";
        this.lblKpiPrepTitle.Size = new System.Drawing.Size(76, 20);
        this.lblKpiPrepTitle.TabIndex = 0;
        this.lblKpiPrepTitle.Text = "Preparing";
        // 
        // pnlKpiReady
        // 
        this.pnlKpiReady.BackColor = System.Drawing.Color.White;
        this.pnlKpiReady.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlKpiReady.Controls.Add(this.lblReadyCount);
        this.pnlKpiReady.Controls.Add(this.lblKpiReadyTitle);
        this.pnlKpiReady.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlKpiReady.Location = new System.Drawing.Point(4, 69);
        this.pnlKpiReady.Margin = new System.Windows.Forms.Padding(4);
        this.pnlKpiReady.Name = "pnlKpiReady";
        this.pnlKpiReady.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
        this.pnlKpiReady.Size = new System.Drawing.Size(315, 57);
        this.pnlKpiReady.TabIndex = 3;
        // 
        // lblReadyCount
        // 
        this.lblReadyCount.AutoSize = true;
        this.lblReadyCount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        this.lblReadyCount.ForeColor = System.Drawing.Color.FromArgb(16, 149, 93);
        this.lblReadyCount.Location = new System.Drawing.Point(8, 22);
        this.lblReadyCount.Name = "lblReadyCount";
        this.lblReadyCount.Size = new System.Drawing.Size(29, 35);
        this.lblReadyCount.TabIndex = 1;
        this.lblReadyCount.Text = "2";
        // 
        // lblKpiReadyTitle
        // 
        this.lblKpiReadyTitle.AutoSize = true;
        this.lblKpiReadyTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        this.lblKpiReadyTitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblKpiReadyTitle.Location = new System.Drawing.Point(8, 4);
        this.lblKpiReadyTitle.Name = "lblKpiReadyTitle";
        this.lblKpiReadyTitle.Size = new System.Drawing.Size(51, 20);
        this.lblKpiReadyTitle.TabIndex = 0;
        this.lblKpiReadyTitle.Text = "Ready";
        // 
        // pnlKpiCompleted
        // 
        this.pnlKpiCompleted.BackColor = System.Drawing.Color.White;
        this.pnlKpiCompleted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlKpiCompleted.Controls.Add(this.lblCompletedCount);
        this.pnlKpiCompleted.Controls.Add(this.lblKpiCompTitle);
        this.pnlKpiCompleted.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlKpiCompleted.Location = new System.Drawing.Point(327, 69);
        this.pnlKpiCompleted.Margin = new System.Windows.Forms.Padding(4);
        this.pnlKpiCompleted.Name = "pnlKpiCompleted";
        this.pnlKpiCompleted.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
        this.pnlKpiCompleted.Size = new System.Drawing.Size(315, 57);
        this.pnlKpiCompleted.TabIndex = 4;
        // 
        // lblCompletedCount
        // 
        this.lblCompletedCount.AutoSize = true;
        this.lblCompletedCount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        this.lblCompletedCount.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblCompletedCount.Location = new System.Drawing.Point(8, 22);
        this.lblCompletedCount.Name = "lblCompletedCount";
        this.lblCompletedCount.Size = new System.Drawing.Size(29, 35);
        this.lblCompletedCount.TabIndex = 1;
        this.lblCompletedCount.Text = "5";
        // 
        // lblKpiCompTitle
        // 
        this.lblKpiCompTitle.AutoSize = true;
        this.lblKpiCompTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        this.lblKpiCompTitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblKpiCompTitle.Location = new System.Drawing.Point(8, 4);
        this.lblKpiCompTitle.Name = "lblKpiCompTitle";
        this.lblKpiCompTitle.Size = new System.Drawing.Size(86, 20);
        this.lblKpiCompTitle.TabIndex = 0;
        this.lblKpiCompTitle.Text = "Completed";
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
        // grpRecentOrders
        // 
        this.grpRecentOrders.BackColor = System.Drawing.Color.Transparent;
        this.grpRecentOrders.Controls.Add(this.dgvRecentOrders);
        this.grpRecentOrders.Controls.Add(this.pnlRecentHeader);
        this.grpRecentOrders.Dock = System.Windows.Forms.DockStyle.Fill;
        this.grpRecentOrders.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.grpRecentOrders.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.grpRecentOrders.Location = new System.Drawing.Point(24, 251);
        this.grpRecentOrders.Name = "grpRecentOrders";
        this.grpRecentOrders.Padding = new System.Windows.Forms.Padding(12, 10, 12, 12);
        this.grpRecentOrders.Size = new System.Drawing.Size(996, 409);
        this.grpRecentOrders.TabIndex = 2;
        this.grpRecentOrders.TabStop = false;
        this.grpRecentOrders.Text = "Recent Orders";
        // 
        // dgvRecentOrders
        // 
        this.dgvRecentOrders.AllowUserToAddRows = false;
        this.dgvRecentOrders.AllowUserToDeleteRows = false;
        this.dgvRecentOrders.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        this.dgvRecentOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        this.dgvRecentOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvRecentOrders.BackgroundColor = System.Drawing.Color.White;
        this.dgvRecentOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.dgvRecentOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        this.dgvRecentOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        this.dgvRecentOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvRecentOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
        this.dgvRecentOrders.DefaultCellStyle = dataGridViewCellStyle3;
        this.dgvRecentOrders.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvRecentOrders.EnableHeadersVisualStyles = false;
        this.dgvRecentOrders.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
        this.dgvRecentOrders.Location = new System.Drawing.Point(12, 60);
        this.dgvRecentOrders.MultiSelect = false;
        this.dgvRecentOrders.Name = "dgvRecentOrders";
        this.dgvRecentOrders.ReadOnly = true;
        this.dgvRecentOrders.RowHeadersVisible = false;
        this.dgvRecentOrders.RowHeadersWidth = 51;
        this.dgvRecentOrders.RowTemplate.Height = 36;
        this.dgvRecentOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvRecentOrders.Size = new System.Drawing.Size(972, 337);
        this.dgvRecentOrders.TabIndex = 1;
        // 
        // colOrderNum
        // 
        this.colOrderNum.FillWeight = 80F;
        this.colOrderNum.HeaderText = "Order #";
        this.colOrderNum.MinimumWidth = 6;
        this.colOrderNum.Name = "colOrderNum";
        this.colOrderNum.ReadOnly = true;
        // 
        // colCustomer
        // 
        this.colCustomer.FillWeight = 130F;
        this.colCustomer.HeaderText = "Customer";
        this.colCustomer.MinimumWidth = 6;
        this.colCustomer.Name = "colCustomer";
        this.colCustomer.ReadOnly = true;
        // 
        // colTable
        // 
        this.colTable.FillWeight = 80F;
        this.colTable.HeaderText = "Table";
        this.colTable.MinimumWidth = 6;
        this.colTable.Name = "colTable";
        this.colTable.ReadOnly = true;
        // 
        // colCreated
        // 
        this.colCreated.FillWeight = 90F;
        this.colCreated.HeaderText = "Created Time";
        this.colCreated.MinimumWidth = 6;
        this.colCreated.Name = "colCreated";
        this.colCreated.ReadOnly = true;
        // 
        // colTotal
        // 
        this.colTotal.FillWeight = 100F;
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
        // pnlRecentHeader
        // 
        this.pnlRecentHeader.Controls.Add(this.lnkViewAll);
        this.pnlRecentHeader.Controls.Add(this.lblRecentSubtitle);
        this.pnlRecentHeader.Dock = System.Windows.Forms.DockStyle.Top;
        this.pnlRecentHeader.Location = new System.Drawing.Point(12, 33);
        this.pnlRecentHeader.Name = "pnlRecentHeader";
        this.pnlRecentHeader.Size = new System.Drawing.Size(972, 27);
        this.pnlRecentHeader.TabIndex = 0;
        // 
        // lnkViewAll
        // 
        this.lnkViewAll.ActiveLinkColor = System.Drawing.Color.FromArgb(22, 44, 71);
        this.lnkViewAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.lnkViewAll.AutoSize = true;
        this.lnkViewAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.lnkViewAll.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
        this.lnkViewAll.LinkColor = System.Drawing.Color.FromArgb(30, 58, 95);
        this.lnkViewAll.Location = new System.Drawing.Point(844, 4);
        this.lnkViewAll.Name = "lnkViewAll";
        this.lnkViewAll.Size = new System.Drawing.Size(126, 20);
        this.lnkViewAll.TabIndex = 1;
        this.lnkViewAll.TabStop = true;
        this.lnkViewAll.Text = "View all orders →";
        this.lnkViewAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkViewAll_LinkClicked);
        // 
        // lblRecentSubtitle
        // 
        this.lblRecentSubtitle.AutoSize = true;
        this.lblRecentSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblRecentSubtitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblRecentSubtitle.Location = new System.Drawing.Point(0, 4);
        this.lblRecentSubtitle.Name = "lblRecentSubtitle";
        this.lblRecentSubtitle.Size = new System.Drawing.Size(161, 20);
        this.lblRecentSubtitle.TabIndex = 0;
        this.lblRecentSubtitle.Text = "Latest restaurant activity";
        // 
        // DashboardView
        // 
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
        this.Controls.Add(this.grpRecentOrders);
        this.Controls.Add(this.grpOverview);
        this.Controls.Add(this.pnlHeader);
        this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.Name = "DashboardView";
        this.Padding = new System.Windows.Forms.Padding(24, 16, 24, 20);
        this.Size = new System.Drawing.Size(1044, 676);
        this.pnlHeader.ResumeLayout(false);
        this.pnlHeader.PerformLayout();
        this.grpOverview.ResumeLayout(false);
        this.tlpKpis.ResumeLayout(false);
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
        this.grpRecentOrders.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvRecentOrders)).EndInit();
        this.pnlRecentHeader.ResumeLayout(false);
        this.pnlRecentHeader.PerformLayout();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Button btnNewOrder;
    private System.Windows.Forms.GroupBox grpOverview;
    private System.Windows.Forms.TableLayoutPanel tlpKpis;
    private System.Windows.Forms.Panel pnlKpiTotal;
    private System.Windows.Forms.Label lblTotalCount;
    private System.Windows.Forms.Label lblKpiTotalTitle;
    private System.Windows.Forms.Panel pnlKpiPending;
    private System.Windows.Forms.Label lblPendingCount;
    private System.Windows.Forms.Label lblKpiPendingTitle;
    private System.Windows.Forms.Panel pnlKpiPreparing;
    private System.Windows.Forms.Label lblPreparingCount;
    private System.Windows.Forms.Label lblKpiPrepTitle;
    private System.Windows.Forms.Panel pnlKpiReady;
    private System.Windows.Forms.Label lblReadyCount;
    private System.Windows.Forms.Label lblKpiReadyTitle;
    private System.Windows.Forms.Panel pnlKpiCompleted;
    private System.Windows.Forms.Label lblCompletedCount;
    private System.Windows.Forms.Label lblKpiCompTitle;
    private System.Windows.Forms.Panel pnlKpiValue;
    private System.Windows.Forms.Label lblCompletedValue;
    private System.Windows.Forms.Label lblKpiValTitle;
    private System.Windows.Forms.GroupBox grpRecentOrders;
    private System.Windows.Forms.Panel pnlRecentHeader;
    private System.Windows.Forms.Label lblRecentSubtitle;
    private System.Windows.Forms.LinkLabel lnkViewAll;
    private System.Windows.Forms.DataGridView dgvRecentOrders;
    private System.Windows.Forms.DataGridViewTextBoxColumn colOrderNum;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCustomer;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTable;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCreated;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
    private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
}
