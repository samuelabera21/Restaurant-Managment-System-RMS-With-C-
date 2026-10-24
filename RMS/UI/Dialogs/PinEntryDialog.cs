using System.Drawing;
using System.Windows.Forms;
using RMS.Common;

namespace RMS.UI.Dialogs;

/// <summary>
/// Modal dialog for entering the Admin PIN to access Menu Management.
/// </summary>
public class PinEntryDialog : Form
{
    private const string DefaultAdminPin = "1234";

    private readonly TextBox _txtPin;
    private readonly Label _lblError;
    private readonly Button _btnConfirm;
    private readonly Button _btnCancel;

    public bool IsAuthenticated { get; private set; }

    public PinEntryDialog()
    {
        Text = "Admin Verification";
        Width = 380;
        Height = 260;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        StartPosition = FormStartPosition.CenterParent;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        BackColor = Color.White;

        var pnlHeader = new Panel
        {
            Dock = DockStyle.Top,
            Height = 70,
            BackColor = AppTheme.SidebarBackground,
            Padding = new Padding(20, 15, 20, 10)
        };

        var lblTitle = new Label
        {
            Text = "Menu Administration",
            Font = AppTheme.HeaderMedium,
            ForeColor = Color.White,
            AutoSize = true,
            Location = new Point(20, 14)
        };

        var lblSubtitle = new Label
        {
            Text = "Enter PIN to access menu management",
            Font = AppTheme.SmallRegular,
            ForeColor = AppTheme.SidebarMutedText,
            AutoSize = true,
            Location = new Point(20, 40)
        };

        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Controls.Add(lblSubtitle);

        var pnlBody = new Panel
        {
            Dock = DockStyle.Fill,
            Padding = new Padding(30, 20, 30, 20),
            BackColor = Color.White
        };

        var lblPrompt = new Label
        {
            Text = "Security PIN (Default: 1234)",
            Font = AppTheme.BodyBold,
            ForeColor = AppTheme.TextPrimary,
            AutoSize = true,
            Location = new Point(30, 20)
        };

        _txtPin = new TextBox
        {
            Font = new Font("Segoe UI", 14f, FontStyle.Bold),
            Location = new Point(30, 46),
            Width = 300,
            PasswordChar = '•',
            MaxLength = 8,
            TextAlign = HorizontalAlignment.Center
        };
        _txtPin.KeyDown += (s, e) =>
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateAndSubmit();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        };

        _lblError = new Label
        {
            Text = "Incorrect PIN. Please try again.",
            Font = AppTheme.SmallBold,
            ForeColor = AppTheme.DangerButton,
            AutoSize = true,
            Location = new Point(30, 84),
            Visible = false
        };

        _btnConfirm = new Button
        {
            Text = "Unlock",
            Font = AppTheme.BodyBold,
            ForeColor = Color.White,
            BackColor = AppTheme.PrimaryButton,
            FlatStyle = FlatStyle.Flat,
            Size = new Size(110, 36),
            Location = new Point(110, 150),
            Cursor = Cursors.Hand
        };
        _btnConfirm.FlatAppearance.BorderSize = 0;
        _btnConfirm.Click += (s, e) => ValidateAndSubmit();

        _btnCancel = new Button
        {
            Text = "Cancel",
            Font = AppTheme.BodyRegular,
            ForeColor = AppTheme.TextPrimary,
            BackColor = Color.FromArgb(243, 244, 246),
            FlatStyle = FlatStyle.Flat,
            Size = new Size(90, 36),
            Location = new Point(230, 150),
            Cursor = Cursors.Hand
        };
        _btnCancel.FlatAppearance.BorderColor = AppTheme.CardBorder;
        _btnCancel.Click += (s, e) =>
        {
            DialogResult = DialogResult.Cancel;
            Close();
        };

        var pnlBottom = new Panel
        {
            Dock = DockStyle.Bottom,
            Height = 60,
            BackColor = AppTheme.ContentBackground
        };
        pnlBottom.Controls.Add(_btnConfirm);
        pnlBottom.Controls.Add(_btnCancel);

        pnlBody.Controls.Add(lblPrompt);
        pnlBody.Controls.Add(_txtPin);
        pnlBody.Controls.Add(_lblError);

        Controls.Add(pnlBody);
        Controls.Add(pnlBottom);
        Controls.Add(pnlHeader);

        AcceptButton = _btnConfirm;
        CancelButton = _btnCancel;

        Shown += (s, e) => _txtPin.Focus();
    }

    private void ValidateAndSubmit()
    {
        if (_txtPin.Text == DefaultAdminPin)
        {
            IsAuthenticated = true;
            DialogResult = DialogResult.OK;
            Close();
        }
        else
        {
            _lblError.Visible = true;
            _txtPin.SelectAll();
            _txtPin.Focus();
        }
    }
}
