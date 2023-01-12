#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

namespace Common.Utils;

public static class ApplicationData
{
    public static string PcgToolsApplicationDataDir { get; private set; } = string.Empty;

    public static void Initialize()
    {
        //TODO: This should be initialized by the application on launch
        PcgToolsApplicationDataDir = "";
    }
}

public static class SettingsDefault
{
    public static bool CopyPaste_CopyPatchesFromMasterFile { get; private set; }

    public static bool UI_ClearPatchesFixReferences { get; private set; }

    public static int UI_ClearPatches { get; private set; }

    public static bool CopyPaste_CopyIncompleteCombis { get; private set; }

    public static bool CopyPaste_CopyIncompleteSetListSlots { get; private set; }

    public static bool CopyPaste_PasteDuplicatePrograms { get; private set; }

    public static bool CopyPaste_PasteDuplicateCombis { get; private set; }

    public static bool CopyPaste_PasteDuplicateDrumKits { get; private set; }

    public static bool CopyPaste_PasteDuplicateDrumPatterns { get; private set; }

    public static bool CopyPaste_PasteDuplicateWaveSequences { get; private set; }

    public static bool CopyPaste_PasteDuplicateSetListSlots { get; private set; }

    public static int CopyPaste_PatchDuplicationName { get; private set; }

    public static bool CopyPaste_AutoExtendedSinglePatchSelectionPaste { get; private set; }

    public static bool CopyPaste_OverwriteFilledPrograms { get; private set; }

    public static bool CopyPaste_OverwriteFilledCombis { get; private set; }

    public static bool CopyPaste_OverwriteFilledSetListSlots { get; private set; }

    public static bool CopyPaste_OverwriteFilledDrumKits { get; private set; }

    public static bool CopyPaste_OverwriteFilledDrumPatterns { get; private set; }

    public static bool CopyPaste_OverwriteFilledWaveSequences { get; private set; }

    public static bool TrinityCategorySetA { get; private set; }

    public static bool Sort_ArtistTitleSortOrder { get; private set; }

    public static string Sort_SplitCharacter { get; private set; } = ",";

    public static bool SingleLinedSetListSlotDescriptions { get; private set; }

    public static bool UI_ShowNumberOfReferencesColumn { get; private set; }

    public static bool Edit_RenameFileWhenPatchNameChanges { get; private set; }

    public static string CopyPaste_IgnoreCharactersForPatchDuplication { get; private set; } = string.Empty;

    public static string MasterFile_KronosOS3x { get; private set; } = string.Empty;

    public static string MasterFile_KronosOS2x { get; private set; } = string.Empty;

    public static string MasterFile_KronosOS15_16 { get; private set; } = string.Empty;

    public static string MasterFile_KronosOS10_11 { get; private set; } = string.Empty;

    public static string MasterFile_Oasys { get; private set; } = string.Empty;

    public static string MasterFile_Krome { get; private set; } = string.Empty;

    public static string MasterFile_KromeEx { get; private set; } = string.Empty;

    public static string MasterFile_Kross { get; private set; } = string.Empty;

    public static string MasterFile_Kross2 { get; private set; } = string.Empty;

    public static string MasterFile_M3_OS20 { get; private set; } = string.Empty;

    public static string MasterFile_M3_OS1x { get; private set; } = string.Empty;

    public static string MasterFile_M50 { get; private set; } = string.Empty;

    public static string MasterFile_MicroStation { get; private set; } = string.Empty;

    public static string MasterFile_TritonExtreme { get; private set; } = string.Empty;

    public static string MasterFile_TritonTrClassicStudioRack { get; private set; } = string.Empty;

    public static string MasterFile_TritonLe { get; private set; } = string.Empty;

    public static string MasterFile_TritonKarma { get; private set; } = string.Empty;

    public static string MasterFile_TrinityV2 { get; private set; } = string.Empty;

    public static string MasterFile_TrinityV3 { get; private set; } = string.Empty;

    public static void Initialize()
    {
        //TODO: This should be initialized by the user's current settings
        CopyPaste_CopyPatchesFromMasterFile = true;
        UI_ClearPatchesFixReferences = true;
        UI_ClearPatches = 2;
        CopyPaste_CopyIncompleteCombis = true;
        CopyPaste_CopyIncompleteSetListSlots = true;
        CopyPaste_PasteDuplicatePrograms = true;
        CopyPaste_PasteDuplicateCombis = true;
        CopyPaste_PasteDuplicateDrumKits = true;
        CopyPaste_PasteDuplicateDrumPatterns = true;
        CopyPaste_PasteDuplicateWaveSequences = true;
        CopyPaste_PasteDuplicateSetListSlots = true;
        CopyPaste_PatchDuplicationName = 1;
        CopyPaste_AutoExtendedSinglePatchSelectionPaste = true;
        CopyPaste_OverwriteFilledPrograms = true;
        CopyPaste_OverwriteFilledCombis = true;
        CopyPaste_OverwriteFilledSetListSlots = true;
        CopyPaste_OverwriteFilledDrumKits = true;
        CopyPaste_OverwriteFilledDrumPatterns = true;
        CopyPaste_OverwriteFilledWaveSequences = true;
        TrinityCategorySetA = true;
        Sort_ArtistTitleSortOrder = true;
        Sort_SplitCharacter = "|";
        SingleLinedSetListSlotDescriptions = true;
        UI_ShowNumberOfReferencesColumn = true;
        Edit_RenameFileWhenPatchNameChanges = true;
        CopyPaste_IgnoreCharactersForPatchDuplication = "";
    }

    //TODO: This should update the persisted user settings
    public static string SetMasterFile_KronosOS3x(string value)
    {
        return MasterFile_KronosOS3x = value;
    }

    public static string SetMasterFile_KronosOS2x(string value)
    {
        return MasterFile_KronosOS2x = value;
    }

    public static string SetMasterFile_KronosOS15_16(string value)
    {
        return MasterFile_KronosOS15_16 = value;
    }

    public static string SetMasterFile_KronosOS10_11(string value)
    {
        return MasterFile_KronosOS10_11 = value;
    }

    public static string SetMasterFile_Oasys(string value)
    {
        return MasterFile_Oasys = value;
    }

    public static string SetMasterFile_Krome(string value)
    {
        return MasterFile_Krome = value;
    }

    public static string SetMasterFile_KromeEx(string value)
    {
        return MasterFile_KromeEx = value;
    }

    public static string SetMasterFile_Kross(string value)
    {
        return MasterFile_Kross = value;
    }

    public static string SetMasterFile_Kross2(string value)
    {
        return MasterFile_Kross2 = value;
    }

    public static string SetMasterFile_M3_OS20(string value)
    {
        return MasterFile_M3_OS20 = value;
    }

    public static string SetMasterFile_M3_OS1x(string value)
    {
        return MasterFile_M3_OS1x = value;
    }

    public static string SetMasterFile_M50(string value)
    {
        return MasterFile_M50 = value;
    }

    public static string SetMasterFile_MicroStation(string value)
    {
        return MasterFile_MicroStation = value;
    }

    public static string SetMasterFile_TritonExtreme(string value)
    {
        return MasterFile_TritonExtreme = value;
    }

    public static string SetMasterFile_TritonTrClassicStudioRack(string value)
    {
        return MasterFile_TritonTrClassicStudioRack = value;
    }

    public static string SetMasterFile_TritonLe(string value)
    {
        return MasterFile_TritonLe = value;
    }

    public static string SetMasterFile_TritonKarma(string value)
    {
        return MasterFile_TritonKarma = value;
    }

    public static string SetMasterFile_TrinityV2(string value)
    {
        return MasterFile_TrinityV2 = value;
    }

    public static string SetMasterFile_TrinityV3(string value)
    {
        return MasterFile_TrinityV3 = value;
    }
}