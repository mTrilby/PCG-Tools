#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

namespace Common.Utils;

/// <summary>
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