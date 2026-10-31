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

// Menu catalog view for browsing foods and drinks
public partial class MenuView : BaseView
{
    private readonly RestaurantStore _store = RestaurantStore.Instance;

    public MenuView()
    {
        InitializeComponent();

        if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

        dgvMenu.CellDoubleClick += dgvMenu_CellDoubleClick;
        cboAvailability.SelectedIndex = 0;

        // Auto reload when menu items are updated
        _store.OnMenuChanged += () =>
        {
            if (!IsDisposed && !Disposing)
            {
                if (InvokeRequired) Invoke(ApplyFilters);
                else ApplyFilters();
            }
        };

        ApplyFilters();
    }

    // Called when navigating to this view
    public override void OnNavigatedTo(object? parameter = null)
    {
        base.OnNavigatedTo(parameter);
        ApplyFilters();
    }

    // Filter and populate menu items in the table
    private void ApplyFilters()
    {
        if (IsDisposed || Disposing || dgvMenu.IsDisposed) return;

        var query = txtSearch.Text.Trim();
        var filter = cboAvailability.SelectedItem?.ToString() ?? "All Items";

        var items = _store.MenuItems.Where(i =>
            (filter == "All Items" || (filter == "Available" ? i.IsAvailable : !i.IsAvailable)) &&
            (string.IsNullOrEmpty(query) || 
             i.Name.Contains(query, StringComparison.OrdinalIgnoreCase) || 
             i.Category.Contains(query, StringComparison.OrdinalIgnoreCase))
        );

        dgvMenu.Rows.Clear();
        foreach (var item in items)
        {
            int row = dgvMenu.Rows.Add(item.Name, item.Category, $"{item.Price:N0} ETB", item.IsAvailable ? "Available" : "Unavailable", "View");
            dgvMenu.Rows[row].Tag = item;
        }

        dgvMenu.ClearSelection();
    }

    // Live search text change event
    private void txtSearch_TextChanged(object sender, EventArgs e) => ApplyFilters();

    // Availability dropdown change event
    private void cboAvailability_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();

    // Reset search box and filter
    private void btnClearSearch_Click(object sender, EventArgs e)
    {
        txtSearch.Clear();
        cboAvailability.SelectedIndex = 0;
        txtSearch.Focus();
    }

    // View button clicked in table row
    private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && e.ColumnIndex == colAction.Index && dgvMenu.Rows[e.RowIndex].Tag is MenuItem item)
        {
            ShowItemDetails(item);
        }
    }

    // Double click row to view details
    private void dgvMenu_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && dgvMenu.Rows[e.RowIndex].Tag is MenuItem item)
        {
            ShowItemDetails(item);
        }
    }

    // Show popup dialog with item info
    private void ShowItemDetails(MenuItem item)
    {
        string status = item.IsAvailable ? "Available" : "Currently Unavailable";
        MessageBox.Show($"Menu Item: {item.Name}\nCategory: {item.Category}\nPrice: {item.Price:N0} ETB\nStatus: {status}", 
            $"Item Details — {item.Name}", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
