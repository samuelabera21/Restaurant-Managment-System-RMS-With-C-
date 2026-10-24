using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using RMS.Common;
using RMS.Models;
using RMS.Services;
using MenuItem = RMS.Models.MenuItem;

namespace RMS.UI.Views;

/// <summary>
/// Menu catalog screen view allowing waiters to browse available foods and drinks,
/// search by item name, and filter by availability.
/// Matches the 4 visual states in UI/menu/Menu.jpg.
/// </summary>
public class MenuView : BaseView
{
    private enum AvailabilityFilter
    {
        All,
        Available,
        Unavailable
    }

    private readonly RestaurantStore _store = RestaurantStore.Instance;

    // Filter & Search State
    private AvailabilityFilter _activeFilter = AvailabilityFilter.All;
    private string _searchQuery = string.Empty;

    // Controls
    private readonly TextBox _txtSearch;
    private readonly Button _btnClearSearch;
    private readonly Button _btnFilterAll;
    private readonly Button _btnFilterAvailable;
    private readonly Button _btnFilterUnavailable;

    private readonly Label _lblItemsSummary;
    private readonly LinkLabel _lnkClearSearch;

    private readonly DataGridView _gridMenu;
    private readonly Panel _pnlEmptyState;
    private readonly Label _lblFooterLeft;
    private readonly Label _lblFooterRight;

    public MenuView() : base("Menu", "View available restaurant items, prices, and availability")
    {
        // ----------------------------------------------------
        // 1. Search Bar & Filter Pills (Top Bar)
        // ----------------------------------------------------
        var pnlFilterBar = new Panel
        {
            Dock = DockStyle.Top,
            Height = 48,
            BackColor = AppTheme.ContentBackground
        };

        // Search Box container
        var pnlSearchBox = new Panel
        {
            Location = new Point(0, 4),
            Size = new Size(320, 38),
            BackColor = Color.White
        };
        pnlSearchBox.Paint += (s, e) =>
        {
            using var pen = new Pen(AppTheme.CardBorder);
            e.Graphics.DrawRectangle(pen, 0, 0, pnlSearchBox.Width - 1, pnlSearchBox.Height - 1);
        };

        var lblSearchIcon = new Label
        {
            Text = "🔍",
            Font = new Font("Segoe UI", 9f),
            ForeColor = AppTheme.TextMuted,
            Size = new Size(24, 24),
            Location = new Point(8, 8),
            TextAlign = ContentAlignment.MiddleCenter
        };

        _txtSearch = new TextBox
        {
            Font = AppTheme.BodyRegular,
            BorderStyle = BorderStyle.None,
            Location = new Point(36, 10),
            Width = 250,
            PlaceholderText = "Search menu items..."
        };
        _btnClearSearch = new Button
        {
            Text = "✕",
            Font = AppTheme.SmallBold,
            ForeColor = AppTheme.TextMuted,
            BackColor = Color.Transparent,
            FlatStyle = FlatStyle.Flat,
            Size = new Size(24, 24),
            Location = new Point(290, 7),
            Cursor = Cursors.Hand,
            Visible = false
        };
        _btnClearSearch.FlatAppearance.BorderSize = 0;
        _btnClearSearch.Click += (s, e) => ClearSearch();

        pnlSearchBox.Controls.Add(lblSearchIcon);
        pnlSearchBox.Controls.Add(_txtSearch);
        pnlSearchBox.Controls.Add(_btnClearSearch);
        pnlFilterBar.Controls.Add(pnlSearchBox);

        // Filter Pills (Right-aligned)
        var pnlPills = new FlowLayoutPanel
        {
            Dock = DockStyle.Right,
            Width = 320,
            Height = 48,
            FlowDirection = FlowDirection.RightToLeft,
            BackColor = Color.Transparent,
            Padding = new Padding(0, 4, 0, 0)
        };

        _btnFilterUnavailable = CreateFilterButton("Unavailable", AvailabilityFilter.Unavailable);
        _btnFilterAvailable = CreateFilterButton("Available", AvailabilityFilter.Available);
        _btnFilterAll = CreateFilterButton("All Items", AvailabilityFilter.All);

        pnlPills.Controls.Add(_btnFilterUnavailable);
        pnlPills.Controls.Add(_btnFilterAvailable);
        pnlPills.Controls.Add(_btnFilterAll);
        pnlFilterBar.Controls.Add(pnlPills);

        // ----------------------------------------------------
        // 2. Summary Subtitle Bar
        // ----------------------------------------------------
        var pnlSubBar = new Panel
        {
            Dock = DockStyle.Top,
            Height = 32,
            BackColor = AppTheme.ContentBackground
        };

        _lblItemsSummary = new Label
        {
            Text = "5 items",
            Font = AppTheme.SmallBold,
            ForeColor = AppTheme.TextSecondary,
            Dock = DockStyle.Left,
            TextAlign = ContentAlignment.MiddleLeft
        };

        _lnkClearSearch = new LinkLabel
        {
            Text = "Clear search",
            Font = AppTheme.SmallBold,
            LinkColor = AppTheme.PrimaryButton,
            ActiveLinkColor = AppTheme.PrimaryButtonHover,
            Dock = DockStyle.Right,
            TextAlign = ContentAlignment.MiddleRight,
            Visible = false,
            Cursor = Cursors.Hand
        };
        _lnkClearSearch.Click += (s, e) => ClearSearch();

        pnlSubBar.Controls.Add(_lblItemsSummary);
        pnlSubBar.Controls.Add(_lnkClearSearch);

        // Wire search input changes after controls are initialized
        _txtSearch.TextChanged += (s, e) =>
        {
            _searchQuery = _txtSearch.Text.Trim();
            _btnClearSearch.Visible = !string.IsNullOrEmpty(_searchQuery);
            _lnkClearSearch.Visible = !string.IsNullOrEmpty(_searchQuery);
            ApplyFilters();
        };

        // ----------------------------------------------------
        // 3. Main Menu Table (DataGridView)
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

        _gridMenu = new DataGridView
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
            RowTemplate = { Height = 46 }
        };

        // Header Styling
        _gridMenu.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
        {
            BackColor = Color.White,
            ForeColor = AppTheme.TextSecondary,
            Font = AppTheme.SmallBold,
            SelectionBackColor = Color.White,
            SelectionForeColor = AppTheme.TextSecondary,
            Padding = new Padding(12, 10, 12, 10)
        };
        _gridMenu.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        _gridMenu.ColumnHeadersHeight = 40;

        // Default Cell Styling
        _gridMenu.DefaultCellStyle = new DataGridViewCellStyle
        {
            BackColor = Color.White,
            ForeColor = AppTheme.TextPrimary,
            Font = AppTheme.BodyRegular,
            SelectionBackColor = Color.FromArgb(249, 250, 251),
            SelectionForeColor = AppTheme.TextPrimary,
            Padding = new Padding(12, 0, 12, 0)
        };

        // Define Columns
        _gridMenu.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ColName",
            HeaderText = "Item Name",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            FillWeight = 35
        });

        _gridMenu.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ColCategory",
            HeaderText = "Category",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            FillWeight = 25
        });

        _gridMenu.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ColPrice",
            HeaderText = "Price",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            FillWeight = 20
        });

        _gridMenu.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ColAvailability",
            HeaderText = "Availability",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            FillWeight = 20
        });

        var colAction = new DataGridViewLinkColumn
        {
            Name = "ColAction",
            HeaderText = "Actions",
            Text = "View",
            UseColumnTextForLinkValue = true,
            LinkColor = AppTheme.PrimaryButton,
            ActiveLinkColor = AppTheme.PrimaryButtonHover,
            TrackVisitedState = false,
            Width = 80
        };
        _gridMenu.Columns.Add(colAction);

        // Custom badge painting for Availability column
        _gridMenu.CellPainting += GridMenu_CellPainting;
        _gridMenu.CellContentClick += GridMenu_CellContentClick;

        pnlTableCard.Controls.Add(_gridMenu);

        // ----------------------------------------------------
        // 4. Empty State Panel (When 0 items match search)
        // ----------------------------------------------------
        _pnlEmptyState = CreateEmptyStatePanel();
        pnlTableCard.Controls.Add(_pnlEmptyState);

        // ----------------------------------------------------
        // 5. Table Footer Status Strip
        // ----------------------------------------------------
        var pnlFooter = new Panel
        {
            Dock = DockStyle.Bottom,
            Height = 36,
            BackColor = AppTheme.ContentBackground,
            Padding = new Padding(4, 8, 4, 0)
        };

        _lblFooterLeft = new Label
        {
            Text = "Showing 5 of 5 menu items",
            Font = AppTheme.SmallRegular,
            ForeColor = AppTheme.TextMuted,
            Dock = DockStyle.Left,
            TextAlign = ContentAlignment.MiddleLeft
        };

        _lblFooterRight = new Label
        {
            Text = string.Empty,
            Font = AppTheme.SmallRegular,
            ForeColor = AppTheme.TextMuted,
            Dock = DockStyle.Right,
            TextAlign = ContentAlignment.MiddleRight
        };

        pnlFooter.Controls.Add(_lblFooterLeft);
        pnlFooter.Controls.Add(_lblFooterRight);

        // Assemble Layout inside ContentPanel
        ContentPanel.Controls.Add(pnlTableCard);
        ContentPanel.Controls.Add(pnlFooter);
        ContentPanel.Controls.Add(pnlSubBar);
        ContentPanel.Controls.Add(pnlFilterBar);

        // Wire Store updates
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

        // Initial Load
        UpdateFilterButtons();
        ApplyFilters();
    }

    private Button CreateFilterButton(string text, AvailabilityFilter filter)
    {
        var btn = new Button
        {
            Text = text,
            Font = AppTheme.SmallBold,
            Size = new Size(95, 34),
            Margin = new Padding(4, 0, 0, 0),
            FlatStyle = FlatStyle.Flat,
            Cursor = Cursors.Hand
        };
        btn.FlatAppearance.BorderSize = 1;
        btn.FlatAppearance.BorderColor = AppTheme.CardBorder;
        btn.Click += (s, e) =>
        {
            _activeFilter = filter;
            UpdateFilterButtons();
            ApplyFilters();
        };
        return btn;
    }

    private void UpdateFilterButtons()
    {
        SetFilterButtonStyle(_btnFilterAll, _activeFilter == AvailabilityFilter.All);
        SetFilterButtonStyle(_btnFilterAvailable, _activeFilter == AvailabilityFilter.Available);
        SetFilterButtonStyle(_btnFilterUnavailable, _activeFilter == AvailabilityFilter.Unavailable);
    }

    private void SetFilterButtonStyle(Button btn, bool isActive)
    {
        if (isActive)
        {
            btn.BackColor = AppTheme.PrimaryButton;
            btn.ForeColor = Color.White;
            btn.FlatAppearance.BorderColor = AppTheme.PrimaryButton;
        }
        else
        {
            btn.BackColor = Color.White;
            btn.ForeColor = AppTheme.TextPrimary;
            btn.FlatAppearance.BorderColor = AppTheme.CardBorder;
        }
    }

    private Panel CreateEmptyStatePanel()
    {
        var pnl = new Panel
        {
            Dock = DockStyle.Fill,
            BackColor = Color.White,
            Visible = false
        };

        var centerBox = new Panel
        {
            Size = new Size(380, 200),
            BackColor = Color.White
        };

        var lblIcon = new Label
        {
            Text = "🔍",
            Font = new Font("Segoe UI", 24f),
            ForeColor = AppTheme.TextMuted,
            TextAlign = ContentAlignment.MiddleCenter,
            Dock = DockStyle.Top,
            Height = 44
        };

        var lblTitle = new Label
        {
            Text = "No items match your search.",
            Font = AppTheme.HeaderMedium,
            ForeColor = AppTheme.TextPrimary,
            TextAlign = ContentAlignment.MiddleCenter,
            Dock = DockStyle.Top,
            Height = 32
        };

        var lblSubtitle = new Label
        {
            Text = "Try another item name or clear your search to view all items.",
            Font = AppTheme.BodyRegular,
            ForeColor = AppTheme.TextSecondary,
            TextAlign = ContentAlignment.MiddleCenter,
            Dock = DockStyle.Top,
            Height = 40
        };

        var btnClear = new Button
        {
            Text = "Clear search",
            Font = AppTheme.BodyBold,
            ForeColor = Color.White,
            BackColor = AppTheme.PrimaryButton,
            FlatStyle = FlatStyle.Flat,
            Size = new Size(130, 36),
            Cursor = Cursors.Hand
        };
        btnClear.FlatAppearance.BorderSize = 0;
        btnClear.Location = new Point((centerBox.Width - btnClear.Width) / 2, 126);
        btnClear.Click += (s, e) => ClearSearch();

        centerBox.Controls.Add(btnClear);
        centerBox.Controls.Add(lblSubtitle);
        centerBox.Controls.Add(lblTitle);
        centerBox.Controls.Add(lblIcon);

        pnl.Resize += (s, e) =>
        {
            centerBox.Location = new Point((pnl.Width - centerBox.Width) / 2, (pnl.Height - centerBox.Height) / 2);
        };
        pnl.Controls.Add(centerBox);

        return pnl;
    }

    private void ClearSearch()
    {
        _txtSearch.Text = string.Empty;
        _txtSearch.Focus();
    }

    public override void OnNavigatedTo(object? parameter = null)
    {
        base.OnNavigatedTo(parameter);
        ApplyFilters();
    }

    private void ApplyFilters()
    {
        if (IsDisposed || Disposing || _gridMenu.IsDisposed || _gridMenu.Columns.Count == 0) return;

        var allItems = _store.MenuItems;

        // Apply Availability filter
        var filtered = allItems.AsEnumerable();
        if (_activeFilter == AvailabilityFilter.Available)
        {
            filtered = filtered.Where(i => i.IsAvailable);
        }
        else if (_activeFilter == AvailabilityFilter.Unavailable)
        {
            filtered = filtered.Where(i => !i.IsAvailable);
        }

        // Apply Text Search filter
        if (!string.IsNullOrEmpty(_searchQuery))
        {
            filtered = filtered.Where(i =>
                i.Name.Contains(_searchQuery, StringComparison.OrdinalIgnoreCase) ||
                i.Category.Contains(_searchQuery, StringComparison.OrdinalIgnoreCase)
            );
        }

        var resultList = filtered.ToList();

        // Update Subtitle summary
        int availableCount = allItems.Count(i => i.IsAvailable);
        int unavailableCount = allItems.Count - availableCount;

        if (string.IsNullOrEmpty(_searchQuery))
        {
            _lblItemsSummary.Text = $"{allItems.Count} items  •  {availableCount} available, {unavailableCount} unavailable";
            _lblFooterRight.Text = string.Empty;
        }
        else
        {
            _lblItemsSummary.Text = $"{resultList.Count} {(resultList.Count == 1 ? "item" : "items")}";
            _lblFooterRight.Text = $"Search results for \"{_searchQuery}\"";
        }

        _lblFooterLeft.Text = $"Showing {resultList.Count} of {allItems.Count} menu items";

        // Toggle Empty State vs Grid
        if (resultList.Count == 0)
        {
            _gridMenu.Visible = false;
            _pnlEmptyState.Visible = true;
            _pnlEmptyState.BringToFront();
        }
        else
        {
            _pnlEmptyState.Visible = false;
            _gridMenu.Visible = true;

            // Populate Grid Rows
            _gridMenu.Rows.Clear();
            foreach (var item in resultList)
            {
                int rowIndex = _gridMenu.Rows.Add(
                    item.Name,
                    item.Category,
                    $"{item.Price:N0} ETB",
                    item.IsAvailable ? "Available" : "Unavailable",
                    "View"
                );
                _gridMenu.Rows[rowIndex].Tag = item;
            }
        }
    }

    private void GridMenu_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
    {
        if (e.RowIndex < 0 || e.Graphics == null) return;

        int availColIndex = _gridMenu.Columns["ColAvailability"]?.Index ?? -1;

        // Draw Availability column as rounded badge
        if (availColIndex >= 0 && e.ColumnIndex == availColIndex && e.Value != null)
        {
            e.Paint(e.ClipBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border);

            string status = e.Value.ToString() ?? string.Empty;
            bool isAvailable = status.Equals("Available", StringComparison.OrdinalIgnoreCase);

            Color bg = isAvailable ? AppTheme.StatusReadyBg : AppTheme.StatusPreparingBg;
            Color text = isAvailable ? AppTheme.StatusReadyText : AppTheme.StatusPreparingText;

            int badgeWidth = 90;
            int badgeHeight = 24;
            int x = e.CellBounds.X + 8;
            int y = e.CellBounds.Y + (e.CellBounds.Height - badgeHeight) / 2;
            var badgeRect = new Rectangle(x, y, badgeWidth, badgeHeight);

            using var brush = new SolidBrush(bg);
            using var path = GetRoundedRectangle(badgeRect, 6);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillPath(brush, path);

            TextRenderer.DrawText(
                e.Graphics,
                status,
                AppTheme.SmallBold,
                badgeRect,
                text,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );

            e.Handled = true;
        }
    }

    private void GridMenu_CellContentClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        int actionColIndex = _gridMenu.Columns["ColAction"]?.Index ?? -1;
        if (actionColIndex >= 0 && e.ColumnIndex == actionColIndex)
        {
            if (_gridMenu.Rows[e.RowIndex].Tag is MenuItem item)
            {
                string status = item.IsAvailable ? "Available" : "Currently Unavailable";
                MessageBox.Show(
                    $"Menu Item: {item.Name}\nCategory: {item.Category}\nPrice: {item.Price:N0} ETB\nAvailability: {status}",
                    $"Menu Item Details — {item.Name}",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }

    private static GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
    {
        var path = new GraphicsPath();
        int diameter = radius * 2;
        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
        path.CloseFigure();
        return path;
    }
}
