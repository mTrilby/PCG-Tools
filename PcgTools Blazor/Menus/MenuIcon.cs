#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using MudBlazor;

namespace PcgTools_Blazor.Menus;

public struct MenuIcon
{
    private MenuIcon(bool isDefined)
    {
        IsDefined = isDefined;
        Icon = Icons.Material.Filled.Window;
        Size = Size.Medium;
        Color = Color.Default;
    }

    public MenuIcon(string icon, Size size, Color color)
    {
        IsDefined = true;
        Icon = icon;
        Size = size;
        Color = color;
    }

    public bool IsDefined { get; init; }
    public string Icon { get; init; }
    public Size Size { get; init; }
    public Color Color { get; init; }

    public static MenuIcon Empty()
    {
        return new(false);
    }
}