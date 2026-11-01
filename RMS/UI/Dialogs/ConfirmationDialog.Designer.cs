namespace RMS.UI.Dialogs;

partial class ConfirmationDialog
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
        lblHeading = new Label();
        lblMessage = new Label();
        btnConfirm = new Button();
        btnCancel = new Button();
        SuspendLayout();
        // 
        // lblHeading
        // 
        lblHeading.AutoSize = true;
        lblHeading.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblHeading.ForeColor = Color.FromArgb(15, 23, 42);
        lblHeading.Location = new Point(28, 28);
        lblHeading.Margin = new Padding(4, 0, 4, 0);
        lblHeading.Name = "lblHeading";
        lblHeading.Size = new Size(310, 32);
        lblHeading.TabIndex = 0;
        lblHeading.Text = "Discard unsaved changes?";
        // 
        // lblMessage
        // 
        lblMessage.Font = new Font("Segoe UI", 9.5F);
        lblMessage.ForeColor = Color.FromArgb(71, 85, 105);
        lblMessage.Location = new Point(30, 72);
        lblMessage.Margin = new Padding(4, 0, 4, 0);
        lblMessage.Name = "lblMessage";
        lblMessage.Size = new Size(460, 58);
        lblMessage.TabIndex = 1;
        lblMessage.Text = "Your changes to Order 105 will be lost.";
        // 
        // btnConfirm
        // 
        btnConfirm.DialogResult = DialogResult.Yes;
        btnConfirm.FlatStyle = FlatStyle.System;
        btnConfirm.Font = new Font("Segoe UI", 9F);
        btnConfirm.Location = new Point(345, 150);
        btnConfirm.Margin = new Padding(4);
        btnConfirm.Name = "btnConfirm";
        btnConfirm.Size = new Size(145, 42);
        btnConfirm.TabIndex = 2;
        btnConfirm.Text = "Discard Changes";
        btnConfirm.UseVisualStyleBackColor = true;
        btnConfirm.Click += btnConfirm_Click;
        // 
        // btnCancel
        // 
        btnCancel.DialogResult = DialogResult.No;
        btnCancel.FlatStyle = FlatStyle.System;
        btnCancel.Font = new Font("Segoe UI", 9F);
        btnCancel.Location = new Point(210, 150);
        btnCancel.Margin = new Padding(4);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(125, 42);
        btnCancel.TabIndex = 3;
        btnCancel.Text = "Keep Editing";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // ConfirmationDialog
        // 
        AcceptButton = btnConfirm;
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        CancelButton = btnCancel;
        ClientSize = new Size(520, 220);
        Controls.Add(btnCancel);
        Controls.Add(btnConfirm);
        Controls.Add(lblMessage);
        Controls.Add(lblHeading);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "ConfirmationDialog";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Edit Order";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblHeading;
    private System.Windows.Forms.Label lblMessage;
    private System.Windows.Forms.Button btnConfirm;
    private System.Windows.Forms.Button btnCancel;
}

