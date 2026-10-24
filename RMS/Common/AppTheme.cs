using System.Drawing;

namespace RMS.Common;

/// <summary>
/// Centralized styling tokens and design system constants
/// matching the approved UI reference designs.
/// </summary>
public static class AppTheme
{
    // Primary Sidebar & Shell Colors
    public static readonly Color SidebarBackground = Color.FromArgb(46, 24, 29);       // Deep warm burgundy (#2E181D)
    public static readonly Color SidebarHover = Color.FromArgb(64, 34, 41);            // Hover state (#402229)
    public static readonly Color SidebarActive = Color.FromArgb(122, 32, 48);          // Active item pill (#7A2030)
    public static readonly Color SidebarText = Color.FromArgb(235, 225, 226);          // Soft off-white text
    public static readonly Color SidebarMutedText = Color.FromArgb(170, 145, 149);     // Muted labels (#AA9195)
    public static readonly Color GoldAccent = Color.FromArgb(212, 163, 115);           // Warm Gold (#D4A373)
    public static readonly Color GoldBadgeBackground = Color.FromArgb(80, 45, 52);

    // Content Canvas Colors
    public static readonly Color ContentBackground = Color.FromArgb(248, 246, 244);    // Very light warm gray (#F8F6F4)
    public static readonly Color CardBackground = Color.White;
    public static readonly Color CardBorder = Color.FromArgb(235, 230, 225);           // Subtle border (#EBE6E1)
    public static readonly Color HeaderBackground = Color.White;
    public static readonly Color StatusStripBackground = Color.FromArgb(250, 249, 248);

    // Typography Colors
    public static readonly Color TextPrimary = Color.FromArgb(31, 41, 55);              // Dark charcoal (#1F2937)
    public static readonly Color TextSecondary = Color.FromArgb(107, 114, 128);        // Muted gray (#6B7280)
    public static readonly Color TextMuted = Color.FromArgb(156, 163, 175);            // Light gray (#9CA3AF)

    // Action Button Colors
    public static readonly Color PrimaryButton = Color.FromArgb(122, 32, 48);          // Burgundy (#7A2030)
    public static readonly Color PrimaryButtonHover = Color.FromArgb(100, 25, 39);     // Darker burgundy (#641927)
    public static readonly Color SecondaryButtonBorder = Color.FromArgb(209, 213, 219);// Light gray border (#D1D5DB)
    public static readonly Color DangerButton = Color.FromArgb(185, 28, 28);           // Red (#B91C1C)
    public static readonly Color DangerButtonHover = Color.FromArgb(153, 27, 27);

    // Order Status Badges (Background, Text)
    public static readonly Color StatusPendingBg = Color.FromArgb(254, 243, 199);      // Amber (#FEF3C7)
    public static readonly Color StatusPendingText = Color.FromArgb(146, 64, 14);       // Dark amber (#92400E)

    public static readonly Color StatusPreparingBg = Color.FromArgb(255, 237, 213);    // Orange (#FFEDD5)
    public static readonly Color StatusPreparingText = Color.FromArgb(154, 52, 18);     // Dark orange (#9A3412)

    public static readonly Color StatusReadyBg = Color.FromArgb(209, 250, 229);        // Green (#D1FAE5)
    public static readonly Color StatusReadyText = Color.FromArgb(6, 95, 70);          // Dark green (#065F46)

    public static readonly Color StatusCompletedBg = Color.FromArgb(226, 232, 240);    // Slate gray (#E2E8F0)
    public static readonly Color StatusCompletedText = Color.FromArgb(71, 85, 105);     // Dark slate (#475569)

    public static readonly Color StatusCancelledBg = Color.FromArgb(254, 226, 226);    // Soft red (#FEE2E2)
    public static readonly Color StatusCancelledText = Color.FromArgb(153, 27, 27);     // Dark red (#991B1B)

    // Typography
    public static readonly Font HeaderLarge = new("Segoe UI", 16f, FontStyle.Bold);
    public static readonly Font HeaderMedium = new("Segoe UI", 12f, FontStyle.Bold);
    public static readonly Font SectionTitle = new("Segoe UI", 10.5f, FontStyle.Bold);
    public static readonly Font Subtitle = new("Segoe UI", 9f, FontStyle.Regular);
    public static readonly Font BodyRegular = new("Segoe UI", 9.5f, FontStyle.Regular);
    public static readonly Font BodyBold = new("Segoe UI", 9.5f, FontStyle.Bold);
    public static readonly Font SmallRegular = new("Segoe UI", 8.5f, FontStyle.Regular);
    public static readonly Font SmallBold = new("Segoe UI", 8.5f, FontStyle.Bold);
    public static readonly Font NavItemFont = new("Segoe UI", 10f, FontStyle.Regular);
    public static readonly Font NavItemActiveFont = new("Segoe UI", 10f, FontStyle.Bold);
    public static readonly Font KpiNumberFont = new("Segoe UI", 22f, FontStyle.Bold);
}
