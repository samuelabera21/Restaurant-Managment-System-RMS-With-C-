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

/// <summary>
/// Admin Menu Management screen view protected by PIN.
/// Allows adding new items, editing name/category/price, and toggling availability.
/// </summary>
public partial class MenuManagementView : BaseView, INavigationAware
{
    private readonly RestaurantStore _store = RestaurantStore.Instance;

    public MenuManagementView() : base()
    {
        InitializeComponent();

        if (!DesignMode)
        {
            dgvMenuItems.CellDoubleClick += dgvMenuItems_CellDoubleClick;
            cboAvailabilityFilter.SelectedIndex = 0;
        }
    }

    public override void OnNavigatedTo(object? parameter = null)
    {
        base.OnNavigatedTo(parameter);

        if (DesignMode) return;

        PopulateCategoryFilter();
        RefreshGrid();
    }

    private void PopulateCategoryFilter()
    {
        string? currentSelection = cboCategoryFilter.SelectedItem?.ToString();
        cboCategoryFilter.Items.Clear();
        cboCategoryFilter.Items.Add("All Categories");

        var categories = _store.MenuItems
            .Select(m => m.Category)
            .Where(c => !string.IsNullOrWhiteSpace(c))
            .Distinct()
            .OrderBy(c => c);

        foreach (var category in categories)
        {
            cboCategoryFilter.Items.Add(category);
        }

        if (currentSelection != null && cboCategoryFilter.Items.Contains(currentSelection))
        {
            cboCategoryFilter.SelectedItem = currentSelection;
        }
        else
        {
            cboCategoryFilter.SelectedIndex = 0;
        }
    }

    public void RefreshGrid()
    {
        if (DesignMode) return;

        string searchQuery = txtSearch.Text.Trim().ToLowerInvariant();
        string selectedCategory = cboCategoryFilter.SelectedItem?.ToString() ?? "All Categories";
        int availIndex = cboAvailabilityFilter.SelectedIndex;

        var items = _store.MenuItems.AsEnumerable();

        if (!string.IsNullOrEmpty(searchQuery))
        {
            items = items.Where(m =>
                m.Name.ToLowerInvariant().Contains(searchQuery) ||
                m.Category.ToLowerInvariant().Contains(searchQuery) ||
                m.Id.ToString().Contains(searchQuery));
        }

        if (selectedCategory != "All Categories")
        {
            items = items.Where(m => string.Equals(m.Category, selectedCategory, StringComparison.OrdinalIgnoreCase));
        }

        if (availIndex == 1) // Available Only
        {
            items = items.Where(m => m.IsAvailable);
        }
        else if (availIndex == 2) // Unavailable Only
        {
            items = items.Where(m => !m.IsAvailable);
        }

        var filteredList = items.OrderBy(m => m.Id).ToList();

        dgvMenuItems.Rows.Clear();
        foreach (var item in filteredList)
        {
            int rowIndex = dgvMenuItems.Rows.Add(
                item.Id.ToString(),
                item.Name,
                item.Category,
                $"{item.Price:N0} ETB",
                item.IsAvailable ? "Available" : "Unavailable"
            );

            var row = dgvMenuItems.Rows[rowIndex];
            row.Tag = item;

            var statusCell = row.Cells["colStatus"];
            statusCell.Style.ForeColor = Color.FromArgb(15, 23, 42);
            statusCell.Style.Font = AppTheme.BodyRegular;
        }

        lblSummary.Text = $"Showing {filteredList.Count} of {_store.MenuItems.Count} registered menu items";
        UpdateActionButtons();
    }

    private MenuItem? GetSelectedMenuItem()
    {
        if (dgvMenuItems.SelectedRows.Count > 0 && dgvMenuItems.SelectedRows[0].Tag is MenuItem item)
        {
            return item;
        }
        return null;
    }

    private void UpdateActionButtons()
    {
        bool hasSelection = GetSelectedMenuItem() != null;
        btnEditItem.Enabled = hasSelection;
        btnToggleStatus.Enabled = hasSelection;
    }

    private void dgvMenuItems_SelectionChanged(object? sender, EventArgs e)
    {
        UpdateActionButtons();
    }

    private void dgvMenuItems_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            EditSelectedItem();
        }
    }

    private void btnAddItem_Click(object? sender, EventArgs e)
    {
        using var dialog = new MenuItemDialog();
        if (dialog.ShowDialog(FindForm()) == DialogResult.OK && dialog.ResultItem != null)
        {
            _store.AddMenuItem(dialog.ResultItem);
            PopulateCategoryFilter();
            RefreshGrid();
        }
    }

    private void btnEditItem_Click(object? sender, EventArgs e)
    {
        EditSelectedItem();
    }

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

    private void btnToggleStatus_Click(object? sender, EventArgs e)
    {
        var item = GetSelectedMenuItem();
        if (item == null) return;

        _store.SetMenuItemAvailability(item.Id, !item.IsAvailable);
        RefreshGrid();
    }

    private void txtSearch_TextChanged(object? sender, EventArgs e)
    {
        RefreshGrid();
    }

    private void Filter_Changed(object? sender, EventArgs e)
    {
        RefreshGrid();
    }

    private void btnClearSearch_Click(object? sender, EventArgs e)
    {
        txtSearch.Text = string.Empty;
        cboCategoryFilter.SelectedIndex = 0;
        cboAvailabilityFilter.SelectedIndex = 0;
        RefreshGrid();
    }
}
