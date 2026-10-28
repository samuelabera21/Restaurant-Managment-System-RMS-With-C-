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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        pnlHeader = new Panel();
        lblTitle = new Label();
        lblAlertMessage = new Label();
        grpOrderInfo = new GroupBox();
        txtOrderDateTime = new TextBox();
        lblOrderDateTime = new Label();
        numTableNumber = new NumericUpDown();
        lblTableNumber = new Label();
        txtCustomerName = new TextBox();
        lblCustomerName = new Label();
        txtOrderNumber = new TextBox();
        lblOrderNumber = new Label();
        grpAddItem = new GroupBox();
        btnAddItem = new Button();
        numQuantity = new NumericUpDown();
        lblQuantity = new Label();
        cboMenuItems = new ComboBox();
        lblMenuItem = new Label();
        grpOrderItems = new GroupBox();
        dgvOrderItems = new DataGridView();
        colItem = new DataGridViewTextBoxColumn();
        colPrice = new DataGridViewTextBoxColumn();
        colQty = new DataGridViewTextBoxColumn();
        colSubtotal = new DataGridViewTextBoxColumn();
        colRemove = new DataGridViewButtonColumn();
        pnlOrderItemsBottom = new Panel();
        lblTotal = new Label();
        pnlActions = new Panel();
        btnCancel = new Button();
        btnViewOrders = new Button();
        btnClearForm = new Button();
        btnSaveOrder = new Button();
        pnlHeader.SuspendLayout();
        grpOrderInfo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numTableNumber).BeginInit();
        grpAddItem.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
        grpOrderItems.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvOrderItems).BeginInit();
        pnlOrderItemsBottom.SuspendLayout();
        pnlActions.SuspendLayout();
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
        lblTitle.Size = new Size(184, 45);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "New Order";
        // 
        // lblAlertMessage
        // 
        lblAlertMessage.BackColor = Color.FromArgb(254, 242, 242);
        lblAlertMessage.BorderStyle = BorderStyle.FixedSingle;
        lblAlertMessage.Dock = DockStyle.Top;
        lblAlertMessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblAlertMessage.ForeColor = Color.FromArgb(220, 38, 38);
        lblAlertMessage.Location = new Point(24, 60);
        lblAlertMessage.Name = "lblAlertMessage";
        lblAlertMessage.Padding = new Padding(8, 0, 0, 0);
        lblAlertMessage.Size = new Size(1072, 30);
        lblAlertMessage.TabIndex = 1;
        lblAlertMessage.Text = "Alert message";
        lblAlertMessage.TextAlign = ContentAlignment.MiddleLeft;
        lblAlertMessage.Visible = false;
        // 
        // grpOrderInfo
        // 
        grpOrderInfo.BackColor = Color.Transparent;
        grpOrderInfo.Controls.Add(txtOrderDateTime);
        grpOrderInfo.Controls.Add(lblOrderDateTime);
        grpOrderInfo.Controls.Add(numTableNumber);
        grpOrderInfo.Controls.Add(lblTableNumber);
        grpOrderInfo.Controls.Add(txtCustomerName);
        grpOrderInfo.Controls.Add(lblCustomerName);
        grpOrderInfo.Controls.Add(txtOrderNumber);
        grpOrderInfo.Controls.Add(lblOrderNumber);
        grpOrderInfo.Dock = DockStyle.Top;
        grpOrderInfo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        grpOrderInfo.ForeColor = Color.FromArgb(15, 23, 42);
        grpOrderInfo.Location = new Point(24, 90);
        grpOrderInfo.Name = "grpOrderInfo";
        grpOrderInfo.Size = new Size(1072, 88);
        grpOrderInfo.TabIndex = 2;
        grpOrderInfo.TabStop = false;
        grpOrderInfo.Text = "Order Information";
        // 
        // txtOrderDateTime
        // 
        txtOrderDateTime.BackColor = Color.FromArgb(241, 245, 249);
        txtOrderDateTime.Font = new Font("Segoe UI", 9.5F);
        txtOrderDateTime.Location = new Point(630, 46);
        txtOrderDateTime.Name = "txtOrderDateTime";
        txtOrderDateTime.ReadOnly = true;
        txtOrderDateTime.Size = new Size(200, 33);
        txtOrderDateTime.TabIndex = 7;
        // 
        // lblOrderDateTime
        // 
        lblOrderDateTime.AutoSize = true;
        lblOrderDateTime.Font = new Font("Segoe UI", 8.5F);
        lblOrderDateTime.ForeColor = Color.FromArgb(71, 85, 105);
        lblOrderDateTime.Location = new Point(626, 24);
        lblOrderDateTime.Name = "lblOrderDateTime";
        lblOrderDateTime.Size = new Size(97, 23);
        lblOrderDateTime.TabIndex = 6;
        lblOrderDateTime.Text = "Date & Time:";
        // 
        // numTableNumber
        // 
        numTableNumber.Font = new Font("Segoe UI", 9.5F);
        numTableNumber.Location = new Point(475, 46);
        numTableNumber.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
        numTableNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numTableNumber.Name = "numTableNumber";
        numTableNumber.Size = new Size(120, 33);
        numTableNumber.TabIndex = 5;
        numTableNumber.Value = new decimal(new int[] { 4, 0, 0, 0 });
        // 
        // lblTableNumber
        // 
        lblTableNumber.AutoSize = true;
        lblTableNumber.Font = new Font("Segoe UI", 8.5F);
        lblTableNumber.ForeColor = Color.FromArgb(71, 85, 105);
        lblTableNumber.Location = new Point(471, 24);
        lblTableNumber.Name = "lblTableNumber";
        lblTableNumber.Size = new Size(133, 23);
        lblTableNumber.TabIndex = 4;
        lblTableNumber.Text = "Table Number: *";
        // 
        // txtCustomerName
        // 
        txtCustomerName.Font = new Font("Segoe UI", 9.5F);
        txtCustomerName.Location = new Point(170, 46);
        txtCustomerName.Name = "txtCustomerName";
        txtCustomerName.PlaceholderText = "Enter customer name";
        txtCustomerName.Size = new Size(275, 33);
        txtCustomerName.TabIndex = 3;
        txtCustomerName.TextChanged += txtCustomerName_TextChanged;
        // 
        // lblCustomerName
        // 
        lblCustomerName.AutoSize = true;
        lblCustomerName.Font = new Font("Segoe UI", 8.5F);
        lblCustomerName.ForeColor = Color.FromArgb(71, 85, 105);
        lblCustomerName.Location = new Point(166, 24);
        lblCustomerName.Name = "lblCustomerName";
        lblCustomerName.Size = new Size(151, 23);
        lblCustomerName.TabIndex = 2;
        lblCustomerName.Text = "Customer Name: *";
        // 
        // txtOrderNumber
        // 
        txtOrderNumber.BackColor = Color.FromArgb(241, 245, 249);
        txtOrderNumber.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        txtOrderNumber.Location = new Point(18, 46);
        txtOrderNumber.Name = "txtOrderNumber";
        txtOrderNumber.ReadOnly = true;
        txtOrderNumber.Size = new Size(120, 33);
        txtOrderNumber.TabIndex = 1;
        txtOrderNumber.Text = "#116";
        txtOrderNumber.TextAlign = HorizontalAlignment.Center;
        // 
        // lblOrderNumber
        // 
        lblOrderNumber.AutoSize = true;
        lblOrderNumber.Font = new Font("Segoe UI", 8.5F);
        lblOrderNumber.ForeColor = Color.FromArgb(71, 85, 105);
        lblOrderNumber.Location = new Point(14, 24);
        lblOrderNumber.Name = "lblOrderNumber";
        lblOrderNumber.Size = new Size(73, 23);
        lblOrderNumber.TabIndex = 0;
        lblOrderNumber.Text = "Order #:";
        // 
        // grpAddItem
        // 
        grpAddItem.BackColor = Color.Transparent;
        grpAddItem.Controls.Add(btnAddItem);
        grpAddItem.Controls.Add(numQuantity);
        grpAddItem.Controls.Add(lblQuantity);
        grpAddItem.Controls.Add(cboMenuItems);
        grpAddItem.Controls.Add(lblMenuItem);
        grpAddItem.Dock = DockStyle.Top;
        grpAddItem.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        grpAddItem.ForeColor = Color.FromArgb(15, 23, 42);
        grpAddItem.Location = new Point(24, 178);
        grpAddItem.Name = "grpAddItem";
        grpAddItem.Size = new Size(1072, 85);
        grpAddItem.TabIndex = 3;
        grpAddItem.TabStop = false;
        grpAddItem.Text = "Add Menu Item";
        // 
        // btnAddItem
        // 
        btnAddItem.BackColor = Color.FromArgb(30, 58, 95);
        btnAddItem.Cursor = Cursors.Hand;
        btnAddItem.FlatAppearance.BorderSize = 0;
        btnAddItem.FlatStyle = FlatStyle.Flat;
        btnAddItem.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        btnAddItem.ForeColor = Color.White;
        btnAddItem.Location = new Point(530, 42);
        btnAddItem.Name = "btnAddItem";
        btnAddItem.Size = new Size(125, 31);
        btnAddItem.TabIndex = 4;
        btnAddItem.Text = "+ Add Item";
        btnAddItem.UseVisualStyleBackColor = false;
        btnAddItem.Click += btnAddItem_Click;
        // 
        // numQuantity
        // 
        numQuantity.Font = new Font("Segoe UI", 9.5F);
        numQuantity.Location = new Point(415, 43);
        numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numQuantity.Name = "numQuantity";
        numQuantity.Size = new Size(90, 33);
        numQuantity.TabIndex = 3;
        numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // lblQuantity
        // 
        lblQuantity.AutoSize = true;
        lblQuantity.Font = new Font("Segoe UI", 8.5F);
        lblQuantity.ForeColor = Color.FromArgb(71, 85, 105);
        lblQuantity.Location = new Point(411, 22);
        lblQuantity.Name = "lblQuantity";
        lblQuantity.Size = new Size(80, 23);
        lblQuantity.TabIndex = 2;
        lblQuantity.Text = "Quantity:";
        // 
        // cboMenuItems
        // 
        cboMenuItems.DropDownStyle = ComboBoxStyle.DropDownList;
        cboMenuItems.Font = new Font("Segoe UI", 9.5F);
        cboMenuItems.FormattingEnabled = true;
        cboMenuItems.Location = new Point(18, 43);
        cboMenuItems.Name = "cboMenuItems";
        cboMenuItems.Size = new Size(370, 33);
        cboMenuItems.TabIndex = 1;
        // 
        // lblMenuItem
        // 
        lblMenuItem.AutoSize = true;
        lblMenuItem.Font = new Font("Segoe UI", 8.5F);
        lblMenuItem.ForeColor = Color.FromArgb(71, 85, 105);
        lblMenuItem.Location = new Point(14, 22);
        lblMenuItem.Name = "lblMenuItem";
        lblMenuItem.Size = new Size(99, 23);
        lblMenuItem.TabIndex = 0;
        lblMenuItem.Text = "Select Item:";
        // 
        // grpOrderItems
        // 
        grpOrderItems.BackColor = Color.Transparent;
        grpOrderItems.Controls.Add(dgvOrderItems);
        grpOrderItems.Controls.Add(pnlOrderItemsBottom);
        grpOrderItems.Dock = DockStyle.Fill;
        grpOrderItems.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        grpOrderItems.ForeColor = Color.FromArgb(15, 23, 42);
        grpOrderItems.Location = new Point(24, 263);
        grpOrderItems.Name = "grpOrderItems";
        grpOrderItems.Padding = new Padding(12, 10, 12, 12);
        grpOrderItems.Size = new Size(1072, 220);
        grpOrderItems.TabIndex = 4;
        grpOrderItems.TabStop = false;
        grpOrderItems.Text = "Order Items";
        // 
        // dgvOrderItems
        // 
        dgvOrderItems.AllowUserToAddRows = false;
        dgvOrderItems.AllowUserToDeleteRows = false;
        dgvOrderItems.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
        dgvOrderItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvOrderItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvOrderItems.BackgroundColor = Color.White;
        dgvOrderItems.BorderStyle = BorderStyle.Fixed3D;
        dgvOrderItems.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle2.Padding = new Padding(4, 6, 4, 6);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        dgvOrderItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvOrderItems.Columns.AddRange(new DataGridViewColumn[] { colItem, colPrice, colQty, colSubtotal, colRemove });
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.White;
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle3.Padding = new Padding(4);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(219, 234, 254);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        dgvOrderItems.DefaultCellStyle = dataGridViewCellStyle3;
        dgvOrderItems.Dock = DockStyle.Fill;
        dgvOrderItems.EnableHeadersVisualStyles = false;
        dgvOrderItems.GridColor = Color.FromArgb(226, 232, 240);
        dgvOrderItems.Location = new Point(12, 37);
        dgvOrderItems.MultiSelect = false;
        dgvOrderItems.Name = "dgvOrderItems";
        dgvOrderItems.ReadOnly = true;
        dgvOrderItems.RowHeadersVisible = false;
        dgvOrderItems.RowHeadersWidth = 51;
        dgvOrderItems.RowTemplate.Height = 36;
        dgvOrderItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvOrderItems.Size = new Size(1048, 131);
        dgvOrderItems.TabIndex = 0;
        dgvOrderItems.CellContentClick += dgvOrderItems_CellContentClick;
        // 
        // colItem
        // 
        colItem.FillWeight = 160F;
        colItem.HeaderText = "Item Name";
        colItem.MinimumWidth = 6;
        colItem.Name = "colItem";
        colItem.ReadOnly = true;
        // 
        // colPrice
        // 
        colPrice.FillWeight = 90F;
        colPrice.HeaderText = "Unit Price";
        colPrice.MinimumWidth = 6;
        colPrice.Name = "colPrice";
        colPrice.ReadOnly = true;
        // 
        // colQty
        // 
        colQty.FillWeight = 70F;
        colQty.HeaderText = "Quantity";
        colQty.MinimumWidth = 6;
        colQty.Name = "colQty";
        colQty.ReadOnly = true;
        // 
        // colSubtotal
        // 
        colSubtotal.FillWeight = 90F;
        colSubtotal.HeaderText = "Subtotal";
        colSubtotal.MinimumWidth = 6;
        colSubtotal.Name = "colSubtotal";
        colSubtotal.ReadOnly = true;
        // 
        // colRemove
        // 
        colRemove.FillWeight = 70F;
        colRemove.FlatStyle = FlatStyle.System;
        colRemove.HeaderText = "Action";
        colRemove.MinimumWidth = 6;
        colRemove.Name = "colRemove";
        colRemove.ReadOnly = true;
        colRemove.Text = "Remove";
        colRemove.UseColumnTextForButtonValue = true;
        // 
        // pnlOrderItemsBottom
        // 
        pnlOrderItemsBottom.BackColor = Color.Transparent;
        pnlOrderItemsBottom.Controls.Add(lblTotal);
        pnlOrderItemsBottom.Dock = DockStyle.Bottom;
        pnlOrderItemsBottom.Location = new Point(12, 168);
        pnlOrderItemsBottom.Name = "pnlOrderItemsBottom";
        pnlOrderItemsBottom.Size = new Size(1048, 40);
        pnlOrderItemsBottom.TabIndex = 1;
        // 
        // lblTotal
        // 
        lblTotal.Dock = DockStyle.Right;
        lblTotal.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblTotal.ForeColor = Color.FromArgb(30, 58, 95);
        lblTotal.Location = new Point(748, 0);
        lblTotal.Name = "lblTotal";
        lblTotal.Size = new Size(300, 40);
        lblTotal.TabIndex = 0;
        lblTotal.Text = "Total: 0 ETB";
        lblTotal.TextAlign = ContentAlignment.MiddleRight;
        // 
        // pnlActions
        // 
        pnlActions.BackColor = Color.Transparent;
        pnlActions.Controls.Add(btnCancel);
        pnlActions.Controls.Add(btnViewOrders);
        pnlActions.Controls.Add(btnClearForm);
        pnlActions.Controls.Add(btnSaveOrder);
        pnlActions.Dock = DockStyle.Bottom;
        pnlActions.Location = new Point(24, 483);
        pnlActions.Name = "pnlActions";
        pnlActions.Padding = new Padding(0, 8, 0, 0);
        pnlActions.Size = new Size(1072, 50);
        pnlActions.TabIndex = 5;
        // 
        // btnCancel
        // 
        btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnCancel.BackColor = Color.White;
        btnCancel.Cursor = Cursors.Hand;
        btnCancel.FlatStyle = FlatStyle.System;
        btnCancel.Font = new Font("Segoe UI", 9.5F);
        btnCancel.Location = new Point(962, 8);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(110, 36);
        btnCancel.TabIndex = 3;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = false;
        btnCancel.Click += btnCancel_Click;
        // 
        // btnViewOrders
        // 
        btnViewOrders.BackColor = Color.FromArgb(30, 58, 95);
        btnViewOrders.Cursor = Cursors.Hand;
        btnViewOrders.FlatAppearance.BorderSize = 0;
        btnViewOrders.FlatStyle = FlatStyle.Flat;
        btnViewOrders.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        btnViewOrders.ForeColor = Color.White;
        btnViewOrders.Location = new Point(260, 8);
        btnViewOrders.Name = "btnViewOrders";
        btnViewOrders.Size = new Size(140, 36);
        btnViewOrders.TabIndex = 2;
        btnViewOrders.Text = "View Orders";
        btnViewOrders.UseVisualStyleBackColor = false;
        btnViewOrders.Visible = false;
        btnViewOrders.Click += btnViewOrders_Click;
        // 
        // btnClearForm
        // 
        btnClearForm.BackColor = Color.White;
        btnClearForm.Cursor = Cursors.Hand;
        btnClearForm.FlatStyle = FlatStyle.System;
        btnClearForm.Font = new Font("Segoe UI", 9.5F);
        btnClearForm.Location = new Point(145, 8);
        btnClearForm.Name = "btnClearForm";
        btnClearForm.Size = new Size(110, 36);
        btnClearForm.TabIndex = 1;
        btnClearForm.Text = "Clear Form";
        btnClearForm.UseVisualStyleBackColor = false;
        btnClearForm.Click += btnClearForm_Click;
        // 
        // btnSaveOrder
        // 
        btnSaveOrder.BackColor = Color.FromArgb(30, 58, 95);
        btnSaveOrder.Cursor = Cursors.Hand;
        btnSaveOrder.FlatAppearance.BorderSize = 0;
        btnSaveOrder.FlatStyle = FlatStyle.System;
        btnSaveOrder.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        btnSaveOrder.ForeColor = Color.White;
        btnSaveOrder.Location = new Point(0, 8);
        btnSaveOrder.Name = "btnSaveOrder";
        btnSaveOrder.Size = new Size(135, 36);
        btnSaveOrder.TabIndex = 0;
        btnSaveOrder.Text = "Save Order";
        btnSaveOrder.UseVisualStyleBackColor = false;
        btnSaveOrder.Click += btnSaveOrder_Click;
        // 
        // NewOrderView
        // 
        AutoScaleDimensions = new SizeF(144F, 144F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.FromArgb(243, 244, 246);
        Controls.Add(grpOrderItems);
        Controls.Add(grpAddItem);
        Controls.Add(grpOrderInfo);
        Controls.Add(lblAlertMessage);
        Controls.Add(pnlActions);
        Controls.Add(pnlHeader);
        Name = "NewOrderView";
        Padding = new Padding(24, 16, 24, 20);
        Size = new Size(1120, 553);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        grpOrderInfo.ResumeLayout(false);
        grpOrderInfo.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numTableNumber).EndInit();
        grpAddItem.ResumeLayout(false);
        grpAddItem.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
        grpOrderItems.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvOrderItems).EndInit();
        pnlOrderItemsBottom.ResumeLayout(false);
        pnlActions.ResumeLayout(false);
        ResumeLayout(false);
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
