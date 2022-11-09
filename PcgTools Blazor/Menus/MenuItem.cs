#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

namespace PcgTools_Blazor.Menus;

public struct MenuItem
{
    private MenuItem(bool isDivider)
    {
        Name = string.Empty;
        IsDivider = isDivider;
        IsDisabled = false;
        MenuIcon = MenuIcon.Empty();
        OnClick = null;
    }

    public MenuItem(string name, bool isDisabled, MenuIcon menuIcon)
    {
        Name = name;
        IsDivider = false;
        IsDisabled = isDisabled;
        MenuIcon = menuIcon;
        OnClick = null;
    }

    public string Name { get; init; }
    public bool IsDisabled { get; init; }
    public bool IsDivider { get; init; }
    public MenuIcon MenuIcon { get; init; }
    public Func<EventArgs>? OnClick { get; init; }

    public static MenuItem CreateEnabled(string name)
    {
        return new(name, false, MenuIcon.Empty());
    }

    public static MenuItem CreateDisabled(string name)
    {
        return new(name, true, MenuIcon.Empty());
    }

    public static MenuItem CreateWithIcon(string name, bool isDisabled, MenuIcon icon)
    {
        return new(name, isDisabled, icon);
    }

    public static MenuItem CreateDivider()
    {
        return new(true);
    }
}