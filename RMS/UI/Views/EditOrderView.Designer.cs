namespace RMS.UI.Views;

partial class EditOrderView
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
        this.lblSubheaderContext = new System.Windows.Forms.Label();
        this.lblSubtitle = new System.Windows.Forms.Label();
        this.lblTitle = new System.Windows.Forms.Label();
        this.pnlAlertBanner = new System.Windows.Forms.Panel();
        this.lblAlertMessage = new System.Windows.Forms.Label();
        this.grpOrderInfo = new System.Windows.Forms.GroupBox();
        this.lblCurrentStatusBadge = new System.Windows.Forms.Label();
        this.lblStatusTitle = new System.Windows.Forms.Label();
        this.lblTableNumberError = new System.Windows.Forms.Label();
        this.numTableNumber = new System.Windows.Forms.NumericUpDown();
        this.lblTableTitle = new System.Windows.Forms.Label();
        this.lblCustomerNameError = new System.Windows.Forms.Label();
        this.txtCustomerName = new System.Windows.Forms.TextBox();
        this.lblCustomerTitle = new System.Windows.Forms.Label();
        this.lblOrderNumberBadge = new System.Windows.Forms.Label();
        this.lblOrderNumTitle = new System.Windows.Forms.Label();
        this.grpAddItems = new System.Windows.Forms.GroupBox();
        this.btnAddItem = new System.Windows.Forms.Button();
        this.numQuantity = new System.Windows.Forms.NumericUpDown();
        this.lblQuantity = new System.Windows.Forms.Label();
        this.cboMenuItems = new System.Windows.Forms.ComboBox();
        this.lblMenuItem = new System.Windows.Forms.Label();
        this.grpOrderItems = new System.Windows.Forms.GroupBox();
        this.dgvItems = new System.Windows.Forms.DataGridView();
        this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colAction = new System.Windows.Forms.DataGridViewButtonColumn();
        this.pnlItemsFooter = new System.Windows.Forms.Panel();
        this.lblTotalAmount = new System.Windows.Forms.Label();
        this.lblSummaryQty = new System.Windows.Forms.Label();
        this.pnlActions = new System.Windows.Forms.Panel();
        this.btnBackToDetails = new System.Windows.Forms.Button();
        this.btnCancelChanges = new System.Windows.Forms.Button();
        this.btnSaveChanges = new System.Windows.Forms.Button();
        this.pnlHeader.SuspendLayout();
        this.pnlAlertBanner.SuspendLayout();
        this.grpOrderInfo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numTableNumber)).BeginInit();
        this.grpAddItems.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
        this.grpOrderItems.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
        this.pnlItemsFooter.SuspendLayout();
        this.pnlActions.SuspendLayout();
        this.SuspendLayout();
        // 
        // pnlHeader
        // 
        this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
        this.pnlHeader.Controls.Add(this.lblSubheaderContext);
        this.pnlHeader.Controls.Add(this.lblSubtitle);
        this.pnlHeader.Controls.Add(this.lblTitle);
        this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        this.pnlHeader.Location = new System.Drawing.Point(24, 16);
        this.pnlHeader.Name = "pnlHeader";
        this.pnlHeader.Size = new System.Drawing.Size(996, 56);
        this.pnlHeader.TabIndex = 0;
        // 
        // lblSubheaderContext
        // 
        this.lblSubheaderContext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.lblSubheaderContext.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.lblSubheaderContext.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblSubheaderContext.Location = new System.Drawing.Point(546, 20);
        this.lblSubheaderContext.Name = "lblSubheaderContext";
        this.lblSubheaderContext.Size = new System.Drawing.Size(450, 24);
        this.lblSubheaderContext.TabIndex = 2;
        this.lblSubheaderContext.Text = "#104 • Hana • Table 4 • Existing order";
        this.lblSubheaderContext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblSubtitle
        // 
        this.lblSubtitle.AutoSize = true;
        this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblSubtitle.Location = new System.Drawing.Point(0, 32);
        this.lblSubtitle.Name = "lblSubtitle";
        this.lblSubtitle.Size = new System.Drawing.Size(242, 20);
        this.lblSubtitle.TabIndex = 1;
        this.lblSubtitle.Text = "Update an existing restaurant order";
        // 
        // lblTitle
        // 
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.lblTitle.Location = new System.Drawing.Point(-2, 0);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(147, 37);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Edit Order";
        // 
        // pnlAlertBanner
        // 
        this.pnlAlertBanner.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
        this.pnlAlertBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlAlertBanner.Controls.Add(this.lblAlertMessage);
        this.pnlAlertBanner.Dock = System.Windows.Forms.DockStyle.Top;
        this.pnlAlertBanner.Location = new System.Drawing.Point(24, 72);
        this.pnlAlertBanner.Name = "pnlAlertBanner";
        this.pnlAlertBanner.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
        this.pnlAlertBanner.Size = new System.Drawing.Size(996, 38);
        this.pnlAlertBanner.TabIndex = 1;
        // 
        // lblAlertMessage
        // 
        this.lblAlertMessage.Dock = System.Windows.Forms.DockStyle.Fill;
        this.lblAlertMessage.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblAlertMessage.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblAlertMessage.Location = new System.Drawing.Point(12, 6);
        this.lblAlertMessage.Name = "lblAlertMessage";
        this.lblAlertMessage.Size = new System.Drawing.Size(970, 24);
        this.lblAlertMessage.TabIndex = 0;
        this.lblAlertMessage.Text = "ⓘ Update customer details, add items or change quantities, then save.";
        this.lblAlertMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // grpOrderInfo
        // 
        this.grpOrderInfo.BackColor = System.Drawing.Color.Transparent;
        this.grpOrderInfo.Controls.Add(this.lblCurrentStatusBadge);
        this.grpOrderInfo.Controls.Add(this.lblStatusTitle);
        this.grpOrderInfo.Controls.Add(this.lblTableNumberError);
        this.grpOrderInfo.Controls.Add(this.numTableNumber);
        this.grpOrderInfo.Controls.Add(this.lblTableTitle);
        this.grpOrderInfo.Controls.Add(this.lblCustomerNameError);
        this.grpOrderInfo.Controls.Add(this.txtCustomerName);
        this.grpOrderInfo.Controls.Add(this.lblCustomerTitle);
        this.grpOrderInfo.Controls.Add(this.lblOrderNumberBadge);
        this.grpOrderInfo.Controls.Add(this.lblOrderNumTitle);
        this.grpOrderInfo.Dock = System.Windows.Forms.DockStyle.Top;
        this.grpOrderInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.grpOrderInfo.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.grpOrderInfo.Location = new System.Drawing.Point(24, 110);
        this.grpOrderInfo.Name = "grpOrderInfo";
        this.grpOrderInfo.Padding = new System.Windows.Forms.Padding(16, 10, 16, 12);
        this.grpOrderInfo.Size = new System.Drawing.Size(996, 105);
        this.grpOrderInfo.TabIndex = 2;
        this.grpOrderInfo.TabStop = false;
        this.grpOrderInfo.Text = "Order Information";
        // 
        // lblCurrentStatusBadge
        // 
        this.lblCurrentStatusBadge.AutoSize = true;
        this.lblCurrentStatusBadge.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
        this.lblCurrentStatusBadge.ForeColor = System.Drawing.Color.FromArgb(180, 83, 9);
        this.lblCurrentStatusBadge.Location = new System.Drawing.Point(540, 56);
        this.lblCurrentStatusBadge.Name = "lblCurrentStatusBadge";
        this.lblCurrentStatusBadge.Size = new System.Drawing.Size(81, 25);
        this.lblCurrentStatusBadge.TabIndex = 9;
        this.lblCurrentStatusBadge.Text = "Pending";
        // 
        // lblStatusTitle
        // 
        this.lblStatusTitle.AutoSize = true;
        this.lblStatusTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        this.lblStatusTitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblStatusTitle.Location = new System.Drawing.Point(540, 31);
        this.lblStatusTitle.Name = "lblStatusTitle";
        this.lblStatusTitle.Size = new System.Drawing.Size(53, 20);
        this.lblStatusTitle.TabIndex = 8;
        this.lblStatusTitle.Text = "Status";
        // 
        // lblTableNumberError
        // 
        this.lblTableNumberError.AutoSize = true;
        this.lblTableNumberError.Font = new System.Drawing.Font("Segoe UI", 8F);
        this.lblTableNumberError.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
        this.lblTableNumberError.Location = new System.Drawing.Point(405, 84);
        this.lblTableNumberError.Name = "lblTableNumberError";
        this.lblTableNumberError.Size = new System.Drawing.Size(95, 19);
        this.lblTableNumberError.TabIndex = 7;
        this.lblTableNumberError.Text = "Required table";
        this.lblTableNumberError.Visible = false;
        // 
        // numTableNumber
        // 
        this.numTableNumber.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.numTableNumber.Location = new System.Drawing.Point(405, 54);
        this.numTableNumber.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
        this.numTableNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
        this.numTableNumber.Name = "numTableNumber";
        this.numTableNumber.Size = new System.Drawing.Size(100, 29);
        this.numTableNumber.TabIndex = 6;
        this.numTableNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
        this.numTableNumber.ValueChanged += new System.EventHandler(this.Input_Changed);
        // 
        // lblTableTitle
        // 
        this.lblTableTitle.AutoSize = true;
        this.lblTableTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        this.lblTableTitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblTableTitle.Location = new System.Drawing.Point(405, 31);
        this.lblTableTitle.Name = "lblTableTitle";
        this.lblTableTitle.Size = new System.Drawing.Size(117, 20);
        this.lblTableTitle.TabIndex = 5;
        this.lblTableTitle.Text = "Table Number *";
        // 
        // lblCustomerNameError
        // 
        this.lblCustomerNameError.AutoSize = true;
        this.lblCustomerNameError.Font = new System.Drawing.Font("Segoe UI", 8F);
        this.lblCustomerNameError.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
        this.lblCustomerNameError.Location = new System.Drawing.Point(145, 84);
        this.lblCustomerNameError.Name = "lblCustomerNameError";
        this.lblCustomerNameError.Size = new System.Drawing.Size(168, 19);
        this.lblCustomerNameError.TabIndex = 4;
        this.lblCustomerNameError.Text = "Customer name is required";
        this.lblCustomerNameError.Visible = false;
        // 
        // txtCustomerName
        // 
        this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.txtCustomerName.Location = new System.Drawing.Point(145, 54);
        this.txtCustomerName.Name = "txtCustomerName";
        this.txtCustomerName.Size = new System.Drawing.Size(235, 29);
        this.txtCustomerName.TabIndex = 3;
        this.txtCustomerName.TextChanged += new System.EventHandler(this.Input_Changed);
        // 
        // lblCustomerTitle
        // 
        this.lblCustomerTitle.AutoSize = true;
        this.lblCustomerTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        this.lblCustomerTitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblCustomerTitle.Location = new System.Drawing.Point(145, 31);
        this.lblCustomerTitle.Name = "lblCustomerTitle";
        this.lblCustomerTitle.Size = new System.Drawing.Size(133, 20);
        this.lblCustomerTitle.TabIndex = 2;
        this.lblCustomerTitle.Text = "Customer Name *";
        // 
        // lblOrderNumberBadge
        // 
        this.lblOrderNumberBadge.AutoSize = true;
        this.lblOrderNumberBadge.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.lblOrderNumberBadge.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
        this.lblOrderNumberBadge.Location = new System.Drawing.Point(18, 55);
        this.lblOrderNumberBadge.Name = "lblOrderNumberBadge";
        this.lblOrderNumberBadge.Size = new System.Drawing.Size(90, 25);
        this.lblOrderNumberBadge.TabIndex = 1;
        this.lblOrderNumberBadge.Text = "#104   🔒";
        // 
        // lblOrderNumTitle
        // 
        this.lblOrderNumTitle.AutoSize = true;
        this.lblOrderNumTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        this.lblOrderNumTitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblOrderNumTitle.Location = new System.Drawing.Point(18, 31);
        this.lblOrderNumTitle.Name = "lblOrderNumTitle";
        this.lblOrderNumTitle.Size = new System.Drawing.Size(65, 20);
        this.lblOrderNumTitle.TabIndex = 0;
        this.lblOrderNumTitle.Text = "Order #";
        // 
        // grpAddItems
        // 
        this.grpAddItems.BackColor = System.Drawing.Color.Transparent;
        this.grpAddItems.Controls.Add(this.btnAddItem);
        this.grpAddItems.Controls.Add(this.numQuantity);
        this.grpAddItems.Controls.Add(this.lblQuantity);
        this.grpAddItems.Controls.Add(this.cboMenuItems);
        this.grpAddItems.Controls.Add(this.lblMenuItem);
        this.grpAddItems.Dock = System.Windows.Forms.DockStyle.Top;
        this.grpAddItems.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.grpAddItems.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.grpAddItems.Location = new System.Drawing.Point(24, 215);
        this.grpAddItems.Name = "grpAddItems";
        this.grpAddItems.Padding = new System.Windows.Forms.Padding(16, 10, 16, 12);
        this.grpAddItems.Size = new System.Drawing.Size(996, 95);
        this.grpAddItems.TabIndex = 3;
        this.grpAddItems.TabStop = false;
        this.grpAddItems.Text = "Add Menu Item";
        // 
        // btnAddItem
        // 
        this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(30, 58, 95);
        this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.btnAddItem.Location = new System.Drawing.Point(520, 50);
        this.btnAddItem.Name = "btnAddItem";
        this.btnAddItem.Size = new System.Drawing.Size(120, 31);
        this.btnAddItem.TabIndex = 4;
        this.btnAddItem.Text = "+ Add Item";
        this.btnAddItem.UseVisualStyleBackColor = false;
        this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
        // 
        // numQuantity
        // 
        this.numQuantity.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.numQuantity.Location = new System.Drawing.Point(405, 51);
        this.numQuantity.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
        this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
        this.numQuantity.Name = "numQuantity";
        this.numQuantity.Size = new System.Drawing.Size(95, 29);
        this.numQuantity.TabIndex = 3;
        this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
        // 
        // lblQuantity
        // 
        this.lblQuantity.AutoSize = true;
        this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblQuantity.Location = new System.Drawing.Point(405, 28);
        this.lblQuantity.Name = "lblQuantity";
        this.lblQuantity.Size = new System.Drawing.Size(70, 20);
        this.lblQuantity.TabIndex = 2;
        this.lblQuantity.Text = "Quantity";
        // 
        // cboMenuItems
        // 
        this.cboMenuItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboMenuItems.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.cboMenuItems.FormattingEnabled = true;
        this.cboMenuItems.Location = new System.Drawing.Point(18, 51);
        this.cboMenuItems.Name = "cboMenuItems";
        this.cboMenuItems.Size = new System.Drawing.Size(365, 29);
        this.cboMenuItems.TabIndex = 1;
        // 
        // lblMenuItem
        // 
        this.lblMenuItem.AutoSize = true;
        this.lblMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        this.lblMenuItem.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblMenuItem.Location = new System.Drawing.Point(18, 28);
        this.lblMenuItem.Name = "lblMenuItem";
        this.lblMenuItem.Size = new System.Drawing.Size(86, 20);
        this.lblMenuItem.TabIndex = 0;
        this.lblMenuItem.Text = "Menu Item";
        // 
        // grpOrderItems
        // 
        this.grpOrderItems.BackColor = System.Drawing.Color.Transparent;
        this.grpOrderItems.Controls.Add(this.dgvItems);
        this.grpOrderItems.Controls.Add(this.pnlItemsFooter);
        this.grpOrderItems.Dock = System.Windows.Forms.DockStyle.Fill;
        this.grpOrderItems.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.grpOrderItems.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.grpOrderItems.Location = new System.Drawing.Point(24, 310);
        this.grpOrderItems.Name = "grpOrderItems";
        this.grpOrderItems.Padding = new System.Windows.Forms.Padding(16, 10, 16, 12);
        this.grpOrderItems.Size = new System.Drawing.Size(996, 310);
        this.grpOrderItems.TabIndex = 4;
        this.grpOrderItems.TabStop = false;
        this.grpOrderItems.Text = "Order Items";
        // 
        // dgvItems
        // 
        this.dgvItems.AllowUserToAddRows = false;
        this.dgvItems.AllowUserToDeleteRows = false;
        this.dgvItems.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        this.dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvItems.BackgroundColor = System.Drawing.Color.White;
        this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.dgvItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemName,
            this.colUnitPrice,
            this.colQuantity,
            this.colSubtotal,
            this.colAction});
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        this.dgvItems.DefaultCellStyle = dataGridViewCellStyle3;
        this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvItems.EnableHeadersVisualStyles = false;
        this.dgvItems.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
        this.dgvItems.Location = new System.Drawing.Point(16, 33);
        this.dgvItems.MultiSelect = false;
        this.dgvItems.Name = "dgvItems";
        this.dgvItems.ReadOnly = true;
        this.dgvItems.RowHeadersVisible = false;
        this.dgvItems.RowHeadersWidth = 51;
        this.dgvItems.RowTemplate.Height = 36;
        this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvItems.Size = new System.Drawing.Size(964, 220);
        this.dgvItems.TabIndex = 0;
        this.dgvItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellContentClick);
        // 
        // colItemName
        // 
        this.colItemName.FillWeight = 36F;
        this.colItemName.HeaderText = "Item Name";
        this.colItemName.MinimumWidth = 6;
        this.colItemName.Name = "colItemName";
        this.colItemName.ReadOnly = true;
        // 
        // colUnitPrice
        // 
        this.colUnitPrice.FillWeight = 18F;
        this.colUnitPrice.HeaderText = "Unit Price";
        this.colUnitPrice.MinimumWidth = 6;
        this.colUnitPrice.Name = "colUnitPrice";
        this.colUnitPrice.ReadOnly = true;
        // 
        // colQuantity
        // 
        this.colQuantity.FillWeight = 16F;
        this.colQuantity.HeaderText = "Quantity";
        this.colQuantity.MinimumWidth = 6;
        this.colQuantity.Name = "colQuantity";
        this.colQuantity.ReadOnly = true;
        // 
        // colSubtotal
        // 
        this.colSubtotal.FillWeight = 18F;
        this.colSubtotal.HeaderText = "Subtotal";
        this.colSubtotal.MinimumWidth = 6;
        this.colSubtotal.Name = "colSubtotal";
        this.colSubtotal.ReadOnly = true;
        // 
        // colAction
        // 
        this.colAction.FillWeight = 12F;
        this.colAction.HeaderText = "Action";
        this.colAction.MinimumWidth = 6;
        this.colAction.Name = "colAction";
        this.colAction.ReadOnly = true;
        this.colAction.Text = "Remove";
        this.colAction.UseColumnTextForButtonValue = true;
        // 
        // pnlItemsFooter
        // 
        this.pnlItemsFooter.Controls.Add(this.lblTotalAmount);
        this.pnlItemsFooter.Controls.Add(this.lblSummaryQty);
        this.pnlItemsFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.pnlItemsFooter.Location = new System.Drawing.Point(16, 253);
        this.pnlItemsFooter.Name = "pnlItemsFooter";
        this.pnlItemsFooter.Size = new System.Drawing.Size(964, 45);
        this.pnlItemsFooter.TabIndex = 1;
        // 
        // lblTotalAmount
        // 
        this.lblTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        this.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
        this.lblTotalAmount.Location = new System.Drawing.Point(620, 6);
        this.lblTotalAmount.Name = "lblTotalAmount";
        this.lblTotalAmount.Size = new System.Drawing.Size(344, 34);
        this.lblTotalAmount.TabIndex = 1;
        this.lblTotalAmount.Text = "Total: 260 ETB";
        this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblSummaryQty
        // 
        this.lblSummaryQty.AutoSize = true;
        this.lblSummaryQty.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblSummaryQty.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblSummaryQty.Location = new System.Drawing.Point(4, 12);
        this.lblSummaryQty.Name = "lblSummaryQty";
        this.lblSummaryQty.Size = new System.Drawing.Size(166, 20);
        this.lblSummaryQty.TabIndex = 0;
        this.lblSummaryQty.Text = "2 items • 3 total quantity";
        // 
        // pnlActions
        // 
        this.pnlActions.BackColor = System.Drawing.Color.Transparent;
        this.pnlActions.Controls.Add(this.btnBackToDetails);
        this.pnlActions.Controls.Add(this.btnCancelChanges);
        this.pnlActions.Controls.Add(this.btnSaveChanges);
        this.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.pnlActions.Location = new System.Drawing.Point(24, 620);
        this.pnlActions.Name = "pnlActions";
        this.pnlActions.Size = new System.Drawing.Size(996, 60);
        this.pnlActions.TabIndex = 5;
        // 
        // btnBackToDetails
        // 
        this.btnBackToDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnBackToDetails.BackColor = System.Drawing.Color.White;
        this.btnBackToDetails.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnBackToDetails.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.btnBackToDetails.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.btnBackToDetails.Location = new System.Drawing.Point(806, 12);
        this.btnBackToDetails.Name = "btnBackToDetails";
        this.btnBackToDetails.Size = new System.Drawing.Size(190, 36);
        this.btnBackToDetails.TabIndex = 2;
        this.btnBackToDetails.Text = "← Back to Order Details";
        this.btnBackToDetails.UseVisualStyleBackColor = false;
        this.btnBackToDetails.Visible = false;
        this.btnBackToDetails.Click += new System.EventHandler(this.btnBackToDetails_Click);
        // 
        // btnCancelChanges
        // 
        this.btnCancelChanges.BackColor = System.Drawing.Color.White;
        this.btnCancelChanges.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnCancelChanges.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.btnCancelChanges.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.btnCancelChanges.Location = new System.Drawing.Point(165, 12);
        this.btnCancelChanges.Name = "btnCancelChanges";
        this.btnCancelChanges.Size = new System.Drawing.Size(140, 36);
        this.btnCancelChanges.TabIndex = 1;
        this.btnCancelChanges.Text = "Cancel Changes";
        this.btnCancelChanges.UseVisualStyleBackColor = false;
        this.btnCancelChanges.Click += new System.EventHandler(this.btnCancelChanges_Click);
        // 
        // btnSaveChanges
        // 
        this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(30, 58, 95);
        this.btnSaveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.btnSaveChanges.Location = new System.Drawing.Point(0, 12);
        this.btnSaveChanges.Name = "btnSaveChanges";
        this.btnSaveChanges.Size = new System.Drawing.Size(155, 36);
        this.btnSaveChanges.TabIndex = 0;
        this.btnSaveChanges.Text = "💾 Save Changes";
        this.btnSaveChanges.UseVisualStyleBackColor = false;
        this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
        // 
        // EditOrderView
        // 
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
        this.Controls.Add(this.grpOrderItems);
        this.Controls.Add(this.grpAddItems);
        this.Controls.Add(this.grpOrderInfo);
        this.Controls.Add(this.pnlAlertBanner);
        this.Controls.Add(this.pnlActions);
        this.Controls.Add(this.pnlHeader);
        this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.Name = "EditOrderView";
        this.Padding = new System.Windows.Forms.Padding(24, 16, 24, 20);
        this.Size = new System.Drawing.Size(1044, 700);
        this.pnlHeader.ResumeLayout(false);
        this.pnlHeader.PerformLayout();
        this.pnlAlertBanner.ResumeLayout(false);
        this.grpOrderInfo.ResumeLayout(false);
        this.grpOrderInfo.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numTableNumber)).EndInit();
        this.grpAddItems.ResumeLayout(false);
        this.grpAddItems.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
        this.grpOrderItems.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
        this.pnlItemsFooter.ResumeLayout(false);
        this.pnlItemsFooter.PerformLayout();
        this.pnlActions.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Label lblSubheaderContext;
    private System.Windows.Forms.Panel pnlAlertBanner;
    private System.Windows.Forms.Label lblAlertMessage;
    private System.Windows.Forms.GroupBox grpOrderInfo;
    private System.Windows.Forms.Label lblOrderNumTitle;
    private System.Windows.Forms.Label lblOrderNumberBadge;
    private System.Windows.Forms.Label lblCustomerTitle;
    private System.Windows.Forms.TextBox txtCustomerName;
    private System.Windows.Forms.Label lblCustomerNameError;
    private System.Windows.Forms.Label lblTableTitle;
    private System.Windows.Forms.NumericUpDown numTableNumber;
    private System.Windows.Forms.Label lblTableNumberError;
    private System.Windows.Forms.Label lblStatusTitle;
    private System.Windows.Forms.Label lblCurrentStatusBadge;
    private System.Windows.Forms.GroupBox grpAddItems;
    private System.Windows.Forms.Label lblMenuItem;
    private System.Windows.Forms.ComboBox cboMenuItems;
    private System.Windows.Forms.Label lblQuantity;
    private System.Windows.Forms.NumericUpDown numQuantity;
    private System.Windows.Forms.Button btnAddItem;
    private System.Windows.Forms.GroupBox grpOrderItems;
    private System.Windows.Forms.DataGridView dgvItems;
    private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
    private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
    private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
    private System.Windows.Forms.DataGridViewButtonColumn colAction;
    private System.Windows.Forms.Panel pnlItemsFooter;
    private System.Windows.Forms.Label lblSummaryQty;
    private System.Windows.Forms.Label lblTotalAmount;
    private System.Windows.Forms.Panel pnlActions;
    private System.Windows.Forms.Button btnSaveChanges;
    private System.Windows.Forms.Button btnCancelChanges;
    private System.Windows.Forms.Button btnBackToDetails;
}
