using System;
using System.Windows.Forms;
using RMS.UI;
using RMS.UI.Dialogs;

namespace RMS;

internal static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// Shows the Sign In dialog first, then launches MainForm with the authenticated role.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        using var login = new LoginDialog();
        if (login.ShowDialog() == DialogResult.OK)
        {
            Application.Run(new MainForm());
        }
    }
}
