namespace RMS.UI.Dialogs;

partial class ChangeStatusDialog
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
        lblDetails = new Label();
        pnlTransition = new Panel();
        lblNextStatus = new Label();
        lblArrow = new Label();
        lblCurrentStatus = new Label();
        btnCancel = new Button();
        btnConfirm = new Button();
        pnlTransition.SuspendLayout();
        SuspendLayout();
        // 
        // lblHeading
        // 
        lblHeading.AutoSize = true;
        lblHeading.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblHeading.ForeColor = Color.FromArgb(15, 23, 42);
        lblHeading.Location = new Point(25, 52);
        lblHeading.Margin = new Padding(4, 0, 4, 0);
        lblHeading.Name = "lblHeading";
        lblHeading.Size = new Size(362, 32);
        lblHeading.TabIndex = 1;
        lblHeading.Text = "Advance Status for Order 102?";
        // 
        // lblDetails
        // 
        lblDetails.AutoSize = true;
        lblDetails.Font = new Font("Segoe UI", 9.5F);
        lblDetails.ForeColor = Color.FromArgb(71, 85, 105);
        lblDetails.Location = new Point(28, 98);
        lblDetails.Margin = new Padding(4, 0, 4, 0);
        lblDetails.Name = "lblDetails";
        lblDetails.Size = new Size(371, 25);
        lblDetails.TabIndex = 2;
        lblDetails.Text = "Customer: butu  •  Table 4  •  Total: 180 ETB";
        // 
        // pnlTransition
        // 
        pnlTransition.BackColor = Color.FromArgb(248, 250, 252);
        pnlTransition.BorderStyle = BorderStyle.FixedSingle;
        pnlTransition.Controls.Add(lblNextStatus);
        pnlTransition.Controls.Add(lblArrow);
        pnlTransition.Controls.Add(lblCurrentStatus);
        pnlTransition.Location = new Point(30, 142);
        pnlTransition.Margin = new Padding(4, 4, 4, 4);
        pnlTransition.Name = "pnlTransition";
        pnlTransition.Size = new Size(537, 74);
        pnlTransition.TabIndex = 3;
        // 
        // lblNextStatus
        // 
        lblNextStatus.BackColor = Color.FromArgb(241, 245, 249);
        lblNextStatus.BorderStyle = BorderStyle.FixedSingle;
        lblNextStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        lblNextStatus.ForeColor = Color.FromArgb(15, 23, 42);
        lblNextStatus.Location = new Point(312, 18);
        lblNextStatus.Margin = new Padding(4, 0, 4, 0);
        lblNextStatus.Name = "lblNextStatus";
        lblNextStatus.Size = new Size(174, 40);
        lblNextStatus.TabIndex = 2;
        lblNextStatus.Text = "Preparing";
        lblNextStatus.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblArrow
        // 
        lblArrow.AutoSize = true;
        lblArrow.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblArrow.ForeColor = Color.FromArgb(71, 85, 105);
        lblArrow.Location = new Point(238, 19);
        lblArrow.Margin = new Padding(4, 0, 4, 0);
        lblArrow.Name = "lblArrow";
        lblArrow.Size = new Size(35, 32);
        lblArrow.TabIndex = 1;
        lblArrow.Text = "→";
        // 
        // lblCurrentStatus
        // 
        lblCurrentStatus.BackColor = Color.FromArgb(241, 245, 249);
        lblCurrentStatus.BorderStyle = BorderStyle.FixedSingle;
        lblCurrentStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        lblCurrentStatus.ForeColor = Color.FromArgb(15, 23, 42);
        lblCurrentStatus.Location = new Point(45, 18);
        lblCurrentStatus.Margin = new Padding(4, 0, 4, 0);
        lblCurrentStatus.Name = "lblCurrentStatus";
        lblCurrentStatus.Size = new Size(162, 40);
        lblCurrentStatus.TabIndex = 0;
        lblCurrentStatus.Text = "Pending";
        lblCurrentStatus.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btnCancel
        // 
        btnCancel.DialogResult = DialogResult.Cancel;
        btnCancel.FlatStyle = FlatStyle.System;
        btnCancel.Font = new Font("Segoe UI", 9F);
        btnCancel.Location = new Point(185, 255);
        btnCancel.Margin = new Padding(4, 4, 4, 4);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(119, 42);
        btnCancel.TabIndex = 4;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // btnConfirm
        // 
        btnConfirm.FlatStyle = FlatStyle.System;
        btnConfirm.Font = new Font("Segoe UI", 9F);
        btnConfirm.Location = new Point(343, 255);
        btnConfirm.Margin = new Padding(4, 4, 4, 4);
        btnConfirm.Name = "btnConfirm";
        btnConfirm.Size = new Size(195, 42);
        btnConfirm.TabIndex = 5;
        btnConfirm.Text = "Advance to Preparing";
        btnConfirm.UseVisualStyleBackColor = true;
        btnConfirm.Click += btnConfirm_Click;
        // 
        // ChangeStatusDialog
        // 
        AcceptButton = btnConfirm;
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = btnCancel;
        ClientSize = new Size(600, 310);
        Controls.Add(btnConfirm);
        Controls.Add(btnCancel);
        Controls.Add(pnlTransition);
        Controls.Add(lblDetails);
        Controls.Add(lblHeading);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4, 4, 4, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "ChangeStatusDialog";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Change Order Status";
        pnlTransition.ResumeLayout(false);
        pnlTransition.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private System.Windows.Forms.Label lblHeading;
    private System.Windows.Forms.Label lblDetails;
    private System.Windows.Forms.Panel pnlTransition;
    private System.Windows.Forms.Label lblCurrentStatus;
    private System.Windows.Forms.Label lblArrow;
    private System.Windows.Forms.Label lblNextStatus;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnConfirm;
}

