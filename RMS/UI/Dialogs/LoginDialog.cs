using System;
using System.Drawing;
using System.Windows.Forms;
using RMS.Models;
using RMS.Services;

namespace RMS.UI.Dialogs;

/// <summary>
/// Professional, lightweight login dialog prompting for Staff ID.
/// Automatically detects Manager vs. Waiter roles based on the entered ID.
/// </summary>
public partial class LoginDialog : Form
{
    private readonly RestaurantStore _store = RestaurantStore.Instance;

    public StaffMember? AuthenticatedStaff { get; private set; }

    public LoginDialog()
    {
        InitializeComponent();
    }

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
        {
            ShowError("Invalid Staff ID. Account not found or inactive.");
            return;
        }

        AuthenticatedStaff = staff;
        _store.CurrentUser = staff;
        DialogResult = DialogResult.OK;
        Close();
    }

    private void ShowError(string message)
    {
        lblError.Text = message;
        lblError.Visible = true;
        txtStaffId.BackColor = Color.FromArgb(254, 242, 242);
        txtStaffId.Focus();
        txtStaffId.SelectAll();
    }

    private void txtStaffId_TextChanged(object? sender, EventArgs e)
    {
        txtStaffId.BackColor = Color.White;
        if (lblError.Visible)
        {
            lblError.Visible = false;
        }
    }
}
