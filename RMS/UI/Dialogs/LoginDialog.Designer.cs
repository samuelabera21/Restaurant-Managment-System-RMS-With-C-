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

    private void InitializeComponent()
    {
        pnlHeader = new Panel();
        lblSubtitle = new Label();
        lblTitle = new Label();
        pnlBody = new Panel();
        pnlHints = new Panel();
        lblHintsTitle = new Label();
        lblHintsText = new Label();
        lblError = new Label();
        btnLogin = new Button();
        txtStaffId = new TextBox();
        lblStaffId = new Label();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        pnlHints.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = Color.FromArgb(30, 58, 95);
        pnlHeader.Controls.Add(lblSubtitle);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Location = new Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new Padding(24, 16, 24, 16);
        pnlHeader.Size = new Size(420, 80);
        pnlHeader.TabIndex = 0;
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new Font("Segoe UI", 9F);
        lblSubtitle.ForeColor = Color.FromArgb(203, 213, 225);
        lblSubtitle.Location = new Point(24, 45);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(244, 20);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Restaurant Order Management System";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(22, 12);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(93, 32);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Sign In";
        // 
        // pnlBody
        // 
        pnlBody.BackColor = Color.White;
        pnlBody.Controls.Add(pnlHints);
        pnlBody.Controls.Add(lblError);
        pnlBody.Controls.Add(btnLogin);
        pnlBody.Controls.Add(txtStaffId);
        pnlBody.Controls.Add(lblStaffId);
        pnlBody.Dock = DockStyle.Fill;
        pnlBody.Location = new Point(0, 80);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new Padding(24);
        pnlBody.Size = new Size(420, 260);
        pnlBody.TabIndex = 1;
        // 
        // pnlHints
        // 
        pnlHints.BackColor = Color.FromArgb(248, 250, 252);
        pnlHints.BorderStyle = BorderStyle.FixedSingle;
        pnlHints.Controls.Add(lblHintsTitle);
        pnlHints.Controls.Add(lblHintsText);
        pnlHints.Location = new Point(24, 160);
        pnlHints.Name = "pnlHints";
        pnlHints.Padding = new Padding(10, 8, 10, 8);
        pnlHints.Size = new Size(372, 72);
        pnlHints.TabIndex = 4;
        // 
        // lblHintsTitle
        // 
        lblHintsTitle.AutoSize = true;
        lblHintsTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblHintsTitle.ForeColor = Color.FromArgb(71, 85, 105);
        lblHintsTitle.Location = new Point(8, 6);
        lblHintsTitle.Name = "lblHintsTitle";
        lblHintsTitle.Size = new Size(137, 19);
        lblHintsTitle.TabIndex = 0;
        lblHintsTitle.Text = "Registered Staff IDs:";
        // 
        // lblHintsText
        // 
        lblHintsText.AutoSize = true;
        lblHintsText.Font = new Font("Segoe UI", 8.5F);
        lblHintsText.ForeColor = Color.FromArgb(100, 116, 139);
        lblHintsText.Location = new Point(8, 28);
        lblHintsText.Name = "lblHintsText";
        lblHintsText.Size = new Size(328, 38);
        lblHintsText.TabIndex = 1;
        lblHintsText.Text = "• Manager ID: 100\n• Waiter IDs: 101 (Abebe), 102 (Hana), 103 (Dawit)";
        // 
        // lblError
        // 
        lblError.AutoSize = true;
        lblError.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblError.ForeColor = Color.FromArgb(220, 38, 38);
        lblError.Location = new Point(24, 68);
        lblError.Name = "lblError";
        lblError.Size = new Size(265, 20);
        lblError.TabIndex = 2;
        lblError.Text = "Invalid Staff ID. Please try again.";
        lblError.Visible = false;
        // 
        // btnLogin
        // 
        btnLogin.BackColor = Color.FromArgb(30, 58, 95);
        btnLogin.Cursor = Cursors.Hand;
        btnLogin.FlatAppearance.BorderSize = 0;
        btnLogin.FlatStyle = FlatStyle.Flat;
        btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnLogin.ForeColor = Color.White;
        btnLogin.Location = new Point(24, 98);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(372, 40);
        btnLogin.TabIndex = 3;
        btnLogin.Text = "Sign In";
        btnLogin.UseVisualStyleBackColor = false;
        btnLogin.Click += btnLogin_Click;
        // 
        // txtStaffId
        // 
        txtStaffId.Font = new Font("Segoe UI", 11F);
        txtStaffId.Location = new Point(24, 34);
        txtStaffId.Name = "txtStaffId";
        txtStaffId.PlaceholderText = "Enter Staff ID (e.g., 100 or 101)";
        txtStaffId.Size = new Size(372, 32);
        txtStaffId.TabIndex = 1;
        txtStaffId.TextChanged += txtStaffId_TextChanged;
        // 
        // lblStaffId
        // 
        lblStaffId.AutoSize = true;
        lblStaffId.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        lblStaffId.ForeColor = Color.FromArgb(15, 23, 42);
        lblStaffId.Location = new Point(22, 10);
        lblStaffId.Name = "lblStaffId";
        lblStaffId.Size = new Size(74, 21);
        lblStaffId.TabIndex = 0;
        lblStaffId.Text = "Staff ID:";
        // 
        // LoginDialog
        // 
        AcceptButton = btnLogin;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(420, 340);
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "LoginDialog";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "RMS — Sign In";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        pnlBody.PerformLayout();
        pnlHints.ResumeLayout(false);
        pnlHints.PerformLayout();
        ResumeLayout(false);
    }

    private Panel pnlHeader;
    private Label lblTitle;
    private Label lblSubtitle;
    private Panel pnlBody;
    private Label lblStaffId;
    private TextBox txtStaffId;
    private Label lblError;
    private Button btnLogin;
    private Panel pnlHints;
    private Label lblHintsTitle;
    private Label lblHintsText;
}
