#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchDrumPatterns;

// (c) 2011 Michel Keijzers

namespace Domain.MSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class MDrumPatternBanks : DrumPatternBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public MDrumPatternBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// </summary>
        protected override void CreateBanks()
        {
            Add(new MDrumPatternBank(this, BankType.EType.Int, "P", 0)); // Preset

            Add(new MDrumPatternBank(this, BankType.EType.User, "U", 1));
        }
    }
}