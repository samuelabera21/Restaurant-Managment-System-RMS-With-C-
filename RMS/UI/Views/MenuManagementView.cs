using System.Drawing;
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
/// Allows adding new items, editing name/category/price, toggling availability,
/// and persisting immediately to menu.json.
/// </summary>
public class MenuManagementView : BaseView, INavigationAware
{
    private readonly RestaurantStore _store = RestaurantStore.Instance;

    // Filters & Controls
    private readonly TextBox _txtSearch;
    private readonly Button _btnClearSearch;
    private readonly ComboBox _cboCategoryFilter;
    private readonly ComboBox _cboAvailabilityFilter;
    private readonly Button _btnAddItem;
    private readonly Label _lblItemsSummary;

    // Grid
    private readonly DataGridView _gridMenuItems;

    public MenuManagementView() : base("Menu Management", "Administer menu items, prices, and availability")
    {
        // ----------------------------------------------------
        // 1. Info Banner
        // ----------------------------------------------------
        var pnlNoticeBanner = new Panel
        {
            Dock = DockStyle.Top,
            Height = 44,
            BackColor = Color.FromArgb(238, 242, 255),
            Padding = new Padding(16, 10, 16, 10)
        };
        pnlNoticeBanner.Paint += (s, e) =>
        {
            using var pen = new Pen(Color.FromArgb(199, 210, 254));
            e.Graphics.DrawRectangle(pen, 0, 0, pnlNoticeBanner.Width - 1, pnlNoticeBanner.Height - 1);
        };

        var lblNotice = new Label
        {
            Text = "🔒 Admin Mode · Menu items are saved locally to menu.json. Price changes apply to new orders; past orders preserve historical price snapshots.",
            Font = AppTheme.SmallRegular,
            ForeColor = Color.FromArgb(67, 56, 202),
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleLeft
        };
        pnlNoticeBanner.Controls.Add(lblNotice);

        var pnlNoticeGap = new Panel
        {
            Dock = DockStyle.Top,
            Height = 10,
            BackColor = AppTheme.ContentBackground
        };

        // ----------------------------------------------------
        // 2. Toolbar & Filter Bar
        // ----------------------------------------------------
        var pnlToolbar = new Panel
        {
            Dock = DockStyle.Top,
            Height = 54,
            BackColor = AppTheme.ContentBackground,
            Padding = new Padding(0, 10, 0, 8)
        };

        // Search Box
        var pnlSearch = new Panel
        {
            Size = new Size(260, 36),
            Location = new Point(0, 9),
            BackColor = Color.White
        };
        pnlSearch.Paint += (s, e) =>
        {
            using var pen = new Pen(AppTheme.CardBorder);
            e.Graphics.DrawRectangle(pen, 0, 0, pnlSearch.Width - 1, pnlSearch.Height - 1);
        };

        var lblSearchIcon = new Label
        {
            Text = "🔍",
            Font = AppTheme.SmallRegular,
            ForeColor = AppTheme.TextMuted,
            Size = new Size(24, 24),
            Location = new Point(6, 6),
            TextAlign = ContentAlignment.MiddleCenter
        };

        _btnClearSearch = new Button
        {
            Text = "✕",
            Font = AppTheme.SmallBold,
            ForeColor = AppTheme.TextMuted,
            BackColor = Color.Transparent,
            FlatStyle = FlatStyle.Flat,
            Size = new Size(22, 22),
            Location = new Point(234, 7),
            Cursor = Cursors.Hand,
            Visible = false
        };
        _btnClearSearch.FlatAppearance.BorderSize = 0;

        _txtSearch = new TextBox
        {
            BorderStyle = BorderStyle.None,
            Font = AppTheme.BodyRegular,
            ForeColor = AppTheme.TextPrimary,
            Location = new Point(32, 8),
            Size = new Size(198, 20),
            PlaceholderText = "Search menu items..."
        };
        _txtSearch.TextChanged += (s, e) =>
        {
            _btnClearSearch.Visible = !string.IsNullOrEmpty(_txtSearch.Text);
            RefreshGrid();
        };

        _btnClearSearch.Click += (s, e) =>
        {
            _txtSearch.Text = string.Empty;
            _txtSearch.Focus();
        };

        pnlSearch.Controls.Add(lblSearchIcon);
        pnlSearch.Controls.Add(_txtSearch);
        pnlSearch.Controls.Add(_btnClearSearch);
        pnlToolbar.Controls.Add(pnlSearch);

        // Category Filter
        _cboCategoryFilter = new ComboBox
        {
            Font = AppTheme.BodyRegular,
            Location = new Point(275, 11),
            Size = new Size(160, 32),
            DropDownStyle = ComboBoxStyle.DropDownList
        };
        _cboCategoryFilter.Items.Add("All Categories");
        _cboCategoryFilter.SelectedIndex = 0;
        _cboCategoryFilter.SelectedIndexChanged += (s, e) => RefreshGrid();
        pnlToolbar.Controls.Add(_cboCategoryFilter);

        // Availability Filter
        _cboAvailabilityFilter = new ComboBox
        {
            Font = AppTheme.BodyRegular,
            Location = new Point(445, 11),
            Size = new Size(150, 32),
            DropDownStyle = ComboBoxStyle.DropDownList
        };
        _cboAvailabilityFilter.Items.AddRange(new object[] { "All Items", "Available Only", "Unavailable Only" });
        _cboAvailabilityFilter.SelectedIndex = 0;
        _cboAvailabilityFilter.SelectedIndexChanged += (s, e) => RefreshGrid();
        pnlToolbar.Controls.Add(_cboAvailabilityFilter);

        // "+ Add Menu Item" Button on the right
        _btnAddItem = new Button
        {
            Text = "+ Add Menu Item",
            Font = AppTheme.BodyBold,
            ForeColor = Color.White,
            BackColor = AppTheme.PrimaryButton,
            FlatStyle = FlatStyle.Flat,
            Size = new Size(160, 36),
            Anchor = AnchorStyles.Top | AnchorStyles.Right,
            Cursor = Cursors.Hand
        };
        _btnAddItem.FlatAppearance.BorderSize = 0;
        _btnAddItem.Location = new Point(ContentPanel.Width - 170, 9);
        _btnAddItem.Click += OnAddNewItemClicked;
        pnlToolbar.Controls.Add(_btnAddItem);
        pnlToolbar.Resize += (s, e) =>
        {
            _btnAddItem.Location = new Point(pnlToolbar.Width - 170, 9);
        };

        // ----------------------------------------------------
        // 3. Sub-bar Summary Label
        // ----------------------------------------------------
        var pnlSubBar = new Panel
        {
            Dock = DockStyle.Top,
            Height = 26,
            BackColor = AppTheme.ContentBackground
        };

        _lblItemsSummary = new Label
        {
            Text = "Showing all items",
            Font = AppTheme.SmallBold,
            ForeColor = AppTheme.TextSecondary,
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleLeft
        };
        pnlSubBar.Controls.Add(_lblItemsSummary);

        // ----------------------------------------------------
        // 4. DataGridView Table Card
        // ----------------------------------------------------
        var pnlTableCard = new Panel
        {
            Dock = DockStyle.Fill,
            BackColor = AppTheme.CardBackground,
            Padding = new Padding(1)
        };
        pnlTableCard.Paint += (s, e) =>
        {
            using var pen = new Pen(AppTheme.CardBorder);
            e.Graphics.DrawRectangle(pen, 0, 0, pnlTableCard.Width - 1, pnlTableCard.Height - 1);
        };

        _gridMenuItems = new DataGridView
        {
            Dock = DockStyle.Fill,
            BackgroundColor = Color.White,
            BorderStyle = BorderStyle.None,
            CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal,
            GridColor = Color.FromArgb(243, 244, 246),
            RowHeadersVisible = false,
            AllowUserToAddRows = false,
            AllowUserToDeleteRows = false,
            AllowUserToResizeRows = false,
            MultiSelect = false,
            ReadOnly = true,
            SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            EnableHeadersVisualStyles = false,
            RowTemplate = { Height = 48 }
        };

        _gridMenuItems.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
        {
            BackColor = Color.White,
            ForeColor = AppTheme.TextSecondary,
            Font = AppTheme.SmallBold,
            SelectionBackColor = Color.White,
            SelectionForeColor = AppTheme.TextSecondary,
            Padding = new Padding(12, 10, 12, 10),
            Alignment = DataGridViewContentAlignment.MiddleLeft
        };
        _gridMenuItems.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        _gridMenuItems.ColumnHeadersHeight = 44;

        _gridMenuItems.DefaultCellStyle = new DataGridViewCellStyle
        {
            BackColor = Color.White,
            ForeColor = AppTheme.TextPrimary,
            Font = AppTheme.BodyRegular,
            SelectionBackColor = Color.FromArgb(248, 250, 252),
            SelectionForeColor = AppTheme.TextPrimary,
            Padding = new Padding(12, 0, 12, 0),
            Alignment = DataGridViewContentAlignment.MiddleLeft
        };

        SetupGridColumns();
        _gridMenuItems.CellPainting += OnGridCellPainting;
        _gridMenuItems.CellContentClick += OnGridCellContentClick;

        pnlTableCard.Controls.Add(_gridMenuItems);

        // Add controls in reverse docking priority:
        // Fill docks last, then SubBar, Toolbar, Gap, NoticeBanner at the very top.
        ContentPanel.Controls.Add(pnlTableCard);
        ContentPanel.Controls.Add(pnlSubBar);
        ContentPanel.Controls.Add(pnlToolbar);
        ContentPanel.Controls.Add(pnlNoticeGap);
        ContentPanel.Controls.Add(pnlNoticeBanner);

        // Load Categories into dropdown and populate grid
        PopulateCategoryFilter();
        RefreshGrid();
    }

    private void SetupGridColumns()
    {
        _gridMenuItems.Columns.Clear();

        _gridMenuItems.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ColId",
            HeaderText = "ID",
            Width = 65,
            SortMode = DataGridViewColumnSortMode.NotSortable
        });

        _gridMenuItems.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ColName",
            HeaderText = "Item Name",
            Width = 220,
            SortMode = DataGridViewColumnSortMode.NotSortable
        });

        _gridMenuItems.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ColCategory",
            HeaderText = "Category",
            Width = 150,
            SortMode = DataGridViewColumnSortMode.NotSortable
        });

        _gridMenuItems.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ColPrice",
            HeaderText = "Price (ETB)",
            Width = 130,
            SortMode = DataGridViewColumnSortMode.NotSortable
        });

        _gridMenuItems.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ColStatus",
            HeaderText = "Status",
            Width = 150,
            SortMode = DataGridViewColumnSortMode.NotSortable
        });

        _gridMenuItems.Columns.Add(new DataGridViewButtonColumn
        {
            Name = "ColEdit",
            HeaderText = "Actions",
            Text = "Edit",
            UseColumnTextForButtonValue = true,
            Width = 90
        });

        _gridMenuItems.Columns.Add(new DataGridViewButtonColumn
        {
            Name = "ColToggle",
            HeaderText = "",
            Text = "Toggle Status",
            UseColumnTextForButtonValue = true,
            Width = 120
        });
    }

    private void PopulateCategoryFilter()
    {
        string? currentSelection = _cboCategoryFilter.SelectedItem?.ToString();
        _cboCategoryFilter.Items.Clear();
        _cboCategoryFilter.Items.Add("All Categories");

        var categories = _store.MenuItems
            .Select(m => m.Category)
            .Where(c => !string.IsNullOrWhiteSpace(c))
            .Distinct()
            .OrderBy(c => c);

        foreach (var category in categories)
        {
            _cboCategoryFilter.Items.Add(category);
        }

        if (currentSelection != null && _cboCategoryFilter.Items.Contains(currentSelection))
        {
            _cboCategoryFilter.SelectedItem = currentSelection;
        }
        else
        {
            _cboCategoryFilter.SelectedIndex = 0;
        }
    }

    public void RefreshGrid()
    {
        string searchQuery = _txtSearch.Text.Trim().ToLowerInvariant();
        string selectedCategory = _cboCategoryFilter.SelectedItem?.ToString() ?? "All Categories";
        int availIndex = _cboAvailabilityFilter.SelectedIndex;

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

        _gridMenuItems.Rows.Clear();
        foreach (var item in filteredList)
        {
            int rowIndex = _gridMenuItems.Rows.Add(
                $"#{item.Id}",
                item.Name,
                item.Category,
                $"{item.Price:N0} ETB",
                item.IsAvailable ? "Available" : "Unavailable",
                "Edit",
                item.IsAvailable ? "Make Unavailable" : "Make Available"
            );
            _gridMenuItems.Rows[rowIndex].Tag = item;
        }

        _lblItemsSummary.Text = $"Showing {filteredList.Count} of {_store.MenuItems.Count} registered menu items";
    }

    private void OnGridCellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
    {
        if (e.RowIndex < 0 || e.Graphics == null) return;

        int statusColIdx = _gridMenuItems.Columns["ColStatus"]?.Index ?? -1;
        if (e.ColumnIndex == statusColIdx && e.Value != null)
        {
            e.PaintBackground(e.CellBounds, true);

            string statusText = e.Value.ToString() ?? "";
            bool isAvail = statusText.Equals("Available", StringComparison.OrdinalIgnoreCase);

            Color badgeBg = isAvail ? AppTheme.StatusReadyBg : AppTheme.StatusCancelledBg;
            Color badgeFg = isAvail ? AppTheme.StatusReadyText : AppTheme.StatusCancelledText;
            string displayLabel = isAvail ? "● Available" : "○ Unavailable";

            int badgeWidth = 110;
            int badgeHeight = 26;
            int badgeX = e.CellBounds.X + 8;
            int badgeY = e.CellBounds.Y + (e.CellBounds.Height - badgeHeight) / 2;

            var badgeRect = new Rectangle(badgeX, badgeY, badgeWidth, badgeHeight);
            using var brushBg = new SolidBrush(badgeBg);
            using var brushFg = new SolidBrush(badgeFg);
            using var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };

            // Draw rounded pill
            using var path = GetRoundedPath(badgeRect, 6);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillPath(brushBg, path);
            e.Graphics.DrawString(displayLabel, AppTheme.SmallBold, brushFg, badgeRect, sf);

            e.Handled = true;
        }
    }

    private void OnGridCellContentClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        if (_gridMenuItems.Rows[e.RowIndex].Tag is not MenuItem item)
            return;

        int editColIdx = _gridMenuItems.Columns["ColEdit"]?.Index ?? -1;
        int toggleColIdx = _gridMenuItems.Columns["ColToggle"]?.Index ?? -1;

        if (e.ColumnIndex == editColIdx)
        {
            // Edit item
            using var dialog = new MenuItemDialog(item);
            if (dialog.ShowDialog(FindForm()) == DialogResult.OK && dialog.ResultItem != null)
            {
                _store.UpdateMenuItem(dialog.ResultItem);
                PopulateCategoryFilter();
                RefreshGrid();
            }
        }
        else if (e.ColumnIndex == toggleColIdx)
        {
            // Toggle availability
            _store.SetMenuItemAvailability(item.Id, !item.IsAvailable);
            RefreshGrid();
        }
    }

    private void OnAddNewItemClicked(object? sender, EventArgs e)
    {
        using var dialog = new MenuItemDialog();
        if (dialog.ShowDialog(FindForm()) == DialogResult.OK && dialog.ResultItem != null)
        {
            _store.AddMenuItem(dialog.ResultItem);
            PopulateCategoryFilter();
            RefreshGrid();
        }
    }

    private static System.Drawing.Drawing2D.GraphicsPath GetRoundedPath(Rectangle rect, int radius)
    {
        var path = new System.Drawing.Drawing2D.GraphicsPath();
        int d = radius * 2;
        path.AddArc(rect.X, rect.Y, d, d, 180, 90);
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
        path.CloseFigure();
        return path;
    }

    public override void OnNavigatedTo(object? parameter = null)
    {
        PopulateCategoryFilter();
        RefreshGrid();
    }
}
