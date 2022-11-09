#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Common.PcgToolsResources;
using MudBlazor;

namespace PcgTools_Blazor.Menus;

public class ToolbarBuilder
{
    public IEnumerable<ToolbarItem> GetToolbarItems()
    {
        //TODO: Will require a service that provides Enabled/Disable statuses for toggle-able toolbar items
        yield return ToolbarItem.GetEnabledIcon(Icons.Material.Outlined.FileOpen, Strings.OpenFileCommand_mainw_tt);
        yield return ToolbarItem.GetDisabledIcon(Icons.Material.Outlined.Save, Strings.SaveFileCommand_mainw_tt);
        yield return ToolbarItem.GetDisabledIcon(Icons.Material.Outlined.SaveAs, Strings.SaveFileAsCommand_mainw_tt);
        yield return ToolbarItem.GetEnabledIcon(Icons.Material.Outlined.EditNote, Strings.EditSelectedPatch);
        yield return ToolbarItem.GetEnabledIcon(Icons.Material.Outlined.BookmarkAdd, Strings.MarkAsFavorite);
        yield return ToolbarItem.GetEnabledIcon(Icons.Material.Outlined.BookmarkRemove, Strings.UnmarkAsFavorite);
        yield return ToolbarItem.GetEnabledIcon(Icons.Material.Outlined.Deselect, Strings.ClearSelected);
        yield return ToolbarItem.GetEnabledIcon(Icons.Material.Outlined.ArrowCircleUp, Strings.CompactSelected);
        yield return ToolbarItem.GetEnabledIcon(Icons.Material.Outlined.Tune, Strings.ShowTimbres);
        yield return ToolbarItem.GetEnabledIcon(Icons.Material.Outlined.ContentCut, Strings.CutSelected);
        yield return ToolbarItem.GetEnabledIcon(Icons.Material.Outlined.ContentCopy, Strings.CopySelected);
        yield return ToolbarItem.GetEnabledIcon(Icons.Material.Outlined.ContentPaste, Strings.PasteSelected);
        yield return ToolbarItem.GetEnabledIcon(Icons.Material.Outlined.SettingsApplications, Strings.EditSettings);
        yield return ToolbarItem.GetEnabledIcon(Icons.Material.Outlined.ContentPasteOff, Strings.ExitCutCopyPasteModeToolTip);
        yield return ToolbarItem.GetEnabledIcon(Icons.Material.Outlined.ContentPasteGo, Strings.RecallClipboard);
        yield return ToolbarItem.GetEnabledIcon(Icons.Material.Outlined.ExpandLess, Strings.MoveUpToolTip);
        yield return ToolbarItem.GetEnabledIcon(Icons.Material.Outlined.ExpandMore, Strings.MoveDownToolTip);
        yield return ToolbarItem.GetEnabledIcon(Icons.Material.Outlined.ViewList, Strings.GenerateAList);
        yield return ToolbarItem.GetEnabledIcon(Icons.Material.Outlined.Info, Strings.ShowInformation);
        yield return ToolbarItem.GetSpacerIcon();
        yield return ToolbarItem.GetEnabledIcon(Icons.Material.Outlined.AutoAwesome, Strings.SpecialEventToolTip);
    }
}