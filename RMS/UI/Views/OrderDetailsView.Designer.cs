namespace RMS.UI.Views;

partial class OrderDetailsView
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
        btnBack = new Button();
        lblSubtitle = new Label();
        lblTitle = new Label();
        grpOrderInfo = new GroupBox();
        lblStatus = new Label();
        lblCaptionStatus = new Label();
        lblCreated = new Label();
        lblCaptionCreated = new Label();
        lblTable = new Label();
        lblCaptionTable = new Label();
        lblCustomer = new Label();
        lblCaptionCustomer = new Label();
        lblOrderNum = new Label();
        lblCaptionOrderNum = new Label();
        lblOrderHeading = new Label();
        grpOrderItems = new GroupBox();
        dgvItems = new DataGridView();
        colItemName = new DataGridViewTextBoxColumn();
        colUnitPrice = new DataGridViewTextBoxColumn();
        colQuantity = new DataGridViewTextBoxColumn();
        colSubtotal = new DataGridViewTextBoxColumn();
        pnlItemsFooter = new Panel();
        lblTotalAmount = new Label();
        lblSummaryQty = new Label();
        pnlActions = new Panel();
        lblLockedNotice = new Label();
        btnCancelOrder = new Button();
        btnEditOrder = new Button();
        pnlHeader.SuspendLayout();
        grpOrderInfo.SuspendLayout();
        grpOrderItems.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
        pnlItemsFooter.SuspendLayout();
        pnlActions.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = Color.Transparent;
        pnlHeader.Controls.Add(btnBack);
        pnlHeader.Controls.Add(lblSubtitle);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Location = new Point(24, 16);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new Size(1072, 56);
        pnlHeader.TabIndex = 0;
        // 
        // btnBack
        // 
        btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnBack.BackColor = Color.White;
        btnBack.Cursor = Cursors.Hand;
        btnBack.FlatStyle = FlatStyle.System;
        btnBack.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        btnBack.Location = new Point(912, 10);
        btnBack.Name = "btnBack";
        btnBack.Size = new Size(160, 36);
        btnBack.TabIndex = 2;
        btnBack.Text = "Back to Orders";
        btnBack.UseVisualStyleBackColor = false;
        btnBack.Click += btnBack_Click;
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new Font("Segoe UI", 9F);
        lblSubtitle.ForeColor = Color.FromArgb(71, 85, 105);
        lblSubtitle.Location = new Point(271, 16);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(295, 25);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Review order information and items";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
        lblTitle.Location = new Point(3, -4);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(218, 45);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Order Details";
        // 
        // grpOrderInfo
        // 
        grpOrderInfo.BackColor = Color.Transparent;
        grpOrderInfo.Controls.Add(lblStatus);
        grpOrderInfo.Controls.Add(lblCaptionStatus);
        grpOrderInfo.Controls.Add(lblCreated);
        grpOrderInfo.Controls.Add(lblCaptionCreated);
        grpOrderInfo.Controls.Add(lblTable);
        grpOrderInfo.Controls.Add(lblCaptionTable);
        grpOrderInfo.Controls.Add(lblCustomer);
        grpOrderInfo.Controls.Add(lblCaptionCustomer);
        grpOrderInfo.Controls.Add(lblOrderNum);
        grpOrderInfo.Controls.Add(lblCaptionOrderNum);
        grpOrderInfo.Controls.Add(lblOrderHeading);
        grpOrderInfo.Dock = DockStyle.Top;
        grpOrderInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        grpOrderInfo.ForeColor = Color.FromArgb(15, 23, 42);
        grpOrderInfo.Location = new Point(24, 72);
        grpOrderInfo.Name = "grpOrderInfo";
        grpOrderInfo.Padding = new Padding(16, 12, 16, 12);
        grpOrderInfo.Size = new Size(1072, 125);
        grpOrderInfo.TabIndex = 1;
        grpOrderInfo.TabStop = false;
        grpOrderInfo.Text = "Order Information";
        // 
        // lblStatus
        // 
        lblStatus.AutoSize = true;
        lblStatus.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
        lblStatus.ForeColor = Color.FromArgb(180, 83, 9);
        lblStatus.Location = new Point(620, 85);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(94, 30);
        lblStatus.TabIndex = 10;
        lblStatus.Text = "Pending";
        // 
        // lblCaptionStatus
        // 
        lblCaptionStatus.AutoSize = true;
        lblCaptionStatus.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblCaptionStatus.ForeColor = Color.FromArgb(71, 85, 105);
        lblCaptionStatus.Location = new Point(620, 62);
        lblCaptionStatus.Name = "lblCaptionStatus";
        lblCaptionStatus.Size = new Size(60, 23);
        lblCaptionStatus.TabIndex = 9;
        lblCaptionStatus.Text = "Status";
        // 
        // lblCreated
        // 
        lblCreated.AutoSize = true;
        lblCreated.Font = new Font("Segoe UI", 10F);
        lblCreated.ForeColor = Color.FromArgb(15, 23, 42);
        lblCreated.Location = new Point(470, 85);
        lblCreated.Name = "lblCreated";
        lblCreated.Size = new Size(96, 28);
        lblCreated.TabIndex = 8;
        lblCreated.Text = "10:15 AM";
        // 
        // lblCaptionCreated
        // 
        lblCaptionCreated.AutoSize = true;
        lblCaptionCreated.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblCaptionCreated.ForeColor = Color.FromArgb(71, 85, 105);
        lblCaptionCreated.Location = new Point(470, 62);
        lblCaptionCreated.Name = "lblCaptionCreated";
        lblCaptionCreated.Size = new Size(118, 23);
        lblCaptionCreated.TabIndex = 7;
        lblCaptionCreated.Text = "Created Time";
        // 
        // lblTable
        // 
        lblTable.AutoSize = true;
        lblTable.Font = new Font("Segoe UI", 10F);
        lblTable.ForeColor = Color.FromArgb(15, 23, 42);
        lblTable.Location = new Point(320, 85);
        lblTable.Name = "lblTable";
        lblTable.Size = new Size(73, 28);
        lblTable.TabIndex = 6;
        lblTable.Text = "Table 4";
        // 
        // lblCaptionTable
        // 
        lblCaptionTable.AutoSize = true;
        lblCaptionTable.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblCaptionTable.ForeColor = Color.FromArgb(71, 85, 105);
        lblCaptionTable.Location = new Point(320, 62);
        lblCaptionTable.Name = "lblCaptionTable";
        lblCaptionTable.Size = new Size(53, 23);
        lblCaptionTable.TabIndex = 5;
        lblCaptionTable.Text = "Table";
        // 
        // lblCustomer
        // 
        lblCustomer.AutoSize = true;
        lblCustomer.Font = new Font("Segoe UI", 10F);
        lblCustomer.ForeColor = Color.FromArgb(15, 23, 42);
        lblCustomer.Location = new Point(160, 85);
        lblCustomer.Name = "lblCustomer";
        lblCustomer.Size = new Size(57, 28);
        lblCustomer.TabIndex = 4;
        lblCustomer.Text = "Hana";
        // 
        // lblCaptionCustomer
        // 
        lblCaptionCustomer.AutoSize = true;
        lblCaptionCustomer.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblCaptionCustomer.ForeColor = Color.FromArgb(71, 85, 105);
        lblCaptionCustomer.Location = new Point(160, 62);
        lblCaptionCustomer.Name = "lblCaptionCustomer";
        lblCaptionCustomer.Size = new Size(87, 23);
        lblCaptionCustomer.TabIndex = 3;
        lblCaptionCustomer.Text = "Customer";
        // 
        // lblOrderNum
        // 
        lblOrderNum.AutoSize = true;
        lblOrderNum.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
        lblOrderNum.ForeColor = Color.FromArgb(30, 58, 95);
        lblOrderNum.Location = new Point(18, 85);
        lblOrderNum.Name = "lblOrderNum";
        lblOrderNum.Size = new Size(61, 30);
        lblOrderNum.TabIndex = 2;
        lblOrderNum.Text = "104";
        // 
        // lblCaptionOrderNum
        // 
        lblCaptionOrderNum.AutoSize = true;
        lblCaptionOrderNum.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblCaptionOrderNum.ForeColor = Color.FromArgb(71, 85, 105);
        lblCaptionOrderNum.Location = new Point(18, 62);
        lblCaptionOrderNum.Name = "lblCaptionOrderNum";
        lblCaptionOrderNum.Size = new Size(72, 23);
        lblCaptionOrderNum.TabIndex = 1;
        lblCaptionOrderNum.Text = "Order No";
        // 
        // lblOrderHeading
        // 
        lblOrderHeading.AutoSize = true;
        lblOrderHeading.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblOrderHeading.ForeColor = Color.FromArgb(30, 58, 95);
        lblOrderHeading.Location = new Point(18, 28);
        lblOrderHeading.Name = "lblOrderHeading";
        lblOrderHeading.Size = new Size(261, 30);
        lblOrderHeading.TabIndex = 0;
        lblOrderHeading.Text = "Order 104 Information";
        // 
        // grpOrderItems
        // 
        grpOrderItems.BackColor = Color.Transparent;
        grpOrderItems.Controls.Add(dgvItems);
        grpOrderItems.Controls.Add(pnlItemsFooter);
        grpOrderItems.Dock = DockStyle.Fill;
        grpOrderItems.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        grpOrderItems.ForeColor = Color.FromArgb(15, 23, 42);
        grpOrderItems.Location = new Point(24, 197);
        grpOrderItems.Name = "grpOrderItems";
        grpOrderItems.Padding = new Padding(16, 12, 16, 12);
        grpOrderItems.Size = new Size(1072, 271);
        grpOrderItems.TabIndex = 2;
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
        dgvItems.Columns.AddRange(new DataGridViewColumn[] { colItemName, colUnitPrice, colQuantity, colSubtotal });
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
        dgvItems.Location = new Point(16, 39);
        dgvItems.MultiSelect = false;
        dgvItems.Name = "dgvItems";
        dgvItems.ReadOnly = true;
        dgvItems.RowHeadersVisible = false;
        dgvItems.RowHeadersWidth = 51;
        dgvItems.RowTemplate.Height = 36;
        dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvItems.Size = new Size(1040, 170);
        dgvItems.TabIndex = 0;
        // 
        // colItemName
        // 
        colItemName.FillWeight = 40F;
        colItemName.HeaderText = "Item Name";
        colItemName.MinimumWidth = 6;
        colItemName.Name = "colItemName";
        colItemName.ReadOnly = true;
        // 
        // colUnitPrice
        // 
        colUnitPrice.FillWeight = 20F;
        colUnitPrice.HeaderText = "Unit Price";
        colUnitPrice.MinimumWidth = 6;
        colUnitPrice.Name = "colUnitPrice";
        colUnitPrice.ReadOnly = true;
        // 
        // colQuantity
        // 
        colQuantity.FillWeight = 20F;
        colQuantity.HeaderText = "Quantity";
        colQuantity.MinimumWidth = 6;
        colQuantity.Name = "colQuantity";
        colQuantity.ReadOnly = true;
        // 
        // colSubtotal
        // 
        colSubtotal.FillWeight = 20F;
        colSubtotal.HeaderText = "Subtotal";
        colSubtotal.MinimumWidth = 6;
        colSubtotal.Name = "colSubtotal";
        colSubtotal.ReadOnly = true;
        // 
        // pnlItemsFooter
        // 
        pnlItemsFooter.Controls.Add(lblTotalAmount);
        pnlItemsFooter.Controls.Add(lblSummaryQty);
        pnlItemsFooter.Dock = DockStyle.Bottom;
        pnlItemsFooter.Location = new Point(16, 209);
        pnlItemsFooter.Name = "pnlItemsFooter";
        pnlItemsFooter.Size = new Size(1040, 50);
        pnlItemsFooter.TabIndex = 1;
        // 
        // lblTotalAmount
        // 
        lblTotalAmount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblTotalAmount.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblTotalAmount.ForeColor = Color.FromArgb(30, 58, 95);
        lblTotalAmount.Location = new Point(696, 8);
        lblTotalAmount.Name = "lblTotalAmount";
        lblTotalAmount.Size = new Size(344, 34);
        lblTotalAmount.TabIndex = 1;
        lblTotalAmount.Text = "Total: 260 ETB";
        lblTotalAmount.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblSummaryQty
        // 
        lblSummaryQty.AutoSize = true;
        lblSummaryQty.Font = new Font("Segoe UI", 9.5F);
        lblSummaryQty.ForeColor = Color.FromArgb(71, 85, 105);
        lblSummaryQty.Location = new Point(4, 16);
        lblSummaryQty.Name = "lblSummaryQty";
        lblSummaryQty.Size = new Size(217, 25);
        lblSummaryQty.TabIndex = 0;
        lblSummaryQty.Text = "2 items • 3 total quantity";
        // 
        // pnlActions
        // 
        pnlActions.BackColor = Color.Transparent;
        pnlActions.Controls.Add(lblLockedNotice);
        pnlActions.Controls.Add(btnCancelOrder);
        pnlActions.Controls.Add(btnEditOrder);
        pnlActions.Dock = DockStyle.Bottom;
        pnlActions.Location = new Point(24, 468);
        pnlActions.Name = "pnlActions";
        pnlActions.Size = new Size(1072, 65);
        pnlActions.TabIndex = 3;
        // 
        // lblLockedNotice
        // 
        lblLockedNotice.AutoSize = true;
        lblLockedNotice.Font = new Font("Segoe UI", 8.5F);
        lblLockedNotice.ForeColor = Color.FromArgb(107, 114, 128);
        lblLockedNotice.Location = new Point(4, 38);
        lblLockedNotice.Name = "lblLockedNotice";
        lblLockedNotice.Size = new Size(546, 23);
        lblLockedNotice.TabIndex = 2;
        lblLockedNotice.Text = "Completed orders cannot be edited or cancelled, but remain viewable.";
        lblLockedNotice.Visible = false;
        // 
        // btnCancelOrder
        // 
        btnCancelOrder.BackColor = Color.White;
        btnCancelOrder.Cursor = Cursors.Hand;
        btnCancelOrder.FlatStyle = FlatStyle.System;
        btnCancelOrder.Font = new Font("Segoe UI", 9.5F);
        btnCancelOrder.ForeColor = Color.FromArgb(220, 38, 38);
        btnCancelOrder.Location = new Point(150, 4);
        btnCancelOrder.Name = "btnCancelOrder";
        btnCancelOrder.Size = new Size(130, 34);
        btnCancelOrder.TabIndex = 1;
        btnCancelOrder.Text = "Cancel Order";
        btnCancelOrder.UseVisualStyleBackColor = false;
        btnCancelOrder.Click += btnCancelOrder_Click;
        // 
        // btnEditOrder
        // 
        btnEditOrder.BackColor = Color.FromArgb(30, 58, 95);
        btnEditOrder.Cursor = Cursors.Hand;
        btnEditOrder.FlatStyle = FlatStyle.System;
        btnEditOrder.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        btnEditOrder.ForeColor = Color.White;
        btnEditOrder.Location = new Point(0, 4);
        btnEditOrder.Name = "btnEditOrder";
        btnEditOrder.Size = new Size(140, 34);
        btnEditOrder.TabIndex = 0;
        btnEditOrder.Text = "Edit Order";
        btnEditOrder.UseVisualStyleBackColor = false;
        btnEditOrder.Click += btnEditOrder_Click;
        // 
        // OrderDetailsView
        // 
        AutoScaleDimensions = new SizeF(144F, 144F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.FromArgb(243, 244, 246);
        Controls.Add(grpOrderItems);
        Controls.Add(grpOrderInfo);
        Controls.Add(pnlActions);
        Controls.Add(pnlHeader);
        Name = "OrderDetailsView";
        Padding = new Padding(24, 16, 24, 20);
        Size = new Size(1120, 553);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        grpOrderInfo.ResumeLayout(false);
        grpOrderInfo.PerformLayout();
        grpOrderItems.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
        pnlItemsFooter.ResumeLayout(false);
        pnlItemsFooter.PerformLayout();
        pnlActions.ResumeLayout(false);
        pnlActions.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Button btnBack;
    private System.Windows.Forms.GroupBox grpOrderInfo;
    private System.Windows.Forms.Label lblOrderHeading;
    private System.Windows.Forms.Label lblCaptionOrderNum;
    private System.Windows.Forms.Label lblOrderNum;
    private System.Windows.Forms.Label lblCaptionCustomer;
    private System.Windows.Forms.Label lblCustomer;
    private System.Windows.Forms.Label lblCaptionTable;
    private System.Windows.Forms.Label lblTable;
    private System.Windows.Forms.Label lblCaptionCreated;
    private System.Windows.Forms.Label lblCreated;
    private System.Windows.Forms.Label lblCaptionStatus;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.GroupBox grpOrderItems;
    private System.Windows.Forms.DataGridView dgvItems;
    private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
    private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
    private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
    private System.Windows.Forms.Panel pnlItemsFooter;
    private System.Windows.Forms.Label lblSummaryQty;
    private System.Windows.Forms.Label lblTotalAmount;
    private System.Windows.Forms.Panel pnlActions;
    private System.Windows.Forms.Button btnEditOrder;
    private System.Windows.Forms.Button btnCancelOrder;
    private System.Windows.Forms.Label lblLockedNotice;
}

