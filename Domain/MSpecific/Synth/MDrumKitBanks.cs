#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.Common.Synth.PatchDrumKits;

namespace PcgTools.Model.MSpecific.Synth
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