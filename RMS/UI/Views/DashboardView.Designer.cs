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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        pnlHeader = new Panel();
        btnNewOrder = new Button();
        lblSubtitle = new Label();
        lblTitle = new Label();
        grpOverview = new GroupBox();
        tlpKpis = new TableLayoutPanel();
        pnlKpiTotal = new Panel();
        lblTotalCount = new Label();
        lblKpiTotalTitle = new Label();
        pnlKpiPending = new Panel();
        lblPendingCount = new Label();
        lblKpiPendingTitle = new Label();
        pnlKpiPreparing = new Panel();
        lblPreparingCount = new Label();
        lblKpiPrepTitle = new Label();
        pnlKpiReady = new Panel();
        lblReadyCount = new Label();
        lblKpiReadyTitle = new Label();
        pnlKpiCompleted = new Panel();
        lblCompletedCount = new Label();
        lblKpiCompTitle = new Label();
        pnlKpiValue = new Panel();
        lblCompletedValue = new Label();
        lblKpiValTitle = new Label();
        grpRecentOrders = new GroupBox();
        dgvRecentOrders = new DataGridView();
        colOrderNum = new DataGridViewTextBoxColumn();
        colCustomer = new DataGridViewTextBoxColumn();
        colTable = new DataGridViewTextBoxColumn();
        colCreated = new DataGridViewTextBoxColumn();
        colTotal = new DataGridViewTextBoxColumn();
        colStatus = new DataGridViewTextBoxColumn();
        pnlRecentHeader = new Panel();
        lnkViewAll = new LinkLabel();
        lblRecentSubtitle = new Label();
        pnlHeader.SuspendLayout();
        grpOverview.SuspendLayout();
        tlpKpis.SuspendLayout();
        pnlKpiTotal.SuspendLayout();
        pnlKpiPending.SuspendLayout();
        pnlKpiPreparing.SuspendLayout();
        pnlKpiReady.SuspendLayout();
        pnlKpiCompleted.SuspendLayout();
        pnlKpiValue.SuspendLayout();
        grpRecentOrders.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvRecentOrders).BeginInit();
        pnlRecentHeader.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = Color.Transparent;
        pnlHeader.Controls.Add(btnNewOrder);
        pnlHeader.Controls.Add(lblSubtitle);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Location = new Point(24, 16);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new Size(1072, 60);
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
        btnNewOrder.Location = new Point(936, 10);
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
        lblSubtitle.Location = new Point(200, 21);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(310, 25);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Overview of today's restaurant orders";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
        lblTitle.Location = new Point(0, -13);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(184, 45);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Dashboard";
        // 
        // grpOverview
        // 
        grpOverview.BackColor = Color.Transparent;
        grpOverview.Controls.Add(tlpKpis);
        grpOverview.Dock = DockStyle.Top;
        grpOverview.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        grpOverview.ForeColor = Color.FromArgb(15, 23, 42);
        grpOverview.Location = new Point(24, 76);
        grpOverview.Name = "grpOverview";
        grpOverview.Padding = new Padding(12, 10, 12, 12);
        grpOverview.Size = new Size(1072, 175);
        grpOverview.TabIndex = 1;
        grpOverview.TabStop = false;
        grpOverview.Text = "Today's Overview";
        // 
        // tlpKpis
        // 
        tlpKpis.ColumnCount = 3;
        tlpKpis.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
        tlpKpis.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
        tlpKpis.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
        tlpKpis.Controls.Add(pnlKpiTotal, 0, 0);
        tlpKpis.Controls.Add(pnlKpiPending, 1, 0);
        tlpKpis.Controls.Add(pnlKpiPreparing, 2, 0);
        tlpKpis.Controls.Add(pnlKpiReady, 0, 1);
        tlpKpis.Controls.Add(pnlKpiCompleted, 1, 1);
        tlpKpis.Controls.Add(pnlKpiValue, 2, 1);
        tlpKpis.Dock = DockStyle.Fill;
        tlpKpis.Location = new Point(12, 37);
        tlpKpis.Name = "tlpKpis";
        tlpKpis.RowCount = 2;
        tlpKpis.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tlpKpis.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tlpKpis.Size = new Size(1048, 126);
        tlpKpis.TabIndex = 0;
        // 
        // pnlKpiTotal
        // 
        pnlKpiTotal.BackColor = Color.White;
        pnlKpiTotal.BorderStyle = BorderStyle.FixedSingle;
        pnlKpiTotal.Controls.Add(lblTotalCount);
        pnlKpiTotal.Controls.Add(lblKpiTotalTitle);
        pnlKpiTotal.Dock = DockStyle.Fill;
        pnlKpiTotal.Location = new Point(4, 4);
        pnlKpiTotal.Margin = new Padding(4);
        pnlKpiTotal.Name = "pnlKpiTotal";
        pnlKpiTotal.Padding = new Padding(10, 6, 10, 6);
        pnlKpiTotal.Size = new Size(341, 55);
        pnlKpiTotal.TabIndex = 0;
        // 
        // lblTotalCount
        // 
        lblTotalCount.AutoSize = true;
        lblTotalCount.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        lblTotalCount.ForeColor = Color.FromArgb(30, 58, 95);
        lblTotalCount.Location = new Point(122, 6);
        lblTotalCount.Name = "lblTotalCount";
        lblTotalCount.Size = new Size(52, 41);
        lblTotalCount.TabIndex = 1;
        lblTotalCount.Text = "12";
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
        pnlKpiPending.Controls.Add(lblPendingCount);
        pnlKpiPending.Controls.Add(lblKpiPendingTitle);
        pnlKpiPending.Dock = DockStyle.Fill;
        pnlKpiPending.Location = new Point(353, 4);
        pnlKpiPending.Margin = new Padding(4);
        pnlKpiPending.Name = "pnlKpiPending";
        pnlKpiPending.Padding = new Padding(10, 6, 10, 6);
        pnlKpiPending.Size = new Size(341, 55);
        pnlKpiPending.TabIndex = 1;
        // 
        // lblPendingCount
        // 
        lblPendingCount.AutoSize = true;
        lblPendingCount.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        lblPendingCount.ForeColor = Color.FromArgb(180, 83, 9);
        lblPendingCount.Location = new Point(109, 6);
        lblPendingCount.Name = "lblPendingCount";
        lblPendingCount.Size = new Size(35, 41);
        lblPendingCount.TabIndex = 1;
        lblPendingCount.Text = "2";
        // 
        // lblKpiPendingTitle
        // 
        lblKpiPendingTitle.AutoSize = true;
        lblKpiPendingTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblKpiPendingTitle.ForeColor = Color.FromArgb(71, 85, 105);
        lblKpiPendingTitle.Location = new Point(8, 4);
        lblKpiPendingTitle.Name = "lblKpiPendingTitle";
        lblKpiPendingTitle.Size = new Size(75, 23);
        lblKpiPendingTitle.TabIndex = 0;
        lblKpiPendingTitle.Text = "Pending";
        // 
        // pnlKpiPreparing
        // 
        pnlKpiPreparing.BackColor = Color.White;
        pnlKpiPreparing.BorderStyle = BorderStyle.FixedSingle;
        pnlKpiPreparing.Controls.Add(lblPreparingCount);
        pnlKpiPreparing.Controls.Add(lblKpiPrepTitle);
        pnlKpiPreparing.Dock = DockStyle.Fill;
        pnlKpiPreparing.Location = new Point(702, 4);
        pnlKpiPreparing.Margin = new Padding(4);
        pnlKpiPreparing.Name = "pnlKpiPreparing";
        pnlKpiPreparing.Padding = new Padding(10, 6, 10, 6);
        pnlKpiPreparing.Size = new Size(342, 55);
        pnlKpiPreparing.TabIndex = 2;
        // 
        // lblPreparingCount
        // 
        lblPreparingCount.AutoSize = true;
        lblPreparingCount.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        lblPreparingCount.ForeColor = Color.FromArgb(194, 65, 12);
        lblPreparingCount.Location = new Point(120, 6);
        lblPreparingCount.Name = "lblPreparingCount";
        lblPreparingCount.Size = new Size(35, 41);
        lblPreparingCount.TabIndex = 1;
        lblPreparingCount.Text = "3";
        // 
        // lblKpiPrepTitle
        // 
        lblKpiPrepTitle.AutoSize = true;
        lblKpiPrepTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblKpiPrepTitle.ForeColor = Color.FromArgb(71, 85, 105);
        lblKpiPrepTitle.Location = new Point(8, 4);
        lblKpiPrepTitle.Name = "lblKpiPrepTitle";
        lblKpiPrepTitle.Size = new Size(89, 23);
        lblKpiPrepTitle.TabIndex = 0;
        lblKpiPrepTitle.Text = "Preparing";
        // 
        // pnlKpiReady
        // 
        pnlKpiReady.BackColor = Color.White;
        pnlKpiReady.BorderStyle = BorderStyle.FixedSingle;
        pnlKpiReady.Controls.Add(lblReadyCount);
        pnlKpiReady.Controls.Add(lblKpiReadyTitle);
        pnlKpiReady.Dock = DockStyle.Fill;
        pnlKpiReady.Location = new Point(4, 67);
        pnlKpiReady.Margin = new Padding(4);
        pnlKpiReady.Name = "pnlKpiReady";
        pnlKpiReady.Padding = new Padding(10, 6, 10, 6);
        pnlKpiReady.Size = new Size(341, 55);
        pnlKpiReady.TabIndex = 3;
        // 
        // lblReadyCount
        // 
        lblReadyCount.AutoSize = true;
        lblReadyCount.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        lblReadyCount.ForeColor = Color.FromArgb(16, 149, 93);
        lblReadyCount.Location = new Point(98, 6);
        lblReadyCount.Name = "lblReadyCount";
        lblReadyCount.Size = new Size(35, 41);
        lblReadyCount.TabIndex = 1;
        lblReadyCount.Text = "2";
        // 
        // lblKpiReadyTitle
        // 
        lblKpiReadyTitle.AutoSize = true;
        lblKpiReadyTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblKpiReadyTitle.ForeColor = Color.FromArgb(71, 85, 105);
        lblKpiReadyTitle.Location = new Point(8, 4);
        lblKpiReadyTitle.Name = "lblKpiReadyTitle";
        lblKpiReadyTitle.Size = new Size(59, 23);
        lblKpiReadyTitle.TabIndex = 0;
        lblKpiReadyTitle.Text = "Ready";
        // 
        // pnlKpiCompleted
        // 
        pnlKpiCompleted.BackColor = Color.White;
        pnlKpiCompleted.BorderStyle = BorderStyle.FixedSingle;
        pnlKpiCompleted.Controls.Add(lblCompletedCount);
        pnlKpiCompleted.Controls.Add(lblKpiCompTitle);
        pnlKpiCompleted.Dock = DockStyle.Fill;
        pnlKpiCompleted.Location = new Point(353, 67);
        pnlKpiCompleted.Margin = new Padding(4);
        pnlKpiCompleted.Name = "pnlKpiCompleted";
        pnlKpiCompleted.Padding = new Padding(10, 6, 10, 6);
        pnlKpiCompleted.Size = new Size(341, 55);
        pnlKpiCompleted.TabIndex = 4;
        // 
        // lblCompletedCount
        // 
        lblCompletedCount.AutoSize = true;
        lblCompletedCount.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        lblCompletedCount.ForeColor = Color.FromArgb(71, 85, 105);
        lblCompletedCount.Location = new Point(134, 6);
        lblCompletedCount.Name = "lblCompletedCount";
        lblCompletedCount.Size = new Size(35, 41);
        lblCompletedCount.TabIndex = 1;
        lblCompletedCount.Text = "5";
        lblCompletedCount.Click += lblCompletedCount_Click;
        // 
        // lblKpiCompTitle
        // 
        lblKpiCompTitle.AutoSize = true;
        lblKpiCompTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblKpiCompTitle.ForeColor = Color.FromArgb(71, 85, 105);
        lblKpiCompTitle.Location = new Point(8, 4);
        lblKpiCompTitle.Name = "lblKpiCompTitle";
        lblKpiCompTitle.Size = new Size(99, 23);
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
        lblCompletedValue.Location = new Point(148, 4);
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
        // grpRecentOrders
        // 
        grpRecentOrders.BackColor = Color.Transparent;
        grpRecentOrders.Controls.Add(dgvRecentOrders);
        grpRecentOrders.Controls.Add(pnlRecentHeader);
        grpRecentOrders.Dock = DockStyle.Fill;
        grpRecentOrders.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        grpRecentOrders.ForeColor = Color.FromArgb(15, 23, 42);
        grpRecentOrders.Location = new Point(24, 251);
        grpRecentOrders.Name = "grpRecentOrders";
        grpRecentOrders.Padding = new Padding(12, 10, 12, 12);
        grpRecentOrders.Size = new Size(1072, 282);
        grpRecentOrders.TabIndex = 2;
        grpRecentOrders.TabStop = false;
        grpRecentOrders.Text = "Recent Orders";
        // 
        // dgvRecentOrders
        // 
        dgvRecentOrders.AllowUserToAddRows = false;
        dgvRecentOrders.AllowUserToDeleteRows = false;
        dgvRecentOrders.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
        dgvRecentOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvRecentOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvRecentOrders.BackgroundColor = Color.White;
        dgvRecentOrders.BorderStyle = BorderStyle.Fixed3D;
        dgvRecentOrders.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle2.Padding = new Padding(4, 6, 4, 6);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        dgvRecentOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvRecentOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvRecentOrders.Columns.AddRange(new DataGridViewColumn[] { colOrderNum, colCustomer, colTable, colCreated, colTotal, colStatus });
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.White;
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle3.Padding = new Padding(4);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(219, 234, 254);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        dgvRecentOrders.DefaultCellStyle = dataGridViewCellStyle3;
        dgvRecentOrders.Dock = DockStyle.Fill;
        dgvRecentOrders.EnableHeadersVisualStyles = false;
        dgvRecentOrders.GridColor = Color.FromArgb(226, 232, 240);
        dgvRecentOrders.Location = new Point(12, 64);
        dgvRecentOrders.MultiSelect = false;
        dgvRecentOrders.Name = "dgvRecentOrders";
        dgvRecentOrders.ReadOnly = true;
        dgvRecentOrders.RowHeadersVisible = false;
        dgvRecentOrders.RowHeadersWidth = 51;
        dgvRecentOrders.RowTemplate.Height = 36;
        dgvRecentOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvRecentOrders.Size = new Size(1048, 206);
        dgvRecentOrders.TabIndex = 1;
        // 
        // colOrderNum
        // 
        colOrderNum.FillWeight = 80F;
        colOrderNum.HeaderText = "Order #";
        colOrderNum.MinimumWidth = 6;
        colOrderNum.Name = "colOrderNum";
        colOrderNum.ReadOnly = true;
        // 
        // colCustomer
        // 
        colCustomer.FillWeight = 130F;
        colCustomer.HeaderText = "Customer";
        colCustomer.MinimumWidth = 6;
        colCustomer.Name = "colCustomer";
        colCustomer.ReadOnly = true;
        // 
        // colTable
        // 
        colTable.FillWeight = 80F;
        colTable.HeaderText = "Table";
        colTable.MinimumWidth = 6;
        colTable.Name = "colTable";
        colTable.ReadOnly = true;
        // 
        // colCreated
        // 
        colCreated.FillWeight = 90F;
        colCreated.HeaderText = "Created Time";
        colCreated.MinimumWidth = 6;
        colCreated.Name = "colCreated";
        colCreated.ReadOnly = true;
        // 
        // colTotal
        // 
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
        // pnlRecentHeader
        // 
        pnlRecentHeader.Controls.Add(lnkViewAll);
        pnlRecentHeader.Controls.Add(lblRecentSubtitle);
        pnlRecentHeader.Dock = DockStyle.Top;
        pnlRecentHeader.Location = new Point(12, 37);
        pnlRecentHeader.Name = "pnlRecentHeader";
        pnlRecentHeader.Size = new Size(1048, 27);
        pnlRecentHeader.TabIndex = 0;
        // 
        // lnkViewAll
        // 
        lnkViewAll.ActiveLinkColor = Color.FromArgb(22, 44, 71);
        lnkViewAll.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lnkViewAll.AutoSize = true;
        lnkViewAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lnkViewAll.LinkBehavior = LinkBehavior.HoverUnderline;
        lnkViewAll.LinkColor = Color.FromArgb(30, 58, 95);
        lnkViewAll.Location = new Point(920, 4);
        lnkViewAll.Name = "lnkViewAll";
        lnkViewAll.Size = new Size(158, 25);
        lnkViewAll.TabIndex = 1;
        lnkViewAll.TabStop = true;
        lnkViewAll.Text = "View all orders →";
        lnkViewAll.LinkClicked += lnkViewAll_LinkClicked;
        // 
        // lblRecentSubtitle
        // 
        lblRecentSubtitle.AutoSize = true;
        lblRecentSubtitle.Font = new Font("Segoe UI", 9F);
        lblRecentSubtitle.ForeColor = Color.FromArgb(71, 85, 105);
        lblRecentSubtitle.Location = new Point(0, 4);
        lblRecentSubtitle.Name = "lblRecentSubtitle";
        lblRecentSubtitle.Size = new Size(202, 25);
        lblRecentSubtitle.TabIndex = 0;
        lblRecentSubtitle.Text = "Latest restaurant activity";
        // 
        // DashboardView
        // 
        AutoScaleDimensions = new SizeF(144F, 144F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.FromArgb(243, 244, 246);
        Controls.Add(grpRecentOrders);
        Controls.Add(grpOverview);
        Controls.Add(pnlHeader);
        Name = "DashboardView";
        Padding = new Padding(24, 16, 24, 20);
        Size = new Size(1120, 553);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        grpOverview.ResumeLayout(false);
        tlpKpis.ResumeLayout(false);
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
        grpRecentOrders.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvRecentOrders).EndInit();
        pnlRecentHeader.ResumeLayout(false);
        pnlRecentHeader.PerformLayout();
        ResumeLayout(false);
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

