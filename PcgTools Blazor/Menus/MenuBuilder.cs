#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Common.PcgToolsResources;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace PcgTools_Blazor.Menus;

public class NavMenuBase : MudComponentBase
{
    [Inject]
    private IDialogService? DialogService { get; set; }

    protected readonly List<Menu> MenuList = new();

    protected override void OnInitialized()
    {
        var menuBuilder = new MenuBuilder();
        MenuList.AddRange(menuBuilder.GetMenu(this).ToList());
    }

    public async void OpenFileOnClick()
    {
        Console.WriteLine("Calling the OpenFile dialog on click");
        var result = await DialogService!.ShowMessageBox(
            "Warning",
            "Deleting can not be undone!",
            "Delete!", cancelText: "Cancel");
        StateHasChanged();
    }

    private async void OpenFileOnTouch(TouchEventArgs args)
    {
        Console.WriteLine("Calling the OpenFile dialog on touch");
        var result = await DialogService!.ShowMessageBox(
            "Warning",
            "Deleting can not be undone!",
            "Delete!", cancelText: "Cancel");
        StateHasChanged();
    }
}
public class MenuBuilder
{
    public IEnumerable<Menu> GetMenu(NavMenuBase navMenu)
    {
        //TODO: Will require a service that provides Enabled/Disable statuses for toggle-able menu items
        yield return GetFileMenu(navMenu);
        yield return GetEditMenu();
        yield return GetShowMenu();
        yield return GetToolsMenu();
        yield return GetThemeMenu();
        yield return GetLanguageMenu();
        yield return GetOptionsMenu();
        yield return GetWindowsMenu();
        yield return GetHelpMenu();
    }


    private static Menu GetFileMenu(NavMenuBase navMenu)
    {
        var menu = new Menu(Strings.Menu_File, isDense: true);
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled(Strings.Menu_File_Open, "/OpenPcgFile"));
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_File_Save));
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_File_SaveAs));
        menu.MenuItems.Add(MenuItem.CreateDivider());
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled(Strings.Menu_File_ExportForSequencer_Cubase, "/ExportCubaseSequence"));
        menu.MenuItems.Add(MenuItem.CreateDivider());
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_File_RevertToSaved));
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_File_Close));
        menu.MenuItems.Add(MenuItem.CreateDivider());
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled(Strings.Menu_File_Exit, "/Exit"));

        return menu;
    }

    private static Menu GetEditMenu()
    {
        var menu = new Menu(Strings.Menu_Edit, isDense: true);
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_Edit_Edit));
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_Edit_SetFavorite));
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_Edit_UnsetFavorite));
        menu.MenuItems.Add(MenuItem.CreateDivider());
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_Edit_Clear));
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_Edit_ClearDuplicates));
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_Edit_Compact));
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_Edit_Sort));
        menu.MenuItems.Add(MenuItem.CreateDivider());
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_Edit_Cut));
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_Edit_Copy));
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_Edit_Paste));
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_Edit_ExitCutCopyPasteMode));
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_Edit_Recall));
        menu.MenuItems.Add(MenuItem.CreateDivider());
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_Edit_MoveUp));
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_Edit_MoveDown));
        menu.MenuItems.Add(MenuItem.CreateDivider());
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_Edit_ChangeVolume));
        menu.MenuItems.Add(MenuItem.CreateDivider());
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_Edit_InitAsMPECombi));
        menu.MenuItems.Add(MenuItem.CreateDivider());
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_Edit_AssignToSetListSlot));
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_Edit_AutoFillInSetListSlotNames));
        menu.MenuItems.Add(MenuItem.CreateDivider());
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled(Strings.Menu_Edit_Capitalization, "/"));
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_Edit_CapitalizeName));
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_Edit_TitleCaseName));
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_Edit_DecapitalizeName));

        return menu;
    }

    private static Menu GetShowMenu()
    {
        var menu = new Menu(Strings.Menu_Show, isDense: true);
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_Show_Timbres));
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_Show_HexExport));
        menu.MenuItems.Add(MenuItem.CreateDivider());
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled(Strings.Menu_Show_SingleLinedSetListSlotDescriptions, "/"));
        menu.MenuItems.Add(MenuItem.CreateDivider());
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled(Strings.Menu_Show_SpecialEvent, "/"));

        return menu;
    }

    private static Menu GetToolsMenu()
    {
        var menu = new Menu(Strings.Menu_Tools, isDense: true);
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_Tools_MasterFiles));
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_Tools_Show));
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_Tools_SetPCGFileAsMasterFile));
        menu.MenuItems.Add(MenuItem.CreateDivider());
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_Tools_GenerateList));
        menu.MenuItems.Add(MenuItem.CreateDivider());
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_Tools_ProgramReferenceChanger));
        menu.MenuItems.Add(MenuItem.CreateDivider());
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_Tools_DoubleToSingleKeyboardSetup));

        return menu;
    }

    private static Menu GetThemeMenu()
    {
        var menu = new Menu(Strings.Menu_Theme, isDense: true);
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled(Strings.Menu_Theme_Generic, "/"));
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled(Strings.Menu_Theme_Luna, "/"));
        menu.MenuItems.Add(MenuItem.CreateWithIcon(Strings.Menu_Theme_Aero, "/", false,
            new MenuIcon(Icons.Material.Filled.Check, Size.Small, Color.Primary)));

        return menu;
    }

    private static Menu GetLanguageMenu()
    {
        var menu = new Menu(Strings.Menu_Language, isDense: true);
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled($"{Strings.Menu_Language_Czech} ({Strings.Menu_Language_EN_Czech})", "/"));
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled($"{Strings.Menu_Language_Dutch} ({Strings.Menu_Language_EN_Dutch})", "/"));
        menu.MenuItems.Add(MenuItem.CreateWithIcon(
            $"{Strings.Menu_Language_English} ({Strings.Menu_Language_EN_English})", "/", false,
            new MenuIcon(Icons.Material.Filled.Check, Size.Small, Color.Primary)));
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled($"{Strings.Menu_Language_French} ({Strings.Menu_Language_EN_French})", "/"));
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled($"{Strings.Menu_Language_German} ({Strings.Menu_Language_EN_German})", "/"));
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled($"{Strings.Menu_Language_Greek} ({Strings.Menu_Language_EN_Greek})", "/"));
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled($"{Strings.Menu_Language_Italian} ({Strings.Menu_Language_EN_Italian})", "/"));
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled($"{Strings.Menu_Language_Polish} ({Strings.Menu_Language_EN_Polish})", "/"));
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled($"{Strings.Menu_Language_PortugueseBrazil} ({Strings.Menu_Language_EN_PortugueseBrazil})", "/"));
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled($"{Strings.Menu_Language_PortuguesePortugal} ({Strings.Menu_Language_EN_PortuguesePortugal})", "/"));
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled($"{Strings.Menu_Language_Russian} ({Strings.Menu_Language_EN_Russian})", "/"));
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled($"{Strings.Menu_Language_SerbianLatin} ({Strings.Menu_Language_EN_SerbianLatin})", "/"));
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled($"{Strings.Menu_Language_Spanish} ({Strings.Menu_Language_EN_Spanish})", "/"));
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled($"{Strings.Menu_Language_Turkish} ({Strings.Menu_Language_EN_Turkish})", "/"));
        menu.MenuItems.Add(MenuItem.CreateDivider());

        return menu;
    }

    private static Menu GetOptionsMenu()
    {
        var menu = new Menu(Strings.Menu_Options, isDense: true);
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled(Strings.Menu_Options_Settings, "/Settings"));
        menu.MenuItems.Add(MenuItem.CreateDisabled(Strings.Menu_Options_AssignClearProgram));

        return menu;
    }

    private static Menu GetWindowsMenu()
    {
        var menu = new Menu(Strings.Menu_Windows, isDense: true);
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled(Strings.Menu_Windows_GotoNextWindow, "/"));
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled(Strings.Menu_Windows_GotoPreviousWindow, "/"));

        return menu;
    }

    private static Menu GetHelpMenu()
    {
        var menu = new Menu(Strings.Menu_Help, isDense: true);
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled(Strings.Menu_Help_About, "/"));
        menu.MenuItems.Add(MenuItem.CreateDivider());
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled(Strings.Menu_Help_PCGToolsHomePage, "/"));
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled(Strings.Menu_Help_Manual, "/"));
        menu.MenuItems.Add(MenuItem.CreateDivider());
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled(Strings.Menu_Help_ExternalLinksKorgRelated, "/"));
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled(Strings.Menu_Help_ExternalLinksContributors, "/"));
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled(Strings.Menu_Help_ExternalLinksVideoCreators, "/"));
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled(Strings.Menu_Help_ExternalLinksDonators, "/"));
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled(Strings.Menu_Help_ExternalLinksTranslators, "/"));
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled(Strings.Menu_Help_ExternalLinksThirdParties, "/"));
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled(Strings.Menu_Help_ExternalLinksOasysVoucerCodeSponsors, "/"));
        menu.MenuItems.Add(MenuItem.CreateLinkEnabled(Strings.Menu_Help_ExternalLinksPersonalLinks, "/"));

        return menu;
    }
}