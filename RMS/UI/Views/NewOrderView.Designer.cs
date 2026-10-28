namespace RMS.UI.Views;

partial class NewOrderView
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
        this.lblTitle = new System.Windows.Forms.Label();
        this.lblAlertMessage = new System.Windows.Forms.Label();
        this.grpOrderInfo = new System.Windows.Forms.GroupBox();
        this.txtOrderDateTime = new System.Windows.Forms.TextBox();
        this.lblOrderDateTime = new System.Windows.Forms.Label();
        this.numTableNumber = new System.Windows.Forms.NumericUpDown();
        this.lblTableNumber = new System.Windows.Forms.Label();
        this.txtCustomerName = new System.Windows.Forms.TextBox();
        this.lblCustomerName = new System.Windows.Forms.Label();
        this.txtOrderNumber = new System.Windows.Forms.TextBox();
        this.lblOrderNumber = new System.Windows.Forms.Label();
        this.grpAddItem = new System.Windows.Forms.GroupBox();
        this.btnAddItem = new System.Windows.Forms.Button();
        this.numQuantity = new System.Windows.Forms.NumericUpDown();
        this.lblQuantity = new System.Windows.Forms.Label();
        this.cboMenuItems = new System.Windows.Forms.ComboBox();
        this.lblMenuItem = new System.Windows.Forms.Label();
        this.grpOrderItems = new System.Windows.Forms.GroupBox();
        this.dgvOrderItems = new System.Windows.Forms.DataGridView();
        this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colRemove = new System.Windows.Forms.DataGridViewButtonColumn();
        this.pnlOrderItemsBottom = new System.Windows.Forms.Panel();
        this.lblTotal = new System.Windows.Forms.Label();
        this.pnlActions = new System.Windows.Forms.Panel();
        this.btnCancel = new System.Windows.Forms.Button();
        this.btnViewOrders = new System.Windows.Forms.Button();
        this.btnClearForm = new System.Windows.Forms.Button();
        this.btnSaveOrder = new System.Windows.Forms.Button();
        this.pnlHeader.SuspendLayout();
        this.grpOrderInfo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numTableNumber)).BeginInit();
        this.grpAddItem.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
        this.grpOrderItems.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
        this.pnlOrderItemsBottom.SuspendLayout();
        this.pnlActions.SuspendLayout();
        this.SuspendLayout();
        // 
        // pnlHeader
        // 
        this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
        this.pnlHeader.Controls.Add(this.lblTitle);
        this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        this.pnlHeader.Location = new System.Drawing.Point(24, 16);
        this.pnlHeader.Name = "pnlHeader";
        this.pnlHeader.Size = new System.Drawing.Size(1072, 44);
        this.pnlHeader.TabIndex = 0;
        // 
        // lblTitle
        // 
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.lblTitle.Location = new System.Drawing.Point(0, 0);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(158, 37);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "New Order";
        // 
        // lblAlertMessage
        // 
        this.lblAlertMessage.BackColor = System.Drawing.Color.FromArgb(254, 242, 242);
        this.lblAlertMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblAlertMessage.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblAlertMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.lblAlertMessage.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
        this.lblAlertMessage.Location = new System.Drawing.Point(24, 60);
        this.lblAlertMessage.Name = "lblAlertMessage";
        this.lblAlertMessage.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
        this.lblAlertMessage.Size = new System.Drawing.Size(1072, 30);
        this.lblAlertMessage.TabIndex = 1;
        this.lblAlertMessage.Text = "Alert message";
        this.lblAlertMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.lblAlertMessage.Visible = false;
        // 
        // grpOrderInfo
        // 
        this.grpOrderInfo.BackColor = System.Drawing.Color.Transparent;
        this.grpOrderInfo.Controls.Add(this.txtOrderDateTime);
        this.grpOrderInfo.Controls.Add(this.lblOrderDateTime);
        this.grpOrderInfo.Controls.Add(this.numTableNumber);
        this.grpOrderInfo.Controls.Add(this.lblTableNumber);
        this.grpOrderInfo.Controls.Add(this.txtCustomerName);
        this.grpOrderInfo.Controls.Add(this.lblCustomerName);
        this.grpOrderInfo.Controls.Add(this.txtOrderNumber);
        this.grpOrderInfo.Controls.Add(this.lblOrderNumber);
        this.grpOrderInfo.Dock = System.Windows.Forms.DockStyle.Top;
        this.grpOrderInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.grpOrderInfo.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.grpOrderInfo.Location = new System.Drawing.Point(24, 90);
        this.grpOrderInfo.Name = "grpOrderInfo";
        this.grpOrderInfo.Size = new System.Drawing.Size(1072, 88);
        this.grpOrderInfo.TabIndex = 2;
        this.grpOrderInfo.TabStop = false;
        this.grpOrderInfo.Text = "Order Information";
        // 
        // txtOrderDateTime
        // 
        this.txtOrderDateTime.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
        this.txtOrderDateTime.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.txtOrderDateTime.Location = new System.Drawing.Point(630, 46);
        this.txtOrderDateTime.Name = "txtOrderDateTime";
        this.txtOrderDateTime.ReadOnly = true;
        this.txtOrderDateTime.Size = new System.Drawing.Size(200, 29);
        this.txtOrderDateTime.TabIndex = 7;
        // 
        // lblOrderDateTime
        // 
        this.lblOrderDateTime.AutoSize = true;
        this.lblOrderDateTime.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        this.lblOrderDateTime.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblOrderDateTime.Location = new System.Drawing.Point(626, 24);
        this.lblOrderDateTime.Name = "lblOrderDateTime";
        this.lblOrderDateTime.Size = new System.Drawing.Size(91, 20);
        this.lblOrderDateTime.TabIndex = 6;
        this.lblOrderDateTime.Text = "Date & Time:";
        // 
        // numTableNumber
        // 
        this.numTableNumber.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.numTableNumber.Location = new System.Drawing.Point(475, 46);
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
        this.numTableNumber.Size = new System.Drawing.Size(120, 29);
        this.numTableNumber.TabIndex = 5;
        this.numTableNumber.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
        // 
        // lblTableNumber
        // 
        this.lblTableNumber.AutoSize = true;
        this.lblTableNumber.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        this.lblTableNumber.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblTableNumber.Location = new System.Drawing.Point(471, 24);
        this.lblTableNumber.Name = "lblTableNumber";
        this.lblTableNumber.Size = new System.Drawing.Size(117, 20);
        this.lblTableNumber.TabIndex = 4;
        this.lblTableNumber.Text = "Table Number: *";
        // 
        // txtCustomerName
        // 
        this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.txtCustomerName.Location = new System.Drawing.Point(170, 46);
        this.txtCustomerName.Name = "txtCustomerName";
        this.txtCustomerName.PlaceholderText = "Enter customer name";
        this.txtCustomerName.Size = new System.Drawing.Size(275, 29);
        this.txtCustomerName.TabIndex = 3;
        this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
        // 
        // lblCustomerName
        // 
        this.lblCustomerName.AutoSize = true;
        this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblCustomerName.Location = new System.Drawing.Point(166, 24);
        this.lblCustomerName.Name = "lblCustomerName";
        this.lblCustomerName.Size = new System.Drawing.Size(130, 20);
        this.lblCustomerName.TabIndex = 2;
        this.lblCustomerName.Text = "Customer Name: *";
        // 
        // txtOrderNumber
        // 
        this.txtOrderNumber.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
        this.txtOrderNumber.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.txtOrderNumber.Location = new System.Drawing.Point(18, 46);
        this.txtOrderNumber.Name = "txtOrderNumber";
        this.txtOrderNumber.ReadOnly = true;
        this.txtOrderNumber.Size = new System.Drawing.Size(120, 29);
        this.txtOrderNumber.TabIndex = 1;
        this.txtOrderNumber.Text = "#116";
        this.txtOrderNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // lblOrderNumber
        // 
        this.lblOrderNumber.AutoSize = true;
        this.lblOrderNumber.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        this.lblOrderNumber.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblOrderNumber.Location = new System.Drawing.Point(14, 24);
        this.lblOrderNumber.Name = "lblOrderNumber";
        this.lblOrderNumber.Size = new System.Drawing.Size(65, 20);
        this.lblOrderNumber.TabIndex = 0;
        this.lblOrderNumber.Text = "Order #:";
        // 
        // grpAddItem
        // 
        this.grpAddItem.BackColor = System.Drawing.Color.Transparent;
        this.grpAddItem.Controls.Add(this.btnAddItem);
        this.grpAddItem.Controls.Add(this.numQuantity);
        this.grpAddItem.Controls.Add(this.lblQuantity);
        this.grpAddItem.Controls.Add(this.cboMenuItems);
        this.grpAddItem.Controls.Add(this.lblMenuItem);
        this.grpAddItem.Dock = System.Windows.Forms.DockStyle.Top;
        this.grpAddItem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.grpAddItem.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.grpAddItem.Location = new System.Drawing.Point(24, 178);
        this.grpAddItem.Name = "grpAddItem";
        this.grpAddItem.Size = new System.Drawing.Size(1072, 85);
        this.grpAddItem.TabIndex = 3;
        this.grpAddItem.TabStop = false;
        this.grpAddItem.Text = "Add Menu Item";
        // 
        // btnAddItem
        // 
        this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(30, 58, 95);
        this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnAddItem.FlatAppearance.BorderSize = 0;
        this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.btnAddItem.ForeColor = System.Drawing.Color.White;
        this.btnAddItem.Location = new System.Drawing.Point(530, 42);
        this.btnAddItem.Name = "btnAddItem";
        this.btnAddItem.Size = new System.Drawing.Size(125, 31);
        this.btnAddItem.TabIndex = 4;
        this.btnAddItem.Text = "+ Add Item";
        this.btnAddItem.UseVisualStyleBackColor = false;
        this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
        // 
        // numQuantity
        // 
        this.numQuantity.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.numQuantity.Location = new System.Drawing.Point(415, 43);
        this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
        this.numQuantity.Name = "numQuantity";
        this.numQuantity.Size = new System.Drawing.Size(90, 29);
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
        this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblQuantity.Location = new System.Drawing.Point(411, 22);
        this.lblQuantity.Name = "lblQuantity";
        this.lblQuantity.Size = new System.Drawing.Size(68, 20);
        this.lblQuantity.TabIndex = 2;
        this.lblQuantity.Text = "Quantity:";
        // 
        // cboMenuItems
        // 
        this.cboMenuItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboMenuItems.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.cboMenuItems.FormattingEnabled = true;
        this.cboMenuItems.Location = new System.Drawing.Point(18, 43);
        this.cboMenuItems.Name = "cboMenuItems";
        this.cboMenuItems.Size = new System.Drawing.Size(370, 29);
        this.cboMenuItems.TabIndex = 1;
        // 
        // lblMenuItem
        // 
        this.lblMenuItem.AutoSize = true;
        this.lblMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        this.lblMenuItem.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblMenuItem.Location = new System.Drawing.Point(14, 22);
        this.lblMenuItem.Name = "lblMenuItem";
        this.lblMenuItem.Size = new System.Drawing.Size(86, 20);
        this.lblMenuItem.TabIndex = 0;
        this.lblMenuItem.Text = "Select Item:";
        // 
        // grpOrderItems
        // 
        this.grpOrderItems.BackColor = System.Drawing.Color.Transparent;
        this.grpOrderItems.Controls.Add(this.dgvOrderItems);
        this.grpOrderItems.Controls.Add(this.pnlOrderItemsBottom);
        this.grpOrderItems.Dock = System.Windows.Forms.DockStyle.Fill;
        this.grpOrderItems.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.grpOrderItems.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.grpOrderItems.Location = new System.Drawing.Point(24, 263);
        this.grpOrderItems.Name = "grpOrderItems";
        this.grpOrderItems.Padding = new System.Windows.Forms.Padding(12, 10, 12, 12);
        this.grpOrderItems.Size = new System.Drawing.Size(1072, 220);
        this.grpOrderItems.TabIndex = 4;
        this.grpOrderItems.TabStop = false;
        this.grpOrderItems.Text = "Order Items";
        // 
        // dgvOrderItems
        // 
        this.dgvOrderItems.AllowUserToAddRows = false;
        this.dgvOrderItems.AllowUserToDeleteRows = false;
        this.dgvOrderItems.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        this.dgvOrderItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        this.dgvOrderItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvOrderItems.BackgroundColor = System.Drawing.Color.White;
        this.dgvOrderItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.dgvOrderItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        this.dgvOrderItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        this.dgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvOrderItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItem,
            this.colPrice,
            this.colQty,
            this.colSubtotal,
            this.colRemove});
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        this.dgvOrderItems.DefaultCellStyle = dataGridViewCellStyle3;
        this.dgvOrderItems.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvOrderItems.EnableHeadersVisualStyles = false;
        this.dgvOrderItems.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
        this.dgvOrderItems.Location = new System.Drawing.Point(12, 33);
        this.dgvOrderItems.MultiSelect = false;
        this.dgvOrderItems.Name = "dgvOrderItems";
        this.dgvOrderItems.ReadOnly = true;
        this.dgvOrderItems.RowHeadersVisible = false;
        this.dgvOrderItems.RowHeadersWidth = 51;
        this.dgvOrderItems.RowTemplate.Height = 36;
        this.dgvOrderItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvOrderItems.Size = new System.Drawing.Size(1048, 135);
        this.dgvOrderItems.TabIndex = 0;
        this.dgvOrderItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderItems_CellContentClick);
        // 
        // colItem
        // 
        this.colItem.FillWeight = 160F;
        this.colItem.HeaderText = "Item Name";
        this.colItem.MinimumWidth = 6;
        this.colItem.Name = "colItem";
        this.colItem.ReadOnly = true;
        // 
        // colPrice
        // 
        this.colPrice.FillWeight = 90F;
        this.colPrice.HeaderText = "Unit Price";
        this.colPrice.MinimumWidth = 6;
        this.colPrice.Name = "colPrice";
        this.colPrice.ReadOnly = true;
        // 
        // colQty
        // 
        this.colQty.FillWeight = 70F;
        this.colQty.HeaderText = "Quantity";
        this.colQty.MinimumWidth = 6;
        this.colQty.Name = "colQty";
        this.colQty.ReadOnly = true;
        // 
        // colSubtotal
        // 
        this.colSubtotal.FillWeight = 90F;
        this.colSubtotal.HeaderText = "Subtotal";
        this.colSubtotal.MinimumWidth = 6;
        this.colSubtotal.Name = "colSubtotal";
        this.colSubtotal.ReadOnly = true;
        // 
        // colRemove
        // 
        this.colRemove.FillWeight = 70F;
        this.colRemove.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.colRemove.HeaderText = "Action";
        this.colRemove.MinimumWidth = 6;
        this.colRemove.Name = "colRemove";
        this.colRemove.ReadOnly = true;
        this.colRemove.Text = "Remove";
        this.colRemove.UseColumnTextForButtonValue = true;
        // 
        // pnlOrderItemsBottom
        // 
        this.pnlOrderItemsBottom.BackColor = System.Drawing.Color.Transparent;
        this.pnlOrderItemsBottom.Controls.Add(this.lblTotal);
        this.pnlOrderItemsBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.pnlOrderItemsBottom.Location = new System.Drawing.Point(12, 168);
        this.pnlOrderItemsBottom.Name = "pnlOrderItemsBottom";
        this.pnlOrderItemsBottom.Size = new System.Drawing.Size(1048, 40);
        this.pnlOrderItemsBottom.TabIndex = 1;
        // 
        // lblTotal
        // 
        this.lblTotal.Dock = System.Windows.Forms.DockStyle.Right;
        this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
        this.lblTotal.Location = new System.Drawing.Point(748, 0);
        this.lblTotal.Name = "lblTotal";
        this.lblTotal.Size = new System.Drawing.Size(300, 40);
        this.lblTotal.TabIndex = 0;
        this.lblTotal.Text = "Total: 0 ETB";
        this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // pnlActions
        // 
        this.pnlActions.BackColor = System.Drawing.Color.Transparent;
        this.pnlActions.Controls.Add(this.btnCancel);
        this.pnlActions.Controls.Add(this.btnViewOrders);
        this.pnlActions.Controls.Add(this.btnClearForm);
        this.pnlActions.Controls.Add(this.btnSaveOrder);
        this.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.pnlActions.Location = new System.Drawing.Point(24, 483);
        this.pnlActions.Name = "pnlActions";
        this.pnlActions.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
        this.pnlActions.Size = new System.Drawing.Size(1072, 50);
        this.pnlActions.TabIndex = 5;
        // 
        // btnCancel
        // 
        this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnCancel.BackColor = System.Drawing.Color.White;
        this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.btnCancel.Location = new System.Drawing.Point(962, 8);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new System.Drawing.Size(110, 36);
        this.btnCancel.TabIndex = 3;
        this.btnCancel.Text = "Cancel";
        this.btnCancel.UseVisualStyleBackColor = false;
        this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
        // 
        // btnViewOrders
        // 
        this.btnViewOrders.BackColor = System.Drawing.Color.FromArgb(30, 58, 95);
        this.btnViewOrders.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnViewOrders.FlatAppearance.BorderSize = 0;
        this.btnViewOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnViewOrders.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.btnViewOrders.ForeColor = System.Drawing.Color.White;
        this.btnViewOrders.Location = new System.Drawing.Point(260, 8);
        this.btnViewOrders.Name = "btnViewOrders";
        this.btnViewOrders.Size = new System.Drawing.Size(140, 36);
        this.btnViewOrders.TabIndex = 2;
        this.btnViewOrders.Text = "📋 View Orders";
        this.btnViewOrders.UseVisualStyleBackColor = false;
        this.btnViewOrders.Visible = false;
        this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
        // 
        // btnClearForm
        // 
        this.btnClearForm.BackColor = System.Drawing.Color.White;
        this.btnClearForm.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnClearForm.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.btnClearForm.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.btnClearForm.Location = new System.Drawing.Point(145, 8);
        this.btnClearForm.Name = "btnClearForm";
        this.btnClearForm.Size = new System.Drawing.Size(110, 36);
        this.btnClearForm.TabIndex = 1;
        this.btnClearForm.Text = "Clear Form";
        this.btnClearForm.UseVisualStyleBackColor = false;
        this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
        // 
        // btnSaveOrder
        // 
        this.btnSaveOrder.BackColor = System.Drawing.Color.FromArgb(30, 58, 95);
        this.btnSaveOrder.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnSaveOrder.FlatAppearance.BorderSize = 0;
        this.btnSaveOrder.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.btnSaveOrder.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.btnSaveOrder.ForeColor = System.Drawing.Color.White;
        this.btnSaveOrder.Location = new System.Drawing.Point(0, 8);
        this.btnSaveOrder.Name = "btnSaveOrder";
        this.btnSaveOrder.Size = new System.Drawing.Size(135, 36);
        this.btnSaveOrder.TabIndex = 0;
        this.btnSaveOrder.Text = "💾 Save Order";
        this.btnSaveOrder.UseVisualStyleBackColor = false;
        this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
        // 
        // NewOrderView
        // 
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
        this.Controls.Add(this.grpOrderItems);
        this.Controls.Add(this.grpAddItem);
        this.Controls.Add(this.grpOrderInfo);
        this.Controls.Add(this.lblAlertMessage);
        this.Controls.Add(this.pnlActions);
        this.Controls.Add(this.pnlHeader);
        this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.Name = "NewOrderView";
        this.Padding = new System.Windows.Forms.Padding(24, 16, 24, 20);
        this.Size = new System.Drawing.Size(1120, 553);
        this.pnlHeader.ResumeLayout(false);
        this.pnlHeader.PerformLayout();
        this.grpOrderInfo.ResumeLayout(false);
        this.grpOrderInfo.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numTableNumber)).EndInit();
        this.grpAddItem.ResumeLayout(false);
        this.grpAddItem.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
        this.grpOrderItems.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).EndInit();
        this.pnlOrderItemsBottom.ResumeLayout(false);
        this.pnlActions.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblAlertMessage;
    private System.Windows.Forms.GroupBox grpOrderInfo;
    private System.Windows.Forms.Label lblOrderNumber;
    private System.Windows.Forms.TextBox txtOrderNumber;
    private System.Windows.Forms.Label lblCustomerName;
    private System.Windows.Forms.TextBox txtCustomerName;
    private System.Windows.Forms.Label lblTableNumber;
    private System.Windows.Forms.NumericUpDown numTableNumber;
    private System.Windows.Forms.Label lblOrderDateTime;
    private System.Windows.Forms.TextBox txtOrderDateTime;
    private System.Windows.Forms.GroupBox grpAddItem;
    private System.Windows.Forms.Label lblMenuItem;
    private System.Windows.Forms.ComboBox cboMenuItems;
    private System.Windows.Forms.Label lblQuantity;
    private System.Windows.Forms.NumericUpDown numQuantity;
    private System.Windows.Forms.Button btnAddItem;
    private System.Windows.Forms.GroupBox grpOrderItems;
    private System.Windows.Forms.DataGridView dgvOrderItems;
    private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
    private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
    private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
    private System.Windows.Forms.DataGridViewButtonColumn colRemove;
    private System.Windows.Forms.Panel pnlOrderItemsBottom;
    private System.Windows.Forms.Label lblTotal;
    private System.Windows.Forms.Panel pnlActions;
    private System.Windows.Forms.Button btnSaveOrder;
    private System.Windows.Forms.Button btnClearForm;
    private System.Windows.Forms.Button btnViewOrders;
    private System.Windows.Forms.Button btnCancel;
}
