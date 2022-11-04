#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.Common.Synth.PatchDrumPatterns;

namespace PcgTools.Model.KronosOasysSpecific.Synth
{
    /// <summary>
    /// </summary>
    public abstract class KronosOasysDrumPatternBanks : DrumPatternBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        protected KronosOasysDrumPatternBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }
    }
}