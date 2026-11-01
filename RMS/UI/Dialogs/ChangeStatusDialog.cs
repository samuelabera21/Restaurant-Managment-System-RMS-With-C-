using System;
using System.Drawing;
using System.Windows.Forms;
using RMS.Common;
using RMS.Models;

namespace RMS.UI.Dialogs;

// Dialog for advancing an order status one stage forward
public partial class ChangeStatusDialog : Form
{
    public bool IsConfirmed { get; private set; }

    // Parameterless constructor for Visual Studio Designer
    public ChangeStatusDialog()
    {
        InitializeComponent();
    }

    // Runtime constructor with target order and next status
    public ChangeStatusDialog(Order order, OrderStatus nextStatus) : this()
    {
        ArgumentNullException.ThrowIfNull(order);

        lblHeading.Text = $"Advance Status for Order {order.OrderNumber}?";
        lblDetails.Text = $"Customer: {order.CustomerName}  •  Table {order.TableNumber}  •  Total: {order.Total:N0} ETB";

        lblCurrentStatus.Text = order.Status.ToString();
        lblNextStatus.Text = nextStatus.ToString();
        btnConfirm.Text = $"Advance to {nextStatus}";
    }

    // Confirm status transition
    private void btnConfirm_Click(object sender, EventArgs e)
    {
        IsConfirmed = true;
        DialogResult = DialogResult.OK;
        Close();
    }

    // Cancel status transition
    private void btnCancel_Click(object sender, EventArgs e)
    {
        IsConfirmed = false;
        DialogResult = DialogResult.Cancel;
        Close();
    }
}
