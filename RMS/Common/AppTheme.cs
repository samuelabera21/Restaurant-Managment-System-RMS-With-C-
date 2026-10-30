using System.Drawing;

namespace RMS.Common;

/// <summary>
/// Centralized styling tokens and design system constants
/// matching clean, authentic Windows Forms desktop standards.
/// </summary>
public static class AppTheme
{
    // Primary Sidebar & Shell Colors (Clean Light Desktop Windows Form)
    public static readonly Color SidebarBackground = Color.FromArgb(241, 245, 249);       // Clean light gray (#F1F5F9)
    public static readonly Color SidebarHover = Color.FromArgb(226, 232, 240);            // Subtle hover (#E2E8F0)
    public static readonly Color SidebarActive = Color.FromArgb(30, 58, 95);              // Corporate Navy Blue highlight (#1E3A5F)
    public static readonly Color SidebarText = Color.FromArgb(30, 41, 59);               // Dark text (#1E293B)
    public static readonly Color SidebarMutedText = Color.FromArgb(71, 85, 105);          // Muted section labels (#475569)
    public static readonly Color GoldAccent = Color.FromArgb(71, 85, 105);
    public static readonly Color GoldBadgeBackground = Color.FromArgb(226, 232, 240);

    // Content Canvas Colors
    public static readonly Color ContentBackground = Color.FromArgb(243, 244, 246);    // Standard Windows Desktop Light Gray (#F3F4F6)
    public static readonly Color CardBackground = Color.White;
    public static readonly Color CardBorder = Color.FromArgb(203, 213, 225);           // Standard subtle border (#CBD5E1)
    public static readonly Color HeaderBackground = Color.White;
    public static readonly Color StatusStripBackground = Color.FromArgb(241, 245, 249); // Status bar light gray

    // Typography Colors
    public static readonly Color TextPrimary = Color.FromArgb(15, 23, 42);              // Deep charcoal/black (#0F172A)
    public static readonly Color TextSecondary = Color.FromArgb(71, 85, 105);          // Secondary gray (#475569)
    public static readonly Color TextMuted = Color.FromArgb(148, 163, 184);            // Light gray (#94A3B8)

    // Action Button Colors
    public static readonly Color PrimaryButton = Color.FromArgb(30, 58, 95);          // Classic Navy (#1E3A5F)
    public static readonly Color PrimaryButtonHover = Color.FromArgb(22, 44, 71);     // Darker Navy (#162C47)
    public static readonly Color SecondaryButtonBorder = Color.FromArgb(203, 213, 225);// Light gray border (#CBD5E1)
    public static readonly Color DangerButton = Color.FromArgb(220, 38, 38);           // Standard Red (#DC2626)
    public static readonly Color DangerButtonHover = Color.FromArgb(185, 28, 28);

    // Order Status Badges (Clean, neutral desktop colors)
    public static readonly Color StatusPendingBg = Color.FromArgb(241, 245, 249);
    public static readonly Color StatusPendingText = Color.FromArgb(15, 23, 42);

    public static readonly Color StatusPreparingBg = Color.FromArgb(241, 245, 249);
    public static readonly Color StatusPreparingText = Color.FromArgb(15, 23, 42);

    public static readonly Color StatusReadyBg = Color.FromArgb(241, 245, 249);
    public static readonly Color StatusReadyText = Color.FromArgb(15, 23, 42);

    public static readonly Color StatusCompletedBg = Color.FromArgb(241, 245, 249);
    public static readonly Color StatusCompletedText = Color.FromArgb(71, 85, 105);

    public static readonly Color StatusCancelledBg = Color.FromArgb(241, 245, 249);
    public static readonly Color StatusCancelledText = Color.FromArgb(185, 28, 28);

    // Typography
    public static readonly Font HeaderLarge = new("Segoe UI", 16f, FontStyle.Bold);
    public static readonly Font HeaderMedium = new("Segoe UI", 12f, FontStyle.Bold);
    public static readonly Font SectionTitle = new("Segoe UI", 10.5f, FontStyle.Bold);
    public static readonly Font Subtitle = new("Segoe UI", 9f, FontStyle.Regular);
    public static readonly Font BodyRegular = new("Segoe UI", 9.5f, FontStyle.Regular);
    public static readonly Font BodyBold = new("Segoe UI", 9.5f, FontStyle.Bold);
    public static readonly Font SmallRegular = new("Segoe UI", 8.5f, FontStyle.Regular);
    public static readonly Font SmallBold = new("Segoe UI", 8.5f, FontStyle.Bold);
    public static readonly Font NavItemFont = new("Segoe UI", 9.5f, FontStyle.Regular);
    public static readonly Font NavItemActiveFont = new("Segoe UI", 9.5f, FontStyle.Bold);
    public static readonly Font KpiNumberFont = new("Segoe UI", 20f, FontStyle.Bold);
}
