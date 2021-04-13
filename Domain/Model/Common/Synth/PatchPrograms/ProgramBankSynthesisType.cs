namespace Domain.Model.Common.Synth.PatchPrograms
{
    /// <summary>
    /// When changed, also change IsModeled.
    /// </summary>
    public enum ProgramBankSynthesisType
    {
        // Sampled types
        Ai,             // M1 sample engine, Advanced Integrated
        Ai2,            // Advanted Integrated 2
        Access,         // Trinity Sample engine
        Hi,             // Triton/Karma Sample engine
        Eds,            // M3/M50 Sample engine
        Edsi,           // MicroStation Sample engine
        Edsx,           // Krome (EX)/Kross(2) Sample engine
        Hd1,            // Kronos/Oasys Sample engine

        // Modeled types
        // Prophecy,       // Trinity option SOLO-TRI
        AnalogModeling, // MS2000, MicroKorg
        Mmt,            // MicroKorg XL (Plus)
        MossZ1,         // Trinity option MOSS-TRI or MOSS board for Korg Triton (except LE)
        Radias,         // M3 option
        Exi,            // Oasys/Kronos modeled engine

        Last,

        Unknown         // Unknown; Used for Oasys/Kronos where synthesis type is dynamic.
    }
}