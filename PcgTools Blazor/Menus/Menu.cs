#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

namespace PcgTools_Blazor.Menus;

public struct Menu
{
    public Menu(string label, bool isDisabled = false, bool isDense = false)
    {
        Label = label;
        IsDisabled = isDisabled;
        IsDense = isDense;

        MenuItems = new List<MenuItem>();
    }

    public string Label { get; init; }
    public bool IsDisabled { get; init; }
    public bool IsDense { get; init; }
    public List<MenuItem> MenuItems { get; }
}