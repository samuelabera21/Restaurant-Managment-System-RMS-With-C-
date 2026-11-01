using System.Drawing;
using System.Windows.Forms;

namespace RMS.UI.Dialogs;

// Reusable modal confirmation dialog (e.g. discard changes, cancel order)
public partial class ConfirmationDialog : Form
{
    // Parameterless constructor for Visual Studio Designer
    public ConfirmationDialog()
    {
        InitializeComponent();
    }

    // Runtime constructor initializing text and button labels
    public ConfirmationDialog(string title, string heading, string message, string confirmButtonText, bool isDanger = true) : this()
    {
        Text = title;
        lblHeading.Text = heading;
        lblMessage.Text = message;
        btnConfirm.Text = confirmButtonText;
    }

    // Confirm action (Yes)
    private void btnConfirm_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Yes;
        Close();
    }

    // Cancel action (No)
    private void btnCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.No;
        Close();
    }

    // Static helper to show confirmation modal
    public static bool Confirm(IWin32Window owner, string title, string heading, string message, string confirmText = "Discard Order", bool isDanger = true)
    {
        using var dlg = new ConfirmationDialog(title, heading, message, confirmText, isDanger);
        return dlg.ShowDialog(owner) == DialogResult.Yes;
    }
}
