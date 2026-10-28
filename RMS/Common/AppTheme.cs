using System.Drawing;

namespace RMS.Common;

/// <summary>
/// Centralized styling tokens and design system constants
/// matching the approved UI reference designs.
/// </summary>
public static class AppTheme
{
    // Primary Sidebar & Shell Colors (Classic Windows Corporate Slate/Navy)
    public static readonly Color SidebarBackground = Color.FromArgb(30, 41, 59);       // Professional Slate (#1E293B)
    public static readonly Color SidebarHover = Color.FromArgb(51, 65, 85);            // Slate hover (#334155)
    public static readonly Color SidebarActive = Color.FromArgb(37, 99, 235);          // Corporate Blue highlight (#2563EB)
    public static readonly Color SidebarText = Color.FromArgb(248, 250, 252);          // Clean white text
    public static readonly Color SidebarMutedText = Color.FromArgb(148, 163, 184);     // Muted section labels (#94A3B8)
    public static readonly Color GoldAccent = Color.FromArgb(96, 165, 250);            // Corporate soft blue (#60A5FA)
    public static readonly Color GoldBadgeBackground = Color.FromArgb(30, 58, 95);     // Navy badge (#1E3A5F)

    // Content Canvas Colors
    public static readonly Color ContentBackground = Color.FromArgb(243, 244, 246);    // Standard Windows Desktop Light Gray (#F3F4F6)
    public static readonly Color CardBackground = Color.White;
    public static readonly Color CardBorder = Color.FromArgb(226, 232, 240);           // Standard border (#E2E8F0)
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
