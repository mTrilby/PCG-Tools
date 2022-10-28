namespace Common.Utils;

public static class ApplicationData
{
    private static string _pcgToolsApplicationDataDirectory = string.Empty;

    public static void Initialize()
    {
        //TODO: This should be initialized by the application on launch
        _pcgToolsApplicationDataDirectory = "";
    }

    public static string PcgToolsApplicationDataDir => _pcgToolsApplicationDataDirectory;
}
public static class SettingsDefault
{
    private static bool _copyPasteCopyPatchesFromMasterFile = false;
    private static bool _uiClearPatchesFixReferences = false;
    private static int _uiClearPatches = 0;
    private static bool _copyPasteCopyIncompleteCombis = false;
    private static bool _copyPasteCopyIncompleteSetListSlots = false;
    private static bool _copyPastePasteDuplicatePrograms = false;
    private static bool _copyPastePasteDuplicateCombis = false;
    private static bool _copyPastePasteDuplicateDrumKits = false;
    private static bool _copyPastePasteDuplicateDrumPatterns = false;
    private static bool _copyPastePasteDuplicateWaveSequences = false;
    private static bool _copyPastePasteDuplicateSetListSlots = false;
    private static int _copyPastePatchDuplicationName = 0;
    private static bool _copyPasteAutoExtendedSinglePatchSelectionPaste = false;
    private static bool _copyPasteOverwriteFilledPrograms = false;
    private static bool _copyPasteOverwriteFilledCombis = false;
    private static bool _copyPasteOverwriteFilledSetListSlots = false;
    private static bool _copyPasteOverwriteFilledDrumKits = false;
    private static bool _copyPasteOverwriteFilledDrumPatterns = false;
    private static bool _copyPasteOverwriteFilledWaveSequences = false;
    private static bool _trinityCategorySetA = false;
    private static bool _sortArtistTitleSortOrder = false;
    private static string _sortSplitCharacter = ",";
    private static bool _singleLinedSetListSlotDescriptions = false;
    private static bool _uiShowNumberOfReferencesColumn = false;
    private static bool _editRenameFileWhenPatchNameChanges = false;
    private static string _copyPasteIgnoreCharactersForPatchDuplication = string.Empty;
    private static string _masterFileKronosOS3x = string.Empty;
    private static string _masterFileKronosOS2x = string.Empty;
    private static string _masterFileKronosOS15_16 = string.Empty;
    private static string _masterFileKronosOS10_11 = string.Empty;
    private static string _masterFileOasys = string.Empty;
    private static string _masterFileKrome = string.Empty;
    private static string _masterFileKromeEx = string.Empty;
    private static string _masterFileKross = string.Empty;
    private static string _masterFileKross2 = string.Empty;
    private static string _masterFileM3_OS20 = string.Empty;
    private static string _masterFileM3_OS1x = string.Empty;
    private static string _masterFileM50 = string.Empty;
    private static string _masterFileMicroStation = string.Empty;
    private static string _masterFileTritonExtreme = string.Empty;
    private static string _masterFileTritonTrClassicStudioRack = string.Empty;
    private static string _masterFileTritonLe = string.Empty;
    private static string _masterFileTritonKarma = string.Empty;
    private static string _masterFileTrinityV2 = string.Empty;
    private static string _masterFileTrinityV3 = string.Empty;

    public static void Initialize()
    {
        //TODO: This should be initialized by the user's current settings
        _copyPasteCopyPatchesFromMasterFile = true;
        _uiClearPatchesFixReferences = true;
        _uiClearPatches = 2;
        _copyPasteCopyIncompleteCombis = true;
        _copyPasteCopyIncompleteSetListSlots = true;
        _copyPastePasteDuplicatePrograms = true;
        _copyPastePasteDuplicateCombis = true;
        _copyPastePasteDuplicateDrumKits = true;
        _copyPastePasteDuplicateDrumPatterns = true;
        _copyPastePasteDuplicateWaveSequences = true;
        _copyPastePasteDuplicateSetListSlots = true;
        _copyPastePatchDuplicationName = 1;
        _copyPasteAutoExtendedSinglePatchSelectionPaste = true;
        _copyPasteOverwriteFilledPrograms = true;
        _copyPasteOverwriteFilledCombis = true;
        _copyPasteOverwriteFilledSetListSlots = true;
        _copyPasteOverwriteFilledDrumKits = true;
        _copyPasteOverwriteFilledDrumPatterns = true;
        _copyPasteOverwriteFilledWaveSequences = true;
        _trinityCategorySetA = true;
        _sortArtistTitleSortOrder = true;
        _sortSplitCharacter = "|";
        _singleLinedSetListSlotDescriptions = true;
        _uiShowNumberOfReferencesColumn = true;
        _editRenameFileWhenPatchNameChanges = true;
        _copyPasteIgnoreCharactersForPatchDuplication = "";
    }

    public static bool CopyPaste_CopyPatchesFromMasterFile => _copyPasteCopyPatchesFromMasterFile;
    public static bool UI_ClearPatchesFixReferences => _uiClearPatchesFixReferences;
    public static int UI_ClearPatches => _uiClearPatches;
    public static bool CopyPaste_CopyIncompleteCombis => _copyPasteCopyIncompleteCombis;
    public static bool CopyPaste_CopyIncompleteSetListSlots => _copyPasteCopyIncompleteSetListSlots;
    public static bool CopyPaste_PasteDuplicatePrograms => _copyPastePasteDuplicatePrograms;
    public static bool CopyPaste_PasteDuplicateCombis => _copyPastePasteDuplicateCombis;
    public static bool CopyPaste_PasteDuplicateDrumKits => _copyPastePasteDuplicateDrumKits;
    public static bool CopyPaste_PasteDuplicateDrumPatterns => _copyPastePasteDuplicateDrumPatterns;
    public static bool CopyPaste_PasteDuplicateWaveSequences => _copyPastePasteDuplicateWaveSequences;
    public static bool CopyPaste_PasteDuplicateSetListSlots => _copyPastePasteDuplicateSetListSlots;
    public static int CopyPaste_PatchDuplicationName => _copyPastePatchDuplicationName;
    public static bool CopyPaste_AutoExtendedSinglePatchSelectionPaste => _copyPasteAutoExtendedSinglePatchSelectionPaste;
    public static bool CopyPaste_OverwriteFilledPrograms => _copyPasteOverwriteFilledPrograms;
    public static bool CopyPaste_OverwriteFilledCombis => _copyPasteOverwriteFilledCombis;
    public static bool CopyPaste_OverwriteFilledSetListSlots => _copyPasteOverwriteFilledSetListSlots;
    public static bool CopyPaste_OverwriteFilledDrumKits => _copyPasteOverwriteFilledDrumKits;
    public static bool CopyPaste_OverwriteFilledDrumPatterns => _copyPasteOverwriteFilledDrumPatterns;
    public static bool CopyPaste_OverwriteFilledWaveSequences => _copyPasteOverwriteFilledWaveSequences;
    public static bool TrinityCategorySetA => _trinityCategorySetA;
    public static bool Sort_ArtistTitleSortOrder => _sortArtistTitleSortOrder;
    public static string Sort_SplitCharacter => _sortSplitCharacter;
    public static bool SingleLinedSetListSlotDescriptions => _singleLinedSetListSlotDescriptions;
    public static bool UI_ShowNumberOfReferencesColumn => _uiShowNumberOfReferencesColumn;
    public static bool Edit_RenameFileWhenPatchNameChanges => _editRenameFileWhenPatchNameChanges;
    public static string CopyPaste_IgnoreCharactersForPatchDuplication => _copyPasteIgnoreCharactersForPatchDuplication;
    public static string MasterFile_KronosOS3x => _masterFileKronosOS3x;
    public static string MasterFile_KronosOS2x => _masterFileKronosOS2x;
    public static string MasterFile_KronosOS15_16 => _masterFileKronosOS15_16;
    public static string MasterFile_KronosOS10_11 => _masterFileKronosOS10_11;
    public static string MasterFile_Oasys => _masterFileOasys;
    public static string MasterFile_Krome => _masterFileKrome;
    public static string MasterFile_KromeEx => _masterFileKromeEx;
    public static string MasterFile_Kross => _masterFileKross;
    public static string MasterFile_Kross2 => _masterFileKross2;
    public static string MasterFile_M3_OS20 => _masterFileM3_OS20;
    public static string MasterFile_M3_OS1x => _masterFileM3_OS1x;
    public static string MasterFile_M50 => _masterFileM50;
    public static string MasterFile_MicroStation => _masterFileMicroStation;
    public static string MasterFile_TritonExtreme => _masterFileTritonExtreme;
    public static string MasterFile_TritonTrClassicStudioRack => _masterFileTritonTrClassicStudioRack;
    public static string MasterFile_TritonLe => _masterFileTritonLe;
    public static string MasterFile_TritonKarma => _masterFileTritonKarma;
    public static string MasterFile_TrinityV2 => _masterFileTrinityV2;
    public static string MasterFile_TrinityV3 => _masterFileTrinityV3;

    //TODO: This should update the persisted user settings
    public static string SetMasterFile_KronosOS3x(string value) => _masterFileKronosOS3x = value;
    public static string SetMasterFile_KronosOS2x(string value) => _masterFileKronosOS2x = value;
    public static string SetMasterFile_KronosOS15_16(string value) => _masterFileKronosOS15_16 = value;
    public static string SetMasterFile_KronosOS10_11(string value) => _masterFileKronosOS10_11 = value;
    public static string SetMasterFile_Oasys(string value) => _masterFileOasys = value;
    public static string SetMasterFile_Krome(string value) => _masterFileKrome = value;
    public static string SetMasterFile_KromeEx(string value) => _masterFileKromeEx = value;
    public static string SetMasterFile_Kross(string value) => _masterFileKross = value;
    public static string SetMasterFile_Kross2(string value) => _masterFileKross2 = value;
    public static string SetMasterFile_M3_OS20(string value) => _masterFileM3_OS20 = value;
    public static string SetMasterFile_M3_OS1x(string value) => _masterFileM3_OS1x = value;
    public static string SetMasterFile_M50(string value) => _masterFileM50 = value;
    public static string SetMasterFile_MicroStation(string value) => _masterFileMicroStation = value;
    public static string SetMasterFile_TritonExtreme(string value) => _masterFileTritonExtreme = value;
    public static string SetMasterFile_TritonTrClassicStudioRack(string value) => _masterFileTritonTrClassicStudioRack = value;
    public static string SetMasterFile_TritonLe(string value) => _masterFileTritonLe = value;
    public static string SetMasterFile_TritonKarma(string value) => _masterFileTritonKarma = value;
    public static string SetMasterFile_TrinityV2(string value) => _masterFileTrinityV2 = value;
    public static string SetMasterFile_TrinityV3(string value) => _masterFileTrinityV3 = value;
}