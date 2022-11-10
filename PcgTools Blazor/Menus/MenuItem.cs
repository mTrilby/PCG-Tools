#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

namespace PcgTools_Blazor.Menus;

public struct MenuItem
{
    private MenuItem(bool isDivider)
    {
        Name = string.Empty;
        HRef = string.Empty;
        IsDivider = isDivider;
        IsDisabled = false;
        MenuIcon = MenuIcon.Empty();
        OnClick = null;
    }

    public MenuItem(string name, string hrefLink, bool isDisabled, MenuIcon menuIcon)
    {
        Name = name;
        HRef = hrefLink;
        IsDivider = false;
        IsDisabled = isDisabled;
        MenuIcon = menuIcon;
        OnClick = null;
    }

    public string Name { get; init; }
    public string HRef { get; init; }
    public bool IsDisabled { get; init; }
    public bool IsDivider { get; init; }
    public MenuIcon MenuIcon { get; init; }
    public Func<EventArgs>? OnClick { get; init; }

    public static MenuItem CreateEnabled(string name, string href) =>
        new(name, href, false, MenuIcon.Empty());

    public static MenuItem CreateDisabled(string name) =>
        new(name, string.Empty, true, MenuIcon.Empty());

    public static MenuItem CreateWithIcon(string name, string href, bool isDisabled, MenuIcon icon) =>
        new(name, href, isDisabled, icon);

    public static MenuItem CreateDivider() =>
        new(true);
}