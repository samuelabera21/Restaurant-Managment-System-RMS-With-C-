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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        pnlHeader = new Panel();
        lblTitle = new Label();
        grpFilter = new GroupBox();
        lblCountSummary = new Label();
        cboAvailability = new ComboBox();
        lblFilterAvailability = new Label();
        btnClearSearch = new Button();
        txtSearch = new TextBox();
        lblSearch = new Label();
        grpMenuTable = new GroupBox();
        dgvMenu = new DataGridView();
        colName = new DataGridViewTextBoxColumn();
        colCategory = new DataGridViewTextBoxColumn();
        colPrice = new DataGridViewTextBoxColumn();
        colAvailability = new DataGridViewTextBoxColumn();
        colAction = new DataGridViewButtonColumn();
        pnlHeader.SuspendLayout();
        grpFilter.SuspendLayout();
        grpMenuTable.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvMenu).BeginInit();
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
        lblTitle.Location = new Point(0, -1);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(106, 45);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Menu";
        
        // 
        // grpFilter
        // 
        grpFilter.BackColor = Color.Transparent;
        grpFilter.Controls.Add(lblCountSummary);
        grpFilter.Controls.Add(cboAvailability);
        grpFilter.Controls.Add(lblFilterAvailability);
        grpFilter.Controls.Add(btnClearSearch);
        grpFilter.Controls.Add(txtSearch);
        grpFilter.Controls.Add(lblSearch);
        grpFilter.Dock = DockStyle.Top;
        grpFilter.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        grpFilter.ForeColor = Color.FromArgb(15, 23, 42);
        grpFilter.Location = new Point(24, 60);
        grpFilter.Name = "grpFilter";
        grpFilter.Size = new Size(1072, 72);
        grpFilter.TabIndex = 1;
        grpFilter.TabStop = false;
        grpFilter.Text = "Search & Filter";
        // 
        // lblCountSummary
        // 
        lblCountSummary.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblCountSummary.Font = new Font("Segoe UI", 9F);
        lblCountSummary.ForeColor = Color.FromArgb(71, 85, 105);
        lblCountSummary.Location = new Point(720, 28);
        lblCountSummary.Name = "lblCountSummary";
        lblCountSummary.Size = new Size(335, 25);
        lblCountSummary.TabIndex = 5;
        lblCountSummary.Text = "Showing 7 of 7 items";
        lblCountSummary.TextAlign = ContentAlignment.MiddleRight;
        // 
        // cboAvailability
        // 
        cboAvailability.DropDownStyle = ComboBoxStyle.DropDownList;
        cboAvailability.Font = new Font("Segoe UI", 9.5F);
        cboAvailability.FormattingEnabled = true;
        cboAvailability.Items.AddRange(new object[] { "All Items", "Available", "Unavailable" });
        cboAvailability.Location = new Point(525, 25);
        cboAvailability.Name = "cboAvailability";
        cboAvailability.Size = new Size(140, 33);
        cboAvailability.TabIndex = 4;
        cboAvailability.SelectedIndexChanged += cboAvailability_SelectedIndexChanged;
        // 
        // lblFilterAvailability
        // 
        lblFilterAvailability.AutoSize = true;
        lblFilterAvailability.Font = new Font("Segoe UI", 9.5F);
        lblFilterAvailability.Location = new Point(430, 28);
        lblFilterAvailability.Name = "lblFilterAvailability";
        lblFilterAvailability.Size = new Size(108, 25);
        lblFilterAvailability.TabIndex = 3;
        lblFilterAvailability.Text = "Availability:";
        // 
        // btnClearSearch
        // 
        btnClearSearch.BackColor = Color.White;
        btnClearSearch.Cursor = Cursors.Hand;
        btnClearSearch.FlatStyle = FlatStyle.System;
        btnClearSearch.Font = new Font("Segoe UI", 9F);
        btnClearSearch.Location = new Point(330, 24);
        btnClearSearch.Name = "btnClearSearch";
        btnClearSearch.Size = new Size(70, 31);
        btnClearSearch.TabIndex = 2;
        btnClearSearch.Text = "Clear";
        btnClearSearch.UseVisualStyleBackColor = false;
        btnClearSearch.Click += btnClearSearch_Click;
        // 
        // txtSearch
        // 
        txtSearch.Font = new Font("Segoe UI", 9.5F);
        txtSearch.Location = new Point(80, 25);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Search item name or category...";
        txtSearch.Size = new Size(235, 33);
        txtSearch.TabIndex = 1;
        txtSearch.TextChanged += txtSearch_TextChanged;
        // 
        // lblSearch
        // 
        lblSearch.AutoSize = true;
        lblSearch.Font = new Font("Segoe UI", 9.5F);
        lblSearch.Location = new Point(16, 28);
        lblSearch.Name = "lblSearch";
        lblSearch.Size = new Size(73, 25);
        lblSearch.TabIndex = 0;
        lblSearch.Text = "Search:";
        // 
        // grpMenuTable
        // 
        grpMenuTable.BackColor = Color.Transparent;
        grpMenuTable.Controls.Add(dgvMenu);
        grpMenuTable.Dock = DockStyle.Fill;
        grpMenuTable.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        grpMenuTable.ForeColor = Color.FromArgb(15, 23, 42);
        grpMenuTable.Location = new Point(24, 132);
        grpMenuTable.Name = "grpMenuTable";
        grpMenuTable.Padding = new Padding(12, 10, 12, 12);
        grpMenuTable.Size = new Size(1072, 390);
        grpMenuTable.TabIndex = 2;
        grpMenuTable.TabStop = false;
        grpMenuTable.Text = "Menu Items";
        // 
        // dgvMenu
        // 
        dgvMenu.AllowUserToAddRows = false;
        dgvMenu.AllowUserToDeleteRows = false;
        dgvMenu.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
        dgvMenu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvMenu.BackgroundColor = Color.White;
        dgvMenu.BorderStyle = BorderStyle.Fixed3D;
        dgvMenu.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle2.Padding = new Padding(4, 6, 4, 6);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(241, 245, 249);
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 41, 59);
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        dgvMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvMenu.Columns.AddRange(new DataGridViewColumn[] { colName, colCategory, colPrice, colAvailability, colAction });
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.White;
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle3.Padding = new Padding(4);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(219, 234, 254);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(15, 23, 42);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        dgvMenu.DefaultCellStyle = dataGridViewCellStyle3;
        dgvMenu.Dock = DockStyle.Fill;
        dgvMenu.EnableHeadersVisualStyles = false;
        dgvMenu.GridColor = Color.FromArgb(226, 232, 240);
        dgvMenu.Location = new Point(12, 37);
        dgvMenu.MultiSelect = false;
        dgvMenu.Name = "dgvMenu";
        dgvMenu.ReadOnly = true;
        dgvMenu.RowHeadersVisible = false;
        dgvMenu.RowHeadersWidth = 51;
        dgvMenu.RowTemplate.Height = 36;
        dgvMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvMenu.Size = new Size(1048, 341);
        dgvMenu.TabIndex = 0;
        dgvMenu.CellContentClick += dgvMenu_CellContentClick;
        // 
        // colName
        // 
        colName.FillWeight = 160F;
        colName.HeaderText = "Item Name";
        colName.MinimumWidth = 6;
        colName.Name = "colName";
        colName.ReadOnly = true;
        // 
        // colCategory
        // 
        colCategory.FillWeight = 110F;
        colCategory.HeaderText = "Category";
        colCategory.MinimumWidth = 6;
        colCategory.Name = "colCategory";
        colCategory.ReadOnly = true;
        // 
        // colPrice
        // 
        colPrice.FillWeight = 90F;
        colPrice.HeaderText = "Price (ETB)";
        colPrice.MinimumWidth = 6;
        colPrice.Name = "colPrice";
        colPrice.ReadOnly = true;
        // 
        // colAvailability
        // 
        colAvailability.HeaderText = "Availability";
        colAvailability.MinimumWidth = 6;
        colAvailability.Name = "colAvailability";
        colAvailability.ReadOnly = true;
        // 
        // colAction
        // 
        colAction.FillWeight = 70F;
        colAction.FlatStyle = FlatStyle.System;
        colAction.HeaderText = "Action";
        colAction.MinimumWidth = 6;
        colAction.Name = "colAction";
        colAction.ReadOnly = true;
        colAction.Text = "View";
        colAction.UseColumnTextForButtonValue = true;
        // 
        // MenuView
        // 
        AutoScaleDimensions = new SizeF(144F, 144F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.FromArgb(243, 244, 246);
        Controls.Add(grpMenuTable);
        Controls.Add(grpFilter);
        Controls.Add(pnlHeader);
        Name = "MenuView";
        Padding = new Padding(24, 16, 24, 20);
        Size = new Size(1120, 542);
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        grpFilter.ResumeLayout(false);
        grpFilter.PerformLayout();
        grpMenuTable.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvMenu).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
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
