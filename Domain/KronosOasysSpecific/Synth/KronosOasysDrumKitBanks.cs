#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.PatchDrumKits;

namespace Domain.KronosOasysSpecific.Synth
{
    /// <summary>
    /// </summary>
    public abstract class KronosOasysDrumKitBanks : DrumKitBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        protected KronosOasysDrumKitBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }
    }
}