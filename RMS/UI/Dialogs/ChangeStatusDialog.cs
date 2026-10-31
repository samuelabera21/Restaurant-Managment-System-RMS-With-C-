using System;
using System.Drawing;
using System.Windows.Forms;
using RMS.Common;
using RMS.Models;

namespace RMS.UI.Dialogs;

/// <summary>
/// Confirmation dialog for advancing an order's status exactly one stage.
/// Fully compatible with the Visual Studio Form Designer.
/// </summary>
public partial class ChangeStatusDialog : Form
{
    public bool IsConfirmed { get; private set; }

    /// <summary>
    /// Parameterless constructor required by the Visual Studio Designer.
    /// </summary>
    public ChangeStatusDialog()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Runtime constructor initializing the dialog with live order and target status.
    /// </summary>
    public ChangeStatusDialog(Order order, OrderStatus nextStatus) : this()
    {
        ArgumentNullException.ThrowIfNull(order);

        lblHeading.Text = $"Advance Status for Order {order.OrderNumber}?";
        lblDetails.Text = $"Customer: {order.CustomerName}  •  Table {order.TableNumber}  •  Total: {order.Total:N0} ETB";

        lblCurrentStatus.Text = order.Status.ToString();
        lblNextStatus.Text = nextStatus.ToString();
        btnConfirm.Text = $"Advance to {nextStatus}";
    }

    private void btnConfirm_Click(object? sender, EventArgs e)
    {
        IsConfirmed = true;
        DialogResult = DialogResult.OK;
        Close();
    }

    private void btnCancel_Click(object? sender, EventArgs e)
    {
        IsConfirmed = false;
        DialogResult = DialogResult.Cancel;
        Close();
    }
}
