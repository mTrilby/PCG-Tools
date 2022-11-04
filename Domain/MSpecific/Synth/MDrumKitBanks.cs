#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.PatchDrumKits;

namespace Domain.MSpecific.Synth
{
    /// <summary>
    /// </summary>
    public abstract class MDrumKitBanks : DrumKitBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        protected MDrumKitBanks(PcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }
    }
}