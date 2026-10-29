namespace RMS.UI.Dialogs;

partial class StaffMemberDialog
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
        pnlHeader = new Panel();
        lblDialogTitle = new Label();
        pnlBody = new Panel();
        lblError = new Label();
        cboShift = new ComboBox();
        lblShift = new Label();
        txtFullName = new TextBox();
        lblFullName = new Label();
        txtStaffId = new TextBox();
        lblStaffId = new Label();
        pnlActions = new Panel();
        btnCancel = new Button();
        btnSave = new Button();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        pnlActions.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = Color.FromArgb(30, 58, 95);
        pnlHeader.Controls.Add(lblDialogTitle);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Location = new Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new Padding(20, 14, 20, 14);
        pnlHeader.Size = new Size(420, 56);
        pnlHeader.TabIndex = 0;
        // 
        // lblDialogTitle
        // 
        lblDialogTitle.AutoSize = true;
        lblDialogTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblDialogTitle.ForeColor = Color.White;
        lblDialogTitle.Location = new Point(18, 14);
        lblDialogTitle.Name = "lblDialogTitle";
        lblDialogTitle.Size = new Size(157, 28);
        lblDialogTitle.TabIndex = 0;
        lblDialogTitle.Text = "Add New Waiter";
        // 
        // pnlBody
        // 
        pnlBody.BackColor = Color.White;
        pnlBody.Controls.Add(lblError);
        pnlBody.Controls.Add(cboShift);
        pnlBody.Controls.Add(lblShift);
        pnlBody.Controls.Add(txtFullName);
        pnlBody.Controls.Add(lblFullName);
        pnlBody.Controls.Add(txtStaffId);
        pnlBody.Controls.Add(lblStaffId);
        pnlBody.Dock = DockStyle.Fill;
        pnlBody.Location = new Point(0, 56);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new Padding(24, 16, 24, 16);
        pnlBody.Size = new Size(420, 230);
        pnlBody.TabIndex = 1;
        // 
        // lblError
        // 
        lblError.AutoSize = true;
        lblError.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblError.ForeColor = Color.FromArgb(220, 38, 38);
        lblError.Location = new Point(24, 195);
        lblError.Name = "lblError";
        lblError.Size = new Size(183, 19);
        lblError.TabIndex = 6;
        lblError.Text = "Please enter waiter name.";
        lblError.Visible = false;
        // 
        // cboShift
        // 
        cboShift.DropDownStyle = ComboBoxStyle.DropDownList;
        cboShift.Font = new Font("Segoe UI", 10F);
        cboShift.FormattingEnabled = true;
        cboShift.Items.AddRange(new object[] { "Day Shift", "Evening Shift", "Night Shift" });
        cboShift.Location = new Point(24, 155);
        cboShift.Name = "cboShift";
        cboShift.Size = new Size(372, 31);
        cboShift.TabIndex = 5;
        // 
        // lblShift
        // 
        lblShift.AutoSize = true;
        lblShift.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblShift.ForeColor = Color.FromArgb(71, 85, 105);
        lblShift.Location = new Point(22, 132);
        lblShift.Name = "lblShift";
        lblShift.Size = new Size(106, 20);
        lblShift.TabIndex = 4;
        lblShift.Text = "Working Shift:";
        // 
        // txtFullName
        // 
        txtFullName.Font = new Font("Segoe UI", 10F);
        txtFullName.Location = new Point(24, 94);
        txtFullName.Name = "txtFullName";
        txtFullName.PlaceholderText = "Enter full name";
        txtFullName.Size = new Size(372, 30);
        txtFullName.TabIndex = 3;
        txtFullName.TextChanged += txtFullName_TextChanged;
        // 
        // lblFullName
        // 
        lblFullName.AutoSize = true;
        lblFullName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblFullName.ForeColor = Color.FromArgb(71, 85, 105);
        lblFullName.Location = new Point(22, 71);
        lblFullName.Name = "lblFullName";
        lblFullName.Size = new Size(108, 20);
        lblFullName.TabIndex = 2;
        lblFullName.Text = "Full Name: *";
        // 
        // txtStaffId
        // 
        txtStaffId.BackColor = Color.FromArgb(241, 245, 249);
        txtStaffId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        txtStaffId.ForeColor = Color.FromArgb(15, 23, 42);
        txtStaffId.Location = new Point(24, 33);
        txtStaffId.Name = "txtStaffId";
        txtStaffId.ReadOnly = true;
        txtStaffId.Size = new Size(372, 30);
        txtStaffId.TabIndex = 1;
        // 
        // lblStaffId
        // 
        lblStaffId.AutoSize = true;
        lblStaffId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblStaffId.ForeColor = Color.FromArgb(71, 85, 105);
        lblStaffId.Location = new Point(22, 10);
        lblStaffId.Name = "lblStaffId";
        lblStaffId.Size = new Size(178, 20);
        lblStaffId.TabIndex = 0;
        lblStaffId.Text = "Staff ID (Auto-Assigned):";
        // 
        // pnlActions
        // 
        pnlActions.BackColor = Color.FromArgb(248, 250, 252);
        pnlActions.Controls.Add(btnCancel);
        pnlActions.Controls.Add(btnSave);
        pnlActions.Dock = DockStyle.Bottom;
        pnlActions.Location = new Point(0, 286);
        pnlActions.Name = "pnlActions";
        pnlActions.Padding = new Padding(16, 10, 16, 10);
        pnlActions.Size = new Size(420, 54);
        pnlActions.TabIndex = 2;
        // 
        // btnCancel
        // 
        btnCancel.BackColor = Color.White;
        btnCancel.Cursor = Cursors.Hand;
        btnCancel.DialogResult = DialogResult.Cancel;
        btnCancel.FlatStyle = FlatStyle.System;
        btnCancel.Font = new Font("Segoe UI", 9F);
        btnCancel.Location = new Point(310, 10);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(86, 32);
        btnCancel.TabIndex = 1;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = false;
        // 
        // btnSave
        // 
        btnSave.BackColor = Color.FromArgb(30, 58, 95);
        btnSave.Cursor = Cursors.Hand;
        btnSave.FlatAppearance.BorderSize = 0;
        btnSave.FlatStyle = FlatStyle.Flat;
        btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnSave.ForeColor = Color.White;
        btnSave.Location = new Point(205, 10);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(95, 32);
        btnSave.TabIndex = 0;
        btnSave.Text = "Save";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Click += btnSave_Click;
        // 
        // StaffMemberDialog
        // 
        AcceptButton = btnSave;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = btnCancel;
        ClientSize = new Size(420, 340);
        Controls.Add(pnlBody);
        Controls.Add(pnlActions);
        Controls.Add(pnlHeader);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "StaffMemberDialog";
        StartPosition = FormStartPosition.CenterParent;
        Text = "RMS — Staff Member";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        pnlBody.PerformLayout();
        pnlActions.ResumeLayout(false);
        ResumeLayout(false);
    }

    private Panel pnlHeader;
    private Label lblDialogTitle;
    private Panel pnlBody;
    private Label lblStaffId;
    private TextBox txtStaffId;
    private Label lblFullName;
    private TextBox txtFullName;
    private Label lblShift;
    private ComboBox cboShift;
    private Label lblError;
    private Panel pnlActions;
    private Button btnSave;
    private Button btnCancel;
}

