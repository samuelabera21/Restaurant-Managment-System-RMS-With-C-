using System.Drawing;
using System.Windows.Forms;
using RMS.Common;
using MenuItem = RMS.Models.MenuItem;

namespace RMS.UI.Dialogs;

/// <summary>
/// Modal dialog for adding a new menu item or editing an existing menu item.
/// Supports item name, category, price in ETB, and availability status.
/// </summary>
public class MenuItemDialog : Form
{
    private readonly TextBox _txtName;
    private readonly ComboBox _cboCategory;
    private readonly NumericUpDown _numPrice;
    private readonly CheckBox _chkAvailable;
    private readonly Label _lblError;
    private readonly Button _btnSave;
    private readonly Button _btnCancel;

    public MenuItem? ResultItem { get; private set; }

    public MenuItemDialog(MenuItem? existingItem = null)
    {
        bool isEditing = existingItem != null;

        Text = isEditing ? "Edit Menu Item" : "Add Menu Item";
        Size = new Size(460, 440);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        StartPosition = FormStartPosition.CenterParent;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        BackColor = Color.White;
        Font = AppTheme.BodyRegular;

        // Header Panel
        var pnlHeader = new Panel
        {
            Dock = DockStyle.Top,
            Height = 70,
            BackColor = AppTheme.ContentBackground,
            Padding = new Padding(24, 16, 24, 12)
        };
        pnlHeader.Paint += (s, e) =>
        {
            using var pen = new Pen(AppTheme.CardBorder);
            e.Graphics.DrawLine(pen, 0, pnlHeader.Height - 1, pnlHeader.Width, pnlHeader.Height - 1);
        };

        var lblTitle = new Label
        {
            Text = isEditing ? "Edit Menu Item" : "Add New Menu Item",
            Font = AppTheme.HeaderMedium,
            ForeColor = AppTheme.TextPrimary,
            AutoSize = true,
            Location = new Point(24, 14)
        };

        var lblSubtitle = new Label
        {
            Text = isEditing ? $"Update details for Item {existingItem!.Id} - {existingItem.Name}" : "Configure item name, category, price, and availability",
            Font = AppTheme.SmallRegular,
            ForeColor = AppTheme.TextSecondary,
            AutoSize = true,
            Location = new Point(24, 40)
        };

        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Controls.Add(lblSubtitle);
        Controls.Add(pnlHeader);

        // Body Panel
        var pnlBody = new Panel
        {
            Dock = DockStyle.Fill,
            Padding = new Padding(24, 16, 24, 16)
        };

        int top = 85;

        // 1. Item Name
        var lblName = new Label
        {
            Text = "Item Name *",
            Font = AppTheme.SmallBold,
            ForeColor = AppTheme.TextPrimary,
            Location = new Point(24, top),
            AutoSize = true
        };
        Controls.Add(lblName);
        top += 20;

        _txtName = new TextBox
        {
            Font = AppTheme.BodyRegular,
            Location = new Point(24, top),
            Size = new Size(396, 30),
            Text = existingItem?.Name ?? string.Empty
        };
        Controls.Add(_txtName);
        top += 38;

        // 2. Category
        var lblCategory = new Label
        {
            Text = "Category *",
            Font = AppTheme.SmallBold,
            ForeColor = AppTheme.TextPrimary,
            Location = new Point(24, top),
            AutoSize = true
        };
        Controls.Add(lblCategory);
        top += 20;

        _cboCategory = new ComboBox
        {
            Font = AppTheme.BodyRegular,
            Location = new Point(24, top),
            Size = new Size(396, 30),
            DropDownStyle = ComboBoxStyle.DropDown
        };
        _cboCategory.Items.AddRange(new object[]
        {
            "Beverage",
            "Hot Drinks",
            "Fast Food",
            "Main Dish",
            "Traditional",
            "Side Dish",
            "Dessert"
        });
        _cboCategory.Text = existingItem?.Category ?? "Beverage";
        Controls.Add(_cboCategory);
        top += 38;

        // 3. Price (ETB)
        var lblPrice = new Label
        {
            Text = "Price (ETB) *",
            Font = AppTheme.SmallBold,
            ForeColor = AppTheme.TextPrimary,
            Location = new Point(24, top),
            AutoSize = true
        };
        Controls.Add(lblPrice);
        top += 20;

        _numPrice = new NumericUpDown
        {
            Font = AppTheme.BodyRegular,
            Location = new Point(24, top),
            Size = new Size(180, 30),
            Minimum = 1,
            Maximum = 10000,
            DecimalPlaces = 0,
            Value = existingItem != null ? (decimal)existingItem.Price : 50m
        };
        Controls.Add(_numPrice);

        // 4. Availability CheckBox
        _chkAvailable = new CheckBox
        {
            Text = "Available for ordering",
            Font = AppTheme.BodyBold,
            ForeColor = AppTheme.StatusReadyText,
            Location = new Point(220, top + 2),
            Size = new Size(200, 26),
            Checked = existingItem?.IsAvailable ?? true,
            Cursor = Cursors.Hand
        };
        Controls.Add(_chkAvailable);
        top += 40;

        // Error message label
        _lblError = new Label
        {
            Text = string.Empty,
            Font = AppTheme.SmallBold,
            ForeColor = AppTheme.DangerButton,
            Location = new Point(24, top),
            Size = new Size(396, 20),
            Visible = false
        };
        Controls.Add(_lblError);

        // Footer / Button Panel
        var pnlFooter = new Panel
        {
            Dock = DockStyle.Bottom,
            Height = 65,
            BackColor = AppTheme.ContentBackground,
            Padding = new Padding(24, 14, 24, 14)
        };
        pnlFooter.Paint += (s, e) =>
        {
            using var pen = new Pen(AppTheme.CardBorder);
            e.Graphics.DrawLine(pen, 0, 0, pnlFooter.Width, 0);
        };

        _btnCancel = new Button
        {
            Text = "Cancel",
            Font = AppTheme.BodyBold,
            ForeColor = AppTheme.TextPrimary,
            BackColor = Color.White,
            FlatStyle = FlatStyle.Flat,
            Size = new Size(100, 36),
            Location = new Point(208, 14),
            Cursor = Cursors.Hand,
            DialogResult = DialogResult.Cancel
        };
        _btnCancel.FlatAppearance.BorderColor = AppTheme.CardBorder;

        _btnSave = new Button
        {
            Text = isEditing ? "Save Changes" : "Add Item",
            Font = AppTheme.BodyBold,
            ForeColor = Color.White,
            BackColor = AppTheme.PrimaryButton,
            FlatStyle = FlatStyle.Flat,
            Size = new Size(110, 36),
            Location = new Point(316, 14),
            Cursor = Cursors.Hand
        };
        _btnSave.FlatAppearance.BorderSize = 0;
        _btnSave.Click += (s, e) =>
        {
            string name = _txtName.Text.Trim();
            string category = _cboCategory.Text.Trim();
            decimal price = _numPrice.Value;
            bool isAvailable = _chkAvailable.Checked;

            if (string.IsNullOrWhiteSpace(name))
            {
                _lblError.Text = "Item name cannot be empty.";
                _lblError.Visible = true;
                _txtName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(category))
            {
                _lblError.Text = "Please specify a category.";
                _lblError.Visible = true;
                _cboCategory.Focus();
                return;
            }

            if (price <= 0)
            {
                _lblError.Text = "Price must be greater than 0 ETB.";
                _lblError.Visible = true;
                _numPrice.Focus();
                return;
            }

            int id = existingItem?.Id ?? 0;
            ResultItem = new MenuItem(id, name, category, price, isAvailable);
            DialogResult = DialogResult.OK;
            Close();
        };

        pnlFooter.Controls.Add(_btnCancel);
        pnlFooter.Controls.Add(_btnSave);
        Controls.Add(pnlFooter);

        AcceptButton = _btnSave;
        CancelButton = _btnCancel;
    }
}
