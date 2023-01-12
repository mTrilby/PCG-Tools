#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchDrumPatterns;

#endregion

namespace Domain.M3Specific.Synth
{
    /// <summary>
    /// </summary>
    public class M3DrumPatternBanks : DrumPatternBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public M3DrumPatternBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }

        /// <summary>
        /// </summary>
        protected override void CreateBanks()
        {
            Add(new M3DrumPatternBank(this, BankType.EType.Int, "P", 0)); // Preset

            Add(new M3DrumPatternBank(this, BankType.EType.User, "U", 1));
        }
    }
}