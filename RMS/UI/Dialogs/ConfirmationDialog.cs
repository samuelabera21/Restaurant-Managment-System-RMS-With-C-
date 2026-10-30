using System.Drawing;
using System.Windows.Forms;
using RMS.Common;

namespace RMS.UI.Dialogs;

/// <summary>
/// Reusable modal confirmation dialog matching the Stitch/Figma designs
/// (for discarding unsaved orders and confirming order cancellations).
/// </summary>
public class ConfirmationDialog : Form
{
    public ConfirmationDialog(string title, string heading, string message, string confirmButtonText, bool isDanger = true)
    {
        Text = title;
        Width = 440;
        Height = 240;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        StartPosition = FormStartPosition.CenterParent;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        BackColor = Color.White;

        var pnlHeader = new Panel
        {
            Dock = DockStyle.Top,
            Height = 44,
            BackColor = Color.White,
            Padding = new Padding(20, 12, 20, 0)
        };

        var lblDialogTitle = new Label
        {
            Text = title,
            Font = AppTheme.SmallBold,
            ForeColor = AppTheme.TextSecondary,
            AutoSize = true,
            Location = new Point(20, 14)
        };
        pnlHeader.Controls.Add(lblDialogTitle);

        var pnlBody = new Panel
        {
            Dock = DockStyle.Fill,
            Padding = new Padding(24, 8, 24, 16),
            BackColor = Color.White
        };

        var lblHeading = new Label
        {
            Text = heading,
            Font = AppTheme.HeaderMedium,
            ForeColor = AppTheme.TextPrimary,
            AutoSize = true,
            Location = new Point(24, 10)
        };

        var lblMessage = new Label
        {
            Text = message,
            Font = AppTheme.BodyRegular,
            ForeColor = AppTheme.TextSecondary,
            Size = new Size(380, 50),
            Location = new Point(24, 46)
        };

        var pnlButtons = new Panel
        {
            Dock = DockStyle.Bottom,
            Height = 60,
            BackColor = AppTheme.ContentBackground,
            Padding = new Padding(0, 0, 20, 0)
        };

        var btnConfirm = new Button
        {
            Text = confirmButtonText,
            Font = AppTheme.BodyBold,
            ForeColor = SystemColors.ControlText,
            BackColor = isDanger ? AppTheme.PrimaryButton : AppTheme.PrimaryButton,
            FlatStyle = FlatStyle.System,
            Size = new Size(130, 36),
            Anchor = AnchorStyles.Top | AnchorStyles.Right,
            Location = new Point(pnlButtons.Width - 150, 12),
            Cursor = Cursors.Hand,
            DialogResult = DialogResult.Yes
        };
        btnConfirm.FlatAppearance.BorderSize = 0;

        var btnCancel = new Button
        {
            Text = "Keep Editing",
            Font = AppTheme.BodyRegular,
            ForeColor = AppTheme.TextPrimary,
            BackColor = Color.White,
            FlatStyle = FlatStyle.System,
            Size = new Size(110, 36),
            Anchor = AnchorStyles.Top | AnchorStyles.Right,
            Location = new Point(pnlButtons.Width - 270, 12),
            Cursor = Cursors.Hand,
            DialogResult = DialogResult.No
        };
        btnCancel.FlatAppearance.BorderColor = AppTheme.CardBorder;

        pnlButtons.Controls.Add(btnConfirm);
        pnlButtons.Controls.Add(btnCancel);

        pnlBody.Controls.Add(lblHeading);
        pnlBody.Controls.Add(lblMessage);

        Controls.Add(pnlBody);
        Controls.Add(pnlButtons);
        Controls.Add(pnlHeader);

        AcceptButton = btnConfirm;
        CancelButton = btnCancel;
    }

    public static bool Confirm(IWin32Window owner, string title, string heading, string message, string confirmText = "Discard Order", bool isDanger = true)
    {
        using var dlg = new ConfirmationDialog(title, heading, message, confirmText, isDanger);
        return dlg.ShowDialog(owner) == DialogResult.Yes;
    }
}
