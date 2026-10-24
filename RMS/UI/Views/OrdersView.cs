using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using RMS.Common;
using RMS.Models;
using RMS.Services;
using RMS.UI.Dialogs;
using RMS.UI.Navigation;

namespace RMS.UI.Views;

/// <summary>
/// Orders management screen view providing multi-column search, status filtering,
/// order cancellation, and single-step status advancement.
/// Matches all states in UI/orders/Orders.jpg and Orders2.jpg.
/// </summary>
public class OrdersView : BaseView
{
    private readonly RestaurantStore _store = RestaurantStore.Instance;
    private readonly OrderService _orderService = new();

    // Filters
    private string _searchQuery = string.Empty;
    private OrderStatus? _statusFilter = null;

    // Controls
    private readonly Button _btnNewOrder;
    private readonly TextBox _txtSearch;
    private readonly Button _btnClearSearch;
    private readonly ComboBox _cboStatusFilter;
    private readonly Button _btnClearFilters;

    private readonly Label _lblOrdersSummary;
    private readonly Label _lblResultDetails;

    private readonly DataGridView _gridOrders;
    private readonly Panel _pnlEmptyState;
    private readonly Label _lblFooterLeft;
    private readonly Label _lblFooterRight;

    public OrdersView() : base("Orders", "Search and manage restaurant orders")
    {
        // Top "+ New Order" Button on Header
        _btnNewOrder = new Button
        {
            Text = "+ New Order",
            Font = AppTheme.BodyBold,
            ForeColor = Color.White,
            BackColor = AppTheme.PrimaryButton,
            FlatStyle = FlatStyle.Flat,
            Size = new Size(130, 38),
            Anchor = AnchorStyles.Top | AnchorStyles.Right,
            Cursor = Cursors.Hand
        };
        _btnNewOrder.FlatAppearance.BorderSize = 0;
        _btnNewOrder.Location = new Point(HeaderPanel.Width - 160, 18);
        _btnNewOrder.Click += (s, e) => Navigate(ViewType.NewOrder);
        HeaderPanel.Controls.Add(_btnNewOrder);
        HeaderPanel.Resize += (s, e) =>
        {
            _btnNewOrder.Location = new Point(HeaderPanel.Width - 160, 18);
        };

        // ----------------------------------------------------
        // 1. Search and Status Filter Toolbar
        // ----------------------------------------------------
        var pnlFilterBar = new Panel
        {
            Dock = DockStyle.Top,
            Height = 48,
            BackColor = AppTheme.ContentBackground
        };

        // Search Input Box
        var pnlSearchBox = new Panel
        {
            Location = new Point(0, 4),
            Size = new Size(360, 38),
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
            Width = 290,
            PlaceholderText = "Search by order number, customer, or table..."
        };

        _btnClearSearch = new Button
        {
            Text = "✕",
            Font = AppTheme.SmallBold,
            ForeColor = AppTheme.TextMuted,
            BackColor = Color.Transparent,
            FlatStyle = FlatStyle.Flat,
            Size = new Size(24, 24),
            Location = new Point(330, 7),
            Cursor = Cursors.Hand,
            Visible = false
        };
        _btnClearSearch.FlatAppearance.BorderSize = 0;
        _btnClearSearch.Click += (s, e) =>
        {
            _txtSearch.Text = string.Empty;
            _txtSearch.Focus();
        };

        pnlSearchBox.Controls.Add(lblSearchIcon);
        pnlSearchBox.Controls.Add(_txtSearch);
        pnlSearchBox.Controls.Add(_btnClearSearch);
        pnlFilterBar.Controls.Add(pnlSearchBox);

        // Status Filter Dropdown
        _cboStatusFilter = new ComboBox
        {
            Font = AppTheme.BodyRegular,
            Location = new Point(380, 8),
            Size = new Size(150, 32),
            DropDownStyle = ComboBoxStyle.DropDownList
        };
        _cboStatusFilter.Items.Add("All Statuses");
        _cboStatusFilter.Items.Add("Pending");
        _cboStatusFilter.Items.Add("Preparing");
        _cboStatusFilter.Items.Add("Ready");
        _cboStatusFilter.Items.Add("Completed");
        _cboStatusFilter.Items.Add("Cancelled");
        _cboStatusFilter.SelectedIndex = 0;
        _cboStatusFilter.SelectedIndexChanged += (s, e) =>
        {
            if (_cboStatusFilter.SelectedIndex == 0)
            {
                _statusFilter = null;
            }
            else
            {
                _statusFilter = Enum.Parse<OrderStatus>(_cboStatusFilter.SelectedItem?.ToString() ?? "Pending");
            }
            ApplyFilters();
        };
        pnlFilterBar.Controls.Add(_cboStatusFilter);

        // Clear Filters Button
        _btnClearFilters = new Button
        {
            Text = "Clear Filters",
            Font = AppTheme.SmallBold,
            ForeColor = AppTheme.TextPrimary,
            BackColor = Color.White,
            FlatStyle = FlatStyle.Flat,
            Size = new Size(110, 34),
            Location = new Point(545, 6),
            Cursor = Cursors.Hand
        };
        _btnClearFilters.FlatAppearance.BorderColor = AppTheme.CardBorder;
        _btnClearFilters.Click += (s, e) => ResetFilters();
        pnlFilterBar.Controls.Add(_btnClearFilters);

        // Wire search input changes after controls are initialized
        _txtSearch.TextChanged += (s, e) =>
        {
            _searchQuery = _txtSearch.Text.Trim();
            _btnClearSearch.Visible = !string.IsNullOrEmpty(_searchQuery);
            ApplyFilters();
        };

        // ----------------------------------------------------
        // 2. Subtitle / Summary Bar
        // ----------------------------------------------------
        var pnlSubBar = new Panel
        {
            Dock = DockStyle.Top,
            Height = 32,
            BackColor = AppTheme.ContentBackground
        };

        _lblOrdersSummary = new Label
        {
            Text = "Orders Today",
            Font = AppTheme.SmallBold,
            ForeColor = AppTheme.TextSecondary,
            Dock = DockStyle.Left,
            TextAlign = ContentAlignment.MiddleLeft
        };

        _lblResultDetails = new Label
        {
            Text = string.Empty,
            Font = AppTheme.SmallRegular,
            ForeColor = AppTheme.TextSecondary,
            Dock = DockStyle.Right,
            TextAlign = ContentAlignment.MiddleRight
        };

        pnlSubBar.Controls.Add(_lblOrdersSummary);
        pnlSubBar.Controls.Add(_lblResultDetails);

        // ----------------------------------------------------
        // 3. Orders DataGridView Table Card
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

        _gridOrders = new DataGridView
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

        _gridOrders.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
        {
            BackColor = Color.White,
            ForeColor = AppTheme.TextSecondary,
            Font = AppTheme.SmallBold,
            SelectionBackColor = Color.White,
            SelectionForeColor = AppTheme.TextSecondary,
            Padding = new Padding(10, 8, 10, 8)
        };
        _gridOrders.ColumnHeadersHeight = 38;
        _gridOrders.DefaultCellStyle = new DataGridViewCellStyle
        {
            BackColor = Color.White,
            ForeColor = AppTheme.TextPrimary,
            Font = AppTheme.BodyRegular,
            SelectionBackColor = Color.FromArgb(249, 250, 251),
            SelectionForeColor = AppTheme.TextPrimary,
            Padding = new Padding(10, 0, 10, 0)
        };

        _gridOrders.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColOrderNum", HeaderText = "Order #", FillWeight = 14, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
        _gridOrders.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColCustomer", HeaderText = "Customer", FillWeight = 20, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
        _gridOrders.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColTable", HeaderText = "Table", FillWeight = 14, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
        _gridOrders.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColCreated", HeaderText = "Created", FillWeight = 14, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
        _gridOrders.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColTotal", HeaderText = "Total", FillWeight = 16, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
        _gridOrders.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColStatus", HeaderText = "Status", FillWeight = 16, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
        _gridOrders.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColActions", HeaderText = "Actions", FillWeight = 26, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });

        _gridOrders.CellPainting += GridOrders_CellPainting;
        _gridOrders.CellMouseClick += GridOrders_CellMouseClick;

        pnlTableCard.Controls.Add(_gridOrders);

        // ----------------------------------------------------
        // 4. Empty State Panel
        // ----------------------------------------------------
        _pnlEmptyState = CreateEmptyStatePanel();
        pnlTableCard.Controls.Add(_pnlEmptyState);

        // ----------------------------------------------------
        // 5. Bottom Info & Footer Strip
        // ----------------------------------------------------
        var pnlBottomContainer = new Panel
        {
            Dock = DockStyle.Bottom,
            Height = 60,
            BackColor = AppTheme.ContentBackground
        };

        var lblLockNote = new Label
        {
            Text = "ⓘ Completed orders cannot be edited or cancelled. View remains available.",
            Font = AppTheme.SmallRegular,
            ForeColor = AppTheme.TextMuted,
            Dock = DockStyle.Top,
            Height = 24,
            TextAlign = ContentAlignment.MiddleLeft,
            Padding = new Padding(4, 2, 0, 0)
        };

        var pnlFooter = new Panel
        {
            Dock = DockStyle.Bottom,
            Height = 32,
            BackColor = AppTheme.ContentBackground,
            Padding = new Padding(4, 4, 4, 0)
        };

        _lblFooterLeft = new Label
        {
            Text = "Showing 12 of 12 orders today",
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

        pnlBottomContainer.Controls.Add(lblLockNote);
        pnlBottomContainer.Controls.Add(pnlFooter);

        // Assemble Layout
        ContentPanel.Controls.Add(pnlTableCard);
        ContentPanel.Controls.Add(pnlBottomContainer);
        ContentPanel.Controls.Add(pnlSubBar);
        ContentPanel.Controls.Add(pnlFilterBar);

        // Wire Store updates
        _store.OnOrdersChanged += () =>
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
            Size = new Size(420, 200),
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
            Text = "No orders match your search.",
            Font = AppTheme.HeaderMedium,
            ForeColor = AppTheme.TextPrimary,
            TextAlign = ContentAlignment.MiddleCenter,
            Dock = DockStyle.Top,
            Height = 32
        };

        var lblSubtitle = new Label
        {
            Text = "Try another order number, customer, or table, or clear your search.",
            Font = AppTheme.BodyRegular,
            ForeColor = AppTheme.TextSecondary,
            TextAlign = ContentAlignment.MiddleCenter,
            Dock = DockStyle.Top,
            Height = 40
        };

        var btnClear = new Button
        {
            Text = "Clear Search",
            Font = AppTheme.BodyBold,
            ForeColor = Color.White,
            BackColor = AppTheme.PrimaryButton,
            FlatStyle = FlatStyle.Flat,
            Size = new Size(130, 36),
            Cursor = Cursors.Hand
        };
        btnClear.FlatAppearance.BorderSize = 0;
        btnClear.Location = new Point((centerBox.Width - btnClear.Width) / 2, 126);
        btnClear.Click += (s, e) => ResetFilters();

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

    public override void OnNavigatedTo(object? parameter = null)
    {
        base.OnNavigatedTo(parameter);
        ApplyFilters();
    }

    private void ResetFilters()
    {
        _txtSearch.Text = string.Empty;
        _cboStatusFilter.SelectedIndex = 0;
        _statusFilter = null;
        ApplyFilters();
    }

    private void ApplyFilters()
    {
        if (IsDisposed || Disposing || _gridOrders.IsDisposed || _gridOrders.Columns.Count == 0) return;

        var filteredList = _orderService.FilterOrders(_searchQuery, _statusFilter).ToList();
        int totalOrders = _store.Orders.Count;

        // Update Subtitle & Footers
        if (string.IsNullOrEmpty(_searchQuery) && _statusFilter == null)
        {
            _lblOrdersSummary.Text = "Orders Today";
            _lblResultDetails.Text = $"{filteredList.Count} orders";
            _lblFooterRight.Text = string.Empty;
        }
        else
        {
            _lblOrdersSummary.Text = "Search & Filter Results";
            _lblResultDetails.Text = $"{filteredList.Count} {(filteredList.Count == 1 ? "order" : "orders")}";
            _lblFooterRight.Text = !string.IsNullOrEmpty(_searchQuery) ? $"Search results for \"{_searchQuery}\"" : string.Empty;
        }

        _lblFooterLeft.Text = $"Showing {filteredList.Count} of {totalOrders} orders today";

        // Toggle Empty State vs Grid
        if (filteredList.Count == 0)
        {
            _gridOrders.Visible = false;
            _pnlEmptyState.Visible = true;
            _pnlEmptyState.BringToFront();
        }
        else
        {
            _pnlEmptyState.Visible = false;
            _gridOrders.Visible = true;

            _gridOrders.Rows.Clear();
            foreach (var order in filteredList)
            {
                int rowIndex = _gridOrders.Rows.Add(
                    $"#{order.OrderNumber}",
                    order.CustomerName,
                    $"Table {order.TableNumber}",
                    order.CreatedAt.ToString("h:mm tt"),
                    $"{order.Total:N0} ETB",
                    order.Status.ToString(),
                    string.Empty // Custom painted in CellPainting
                );
                _gridOrders.Rows[rowIndex].Tag = order;
            }
        }
    }

    private void GridOrders_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
    {
        if (e.RowIndex < 0 || e.Graphics == null) return;

        // 1. Order Number: Burgundy Bold styling
        int orderNumCol = _gridOrders.Columns["ColOrderNum"]?.Index ?? -1;
        if (orderNumCol >= 0 && e.ColumnIndex == orderNumCol && e.Value != null)
        {
            e.Paint(e.ClipBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border);
            TextRenderer.DrawText(
                e.Graphics,
                e.Value.ToString(),
                AppTheme.BodyBold,
                e.CellBounds,
                AppTheme.PrimaryButton,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.LeftAndRightPadding
            );
            e.Handled = true;
            return;
        }

        // 2. Status Badge Column
        int statusCol = _gridOrders.Columns["ColStatus"]?.Index ?? -1;
        if (statusCol >= 0 && e.ColumnIndex == statusCol && e.Value != null)
        {
            e.Paint(e.ClipBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border);

            string statusText = e.Value.ToString() ?? "";
            Enum.TryParse<OrderStatus>(statusText, out var status);

            Color bg;
            Color text;
            switch (status)
            {
                case OrderStatus.Pending:
                    bg = AppTheme.StatusPendingBg;
                    text = AppTheme.StatusPendingText;
                    break;
                case OrderStatus.Preparing:
                    bg = AppTheme.StatusPreparingBg;
                    text = AppTheme.StatusPreparingText;
                    break;
                case OrderStatus.Ready:
                    bg = AppTheme.StatusReadyBg;
                    text = AppTheme.StatusReadyText;
                    break;
                case OrderStatus.Completed:
                    bg = AppTheme.StatusCompletedBg;
                    text = AppTheme.StatusCompletedText;
                    break;
                case OrderStatus.Cancelled:
                default:
                    bg = AppTheme.StatusCancelledBg;
                    text = AppTheme.StatusCancelledText;
                    break;
            }

            int badgeWidth = 84;
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
                statusText,
                AppTheme.SmallBold,
                badgeRect,
                text,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );

            e.Handled = true;
            return;
        }

        // 3. Actions Column: View | Edit | Change Status | Cancel
        int actionsCol = _gridOrders.Columns["ColActions"]?.Index ?? -1;
        if (actionsCol >= 0 && e.ColumnIndex == actionsCol)
        {
            e.Paint(e.ClipBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border);

            if (_gridOrders.Rows[e.RowIndex].Tag is Order order)
            {
                string actionText;
                if (order.Status == OrderStatus.Completed)
                {
                    actionText = "View  •  🔒 Locked";
                }
                else if (order.Status == OrderStatus.Cancelled)
                {
                    actionText = "View  •  🚫 Cancelled";
                }
                else
                {
                    actionText = "View  |  Edit  |  Change Status  |  Cancel";
                }

                TextRenderer.DrawText(
                    e.Graphics,
                    actionText,
                    AppTheme.SmallBold,
                    e.CellBounds,
                    order.CanEdit ? AppTheme.PrimaryButton : AppTheme.TextMuted,
                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.LeftAndRightPadding
                );
            }

            e.Handled = true;
        }
    }

    private void GridOrders_CellMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
    {
        if (e.RowIndex < 0) return;

        int actionsCol = _gridOrders.Columns["ColActions"]?.Index ?? -1;
        if (actionsCol >= 0 && e.ColumnIndex == actionsCol)
        {
            if (_gridOrders.Rows[e.RowIndex].Tag is not Order order) return;

            // Determine which action segment was clicked based on click X position
            int cellX = e.X;

            if (order.Status == OrderStatus.Completed)
            {
                if (cellX < 50)
                {
                    Navigate(ViewType.OrderDetails, order.OrderNumber);
                }
                else
                {
                    MessageBox.Show(
                        $"Order #{order.OrderNumber} · {order.CustomerName} · Table {order.TableNumber} [Completed]\nThis order is completed and cannot be edited or cancelled. You can still view this order.",
                        "Order Locked",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                return;
            }

            if (order.Status == OrderStatus.Cancelled)
            {
                Navigate(ViewType.OrderDetails, order.OrderNumber);
                return;
            }

            // Active order action layout: "View  |  Edit  |  Change Status  |  Cancel"
            if (cellX < 45)
            {
                // Clicked View
                Navigate(ViewType.OrderDetails, order.OrderNumber);
            }
            else if (cellX < 85)
            {
                // Clicked Edit
                Navigate(ViewType.EditOrder, order.OrderNumber);
            }
            else if (cellX < 190)
            {
                // Clicked Change Status
                PromptChangeStatus(order);
            }
            else
            {
                // Clicked Cancel
                PromptCancelOrder(order);
            }
        }
    }

    private void PromptChangeStatus(Order order)
    {
        if (!_orderService.CanAdvanceStatus(order.Status, out var nextStatus) || nextStatus == null)
        {
            MessageBox.Show($"Order #{order.OrderNumber} with status '{order.Status}' cannot advance further.",
                "Status Limit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        using var dlg = new ChangeStatusDialog(order, nextStatus.Value);
        if (dlg.ShowDialog(this) == DialogResult.OK && dlg.IsConfirmed)
        {
            _orderService.AdvanceOrderStatus(order.OrderNumber);
            ApplyFilters();
        }
    }

    private void PromptCancelOrder(Order order)
    {
        if (!order.CanCancel)
        {
            MessageBox.Show($"Order #{order.OrderNumber} cannot be cancelled.", "Cancel Not Allowed",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string message = $"Are you sure you want to cancel Order #{order.OrderNumber}?\n#{order.OrderNumber} • {order.CustomerName} • Table {order.TableNumber} • {order.Status}";
        if (ConfirmationDialog.Confirm(this, "Cancel Order?", "Cancel Order?", message, "Yes, Cancel Order", isDanger: true))
        {
            _orderService.CancelOrder(order.OrderNumber);
            ApplyFilters();
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
