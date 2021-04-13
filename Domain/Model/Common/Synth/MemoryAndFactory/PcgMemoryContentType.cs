namespace Domain.Model.Common.Synth.MemoryAndFactory
{
    /// <summary>
    /// The values come from Sysex functions.
    /// </summary>
    public enum PcgMemoryContentType
    {
        All = 0x50,

        AllPrograms = 0x4C,
        ProgramBank = 0x80, // No Sysex function
        CurrentProgram = 0x40,

        AllCombis = 0x4D,
        CombiBank = 0x90, // No Sysex function
        CurrentCombi = 0x49,

        MultiSound = 0x44,

        AllDrumSound = 0x47,
        Drums = 0x52,
        // ReSharper disable once UnusedMember.Global
        DrumKitAndMultiSoundParameterChange = 0x53,

        ArpeggioPattern = 0x69, // Z1, ...
        CurrentArpeggioPattern = 0x6B, // Z1, ...

        AllSequence = 0x48,
        CurrentSequence = 0xa0, // No Sysex function

        Global = 0x51,

        ModeChange = 0x4E, // Skip
        // ReSharper disable once UnusedMember.Global
        ParameterChange = 0x41,

        // Unused:
        // All requests
        // WriteCompleted       // 0x21
        // WriteError           // 0x22
        // DataLoadCompleted    // 0x23
        // DataLoadError        // 0x24
        // DataFormatError      // 0x26
    }
}