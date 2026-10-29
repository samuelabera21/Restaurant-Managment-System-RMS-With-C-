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
        grpCredentials = new System.Windows.Forms.GroupBox();
        lblError = new System.Windows.Forms.Label();
        lblHint = new System.Windows.Forms.Label();
        txtStaffId = new System.Windows.Forms.TextBox();
        lblStaffId = new System.Windows.Forms.Label();
        btnLogin = new System.Windows.Forms.Button();
        btnCancel = new System.Windows.Forms.Button();
        grpCredentials.SuspendLayout();
        SuspendLayout();
        // 
        // grpCredentials
        // 
        grpCredentials.Controls.Add(lblError);
        grpCredentials.Controls.Add(lblHint);
        grpCredentials.Controls.Add(txtStaffId);
        grpCredentials.Controls.Add(lblStaffId);
        grpCredentials.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        grpCredentials.Location = new System.Drawing.Point(16, 14);
        grpCredentials.Name = "grpCredentials";
        grpCredentials.Size = new System.Drawing.Size(346, 130);
        grpCredentials.TabIndex = 0;
        grpCredentials.TabStop = false;
        grpCredentials.Text = "Staff Login";
        // 
        // lblError
        // 
        lblError.AutoSize = true;
        lblError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        lblError.ForeColor = System.Drawing.Color.Red;
        lblError.Location = new System.Drawing.Point(20, 96);
        lblError.Name = "lblError";
        lblError.Size = new System.Drawing.Size(262, 19);
        lblError.TabIndex = 3;
        lblError.Text = "Invalid Staff ID. Account not found or inactive.";
        lblError.Visible = false;
        // 
        // lblHint
        // 
        lblHint.AutoSize = true;
        lblHint.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        lblHint.ForeColor = System.Drawing.SystemColors.GrayText;
        lblHint.Location = new System.Drawing.Point(95, 64);
        lblHint.Name = "lblHint";
        lblHint.Size = new System.Drawing.Size(227, 19);
        lblHint.TabIndex = 2;
        lblHint.Text = "Manager: 100  |  Waiters: 101, 102, 103";
        // 
        // txtStaffId
        // 
        txtStaffId.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        txtStaffId.Location = new System.Drawing.Point(95, 30);
        txtStaffId.Name = "txtStaffId";
        txtStaffId.Size = new System.Drawing.Size(228, 29);
        txtStaffId.TabIndex = 1;
        txtStaffId.TextChanged += txtStaffId_TextChanged;
        // 
        // lblStaffId
        // 
        lblStaffId.AutoSize = true;
        lblStaffId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        lblStaffId.Location = new System.Drawing.Point(20, 34);
        lblStaffId.Name = "lblStaffId";
        lblStaffId.Size = new System.Drawing.Size(61, 20);
        lblStaffId.TabIndex = 0;
        lblStaffId.Text = "Staff ID:";
        // 
        // btnLogin
        // 
        btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
        btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        btnLogin.Location = new System.Drawing.Point(174, 158);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new System.Drawing.Size(90, 32);
        btnLogin.TabIndex = 1;
        btnLogin.Text = "Sign In";
        btnLogin.UseVisualStyleBackColor = true;
        btnLogin.Click += btnLogin_Click;
        // 
        // btnCancel
        // 
        btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
        btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        btnCancel.Location = new System.Drawing.Point(272, 158);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(90, 32);
        btnCancel.TabIndex = 2;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // LoginDialog
        // 
        AcceptButton = btnLogin;
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        CancelButton = btnCancel;
        ClientSize = new System.Drawing.Size(380, 206);
        Controls.Add(btnCancel);
        Controls.Add(btnLogin);
        Controls.Add(grpCredentials);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "LoginDialog";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
