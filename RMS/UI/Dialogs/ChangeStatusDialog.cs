using System.Drawing;
using System.Windows.Forms;
using RMS.Common;
using RMS.Models;
using RMS.Services;

namespace RMS.UI.Dialogs;

/// <summary>
/// Confirmation dialog for advancing an order's status exactly one stage
/// (Pending -> Preparing -> Ready -> Completed).
/// </summary>
public class ChangeStatusDialog : Form
{
    public bool IsConfirmed { get; private set; }

    public ChangeStatusDialog(Order order, OrderStatus nextStatus)
    {
        Text = "Change Order Status";
        Width = 460;
        Height = 280;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        StartPosition = FormStartPosition.CenterParent;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        BackColor = Color.White;

        var pnlHeader = new Panel
        {
            Dock = DockStyle.Top,
            Height = 44,
            BackColor = Color.White,
            Padding = new Padding(20, 12, 20, 0)
        };

        var lblDialogTitle = new Label
        {
            Text = "Order Status Progression",
            Font = AppTheme.SmallBold,
            ForeColor = AppTheme.TextSecondary,
            AutoSize = true,
            Location = new Point(20, 14)
        };
        pnlHeader.Controls.Add(lblDialogTitle);

        var pnlBody = new Panel
        {
            Dock = DockStyle.Fill,
            Padding = new Padding(24, 8, 24, 16),
            BackColor = Color.White
        };

        var lblHeading = new Label
        {
            Text = $"Advance Status for Order #{order.OrderNumber}?",
            Font = AppTheme.HeaderMedium,
            ForeColor = AppTheme.TextPrimary,
            AutoSize = true,
            Location = new Point(24, 10)
        };

        var lblDetails = new Label
        {
            Text = $"Customer: {order.CustomerName}  •  Table {order.TableNumber}  •  Total: {order.Total:N0} ETB",
            Font = AppTheme.BodyRegular,
            ForeColor = AppTheme.TextSecondary,
            AutoSize = true,
            Location = new Point(24, 42)
        };

        // Transition Box (Current -> Next)
        var pnlTransition = new Panel
        {
            Location = new Point(24, 76),
            Size = new Size(395, 48),
            BackColor = Color.FromArgb(249, 250, 251)
        };
        pnlTransition.Paint += (s, e) =>
        {
            using var pen = new Pen(AppTheme.CardBorder);
            e.Graphics.DrawRectangle(pen, 0, 0, pnlTransition.Width - 1, pnlTransition.Height - 1);
        };

        var badgeCurrent = CreateBadge(order.Status);
        badgeCurrent.Location = new Point(20, 12);

        var lblArrow = new Label
        {
            Text = "→",
            Font = new Font("Segoe UI", 12f, FontStyle.Bold),
            ForeColor = AppTheme.TextSecondary,
            AutoSize = true,
            Location = new Point(160, 14)
        };

        var badgeNext = CreateBadge(nextStatus);
        badgeNext.Location = new Point(220, 12);

        pnlTransition.Controls.Add(badgeCurrent);
        pnlTransition.Controls.Add(lblArrow);
        pnlTransition.Controls.Add(badgeNext);

        var pnlButtons = new Panel
        {
            Dock = DockStyle.Bottom,
            Height = 60,
            BackColor = AppTheme.ContentBackground,
            Padding = new Padding(0, 0, 20, 0)
        };

        var btnConfirm = new Button
        {
            Text = $"Advance to {nextStatus}",
            Font = AppTheme.BodyBold,
            ForeColor = Color.White,
            BackColor = AppTheme.PrimaryButton,
            FlatStyle = FlatStyle.Flat,
            Size = new Size(160, 36),
            Anchor = AnchorStyles.Top | AnchorStyles.Right,
            Location = new Point(pnlButtons.Width - 180, 12),
            Cursor = Cursors.Hand
        };
        btnConfirm.FlatAppearance.BorderSize = 0;
        btnConfirm.Click += (s, e) =>
        {
            IsConfirmed = true;
            DialogResult = DialogResult.OK;
            Close();
        };

        var btnCancel = new Button
        {
            Text = "Cancel",
            Font = AppTheme.BodyRegular,
            ForeColor = AppTheme.TextPrimary,
            BackColor = Color.White,
            FlatStyle = FlatStyle.Flat,
            Size = new Size(90, 36),
            Anchor = AnchorStyles.Top | AnchorStyles.Right,
            Location = new Point(pnlButtons.Width - 280, 12),
            Cursor = Cursors.Hand,
            DialogResult = DialogResult.Cancel
        };
        btnCancel.FlatAppearance.BorderColor = AppTheme.CardBorder;
        btnCancel.Click += (s, e) => Close();

        pnlButtons.Controls.Add(btnConfirm);
        pnlButtons.Controls.Add(btnCancel);

        pnlBody.Controls.Add(lblHeading);
        pnlBody.Controls.Add(lblDetails);
        pnlBody.Controls.Add(pnlTransition);

        Controls.Add(pnlBody);
        Controls.Add(pnlButtons);
        Controls.Add(pnlHeader);

        AcceptButton = btnConfirm;
        CancelButton = btnCancel;
    }

    private static Label CreateBadge(OrderStatus status)
    {
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

        return new Label
        {
            Text = status.ToString(),
            Font = AppTheme.SmallBold,
            ForeColor = text,
            BackColor = bg,
            AutoSize = false,
            Size = new Size(90, 24),
            TextAlign = ContentAlignment.MiddleCenter
        };
    }
}
