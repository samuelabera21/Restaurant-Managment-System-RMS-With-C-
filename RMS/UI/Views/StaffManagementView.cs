using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using RMS.Common;
using RMS.Models;
using RMS.Services;
using RMS.UI.Dialogs;
using RMS.UI.Navigation;

namespace RMS.UI.Views;

// Staff management screen: manage waiters, shifts, and active status
public partial class StaffManagementView : BaseView, INavigationAware
{
    private readonly RestaurantStore _store = RestaurantStore.Instance;

    public StaffManagementView() : base()
    {
        InitializeComponent();

        if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

        _store.OnStaffChanged += RefreshStaffGrid;
    }

    // Reload grid when navigating to this view
    public override void OnNavigatedTo(object? parameter = null)
    {
        base.OnNavigatedTo(parameter);
        RefreshStaffGrid();
    }

    // Populate DataGridView with filtered staff members
    public void RefreshStaffGrid()
    {
        if (DesignMode || Disposing || IsDisposed || dgvStaff.IsDisposed) return;

        string query = txtSearch.Text.Trim();
        var staffList = _store.StaffMembers
            .Where(s => string.IsNullOrEmpty(query) ||
                        s.FullName.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                        s.Id.ToString().Contains(query) ||
                        s.Shift.Contains(query, StringComparison.OrdinalIgnoreCase))
            .OrderBy(s => s.Id);

        dgvStaff.Rows.Clear();
        foreach (var staff in staffList)
        {
            int row = dgvStaff.Rows.Add(staff.Id.ToString(), staff.FullName, staff.Role, staff.Shift, staff.IsActive ? "Active" : "Inactive");
            dgvStaff.Rows[row].Tag = staff;
        }

        UpdateActionButtons();
    }

    // Helper to get currently selected staff member
    private StaffMember? GetSelectedStaff() => dgvStaff.CurrentRow?.Tag as StaffMember;

    // Enable or disable edit buttons (Manager record is protected)
    private void UpdateActionButtons()
    {
        var staff = GetSelectedStaff();
        bool isEditable = staff != null && staff.Role != "Manager";
        btnEditStaff.Enabled = btnToggleStatus.Enabled = isEditable;
    }

    // Grid selection change event
    private void dgvStaff_SelectionChanged(object sender, EventArgs e)
    {
        UpdateActionButtons();
    }

    // Double click row to edit
    private void dgvStaff_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0) EditSelectedStaff();
    }

    // Open dialog to register new waiter
    private void btnAddStaff_Click(object sender, EventArgs e)
    {
        using var dialog = new StaffMemberDialog();
        if (dialog.ShowDialog(FindForm()) == DialogResult.OK && dialog.ResultStaff != null)
        {
            _store.AddStaffMember(dialog.ResultStaff);
            RefreshStaffGrid();
        }
    }

    // Edit staff button click
    private void btnEditStaff_Click(object sender, EventArgs e)
    {
        EditSelectedStaff();
    }

    // Open dialog to edit selected waiter
    private void EditSelectedStaff()
    {
        var staff = GetSelectedStaff();
        if (staff == null || staff.Role == "Manager") return;

        using var dialog = new StaffMemberDialog(staff);
        if (dialog.ShowDialog(FindForm()) == DialogResult.OK && dialog.ResultStaff != null)
        {
            _store.UpdateStaffMember(dialog.ResultStaff);
            RefreshStaffGrid();
        }
    }

    // Toggle active status for selected waiter
    private void btnToggleStatus_Click(object sender, EventArgs e)
    {
        var staff = GetSelectedStaff();
        if (staff == null || staff.Role == "Manager") return;

        _store.SetStaffStatus(staff.Id, !staff.IsActive);
        RefreshStaffGrid();
    }

    // Live search input change
    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        RefreshStaffGrid();
    }

    // Reset search box
    private void btnClearSearch_Click(object sender, EventArgs e)
    {
        txtSearch.Clear();
        txtSearch.Focus();
        RefreshStaffGrid();
    }
}
