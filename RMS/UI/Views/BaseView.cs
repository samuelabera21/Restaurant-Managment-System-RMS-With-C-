using System.Drawing;
using System.Windows.Forms;
using RMS.Common;
using RMS.UI.Navigation;

namespace RMS.UI.Views;

/// <summary>
/// Base UserControl for application screen views.
/// Provides consistent background, header layout, and navigation delegation.
/// </summary>
public abstract class BaseView : UserControl, INavigationAware
{
    [System.ComponentModel.Browsable(false)]
    [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
    public Action<ViewType, object?>? NavigateAction { get; set; }

    protected Panel HeaderPanel { get; private set; }
    protected Label TitleLabel { get; private set; }
    protected Label SubtitleLabel { get; private set; }
    protected Panel ContentPanel { get; private set; }

    protected BaseView(string title, string subtitle)
    {
        Dock = DockStyle.Fill;
        BackColor = AppTheme.ContentBackground;

        HeaderPanel = new Panel
        {
            Dock = DockStyle.Top,
            Height = 76,
            BackColor = AppTheme.ContentBackground,
            Padding = new Padding(28, 12, 28, 8)
        };

        TitleLabel = new Label
        {
            Text = title,
            Font = AppTheme.HeaderLarge,
            ForeColor = AppTheme.TextPrimary,
            AutoSize = true,
            Location = new Point(28, 12)
        };

        SubtitleLabel = new Label
        {
            Text = subtitle,
            Font = AppTheme.Subtitle,
            ForeColor = AppTheme.TextSecondary,
            AutoSize = true,
            Location = new Point(28, 46)
        };

        HeaderPanel.Controls.Add(TitleLabel);
        HeaderPanel.Controls.Add(SubtitleLabel);

        ContentPanel = new Panel
        {
            Dock = DockStyle.Fill,
            BackColor = AppTheme.ContentBackground,
            Padding = new Padding(28, 8, 28, 20),
            AutoScroll = false
        };

        // Add HeaderPanel first so it docks to Top at Y=0; ContentPanel docks to Fill below it.
        Controls.Add(HeaderPanel);
        Controls.Add(ContentPanel);
        HeaderPanel.SendToBack();
    }

    public virtual void OnNavigatedTo(object? parameter = null)
    {
        // Derived classes override this to refresh data upon being loaded
    }

    protected void Navigate(ViewType targetView, object? context = null)
    {
        NavigateAction?.Invoke(targetView, context);
    }
}
