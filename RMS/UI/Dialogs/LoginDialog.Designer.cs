namespace RMS.UI.Dialogs;

partial class LoginDialog
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
        grpCredentials = new GroupBox();
        lblError = new Label();
        lblHint = new Label();
        txtStaffId = new TextBox();
        lblStaffId = new Label();
        btnLogin = new Button();
        btnCancel = new Button();
        grpCredentials.SuspendLayout();
        SuspendLayout();
        // 
        // grpCredentials
        // 
        grpCredentials.Controls.Add(lblError);
        grpCredentials.Controls.Add(lblHint);
        grpCredentials.Controls.Add(txtStaffId);
        grpCredentials.Controls.Add(lblStaffId);
        grpCredentials.Font = new Font("Segoe UI", 9F);
        grpCredentials.Location = new Point(20, 18);
        grpCredentials.Margin = new Padding(4, 4, 4, 4);
        grpCredentials.Name = "grpCredentials";
        grpCredentials.Padding = new Padding(4, 4, 4, 4);
        grpCredentials.Size = new Size(432, 162);
        grpCredentials.TabIndex = 0;
        grpCredentials.TabStop = false;
        grpCredentials.Text = "Staff Login";
        // 
        // lblError
        // 
        lblError.AutoSize = true;
        lblError.Font = new Font("Segoe UI", 8.25F);
        lblError.ForeColor = Color.Red;
        lblError.Location = new Point(25, 120);
        lblError.Margin = new Padding(4, 0, 4, 0);
        lblError.Name = "lblError";
        lblError.Size = new Size(361, 23);
        lblError.TabIndex = 3;
        lblError.Text = "Invalid Staff ID. Account not found or inactive.";
        lblError.Visible = false;
        // 
        // lblHint
        // 
        lblHint.AutoSize = true;
        lblHint.Font = new Font("Segoe UI", 8.25F);
        lblHint.ForeColor = SystemColors.GrayText;
        lblHint.Location = new Point(119, 80);
        lblHint.Margin = new Padding(4, 0, 4, 0);
        lblHint.Name = "lblHint";
        lblHint.Size = new Size(302, 23);
        lblHint.TabIndex = 2;
        lblHint.Text = "Manager: 100  |  Waiter: 101";
        // 
        // txtStaffId
        // 
        txtStaffId.Font = new Font("Segoe UI", 9.5F);
        txtStaffId.Location = new Point(119, 38);
        txtStaffId.Margin = new Padding(4, 4, 4, 4);
        txtStaffId.Name = "txtStaffId";
        txtStaffId.Size = new Size(284, 33);
        txtStaffId.TabIndex = 1;
        txtStaffId.TextChanged += txtStaffId_TextChanged;
        // 
        // lblStaffId
        // 
        lblStaffId.AutoSize = true;
        lblStaffId.Font = new Font("Segoe UI", 9F);
        lblStaffId.Location = new Point(25, 42);
        lblStaffId.Margin = new Padding(4, 0, 4, 0);
        lblStaffId.Name = "lblStaffId";
        lblStaffId.Size = new Size(75, 25);
        lblStaffId.TabIndex = 0;
        lblStaffId.Text = "Staff ID:";
        // 
        // btnLogin
        // 
        btnLogin.FlatStyle = FlatStyle.System;
        btnLogin.Font = new Font("Segoe UI", 9F);
        btnLogin.Location = new Point(218, 198);
        btnLogin.Margin = new Padding(4, 4, 4, 4);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(112, 40);
        btnLogin.TabIndex = 1;
        btnLogin.Text = "Sign In";
        btnLogin.UseVisualStyleBackColor = true;
        btnLogin.Click += btnLogin_Click;
        // 
        // btnCancel
        // 
        btnCancel.DialogResult = DialogResult.Cancel;
        btnCancel.FlatStyle = FlatStyle.System;
        btnCancel.Font = new Font("Segoe UI", 9F);
        btnCancel.Location = new Point(340, 198);
        btnCancel.Margin = new Padding(4, 4, 4, 4);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(112, 40);
        btnCancel.TabIndex = 2;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // LoginDialog
        // 
        AcceptButton = btnLogin;
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = btnCancel;
        ClientSize = new Size(537, 258);
        Controls.Add(btnCancel);
        Controls.Add(btnLogin);
        Controls.Add(grpCredentials);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4, 4, 4, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "LoginDialog";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "RMS — Sign In";
        grpCredentials.ResumeLayout(false);
        grpCredentials.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.GroupBox grpCredentials;
    private System.Windows.Forms.Label lblStaffId;
    private System.Windows.Forms.TextBox txtStaffId;
    private System.Windows.Forms.Label lblHint;
    private System.Windows.Forms.Label lblError;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.Button btnCancel;
}
