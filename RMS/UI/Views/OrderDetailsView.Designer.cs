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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        this.pnlHeader = new System.Windows.Forms.Panel();
        this.btnBack = new System.Windows.Forms.Button();
        this.lblSubtitle = new System.Windows.Forms.Label();
        this.lblTitle = new System.Windows.Forms.Label();
        this.grpOrderInfo = new System.Windows.Forms.GroupBox();
        this.lblStatus = new System.Windows.Forms.Label();
        this.lblCaptionStatus = new System.Windows.Forms.Label();
        this.lblCreated = new System.Windows.Forms.Label();
        this.lblCaptionCreated = new System.Windows.Forms.Label();
        this.lblTable = new System.Windows.Forms.Label();
        this.lblCaptionTable = new System.Windows.Forms.Label();
        this.lblCustomer = new System.Windows.Forms.Label();
        this.lblCaptionCustomer = new System.Windows.Forms.Label();
        this.lblOrderNum = new System.Windows.Forms.Label();
        this.lblCaptionOrderNum = new System.Windows.Forms.Label();
        this.lblOrderHeading = new System.Windows.Forms.Label();
        this.grpOrderItems = new System.Windows.Forms.GroupBox();
        this.dgvItems = new System.Windows.Forms.DataGridView();
        this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.pnlItemsFooter = new System.Windows.Forms.Panel();
        this.lblTotalAmount = new System.Windows.Forms.Label();
        this.lblSummaryQty = new System.Windows.Forms.Label();
        this.pnlActions = new System.Windows.Forms.Panel();
        this.lblLockedNotice = new System.Windows.Forms.Label();
        this.btnCancelOrder = new System.Windows.Forms.Button();
        this.btnEditOrder = new System.Windows.Forms.Button();
        this.pnlHeader.SuspendLayout();
        this.grpOrderInfo.SuspendLayout();
        this.grpOrderItems.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
        this.pnlItemsFooter.SuspendLayout();
        this.pnlActions.SuspendLayout();
        this.SuspendLayout();
        // 
        // pnlHeader
        // 
        this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
        this.pnlHeader.Controls.Add(this.btnBack);
        this.pnlHeader.Controls.Add(this.lblSubtitle);
        this.pnlHeader.Controls.Add(this.lblTitle);
        this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        this.pnlHeader.Location = new System.Drawing.Point(24, 16);
        this.pnlHeader.Name = "pnlHeader";
        this.pnlHeader.Size = new System.Drawing.Size(996, 56);
        this.pnlHeader.TabIndex = 0;
        // 
        // btnBack
        // 
        this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnBack.BackColor = System.Drawing.Color.White;
        this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.btnBack.Location = new System.Drawing.Point(836, 10);
        this.btnBack.Name = "btnBack";
        this.btnBack.Size = new System.Drawing.Size(160, 36);
        this.btnBack.TabIndex = 2;
        this.btnBack.Text = "← Back to Orders";
        this.btnBack.UseVisualStyleBackColor = false;
        this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
        // 
        // lblSubtitle
        // 
        this.lblSubtitle.AutoSize = true;
        this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblSubtitle.Location = new System.Drawing.Point(0, 32);
        this.lblSubtitle.Name = "lblSubtitle";
        this.lblSubtitle.Size = new System.Drawing.Size(262, 20);
        this.lblSubtitle.TabIndex = 1;
        this.lblSubtitle.Text = "Review order information and items";
        // 
        // lblTitle
        // 
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.lblTitle.Location = new System.Drawing.Point(-2, 0);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(188, 37);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Order Details";
        // 
        // grpOrderInfo
        // 
        this.grpOrderInfo.BackColor = System.Drawing.Color.Transparent;
        this.grpOrderInfo.Controls.Add(this.lblStatus);
        this.grpOrderInfo.Controls.Add(this.lblCaptionStatus);
        this.grpOrderInfo.Controls.Add(this.lblCreated);
        this.grpOrderInfo.Controls.Add(this.lblCaptionCreated);
        this.grpOrderInfo.Controls.Add(this.lblTable);
        this.grpOrderInfo.Controls.Add(this.lblCaptionTable);
        this.grpOrderInfo.Controls.Add(this.lblCustomer);
        this.grpOrderInfo.Controls.Add(this.lblCaptionCustomer);
        this.grpOrderInfo.Controls.Add(this.lblOrderNum);
        this.grpOrderInfo.Controls.Add(this.lblCaptionOrderNum);
        this.grpOrderInfo.Controls.Add(this.lblOrderHeading);
        this.grpOrderInfo.Dock = System.Windows.Forms.DockStyle.Top;
        this.grpOrderInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.grpOrderInfo.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.grpOrderInfo.Location = new System.Drawing.Point(24, 72);
        this.grpOrderInfo.Name = "grpOrderInfo";
        this.grpOrderInfo.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
        this.grpOrderInfo.Size = new System.Drawing.Size(996, 125);
        this.grpOrderInfo.TabIndex = 1;
        this.grpOrderInfo.TabStop = false;
        this.grpOrderInfo.Text = "Order Information";
        // 
        // lblStatus
        // 
        this.lblStatus.AutoSize = true;
        this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
        this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(180, 83, 9);
        this.lblStatus.Location = new System.Drawing.Point(620, 85);
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Size = new System.Drawing.Size(81, 25);
        this.lblStatus.TabIndex = 10;
        this.lblStatus.Text = "Pending";
        // 
        // lblCaptionStatus
        // 
        this.lblCaptionStatus.AutoSize = true;
        this.lblCaptionStatus.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        this.lblCaptionStatus.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblCaptionStatus.Location = new System.Drawing.Point(620, 62);
        this.lblCaptionStatus.Name = "lblCaptionStatus";
        this.lblCaptionStatus.Size = new System.Drawing.Size(53, 20);
        this.lblCaptionStatus.TabIndex = 9;
        this.lblCaptionStatus.Text = "Status";
        // 
        // lblCreated
        // 
        this.lblCreated.AutoSize = true;
        this.lblCreated.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblCreated.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.lblCreated.Location = new System.Drawing.Point(470, 85);
        this.lblCreated.Name = "lblCreated";
        this.lblCreated.Size = new System.Drawing.Size(80, 23);
        this.lblCreated.TabIndex = 8;
        this.lblCreated.Text = "10:15 AM";
        // 
        // lblCaptionCreated
        // 
        this.lblCaptionCreated.AutoSize = true;
        this.lblCaptionCreated.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        this.lblCaptionCreated.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblCaptionCreated.Location = new System.Drawing.Point(470, 62);
        this.lblCaptionCreated.Name = "lblCaptionCreated";
        this.lblCaptionCreated.Size = new System.Drawing.Size(100, 20);
        this.lblCaptionCreated.TabIndex = 7;
        this.lblCaptionCreated.Text = "Created Time";
        // 
        // lblTable
        // 
        this.lblTable.AutoSize = true;
        this.lblTable.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblTable.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.lblTable.Location = new System.Drawing.Point(320, 85);
        this.lblTable.Name = "lblTable";
        this.lblTable.Size = new System.Drawing.Size(63, 23);
        this.lblTable.TabIndex = 6;
        this.lblTable.Text = "Table 4";
        // 
        // lblCaptionTable
        // 
        this.lblCaptionTable.AutoSize = true;
        this.lblCaptionTable.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        this.lblCaptionTable.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblCaptionTable.Location = new System.Drawing.Point(320, 62);
        this.lblCaptionTable.Name = "lblCaptionTable";
        this.lblCaptionTable.Size = new System.Drawing.Size(46, 20);
        this.lblCaptionTable.TabIndex = 5;
        this.lblCaptionTable.Text = "Table";
        // 
        // lblCustomer
        // 
        this.lblCustomer.AutoSize = true;
        this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblCustomer.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.lblCustomer.Location = new System.Drawing.Point(160, 85);
        this.lblCustomer.Name = "lblCustomer";
        this.lblCustomer.Size = new System.Drawing.Size(50, 23);
        this.lblCustomer.TabIndex = 4;
        this.lblCustomer.Text = "Hana";
        // 
        // lblCaptionCustomer
        // 
        this.lblCaptionCustomer.AutoSize = true;
        this.lblCaptionCustomer.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        this.lblCaptionCustomer.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblCaptionCustomer.Location = new System.Drawing.Point(160, 62);
        this.lblCaptionCustomer.Name = "lblCaptionCustomer";
        this.lblCaptionCustomer.Size = new System.Drawing.Size(78, 20);
        this.lblCaptionCustomer.TabIndex = 3;
        this.lblCaptionCustomer.Text = "Customer";
        // 
        // lblOrderNum
        // 
        this.lblOrderNum.AutoSize = true;
        this.lblOrderNum.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
        this.lblOrderNum.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
        this.lblOrderNum.Location = new System.Drawing.Point(18, 85);
        this.lblOrderNum.Name = "lblOrderNum";
        this.lblOrderNum.Size = new System.Drawing.Size(57, 25);
        this.lblOrderNum.TabIndex = 2;
        this.lblOrderNum.Text = "#104";
        // 
        // lblCaptionOrderNum
        // 
        this.lblCaptionOrderNum.AutoSize = true;
        this.lblCaptionOrderNum.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        this.lblCaptionOrderNum.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblCaptionOrderNum.Location = new System.Drawing.Point(18, 62);
        this.lblCaptionOrderNum.Name = "lblCaptionOrderNum";
        this.lblCaptionOrderNum.Size = new System.Drawing.Size(65, 20);
        this.lblCaptionOrderNum.TabIndex = 1;
        this.lblCaptionOrderNum.Text = "Order #";
        // 
        // lblOrderHeading
        // 
        this.lblOrderHeading.AutoSize = true;
        this.lblOrderHeading.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.lblOrderHeading.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
        this.lblOrderHeading.Location = new System.Drawing.Point(18, 28);
        this.lblOrderHeading.Name = "lblOrderHeading";
        this.lblOrderHeading.Size = new System.Drawing.Size(232, 25);
        this.lblOrderHeading.TabIndex = 0;
        this.lblOrderHeading.Text = "#104 Order Information";
        // 
        // grpOrderItems
        // 
        this.grpOrderItems.BackColor = System.Drawing.Color.Transparent;
        this.grpOrderItems.Controls.Add(this.dgvItems);
        this.grpOrderItems.Controls.Add(this.pnlItemsFooter);
        this.grpOrderItems.Dock = System.Windows.Forms.DockStyle.Fill;
        this.grpOrderItems.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.grpOrderItems.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.grpOrderItems.Location = new System.Drawing.Point(24, 197);
        this.grpOrderItems.Name = "grpOrderItems";
        this.grpOrderItems.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
        this.grpOrderItems.Size = new System.Drawing.Size(996, 418);
        this.grpOrderItems.TabIndex = 2;
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
            this.colSubtotal});
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
        this.dgvItems.Location = new System.Drawing.Point(16, 35);
        this.dgvItems.MultiSelect = false;
        this.dgvItems.Name = "dgvItems";
        this.dgvItems.ReadOnly = true;
        this.dgvItems.RowHeadersVisible = false;
        this.dgvItems.RowHeadersWidth = 51;
        this.dgvItems.RowTemplate.Height = 36;
        this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvItems.Size = new System.Drawing.Size(964, 321);
        this.dgvItems.TabIndex = 0;
        // 
        // colItemName
        // 
        this.colItemName.FillWeight = 40F;
        this.colItemName.HeaderText = "Item Name";
        this.colItemName.MinimumWidth = 6;
        this.colItemName.Name = "colItemName";
        this.colItemName.ReadOnly = true;
        // 
        // colUnitPrice
        // 
        this.colUnitPrice.FillWeight = 20F;
        this.colUnitPrice.HeaderText = "Unit Price";
        this.colUnitPrice.MinimumWidth = 6;
        this.colUnitPrice.Name = "colUnitPrice";
        this.colUnitPrice.ReadOnly = true;
        // 
        // colQuantity
        // 
        this.colQuantity.FillWeight = 20F;
        this.colQuantity.HeaderText = "Quantity";
        this.colQuantity.MinimumWidth = 6;
        this.colQuantity.Name = "colQuantity";
        this.colQuantity.ReadOnly = true;
        // 
        // colSubtotal
        // 
        this.colSubtotal.FillWeight = 20F;
        this.colSubtotal.HeaderText = "Subtotal";
        this.colSubtotal.MinimumWidth = 6;
        this.colSubtotal.Name = "colSubtotal";
        this.colSubtotal.ReadOnly = true;
        // 
        // pnlItemsFooter
        // 
        this.pnlItemsFooter.Controls.Add(this.lblTotalAmount);
        this.pnlItemsFooter.Controls.Add(this.lblSummaryQty);
        this.pnlItemsFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.pnlItemsFooter.Location = new System.Drawing.Point(16, 356);
        this.pnlItemsFooter.Name = "pnlItemsFooter";
        this.pnlItemsFooter.Size = new System.Drawing.Size(964, 50);
        this.pnlItemsFooter.TabIndex = 1;
        // 
        // lblTotalAmount
        // 
        this.lblTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        this.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
        this.lblTotalAmount.Location = new System.Drawing.Point(620, 8);
        this.lblTotalAmount.Name = "lblTotalAmount";
        this.lblTotalAmount.Size = new System.Drawing.Size(344, 34);
        this.lblTotalAmount.TabIndex = 1;
        this.lblTotalAmount.Text = "Total: 260 ETB";
        this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lblSummaryQty
        // 
        this.lblSummaryQty.AutoSize = true;
        this.lblSummaryQty.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblSummaryQty.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblSummaryQty.Location = new System.Drawing.Point(4, 16);
        this.lblSummaryQty.Name = "lblSummaryQty";
        this.lblSummaryQty.Size = new System.Drawing.Size(182, 21);
        this.lblSummaryQty.TabIndex = 0;
        this.lblSummaryQty.Text = "2 items • 3 total quantity";
        // 
        // pnlActions
        // 
        this.pnlActions.BackColor = System.Drawing.Color.Transparent;
        this.pnlActions.Controls.Add(this.lblLockedNotice);
        this.pnlActions.Controls.Add(this.btnCancelOrder);
        this.pnlActions.Controls.Add(this.btnEditOrder);
        this.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.pnlActions.Location = new System.Drawing.Point(24, 615);
        this.pnlActions.Name = "pnlActions";
        this.pnlActions.Size = new System.Drawing.Size(996, 65);
        this.pnlActions.TabIndex = 3;
        // 
        // lblLockedNotice
        // 
        this.lblLockedNotice.AutoSize = true;
        this.lblLockedNotice.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        this.lblLockedNotice.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
        this.lblLockedNotice.Location = new System.Drawing.Point(4, 38);
        this.lblLockedNotice.Name = "lblLockedNotice";
        this.lblLockedNotice.Size = new System.Drawing.Size(462, 20);
        this.lblLockedNotice.TabIndex = 2;
        this.lblLockedNotice.Text = "ⓘ Completed orders cannot be edited or cancelled, but remain viewable.";
        this.lblLockedNotice.Visible = false;
        // 
        // btnCancelOrder
        // 
        this.btnCancelOrder.BackColor = System.Drawing.Color.White;
        this.btnCancelOrder.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.btnCancelOrder.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.btnCancelOrder.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
        this.btnCancelOrder.Location = new System.Drawing.Point(150, 4);
        this.btnCancelOrder.Name = "btnCancelOrder";
        this.btnCancelOrder.Size = new System.Drawing.Size(130, 34);
        this.btnCancelOrder.TabIndex = 1;
        this.btnCancelOrder.Text = "✕ Cancel Order";
        this.btnCancelOrder.UseVisualStyleBackColor = false;
        this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
        // 
        // btnEditOrder
        // 
        this.btnEditOrder.BackColor = System.Drawing.Color.FromArgb(30, 58, 95);
        this.btnEditOrder.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnEditOrder.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.btnEditOrder.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.btnEditOrder.ForeColor = System.Drawing.Color.White;
        this.btnEditOrder.Location = new System.Drawing.Point(0, 4);
        this.btnEditOrder.Name = "btnEditOrder";
        this.btnEditOrder.Size = new System.Drawing.Size(140, 34);
        this.btnEditOrder.TabIndex = 0;
        this.btnEditOrder.Text = "✏ Edit Order";
        this.btnEditOrder.UseVisualStyleBackColor = false;
        this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
        // 
        // OrderDetailsView
        // 
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
        this.Controls.Add(this.grpOrderItems);
        this.Controls.Add(this.grpOrderInfo);
        this.Controls.Add(this.pnlActions);
        this.Controls.Add(this.pnlHeader);
        this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.Name = "OrderDetailsView";
        this.Padding = new System.Windows.Forms.Padding(24, 16, 24, 20);
        this.Size = new System.Drawing.Size(1044, 700);
        this.pnlHeader.ResumeLayout(false);
        this.pnlHeader.PerformLayout();
        this.grpOrderInfo.ResumeLayout(false);
        this.grpOrderInfo.PerformLayout();
        this.grpOrderItems.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
        this.pnlItemsFooter.ResumeLayout(false);
        this.pnlItemsFooter.PerformLayout();
        this.pnlActions.ResumeLayout(false);
        this.pnlActions.PerformLayout();
        this.ResumeLayout(false);
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
