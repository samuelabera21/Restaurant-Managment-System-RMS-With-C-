using System;
using System.Drawing;
using System.Windows.Forms;
using MenuItem = RMS.Models.MenuItem;

namespace RMS.UI.Dialogs;

/// <summary>
/// Modal dialog for adding a new menu item or editing an existing menu item.
/// Fully compatible with the Visual Studio Form Designer.
/// </summary>
public partial class MenuItemDialog : Form
{
    private readonly int _existingId = 0;

    public MenuItem? ResultItem { get; private set; }

    /// <summary>
    /// Parameterless constructor required by the Visual Studio Designer.
    /// </summary>
    public MenuItemDialog()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Runtime constructor initializing the form with existing menu item data (if editing).
    /// </summary>
    public MenuItemDialog(MenuItem? existingItem = null) : this()
    {
        if (existingItem != null)
        {
            _existingId = existingItem.Id;
            Text = "Edit Menu Item";
            lblTitle.Text = "Edit Menu Item";
            lblSubtitle.Text = $"Update details for Item {existingItem.Id} - {existingItem.Name}";
            txtName.Text = existingItem.Name;
            cboCategory.Text = existingItem.Category;
            numPrice.Value = existingItem.Price;
            chkAvailable.Checked = existingItem.IsAvailable;
            btnSave.Text = "Save Changes";
        }
        else
        {
            Text = "Add Menu Item";
            lblTitle.Text = "Add New Menu Item";
            lblSubtitle.Text = "Configure item name, category, price, and availability";
            cboCategory.SelectedIndex = 0;
            btnSave.Text = "Add Item";
        }
    }

    private void btnSave_Click(object? sender, EventArgs e)
    {
        string name = txtName.Text.Trim();
        string category = cboCategory.Text.Trim();
        decimal price = numPrice.Value;
        bool isAvailable = chkAvailable.Checked;

        if (string.IsNullOrWhiteSpace(name))
        {
            lblError.Text = "Item name cannot be empty.";
            lblError.Visible = true;
            txtName.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(category))
        {
            lblError.Text = "Please specify a category.";
            lblError.Visible = true;
            cboCategory.Focus();
            return;
        }

        if (price <= 0)
        {
            lblError.Text = "Price must be greater than 0 ETB.";
            lblError.Visible = true;
            numPrice.Focus();
            return;
        }

        ResultItem = new MenuItem(_existingId, name, category, price, isAvailable);
        DialogResult = DialogResult.OK;
        Close();
    }

    private void btnCancel_Click(object? sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}
