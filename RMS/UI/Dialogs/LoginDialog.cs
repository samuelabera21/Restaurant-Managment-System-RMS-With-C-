using System;
using System.Drawing;
using System.Windows.Forms;
using RMS.Models;
using RMS.Services;

namespace RMS.UI.Dialogs;

// Login dialog: authenticates staff member by numeric ID
public partial class LoginDialog : Form
{
    private readonly RestaurantStore _store = RestaurantStore.Instance;

    public StaffMember? AuthenticatedStaff { get; private set; }

    public LoginDialog()
    {
        InitializeComponent();
    }

    // Validate numeric Staff ID and authenticate with store
    private void btnLogin_Click(object? sender, EventArgs e)
    {
        string input = txtStaffId.Text.Trim();

        if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int staffId))
        {
            ShowError("Please enter a valid numeric Staff ID.");
            return;
        }

        var staff = _store.AuthenticateStaff(staffId);
        if (staff == null)
        //
        {
            ShowError("Invalid Staff ID. Account not found or inactive.");
            return;
        }

        AuthenticatedStaff = staff;
        _store.CurrentUser = staff;
        DialogResult = DialogResult.OK;
        Close();
    }

    // Cancel login dialog
    private void btnCancel_Click(object? sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    // Display error label and highlight input
    private void ShowError(string message)
    {
        lblError.Text = message;
        lblError.Visible = true;
        txtStaffId.Focus();
        txtStaffId.SelectAll();
    }

    // Clear error message when user starts typing again
    private void txtStaffId_TextChanged(object? sender, EventArgs e)
    {
        if (lblError.Visible) lblError.Visible = false;
    }
}
