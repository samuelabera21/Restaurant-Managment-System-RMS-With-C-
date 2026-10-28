namespace RMS.UI.Views;

partial class MenuView
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
        this.grpFilter = new System.Windows.Forms.GroupBox();
        this.lblCountSummary = new System.Windows.Forms.Label();
        this.cboAvailability = new System.Windows.Forms.ComboBox();
        this.lblFilterAvailability = new System.Windows.Forms.Label();
        this.btnClearSearch = new System.Windows.Forms.Button();
        this.txtSearch = new System.Windows.Forms.TextBox();
        this.lblSearch = new System.Windows.Forms.Label();
        this.grpMenuTable = new System.Windows.Forms.GroupBox();
        this.dgvMenu = new System.Windows.Forms.DataGridView();
        this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colAvailability = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colAction = new System.Windows.Forms.DataGridViewButtonColumn();
        this.pnlHeader.SuspendLayout();
        this.grpFilter.SuspendLayout();
        this.grpMenuTable.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
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
        this.lblSubtitle.Text = "View available restaurant items, prices, and availability";
        // 
        // lblTitle
        // 
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.lblTitle.Location = new System.Drawing.Point(-2, 0);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(90, 37);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Menu";
        // 
        // grpFilter
        // 
        this.grpFilter.BackColor = System.Drawing.Color.Transparent;
        this.grpFilter.Controls.Add(this.lblCountSummary);
        this.grpFilter.Controls.Add(this.cboAvailability);
        this.grpFilter.Controls.Add(this.lblFilterAvailability);
        this.grpFilter.Controls.Add(this.btnClearSearch);
        this.grpFilter.Controls.Add(this.txtSearch);
        this.grpFilter.Controls.Add(this.lblSearch);
        this.grpFilter.Dock = System.Windows.Forms.DockStyle.Top;
        this.grpFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.grpFilter.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.grpFilter.Location = new System.Drawing.Point(24, 72);
        this.grpFilter.Name = "grpFilter";
        this.grpFilter.Size = new System.Drawing.Size(996, 75);
        this.grpFilter.TabIndex = 1;
        this.grpFilter.TabStop = false;
        this.grpFilter.Text = "Search & Filter";
        // 
        // lblCountSummary
        // 
        this.lblCountSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.lblCountSummary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
        this.lblCountSummary.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblCountSummary.Location = new System.Drawing.Point(676, 31);
        this.lblCountSummary.Name = "lblCountSummary";
        this.lblCountSummary.Size = new System.Drawing.Size(308, 25);
        this.lblCountSummary.TabIndex = 5;
        this.lblCountSummary.Text = "Showing 7 of 7 items";
        this.lblCountSummary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // cboAvailability
        // 
        this.cboAvailability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboAvailability.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.cboAvailability.FormattingEnabled = true;
        this.cboAvailability.Items.AddRange(new object[] {
            "All Items",
            "Available",
            "Unavailable"});
        this.cboAvailability.Location = new System.Drawing.Point(495, 29);
        this.cboAvailability.Name = "cboAvailability";
        this.cboAvailability.Size = new System.Drawing.Size(150, 29);
        this.cboAvailability.TabIndex = 4;
        this.cboAvailability.SelectedIndexChanged += new System.EventHandler(this.cboAvailability_SelectedIndexChanged);
        // 
        // lblFilterAvailability
        // 
        this.lblFilterAvailability.AutoSize = true;
        this.lblFilterAvailability.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblFilterAvailability.Location = new System.Drawing.Point(405, 32);
        this.lblFilterAvailability.Name = "lblFilterAvailability";
        this.lblFilterAvailability.Size = new System.Drawing.Size(89, 21);
        this.lblFilterAvailability.TabIndex = 3;
        this.lblFilterAvailability.Text = "Availability:";
        // 
        // btnClearSearch
        // 
        this.btnClearSearch.BackColor = System.Drawing.Color.White;
        this.btnClearSearch.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.btnClearSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.btnClearSearch.Location = new System.Drawing.Point(315, 28);
        this.btnClearSearch.Name = "btnClearSearch";
        this.btnClearSearch.Size = new System.Drawing.Size(65, 30);
        this.btnClearSearch.TabIndex = 2;
        this.btnClearSearch.Text = "Clear";
        this.btnClearSearch.UseVisualStyleBackColor = false;
        this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
        // 
        // txtSearch
        // 
        this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.txtSearch.Location = new System.Drawing.Point(75, 29);
        this.txtSearch.Name = "txtSearch";
        this.txtSearch.PlaceholderText = "Search by item or category...";
        this.txtSearch.Size = new System.Drawing.Size(234, 29);
        this.txtSearch.TabIndex = 1;
        this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
        // 
        // lblSearch
        // 
        this.lblSearch.AutoSize = true;
        this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblSearch.Location = new System.Drawing.Point(14, 32);
        this.lblSearch.Name = "lblSearch";
        this.lblSearch.Size = new System.Drawing.Size(60, 21);
        this.lblSearch.TabIndex = 0;
        this.lblSearch.Text = "Search:";
        // 
        // grpMenuTable
        // 
        this.grpMenuTable.BackColor = System.Drawing.Color.Transparent;
        this.grpMenuTable.Controls.Add(this.dgvMenu);
        this.grpMenuTable.Dock = System.Windows.Forms.DockStyle.Fill;
        this.grpMenuTable.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.grpMenuTable.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        this.grpMenuTable.Location = new System.Drawing.Point(24, 147);
        this.grpMenuTable.Name = "grpMenuTable";
        this.grpMenuTable.Padding = new System.Windows.Forms.Padding(12, 10, 12, 12);
        this.grpMenuTable.Size = new System.Drawing.Size(996, 513);
        this.grpMenuTable.TabIndex = 2;
        this.grpMenuTable.TabStop = false;
        this.grpMenuTable.Text = "Menu Items";
        // 
        // dgvMenu
        // 
        this.dgvMenu.AllowUserToAddRows = false;
        this.dgvMenu.AllowUserToDeleteRows = false;
        this.dgvMenu.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        this.dgvMenu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvMenu.BackgroundColor = System.Drawing.Color.White;
        this.dgvMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.dgvMenu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        this.dgvMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colCategory,
            this.colPrice,
            this.colAvailability,
            this.colAction});
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        this.dgvMenu.DefaultCellStyle = dataGridViewCellStyle3;
        this.dgvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvMenu.EnableHeadersVisualStyles = false;
        this.dgvMenu.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
        this.dgvMenu.Location = new System.Drawing.Point(12, 33);
        this.dgvMenu.MultiSelect = false;
        this.dgvMenu.Name = "dgvMenu";
        this.dgvMenu.ReadOnly = true;
        this.dgvMenu.RowHeadersVisible = false;
        this.dgvMenu.RowHeadersWidth = 51;
        this.dgvMenu.RowTemplate.Height = 36;
        this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvMenu.Size = new System.Drawing.Size(972, 468);
        this.dgvMenu.TabIndex = 0;
        this.dgvMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellContentClick);
        // 
        // colName
        // 
        this.colName.FillWeight = 160F;
        this.colName.HeaderText = "Item Name";
        this.colName.MinimumWidth = 6;
        this.colName.Name = "colName";
        this.colName.ReadOnly = true;
        // 
        // colCategory
        // 
        this.colCategory.FillWeight = 110F;
        this.colCategory.HeaderText = "Category";
        this.colCategory.MinimumWidth = 6;
        this.colCategory.Name = "colCategory";
        this.colCategory.ReadOnly = true;
        // 
        // colPrice
        // 
        this.colPrice.FillWeight = 90F;
        this.colPrice.HeaderText = "Price (ETB)";
        this.colPrice.MinimumWidth = 6;
        this.colPrice.Name = "colPrice";
        this.colPrice.ReadOnly = true;
        // 
        // colAvailability
        // 
        this.colAvailability.FillWeight = 100F;
        this.colAvailability.HeaderText = "Availability";
        this.colAvailability.MinimumWidth = 6;
        this.colAvailability.Name = "colAvailability";
        this.colAvailability.ReadOnly = true;
        // 
        // colAction
        // 
        this.colAction.FillWeight = 70F;
        this.colAction.FlatStyle = System.Windows.Forms.FlatStyle.System;
        this.colAction.HeaderText = "Action";
        this.colAction.MinimumWidth = 6;
        this.colAction.Name = "colAction";
        this.colAction.ReadOnly = true;
        this.colAction.Text = "View";
        this.colAction.UseColumnTextForButtonValue = true;
        // 
        // MenuView
        // 
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
        this.Controls.Add(this.grpMenuTable);
        this.Controls.Add(this.grpFilter);
        this.Controls.Add(this.pnlHeader);
        this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.Name = "MenuView";
        this.Padding = new System.Windows.Forms.Padding(24, 16, 24, 20);
        this.Size = new System.Drawing.Size(1044, 680);
        this.pnlHeader.ResumeLayout(false);
        this.pnlHeader.PerformLayout();
        this.grpFilter.ResumeLayout(false);
        this.grpFilter.PerformLayout();
        this.grpMenuTable.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.GroupBox grpFilter;
    private System.Windows.Forms.Label lblSearch;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.Button btnClearSearch;
    private System.Windows.Forms.Label lblFilterAvailability;
    private System.Windows.Forms.ComboBox cboAvailability;
    private System.Windows.Forms.Label lblCountSummary;
    private System.Windows.Forms.GroupBox grpMenuTable;
    private System.Windows.Forms.DataGridView dgvMenu;
    private System.Windows.Forms.DataGridViewTextBoxColumn colName;
    private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
    private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
    private System.Windows.Forms.DataGridViewTextBoxColumn colAvailability;
    private System.Windows.Forms.DataGridViewButtonColumn colAction;
}
