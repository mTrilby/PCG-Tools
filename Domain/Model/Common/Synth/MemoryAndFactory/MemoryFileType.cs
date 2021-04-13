namespace Domain.Model.Common.Synth.MemoryAndFactory
{
    /// <summary>
    ///
    /// </summary>
    public enum MemoryFileType
    {
        Pcg = 0x00, // Various
        Sng = 0x01, // Various
        Bnk,        // MS2000
        Exl,        // MS2000
        Lib,        // MS2000
        MkxlAll,    // MicroKorg
        MkxlPAll,   // MicroKorg XL Plus
        MkxlPProg,  // MicroKorg XL Plus
        MkP0,       // MS2000
        Mid,        // Midi format (with sysex)
        Raw,        // RAW disk image (0 series)
        Tr,         // TR file (Kross series)
        Syx         // Sysex format
    }
}