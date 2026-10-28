using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using RMS.Common;
using RMS.Models;
using RMS.Services;
using MenuItem = RMS.Models.MenuItem;

namespace RMS.UI.Views;

/// <summary>
/// Menu catalog screen view allowing waiters to browse available foods and drinks,
/// search by item name, and filter by availability.
/// </summary>
public partial class MenuView : BaseView
{
    private readonly RestaurantStore _store = RestaurantStore.Instance;

    public MenuView()
    {
        InitializeComponent();

        if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
        {
            return;
        }

        cboAvailability.SelectedIndex = 0; // Default to "All Items"
        _store.OnMenuChanged += () =>
        {
            if (IsDisposed || Disposing) return;
            if (InvokeRequired)
            {
                Invoke(new Action(ApplyFilters));
            }
            else
            {
                ApplyFilters();
            }
        };

        ApplyFilters();
    }

    public override void OnNavigatedTo(object? parameter = null)
    {
        base.OnNavigatedTo(parameter);
        ApplyFilters();
    }

    private void ApplyFilters()
    {
        if (IsDisposed || Disposing || dgvMenu.IsDisposed) return;

        var allItems = _store.MenuItems;
        var query = txtSearch.Text.Trim();
        var selectedFilter = cboAvailability.SelectedItem?.ToString() ?? "All Items";

        // Filter availability
        var filtered = allItems.AsEnumerable();
        if (selectedFilter == "Available")
        {
            filtered = filtered.Where(i => i.IsAvailable);
        }
        else if (selectedFilter == "Unavailable")
        {
            filtered = filtered.Where(i => !i.IsAvailable);
        }

        // Filter search text
        if (!string.IsNullOrEmpty(query))
        {
            filtered = filtered.Where(i =>
                i.Name.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                i.Category.Contains(query, StringComparison.OrdinalIgnoreCase));
        }

        var results = filtered.ToList();

        // Update count summary label
        int availableCount = allItems.Count(i => i.IsAvailable);
        lblCountSummary.Text = $"Showing {results.Count} of {allItems.Count} items ({availableCount} available)";

        // Populate DataGridView
        dgvMenu.Rows.Clear();
        foreach (var item in results)
        {
            int rowIndex = dgvMenu.Rows.Add(
                item.Name,
                item.Category,
                $"{item.Price:N0} ETB",
                item.IsAvailable ? "Available" : "Unavailable",
                "View Details"
            );

            var row = dgvMenu.Rows[rowIndex];
            row.Tag = item;

            // Clean status styling
            var availCell = row.Cells[colAvailability.Index];
            availCell.Style.ForeColor = item.IsAvailable
                ? Color.FromArgb(16, 149, 93)   // Green
                : Color.FromArgb(194, 65, 12);  // Dark orange
            availCell.Style.Font = AppTheme.BodyBold;
        }

        dgvMenu.ClearSelection();
    }

    // =========================================================================
    // Event Handlers (Visual Studio Designer)
    // =========================================================================

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        ApplyFilters();
    }

    private void cboAvailability_SelectedIndexChanged(object sender, EventArgs e)
    {
        ApplyFilters();
    }

    private void btnClearSearch_Click(object sender, EventArgs e)
    {
        txtSearch.Text = string.Empty;
        cboAvailability.SelectedIndex = 0;
        txtSearch.Focus();
    }

    private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        if (e.ColumnIndex == colAction.Index && dgvMenu.Rows[e.RowIndex].Tag is MenuItem item)
        {
            string status = item.IsAvailable ? "Available" : "Currently Unavailable";
            MessageBox.Show(
                $"Menu Item: {item.Name}\nCategory: {item.Category}\nPrice: {item.Price:N0} ETB\nStatus: {status}",
                $"Item Details — {item.Name}",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
