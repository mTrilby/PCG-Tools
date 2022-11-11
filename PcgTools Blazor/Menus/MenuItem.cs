#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Microsoft.AspNetCore.Components.Web;

namespace PcgTools_Blazor.Menus;

public struct MenuItem
{
    private MenuItem(bool isDivider)
    {
        Name = string.Empty;
        OnClickEventHandler = NoOpHandler;
        Link = string.Empty;
        IsDivider = isDivider;
        IsDisabled = false;
        MenuIcon = MenuIcon.Empty();
        OnClick = null;
    }

    public MenuItem(string name, string hrefLink, bool isDisabled, MenuIcon menuIcon)
    {
        Name = name;
        Link = hrefLink;
        OnClickEventHandler = NoOpHandler;
        IsDivider = false;
        IsDisabled = isDisabled;
        MenuIcon = menuIcon;
        OnClick = null;
    }

    public MenuItem(string name, Action eventHandler, bool isDisabled, MenuIcon menuIcon)
    {
        Name = name;
        Link = string.Empty;
        OnClickEventHandler = eventHandler;
        IsDivider = false;
        IsDisabled = isDisabled;
        MenuIcon = menuIcon;
        OnClick = null;
    }

    public string Name { get; init; }
    public string Link { get; init; }
    public Action OnClickEventHandler { get; init; }
    public bool IsDisabled { get; init; }
    public bool IsDivider { get; init; }
    public MenuIcon MenuIcon { get; init; }
    public Func<EventArgs>? OnClick { get; init; }

    public static MenuItem CreateLinkEnabled(string name, string href) =>
        new(name, href,  false, MenuIcon.Empty());

    public static MenuItem CreateEventHandlerEnabled(string name, Action eventHandler) =>
        new(name, eventHandler, false, MenuIcon.Empty());

    public static MenuItem CreateDisabled(string name) =>
        new(name, string.Empty, true, MenuIcon.Empty());

    public static MenuItem CreateWithIcon(string name, string href, bool isDisabled, MenuIcon icon) =>
        new(name, href, isDisabled, icon);

    public static MenuItem CreateDivider() =>
        new(true);

    private static void NoOpHandler() {}
}