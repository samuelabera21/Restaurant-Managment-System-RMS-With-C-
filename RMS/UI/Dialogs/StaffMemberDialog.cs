using System;
using System.Drawing;
using System.Windows.Forms;
using RMS.Models;
using RMS.Services;

namespace RMS.UI.Dialogs;

// Dialog for adding or editing a waiter record
public partial class StaffMemberDialog : Form
{
    private readonly RestaurantStore _store = RestaurantStore.Instance;
    private readonly StaffMember? _existingStaff;

    public StaffMember? ResultStaff { get; private set; }

    // Parameterless constructor for Visual Studio Designer
    public StaffMemberDialog() : this(null) { }

    // Runtime constructor with optional staff to edit
    public StaffMemberDialog(StaffMember? staffToEdit)
    {
        InitializeComponent();
        _existingStaff = staffToEdit;

        if (_existingStaff != null)
        {
            lblDialogTitle.Text = "Edit Waiter";
            txtStaffId.Text = _existingStaff.Id.ToString();
            txtFullName.Text = _existingStaff.FullName;
            cboShift.SelectedItem = _existingStaff.Shift;
        }
        else
        {
            lblDialogTitle.Text = "Add New Waiter";
            txtStaffId.Text = _store.PeekNextStaffId().ToString();
            cboShift.SelectedIndex = 0;
        }
    }

    // Validate inputs and save waiter details
    private void btnSave_Click(object? sender, EventArgs e)
    {
        string name = txtFullName.Text.Trim();
        if (string.IsNullOrWhiteSpace(name))
        {
            lblError.Text = "Please enter waiter's full name.";
            lblError.Visible = true;
            txtFullName.BackColor = Color.FromArgb(254, 242, 242);
            txtFullName.Focus();
            return;
        }

        string shift = cboShift.SelectedItem?.ToString() ?? "Day Shift";

        if (_existingStaff != null)
        {
            _existingStaff.FullName = name;
            _existingStaff.Shift = shift;
            ResultStaff = _existingStaff;
        }
        else
        {
            ResultStaff = new StaffMember(_store.PeekNextStaffId(), name, "Waiter", shift, true);
        }

        DialogResult = DialogResult.OK;
        Close();
    }

    // Reset error styling on name input changed
    private void txtFullName_TextChanged(object? sender, EventArgs e)
    {
        txtFullName.BackColor = Color.White;
        if (lblError.Visible) lblError.Visible = false;
    }
}
