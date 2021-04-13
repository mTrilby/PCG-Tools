namespace Domain.Interfaces
{
    /// <summary>
    ///
    /// </summary>
    public enum SelectedBanksType
    {
        None, // Only allowed during init
        ProgramBanks,
        CombiBanks,
        SetLists,
        DrumKitBanks,
        DrumPatternBanks,
        WaveSequenceBanks,
        AllPatches // No banks selected
    }
}