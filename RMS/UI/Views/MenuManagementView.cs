using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using RMS.Common;
using RMS.Models;
using RMS.Services;
using RMS.UI.Dialogs;
using RMS.UI.Navigation;
using MenuItem = RMS.Models.MenuItem;

namespace RMS.UI.Views;

// Menu management screen: add, edit, and toggle food and drink availability
public partial class MenuManagementView : BaseView, INavigationAware
{
    private readonly RestaurantStore _store = RestaurantStore.Instance;

    public MenuManagementView() : base()
    {
        InitializeComponent();

        if (!DesignMode)
        {
            cboAvailabilityFilter.SelectedIndex = 0;
        }
    }

    // Reload categories and items on navigation
    public override void OnNavigatedTo(object? parameter = null)
    {
        base.OnNavigatedTo(parameter);
        if (DesignMode) return;

        PopulateCategoryFilter();
        RefreshGrid();
    }

    // Populate category dropdown from unique menu categories
    private void PopulateCategoryFilter()
    {
        string? current = cboCategoryFilter.SelectedItem?.ToString();
        cboCategoryFilter.Items.Clear();
        cboCategoryFilter.Items.Add("All Categories");

        var categories = _store.MenuItems.Select(m => m.Category).Where(c => !string.IsNullOrWhiteSpace(c)).Distinct().OrderBy(c => c);
        foreach (var category in categories) cboCategoryFilter.Items.Add(category);

        cboCategoryFilter.SelectedIndex = (current != null && cboCategoryFilter.Items.Contains(current))
            ? cboCategoryFilter.Items.IndexOf(current)
            : 0;
    }

    // Populate DataGridView with filtered menu items
    public void RefreshGrid()
    {
        if (DesignMode || Disposing || IsDisposed || dgvMenuItems.IsDisposed) return;

        string query = txtSearch.Text.Trim();
        string category = cboCategoryFilter.SelectedItem?.ToString() ?? "All Categories";
        int availIndex = cboAvailabilityFilter.SelectedIndex;

        var items = _store.MenuItems.Where(m =>
            (string.IsNullOrEmpty(query) || 
             m.Name.Contains(query, StringComparison.OrdinalIgnoreCase) || 
             m.Category.Contains(query, StringComparison.OrdinalIgnoreCase) ||
             m.Id.ToString().Contains(query)) &&
            (category == "All Categories" || string.Equals(m.Category, category, StringComparison.OrdinalIgnoreCase)) &&
            (availIndex == 0 || (availIndex == 1 ? m.IsAvailable : !m.IsAvailable))
        ).OrderBy(m => m.Id);

        dgvMenuItems.Rows.Clear();
        foreach (var item in items)
        {
            int row = dgvMenuItems.Rows.Add(item.Id.ToString(), item.Name, item.Category, $"{item.Price:N0} ETB", item.IsAvailable ? "Available" : "Unavailable");
            dgvMenuItems.Rows[row].Tag = item;
        }

        UpdateActionButtons();
    }

    // Helper to get currently selected menu item
    private MenuItem? GetSelectedMenuItem() => dgvMenuItems.CurrentRow?.Tag as MenuItem;

    // Enable/disable buttons based on item selection
    private void UpdateActionButtons()
    {
        bool hasSelection = GetSelectedMenuItem() != null;
        btnEditItem.Enabled = btnToggleStatus.Enabled = hasSelection;
    }

    // Grid selection change event
    private void dgvMenuItems_SelectionChanged(object sender, EventArgs e)
    {
        UpdateActionButtons();
    }

    // Double click row to edit item
    private void dgvMenuItems_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0) EditSelectedItem();
    }

    // Open dialog to add new menu item
    private void btnAddItem_Click(object sender, EventArgs e)
    {
        using var dialog = new MenuItemDialog();
        if (dialog.ShowDialog(FindForm()) == DialogResult.OK && dialog.ResultItem != null)
        {
            _store.AddMenuItem(dialog.ResultItem);
            PopulateCategoryFilter();
            RefreshGrid();
        }
    }

    // Edit item button click
    private void btnEditItem_Click(object sender, EventArgs e)
    {
        EditSelectedItem();
    }

    // Open dialog to edit selected menu item
    private void EditSelectedItem()
    {
        var item = GetSelectedMenuItem();
        if (item == null) return;

        using var dialog = new MenuItemDialog(item);
        if (dialog.ShowDialog(FindForm()) == DialogResult.OK && dialog.ResultItem != null)
        {
            _store.UpdateMenuItem(dialog.ResultItem);
            PopulateCategoryFilter();
            RefreshGrid();
        }
    }

    // Toggle availability status of selected item
    private void btnToggleStatus_Click(object sender, EventArgs e)
    {
        var item = GetSelectedMenuItem();
        if (item == null) return;

        _store.SetMenuItemAvailability(item.Id, !item.IsAvailable);
        RefreshGrid();
    }

    // Live search text change event
    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        RefreshGrid();
    }

    // Category or availability filter changed
    private void Filter_Changed(object sender, EventArgs e)
    {
        RefreshGrid();
    }

    // Reset search box and filters
    private void btnClearSearch_Click(object sender, EventArgs e)
    {
        txtSearch.Clear();
        cboCategoryFilter.SelectedIndex = 0;
        cboAvailabilityFilter.SelectedIndex = 0;
        txtSearch.Focus();
        RefreshGrid();
    }
}
