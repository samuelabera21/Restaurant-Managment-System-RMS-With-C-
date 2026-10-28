using System.Drawing;
using System.Windows.Forms;
using RMS.Common;
using RMS.UI.Navigation;

namespace RMS.UI.Views;

/// <summary>
/// Base UserControl for application screen views.
/// Provides consistent background, navigation delegation, and designer support.
/// </summary>
public class BaseView : UserControl, INavigationAware
{
    [System.ComponentModel.Browsable(false)]
    [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
    public Action<ViewType, object?>? NavigateAction { get; set; }

    // Properties for views utilizing base header/content panels
    protected Panel HeaderPanel { get; set; } = null!;
    protected Label TitleLabel { get; set; } = null!;
    protected Label SubtitleLabel { get; set; } = null!;
    protected Panel ContentPanel { get; set; } = null!;

    /// <summary>
    /// Parameterless constructor enabling full Visual Studio Windows Forms Designer support.
    /// </summary>
    public BaseView()
    {
        Dock = DockStyle.Fill;
        BackColor = AppTheme.ContentBackground;
        Font = AppTheme.BodyRegular;
    }

    /// <summary>
    /// Constructor for legacy views that utilize base header and content panels.
    /// </summary>
    protected BaseView(string title, string subtitle) : this()
    {
        HeaderPanel = new Panel
        {
            Dock = DockStyle.Top,
            Height = 70,
            BackColor = AppTheme.ContentBackground,
            Padding = new Padding(24, 8, 24, 4)
        };

        TitleLabel = new Label
        {
            Text = title,
            Font = AppTheme.HeaderLarge,
            ForeColor = AppTheme.TextPrimary,
            AutoSize = true,
            Location = new Point(24, 10)
        };

        SubtitleLabel = new Label
        {
            Text = subtitle,
            Font = AppTheme.Subtitle,
            ForeColor = AppTheme.TextSecondary,
            AutoSize = true,
            Location = new Point(24, 42)
        };

        HeaderPanel.Controls.Add(TitleLabel);
        HeaderPanel.Controls.Add(SubtitleLabel);

        ContentPanel = new Panel
        {
            Dock = DockStyle.Fill,
            BackColor = AppTheme.ContentBackground,
            Padding = new Padding(24, 0, 24, 16),
            AutoScroll = true
        };

        Controls.Add(ContentPanel);
        Controls.Add(HeaderPanel);
        HeaderPanel.SendToBack();
    }

    public virtual void OnNavigatedTo(object? parameter = null)
    {
        // Derived views override this to refresh data upon being displayed
    }

    protected void Navigate(ViewType targetView, object? context = null)
    {
        NavigateAction?.Invoke(targetView, context);
    }
}
