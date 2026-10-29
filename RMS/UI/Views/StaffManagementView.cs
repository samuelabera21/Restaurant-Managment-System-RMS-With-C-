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

/// <summary>
/// Staff & Waiter Management screen view allowing the restaurant manager
/// to register new waiters, update working shifts, and toggle active status.
/// </summary>
public partial class StaffManagementView : BaseView, INavigationAware
{
    private readonly RestaurantStore _store = RestaurantStore.Instance;

    public StaffManagementView() : base()
    {
        InitializeComponent();

        if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
        {
            return;
        }

        dgvStaff.CellDoubleClick += dgvStaff_CellDoubleClick;
        _store.OnStaffChanged += RefreshStaffGrid;
    }

    public override void OnNavigatedTo(object? parameter = null)
    {
        base.OnNavigatedTo(parameter);
        RefreshStaffGrid();
    }

    public void RefreshStaffGrid()
    {
        if (DesignMode || Disposing || IsDisposed || dgvStaff.IsDisposed) return;

        string query = txtSearch.Text.Trim().ToLowerInvariant();
        var allStaff = _store.StaffMembers;

        var filtered = allStaff.AsEnumerable();
        if (!string.IsNullOrEmpty(query))
        {
            filtered = filtered.Where(s =>
                s.FullName.ToLowerInvariant().Contains(query) ||
                s.Id.ToString().Contains(query) ||
                s.Role.ToLowerInvariant().Contains(query) ||
                s.Shift.ToLowerInvariant().Contains(query));
        }

        var results = filtered.OrderBy(s => s.Id).ToList();

        lblSummary.Text = $"Showing {results.Count} of {allStaff.Count} registered staff members";

        dgvStaff.Rows.Clear();
        foreach (var staff in results)
        {
            int rowIndex = dgvStaff.Rows.Add(
                $"#{staff.Id}",
                staff.FullName,
                staff.Role,
                staff.Shift,
                staff.IsActive ? "Active" : "Inactive"
            );

            var row = dgvStaff.Rows[rowIndex];
            row.Tag = staff;
        }

        UpdateActionButtons();
    }

    private StaffMember? GetSelectedStaff()
    {
        if (dgvStaff.CurrentRow?.Tag is StaffMember staff)
        {
            return staff;
        }
        return null;
    }

    private void UpdateActionButtons()
    {
        var staff = GetSelectedStaff();
        bool hasSelection = staff != null;
        bool isEditable = hasSelection && staff?.Role != "Manager"; // Protect primary manager record

        btnEditStaff.Enabled = isEditable;
        btnToggleStatus.Enabled = isEditable;
    }

    private void dgvStaff_SelectionChanged(object? sender, EventArgs e)
    {
        UpdateActionButtons();
    }

    private void dgvStaff_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            EditSelectedStaff();
        }
    }

    private void btnAddStaff_Click(object? sender, EventArgs e)
    {
        using var dialog = new StaffMemberDialog();
        if (dialog.ShowDialog(FindForm()) == DialogResult.OK && dialog.ResultStaff != null)
        {
            _store.AddStaffMember(dialog.ResultStaff);
            RefreshStaffGrid();
        }
    }

    private void btnEditStaff_Click(object? sender, EventArgs e)
    {
        EditSelectedStaff();
    }

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

    private void btnToggleStatus_Click(object? sender, EventArgs e)
    {
        var staff = GetSelectedStaff();
        if (staff == null || staff.Role == "Manager") return;

        _store.SetStaffStatus(staff.Id, !staff.IsActive);
        RefreshStaffGrid();
    }

    private void txtSearch_TextChanged(object? sender, EventArgs e)
    {
        RefreshStaffGrid();
    }

    private void btnClearSearch_Click(object? sender, EventArgs e)
    {
        txtSearch.Text = string.Empty;
        txtSearch.Focus();
        RefreshStaffGrid();
    }
}
