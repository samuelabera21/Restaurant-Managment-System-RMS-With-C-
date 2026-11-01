namespace RMS.UI.Dialogs;

partial class MenuItemDialog
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

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        lblTitle = new Label();
        lblSubtitle = new Label();
        lblName = new Label();
        txtName = new TextBox();
        lblCategory = new Label();
        cboCategory = new ComboBox();
        lblPrice = new Label();
        numPrice = new NumericUpDown();
        chkAvailable = new CheckBox();
        lblError = new Label();
        btnCancel = new Button();
        btnSave = new Button();
        ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
        lblTitle.Location = new Point(28, 18);
        lblTitle.Margin = new Padding(4, 0, 4, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(190, 32);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Edit Menu Item";
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new Font("Segoe UI", 9F);
        lblSubtitle.ForeColor = SystemColors.GrayText;
        lblSubtitle.Location = new Point(30, 55);
        lblSubtitle.Margin = new Padding(4, 0, 4, 0);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(395, 25);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Configure item name, category, price, and status";
        // 
        // lblName
        // 
        lblName.AutoSize = true;
        lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblName.ForeColor = Color.FromArgb(15, 23, 42);
        lblName.Location = new Point(30, 102);
        lblName.Margin = new Padding(4, 0, 4, 0);
        lblName.Name = "lblName";
        lblName.Size = new Size(119, 25);
        lblName.TabIndex = 2;
        lblName.Text = "Item Name *";
        // 
        // txtName
        // 
        txtName.Font = new Font("Segoe UI", 9.5F);
        txtName.Location = new Point(30, 132);
        txtName.Margin = new Padding(4, 4, 4, 4);
        txtName.Name = "txtName";
        txtName.Size = new Size(514, 33);
        txtName.TabIndex = 3;
        // 
        // lblCategory
        // 
        lblCategory.AutoSize = true;
        lblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblCategory.ForeColor = Color.FromArgb(15, 23, 42);
        lblCategory.Location = new Point(30, 185);
        lblCategory.Margin = new Padding(4, 0, 4, 0);
        lblCategory.Name = "lblCategory";
        lblCategory.Size = new Size(103, 25);
        lblCategory.TabIndex = 4;
        lblCategory.Text = "Category *";
        // 
        // cboCategory
        // 
        cboCategory.Font = new Font("Segoe UI", 9.5F);
        cboCategory.FormattingEnabled = true;
        cboCategory.Items.AddRange(new object[] { "Beverage", "Drinks", "Main Course", "Traditional", "Fast Food", "Side Dish", "Dessert" });
        cboCategory.Location = new Point(30, 215);
        cboCategory.Margin = new Padding(4, 4, 4, 4);
        cboCategory.Name = "cboCategory";
        cboCategory.Size = new Size(514, 33);
        cboCategory.TabIndex = 5;
        // 
        // lblPrice
        // 
        lblPrice.AutoSize = true;
        lblPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblPrice.ForeColor = Color.FromArgb(15, 23, 42);
        lblPrice.Location = new Point(30, 268);
        lblPrice.Margin = new Padding(4, 0, 4, 0);
        lblPrice.Name = "lblPrice";
        lblPrice.Size = new Size(119, 25);
        lblPrice.TabIndex = 6;
        lblPrice.Text = "Price (ETB) *";
        // 
        // numPrice
        // 
        numPrice.Font = new Font("Segoe UI", 9.5F);
        numPrice.Location = new Point(30, 298);
        numPrice.Margin = new Padding(4, 4, 4, 4);
        numPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        numPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numPrice.Name = "numPrice";
        numPrice.Size = new Size(225, 33);
        numPrice.TabIndex = 7;
        numPrice.Value = new decimal(new int[] { 50, 0, 0, 0 });
        // 
        // chkAvailable
        // 
        chkAvailable.AutoSize = true;
        chkAvailable.Checked = true;
        chkAvailable.CheckState = CheckState.Checked;
        chkAvailable.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        chkAvailable.ForeColor = Color.FromArgb(15, 23, 42);
        chkAvailable.Location = new Point(292, 300);
        chkAvailable.Margin = new Padding(4, 4, 4, 4);
        chkAvailable.Name = "chkAvailable";
        chkAvailable.Size = new Size(225, 29);
        chkAvailable.TabIndex = 8;
        chkAvailable.Text = "Available for ordering";
        chkAvailable.UseVisualStyleBackColor = true;
        chkAvailable.CheckedChanged += chkAvailable_CheckedChanged;
        // 
        // lblError
        // 
        lblError.AutoSize = true;
        lblError.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblError.ForeColor = Color.Red;
        lblError.Location = new Point(30, 345);
        lblError.Margin = new Padding(4, 0, 4, 0);
        lblError.Name = "lblError";
        lblError.Size = new Size(233, 23);
        lblError.TabIndex = 9;
        lblError.Text = "Please enter valid item data";
        lblError.Visible = false;
        // 
        // btnCancel
        // 
        btnCancel.DialogResult = DialogResult.Cancel;
        btnCancel.FlatStyle = FlatStyle.System;
        btnCancel.Font = new Font("Segoe UI", 9F);
        btnCancel.Location = new Point(272, 385);
        btnCancel.Margin = new Padding(4, 4, 4, 4);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(125, 45);
        btnCancel.TabIndex = 10;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // btnSave
        // 
        btnSave.FlatStyle = FlatStyle.System;
        btnSave.Font = new Font("Segoe UI", 9F);
        btnSave.Location = new Point(408, 385);
        btnSave.Margin = new Padding(4, 4, 4, 4);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(138, 45);
        btnSave.TabIndex = 11;
        btnSave.Text = "Save Changes";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // MenuItemDialog
        // 
        AcceptButton = btnSave;
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = btnCancel;
        ClientSize = new Size(575, 450);
        Controls.Add(btnSave);
        Controls.Add(btnCancel);
        Controls.Add(lblError);
        Controls.Add(chkAvailable);
        Controls.Add(numPrice);
        Controls.Add(lblPrice);
        Controls.Add(cboCategory);
        Controls.Add(lblCategory);
        Controls.Add(txtName);
        Controls.Add(lblName);
        Controls.Add(lblSubtitle);
        Controls.Add(lblTitle);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4, 4, 4, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "MenuItemDialog";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Menu Item";
        ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label lblCategory;
    private System.Windows.Forms.ComboBox cboCategory;
    private System.Windows.Forms.Label lblPrice;
    private System.Windows.Forms.NumericUpDown numPrice;
    private System.Windows.Forms.CheckBox chkAvailable;
    private System.Windows.Forms.Label lblError;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnSave;
}

