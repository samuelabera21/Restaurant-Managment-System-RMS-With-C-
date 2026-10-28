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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        pnlHeader = new Panel();
        lblSubheaderContext = new Label();
        lblSubtitle = new Label();
        lblTitle = new Label();
        pnlAlertBanner = new Panel();
        lblAlertMessage = new Label();
        grpOrderInfo = new GroupBox();
        lblCurrentStatusBadge = new Label();
        lblStatusTitle = new Label();
        lblTableNumberError = new Label();
        numTableNumber = new NumericUpDown();
        lblTableTitle = new Label();
        lblCustomerNameError = new Label();
        txtCustomerName = new TextBox();
        lblCustomerTitle = new Label();
        lblOrderNumberBadge = new Label();
        lblOrderNumTitle = new Label();
        grpAddItems = new GroupBox();
        btnAddItem = new Button();
        numQuantity = new NumericUpDown();
        lblQuantity = new Label();
        cboMenuItems = new ComboBox();
        lblMenuItem = new Label();
        grpOrderItems = new GroupBox();
        dgvItems = new DataGridView();
        colItemName = new DataGridViewTextBoxColumn();
        colUnitPrice = new DataGridViewTextBoxColumn();
        colQuantity = new DataGridViewTextBoxColumn();
        colSubtotal = new DataGridViewTextBoxColumn();
        colAction = new DataGridViewButtonColumn();
        pnlItemsFooter = new Panel();
        lblTotalAmount = new Label();
        lblSummaryQty = new Label();
        pnlActions = new Panel();
        btnBackToDetails = new Button();
        btnCancelChanges = new Button();
        btnSaveChanges = new Button();
        pnlHeader.SuspendLayout();
        pnlAlertBanner.SuspendLayout();
        grpOrderInfo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numTableNumber).BeginInit();
        grpAddItems.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
        grpOrderItems.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
        pnlItemsFooter.SuspendLayout();
        pnlActions.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = Color.Transparent;
        pnlHeader.Controls.Add(lblSubheaderContext);
        pnlHeader.Controls.Add(lblSubtitle);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Location = new Point(24, 16);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new Size(1072, 56);
        pnlHeader.TabIndex = 0;
        // 
        // lblSubheaderContext
        // 
        lblSubheaderContext.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblSubheaderContext.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        lblSubheaderContext.ForeColor = Color.FromArgb(71, 85, 105);
        lblSubheaderContext.Location = new Point(622, 20);
        lblSubheaderContext.Name = "lblSubheaderContext";
        lblSubheaderContext.Size = new Size(450, 24);
        lblSubheaderContext.TabIndex = 2;
        lblSubheaderContext.Text = "#104 • Hana • Table 4 • Existing order";
        lblSubheaderContext.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new Font("Segoe UI", 9F);
        lblSubtitle.ForeColor = Color.FromArgb(71, 85, 105);
        lblSubtitle.Location = new Point(0, 32);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(291, 25);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Update an existing restaurant order";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
        lblTitle.Location = new Point(-9, -13);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(174, 45);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Edit Order";
        // 
        // pnlAlertBanner
        // 
        pnlAlertBanner.BackColor = Color.FromArgb(241, 245, 249);
        pnlAlertBanner.BorderStyle = BorderStyle.FixedSingle;
        pnlAlertBanner.Controls.Add(lblAlertMessage);
        pnlAlertBanner.Dock = DockStyle.Top;
        pnlAlertBanner.Location = new Point(24, 72);
        pnlAlertBanner.Name = "pnlAlertBanner";
        pnlAlertBanner.Padding = new Padding(12, 6, 12, 6);
        pnlAlertBanner.Size = new Size(1072, 38);
        pnlAlertBanner.TabIndex = 1;
        // 
        // lblAlertMessage
        // 
        lblAlertMessage.Dock = DockStyle.Fill;
        lblAlertMessage.Font = new Font("Segoe UI", 9F);
        lblAlertMessage.ForeColor = Color.FromArgb(71, 85, 105);
        lblAlertMessage.Location = new Point(12, 6);
        lblAlertMessage.Name = "lblAlertMessage";
        lblAlertMessage.Size = new Size(1046, 24);
        lblAlertMessage.TabIndex = 0;
        lblAlertMessage.Text = "ⓘ Update customer details, add items or change quantities, then save.";
        lblAlertMessage.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // grpOrderInfo
        // 
        grpOrderInfo.BackColor = Color.Transparent;
        grpOrderInfo.Controls.Add(lblCurrentStatusBadge);
        grpOrderInfo.Controls.Add(lblStatusTitle);
        grpOrderInfo.Controls.Add(lblTableNumberError);
        grpOrderInfo.Controls.Add(numTableNumber);
        grpOrderInfo.Controls.Add(lblTableTitle);
        grpOrderInfo.Controls.Add(lblCustomerNameError);
        grpOrderInfo.Controls.Add(txtCustomerName);
        grpOrderInfo.Controls.Add(lblCustomerTitle);
        grpOrderInfo.Controls.Add(lblOrderNumberBadge);
        grpOrderInfo.Controls.Add(lblOrderNumTitle);
        grpOrderInfo.Dock = DockStyle.Top;
        grpOrderInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        grpOrderInfo.ForeColor = Color.FromArgb(15, 23, 42);
        grpOrderInfo.Location = new Point(24, 110);
        grpOrderInfo.Name = "grpOrderInfo";
        grpOrderInfo.Padding = new Padding(16, 10, 16, 12);
        grpOrderInfo.Size = new Size(1072, 105);
        grpOrderInfo.TabIndex = 2;
        grpOrderInfo.TabStop = false;
        grpOrderInfo.Text = "Order Information";
        // 
        // lblCurrentStatusBadge
        // 
        lblCurrentStatusBadge.AutoSize = true;
        lblCurrentStatusBadge.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
        lblCurrentStatusBadge.ForeColor = Color.FromArgb(180, 83, 9);
        lblCurrentStatusBadge.Location = new Point(540, 56);
        lblCurrentStatusBadge.Name = "lblCurrentStatusBadge";
        lblCurrentStatusBadge.Size = new Size(94, 30);
        lblCurrentStatusBadge.TabIndex = 9;
        lblCurrentStatusBadge.Text = "Pending";
        // 
        // lblStatusTitle
        // 
        lblStatusTitle.AutoSize = true;
        lblStatusTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblStatusTitle.ForeColor = Color.FromArgb(71, 85, 105);
        lblStatusTitle.Location = new Point(540, 31);
        lblStatusTitle.Name = "lblStatusTitle";
        lblStatusTitle.Size = new Size(60, 23);
        lblStatusTitle.TabIndex = 8;
        lblStatusTitle.Text = "Status";
        // 
        // lblTableNumberError
        // 
        lblTableNumberError.AutoSize = true;
        lblTableNumberError.Font = new Font("Segoe UI", 8F);
        lblTableNumberError.ForeColor = Color.FromArgb(220, 38, 38);
        lblTableNumberError.Location = new Point(405, 84);
        lblTableNumberError.Name = "lblTableNumberError";
        lblTableNumberError.Size = new Size(111, 21);
        lblTableNumberError.TabIndex = 7;
        lblTableNumberError.Text = "Required table";
        lblTableNumberError.Visible = false;
        // 
        // numTableNumber
        // 
        numTableNumber.Font = new Font("Segoe UI", 9.5F);
        numTableNumber.Location = new Point(405, 54);
        numTableNumber.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
        numTableNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numTableNumber.Name = "numTableNumber";
        numTableNumber.Size = new Size(100, 33);
        numTableNumber.TabIndex = 6;
        numTableNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
        numTableNumber.ValueChanged += Input_Changed;
        // 
        // lblTableTitle
        // 
        lblTableTitle.AutoSize = true;
        lblTableTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblTableTitle.ForeColor = Color.FromArgb(71, 85, 105);
        lblTableTitle.Location = new Point(405, 31);
        lblTableTitle.Name = "lblTableTitle";
        lblTableTitle.Size = new Size(137, 23);
        lblTableTitle.TabIndex = 5;
        lblTableTitle.Text = "Table Number *";
        // 
        // lblCustomerNameError
        // 
        lblCustomerNameError.AutoSize = true;
        lblCustomerNameError.Font = new Font("Segoe UI", 8F);
        lblCustomerNameError.ForeColor = Color.FromArgb(220, 38, 38);
        lblCustomerNameError.Location = new Point(145, 84);
        lblCustomerNameError.Name = "lblCustomerNameError";
        lblCustomerNameError.Size = new Size(199, 21);
        lblCustomerNameError.TabIndex = 4;
        lblCustomerNameError.Text = "Customer name is required";
        lblCustomerNameError.Visible = false;
        // 
        // txtCustomerName
        // 
        txtCustomerName.Font = new Font("Segoe UI", 9.5F);
        txtCustomerName.Location = new Point(145, 54);
        txtCustomerName.Name = "txtCustomerName";
        txtCustomerName.Size = new Size(235, 33);
        txtCustomerName.TabIndex = 3;
        txtCustomerName.TextChanged += Input_Changed;
        // 
        // lblCustomerTitle
        // 
        lblCustomerTitle.AutoSize = true;
        lblCustomerTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblCustomerTitle.ForeColor = Color.FromArgb(71, 85, 105);
        lblCustomerTitle.Location = new Point(145, 31);
        lblCustomerTitle.Name = "lblCustomerTitle";
        lblCustomerTitle.Size = new Size(152, 23);
        lblCustomerTitle.TabIndex = 2;
        lblCustomerTitle.Text = "Customer Name *";
        // 
        // lblOrderNumberBadge
        // 
        lblOrderNumberBadge.AutoSize = true;
        lblOrderNumberBadge.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblOrderNumberBadge.ForeColor = Color.FromArgb(30, 58, 95);
        lblOrderNumberBadge.Location = new Point(18, 55);
        lblOrderNumberBadge.Name = "lblOrderNumberBadge";
        lblOrderNumberBadge.Size = new Size(114, 30);
        lblOrderNumberBadge.TabIndex = 1;
        lblOrderNumberBadge.Text = "#104   🔒";
        // 
        // lblOrderNumTitle
        // 
        lblOrderNumTitle.AutoSize = true;
        lblOrderNumTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblOrderNumTitle.ForeColor = Color.FromArgb(71, 85, 105);
        lblOrderNumTitle.Location = new Point(18, 31);
        lblOrderNumTitle.Name = "lblOrderNumTitle";
        lblOrderNumTitle.Size = new Size(72, 23);
        lblOrderNumTitle.TabIndex = 0;
        lblOrderNumTitle.Text = "Order #";
        // 
        // grpAddItems
        // 
        grpAddItems.BackColor = Color.Transparent;
        grpAddItems.Controls.Add(btnAddItem);
        grpAddItems.Controls.Add(numQuantity);
        grpAddItems.Controls.Add(lblQuantity);
        grpAddItems.Controls.Add(cboMenuItems);
        grpAddItems.Controls.Add(lblMenuItem);
        grpAddItems.Dock = DockStyle.Top;
        grpAddItems.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        grpAddItems.ForeColor = Color.FromArgb(15, 23, 42);
        grpAddItems.Location = new Point(24, 215);
        grpAddItems.Name = "grpAddItems";
        grpAddItems.Padding = new Padding(16, 10, 16, 12);
        grpAddItems.Size = new Size(1072, 95);
        grpAddItems.TabIndex = 3;
        grpAddItems.TabStop = false;
        grpAddItems.Text = "Add Menu Item";
        // 
        // btnAddItem
        // 
        btnAddItem.BackColor = Color.FromArgb(30, 58, 95);
        btnAddItem.Cursor = Cursors.Hand;
        btnAddItem.FlatStyle = FlatStyle.System;
        btnAddItem.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        btnAddItem.Location = new Point(520, 50);
        btnAddItem.Name = "btnAddItem";
        btnAddItem.Size = new Size(120, 31);
        btnAddItem.TabIndex = 4;
        btnAddItem.Text = "+ Add Item";
        btnAddItem.UseVisualStyleBackColor = false;
        btnAddItem.Click += btnAddItem_Click;
        // 
        // numQuantity
        // 
        numQuantity.Font = new Font("Segoe UI", 9.5F);
        numQuantity.Location = new Point(405, 51);
        numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numQuantity.Name = "numQuantity";
        numQuantity.Size = new Size(95, 33);
        numQuantity.TabIndex = 3;
        numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // lblQuantity
        // 
        lblQuantity.AutoSize = true;
        lblQuantity.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblQuantity.ForeColor = Color.FromArgb(71, 85, 105);
        lblQuantity.Location = new Point(405, 28);
        lblQuantity.Name = "lblQuantity";
        lblQuantity.Size = new Size(80, 23);
        lblQuantity.TabIndex = 2;
        lblQuantity.Text = "Quantity";
        // 
        // cboMenuItems
        // 
        cboMenuItems.DropDownStyle = ComboBoxStyle.DropDownList;
        cboMenuItems.Font = new Font("Segoe UI", 9.5F);
        cboMenuItems.FormattingEnabled = true;
        cboMenuItems.Location = new Point(18, 51);
        cboMenuItems.Name = "cboMenuItems";
        cboMenuItems.Size = new Size(365, 33);
        cboMenuItems.TabIndex = 1;
        // 
        // lblMenuItem
        // 
        lblMenuItem.AutoSize = true;
        lblMenuItem.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblMenuItem.ForeColor = Color.FromArgb(71, 85, 105);
        lblMenuItem.Location = new Point(18, 28);
        lblMenuItem.Name = "lblMenuItem";
        lblMenuItem.Size = new Size(97, 23);
        lblMenuItem.TabIndex = 0;
        lblMenuItem.Text = "Menu Item";
        // 
        // grpOrderItems
        // 
        grpOrderItems.BackColor = Color.Transparent;
        grpOrderItems.Controls.Add(dgvItems);
        grpOrderItems.Controls.Add(pnlItemsFooter);
        grpOrderItems.Dock = DockStyle.Fill;
        grpOrderItems.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        grpOrderItems.ForeColor = Color.FromArgb(15, 23, 42);
        grpOrderItems.Location = new Point(24, 310);
        grpOrderItems.Name = "grpOrderItems";
        grpOrderItems.Padding = new Padding(16, 10, 16, 12);
        grpOrderItems.Size = new Size(1072, 163);
        grpOrderItems.TabIndex = 4;
        grpOrderItems.TabStop = false;
        grpOrderItems.Text = "Order Items";
        // 
        // dgvItems
        // 
        dgvItems.AllowUserToAddRows = false;
        dgvItems.AllowUserToDeleteRows = false;
        dgvItems.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
        dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvItems.BackgroundColor = Color.White;
        dgvItems.BorderStyle = BorderStyle.Fixed3D;
        dgvItems.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle2.Padding = new Padding(4, 6, 4, 6);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvItems.Columns.AddRange(new DataGridViewColumn[] { colItemName, colUnitPrice, colQuantity, colSubtotal, colAction });
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.White;
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle3.Padding = new Padding(4);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(219, 234, 254);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        dgvItems.DefaultCellStyle = dataGridViewCellStyle3;
        dgvItems.Dock = DockStyle.Fill;
        dgvItems.EnableHeadersVisualStyles = false;
        dgvItems.GridColor = Color.FromArgb(226, 232, 240);
        dgvItems.Location = new Point(16, 37);
        dgvItems.MultiSelect = false;
        dgvItems.Name = "dgvItems";
        dgvItems.ReadOnly = true;
        dgvItems.RowHeadersVisible = false;
        dgvItems.RowHeadersWidth = 51;
        dgvItems.RowTemplate.Height = 36;
        dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvItems.Size = new Size(1040, 69);
        dgvItems.TabIndex = 0;
        dgvItems.CellContentClick += dgvItems_CellContentClick;
        // 
        // colItemName
        // 
        colItemName.FillWeight = 36F;
        colItemName.HeaderText = "Item Name";
        colItemName.MinimumWidth = 6;
        colItemName.Name = "colItemName";
        colItemName.ReadOnly = true;
        // 
        // colUnitPrice
        // 
        colUnitPrice.FillWeight = 18F;
        colUnitPrice.HeaderText = "Unit Price";
        colUnitPrice.MinimumWidth = 6;
        colUnitPrice.Name = "colUnitPrice";
        colUnitPrice.ReadOnly = true;
        // 
        // colQuantity
        // 
        colQuantity.FillWeight = 16F;
        colQuantity.HeaderText = "Quantity";
        colQuantity.MinimumWidth = 6;
        colQuantity.Name = "colQuantity";
        colQuantity.ReadOnly = true;
        // 
        // colSubtotal
        // 
        colSubtotal.FillWeight = 18F;
        colSubtotal.HeaderText = "Subtotal";
        colSubtotal.MinimumWidth = 6;
        colSubtotal.Name = "colSubtotal";
        colSubtotal.ReadOnly = true;
        // 
        // colAction
        // 
        colAction.FillWeight = 12F;
        colAction.HeaderText = "Action";
        colAction.MinimumWidth = 6;
        colAction.Name = "colAction";
        colAction.ReadOnly = true;
        colAction.Text = "Remove";
        colAction.UseColumnTextForButtonValue = true;
        // 
        // pnlItemsFooter
        // 
        pnlItemsFooter.Controls.Add(lblTotalAmount);
        pnlItemsFooter.Controls.Add(lblSummaryQty);
        pnlItemsFooter.Dock = DockStyle.Bottom;
        pnlItemsFooter.Location = new Point(16, 106);
        pnlItemsFooter.Name = "pnlItemsFooter";
        pnlItemsFooter.Size = new Size(1040, 45);
        pnlItemsFooter.TabIndex = 1;
        // 
        // lblTotalAmount
        // 
        lblTotalAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblTotalAmount.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblTotalAmount.ForeColor = Color.FromArgb(30, 58, 95);
        lblTotalAmount.Location = new Point(696, 6);
        lblTotalAmount.Name = "lblTotalAmount";
        lblTotalAmount.Size = new Size(344, 34);
        lblTotalAmount.TabIndex = 1;
        lblTotalAmount.Text = "Total: 260 ETB";
        lblTotalAmount.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblSummaryQty
        // 
        lblSummaryQty.AutoSize = true;
        lblSummaryQty.Font = new Font("Segoe UI", 9F);
        lblSummaryQty.ForeColor = Color.FromArgb(71, 85, 105);
        lblSummaryQty.Location = new Point(4, 12);
        lblSummaryQty.Name = "lblSummaryQty";
        lblSummaryQty.Size = new Size(208, 25);
        lblSummaryQty.TabIndex = 0;
        lblSummaryQty.Text = "2 items • 3 total quantity";
        // 
        // pnlActions
        // 
        pnlActions.BackColor = Color.Transparent;
        pnlActions.Controls.Add(btnBackToDetails);
        pnlActions.Controls.Add(btnCancelChanges);
        pnlActions.Controls.Add(btnSaveChanges);
        pnlActions.Dock = DockStyle.Bottom;
        pnlActions.Location = new Point(24, 473);
        pnlActions.Name = "pnlActions";
        pnlActions.Size = new Size(1072, 60);
        pnlActions.TabIndex = 5;
        // 
        // btnBackToDetails
        // 
        btnBackToDetails.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnBackToDetails.BackColor = Color.White;
        btnBackToDetails.Cursor = Cursors.Hand;
        btnBackToDetails.FlatStyle = FlatStyle.System;
        btnBackToDetails.Font = new Font("Segoe UI", 9.5F);
        btnBackToDetails.Location = new Point(882, 12);
        btnBackToDetails.Name = "btnBackToDetails";
        btnBackToDetails.Size = new Size(190, 36);
        btnBackToDetails.TabIndex = 2;
        btnBackToDetails.Text = "← Back to Order Details";
        btnBackToDetails.UseVisualStyleBackColor = false;
        btnBackToDetails.Visible = false;
        btnBackToDetails.Click += btnBackToDetails_Click;
        // 
        // btnCancelChanges
        // 
        btnCancelChanges.BackColor = Color.White;
        btnCancelChanges.Cursor = Cursors.Hand;
        btnCancelChanges.FlatStyle = FlatStyle.System;
        btnCancelChanges.Font = new Font("Segoe UI", 9.5F);
        btnCancelChanges.Location = new Point(165, 12);
        btnCancelChanges.Name = "btnCancelChanges";
        btnCancelChanges.Size = new Size(140, 36);
        btnCancelChanges.TabIndex = 1;
        btnCancelChanges.Text = "Cancel Changes";
        btnCancelChanges.UseVisualStyleBackColor = false;
        btnCancelChanges.Click += btnCancelChanges_Click;
        // 
        // btnSaveChanges
        // 
        btnSaveChanges.BackColor = Color.FromArgb(30, 58, 95);
        btnSaveChanges.Cursor = Cursors.Hand;
        btnSaveChanges.FlatStyle = FlatStyle.System;
        btnSaveChanges.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        btnSaveChanges.Location = new Point(0, 12);
        btnSaveChanges.Name = "btnSaveChanges";
        btnSaveChanges.Size = new Size(155, 36);
        btnSaveChanges.TabIndex = 0;
        btnSaveChanges.Text = "💾 Save Changes";
        btnSaveChanges.UseVisualStyleBackColor = false;
        btnSaveChanges.Click += btnSaveChanges_Click;
        // 
        // EditOrderView
        // 
        AutoScaleDimensions = new SizeF(144F, 144F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.FromArgb(243, 244, 246);
        Controls.Add(grpOrderItems);
        Controls.Add(grpAddItems);
        Controls.Add(grpOrderInfo);
        Controls.Add(pnlAlertBanner);
        Controls.Add(pnlActions);
        Controls.Add(pnlHeader);
        Name = "EditOrderView";
        Padding = new Padding(24, 16, 24, 20);
        Size = new Size(1120, 553);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlAlertBanner.ResumeLayout(false);
        grpOrderInfo.ResumeLayout(false);
        grpOrderInfo.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numTableNumber).EndInit();
        grpAddItems.ResumeLayout(false);
        grpAddItems.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
        grpOrderItems.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
        pnlItemsFooter.ResumeLayout(false);
        pnlItemsFooter.PerformLayout();
        pnlActions.ResumeLayout(false);
        ResumeLayout(false);
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

