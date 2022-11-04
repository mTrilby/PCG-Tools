#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchDrumPatterns;

namespace Domain.M50Specific.Synth
{
    /// <summary>
    /// </summary>
    public class M50DrumPatternBanks : DrumPatternBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public M50DrumPatternBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// </summary>
        protected override void CreateBanks()
        {
            Add(new M50DrumPatternBank(this, BankType.EType.Int, "P", 0)); // Preset

            Add(new M50DrumPatternBank(this, BankType.EType.User, "U", 1));
        }
    }
}