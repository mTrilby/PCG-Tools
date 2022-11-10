#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using MudBlazor;

namespace PcgTools_Blazor.Menus;

public struct ToolbarItem
{
    private ToolbarItem(bool isSpacer)
    {
        IsSpacer = isSpacer;
        Icon = Icons.Material.Outlined.Window;
        HRef = string.Empty;
        Tooltip = string.Empty;
        IsDisabled = false;
        IconColor = Color.Default;
        CustomClass = string.Empty;
    }

    public ToolbarItem(string icon, string href, string tooltip, bool isDisabled, Color color, string className)
    {
        IsSpacer = false;
        Icon = icon;
        HRef = href;
        Tooltip = tooltip;
        IsDisabled = isDisabled;
        IconColor = color;
        CustomClass = className;
    }

    public bool IsSpacer { get; init; }
    public string Icon { get; init; }
    public string HRef { get; init; }
    public string Tooltip { get; init; }
    public bool IsDisabled { get; init; }
    public Color IconColor { get; init; }
    public string CustomClass { get; init; }

    public static ToolbarItem GetSpacerIcon() =>
        new(true);

    public static ToolbarItem GetEnabledIcon(string icon, string href, string tooltip, Color color = Color.Inherit, string className = "") =>
        new(icon, href, tooltip, false, color, className);

    public static ToolbarItem GetDisabledIcon(string icon, string href, string tooltip, Color color = Color.Inherit, string className = "") =>
        new (icon, href, tooltip, true, color, className);
}