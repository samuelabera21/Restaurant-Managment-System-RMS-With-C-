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
        lblTitle = new System.Windows.Forms.Label();
        lblSubtitle = new System.Windows.Forms.Label();
        lblName = new System.Windows.Forms.Label();
        txtName = new System.Windows.Forms.TextBox();
        lblCategory = new System.Windows.Forms.Label();
        cboCategory = new System.Windows.Forms.ComboBox();
        lblPrice = new System.Windows.Forms.Label();
        numPrice = new System.Windows.Forms.NumericUpDown();
        chkAvailable = new System.Windows.Forms.CheckBox();
        lblError = new System.Windows.Forms.Label();
        btnCancel = new System.Windows.Forms.Button();
        btnSave = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblTitle.Location = new System.Drawing.Point(22, 14);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(152, 28);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Edit Menu Item";
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        lblSubtitle.ForeColor = System.Drawing.SystemColors.GrayText;
        lblSubtitle.Location = new System.Drawing.Point(24, 44);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new System.Drawing.Size(325, 20);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Configure item name, category, price, and status";
        // 
        // lblName
        // 
        lblName.AutoSize = true;
        lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        lblName.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblName.Location = new System.Drawing.Point(24, 82);
        lblName.Name = "lblName";
        lblName.Size = new System.Drawing.Size(96, 20);
        lblName.TabIndex = 2;
        lblName.Text = "Item Name *";
        // 
        // txtName
        // 
        txtName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        txtName.Location = new System.Drawing.Point(24, 106);
        txtName.Name = "txtName";
        txtName.Size = new System.Drawing.Size(412, 29);
        txtName.TabIndex = 3;
        // 
        // lblCategory
        // 
        lblCategory.AutoSize = true;
        lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        lblCategory.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblCategory.Location = new System.Drawing.Point(24, 148);
        lblCategory.Name = "lblCategory";
        lblCategory.Size = new System.Drawing.Size(83, 20);
        lblCategory.TabIndex = 4;
        lblCategory.Text = "Category *";
        // 
        // cboCategory
        // 
        cboCategory.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        cboCategory.FormattingEnabled = true;
        cboCategory.Items.AddRange(new object[] { "Beverage", "Drinks", "Main Course", "Traditional", "Fast Food", "Side Dish", "Dessert" });
        cboCategory.Location = new System.Drawing.Point(24, 172);
        cboCategory.Name = "cboCategory";
        cboCategory.Size = new System.Drawing.Size(412, 29);
        cboCategory.TabIndex = 5;
        // 
        // lblPrice
        // 
        lblPrice.AutoSize = true;
        lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        lblPrice.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        lblPrice.Location = new System.Drawing.Point(24, 214);
        lblPrice.Name = "lblPrice";
        lblPrice.Size = new System.Drawing.Size(92, 20);
        lblPrice.TabIndex = 6;
        lblPrice.Text = "Price (ETB) *";
        // 
        // numPrice
        // 
        numPrice.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        numPrice.Location = new System.Drawing.Point(24, 238);
        numPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        numPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numPrice.Name = "numPrice";
        numPrice.Size = new System.Drawing.Size(180, 29);
        numPrice.TabIndex = 7;
        numPrice.Value = new decimal(new int[] { 50, 0, 0, 0 });
        // 
        // chkAvailable
        // 
        chkAvailable.AutoSize = true;
        chkAvailable.Checked = true;
        chkAvailable.CheckState = System.Windows.Forms.CheckState.Checked;
        chkAvailable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        chkAvailable.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
        chkAvailable.Location = new System.Drawing.Point(234, 240);
        chkAvailable.Name = "chkAvailable";
        chkAvailable.Size = new System.Drawing.Size(183, 24);
        chkAvailable.TabIndex = 8;
        chkAvailable.Text = "Available for ordering";
        chkAvailable.UseVisualStyleBackColor = true;
        // 
        // lblError
        // 
        lblError.AutoSize = true;
        lblError.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        lblError.ForeColor = System.Drawing.Color.Red;
        lblError.Location = new System.Drawing.Point(24, 276);
        lblError.Name = "lblError";
        lblError.Size = new System.Drawing.Size(187, 19);
        lblError.TabIndex = 9;
        lblError.Text = "Please enter valid item data";
        lblError.Visible = false;
        // 
        // btnCancel
        // 
        btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
        btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        btnCancel.Location = new System.Drawing.Point(218, 308);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(100, 36);
        btnCancel.TabIndex = 10;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // btnSave
        // 
        btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
        btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        btnSave.Location = new System.Drawing.Point(326, 308);
        btnSave.Name = "btnSave";
        btnSave.Size = new System.Drawing.Size(110, 36);
        btnSave.TabIndex = 11;
        btnSave.Text = "Save Changes";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // MenuItemDialog
        // 
        AcceptButton = btnSave;
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        CancelButton = btnCancel;
        ClientSize = new System.Drawing.Size(460, 360);
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
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "MenuItemDialog";
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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

