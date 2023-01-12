#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.Common.Synth.Meta;
using PcgTools.Model.Common.Synth.PatchDrumPatterns;

#endregion

namespace PcgTools.Model.KromeSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class KromeDrumPatternBanks : DrumPatternBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public KromeDrumPatternBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }

        /// <summary>
        /// </summary>
        protected override void CreateBanks()
        {
            Add(new KromeDrumPatternBank(this, BankType.EType.Int, "P", 0)); // Preset

            Add(new KromeDrumPatternBank(this, BankType.EType.User, "U", 1));
        }
    }
}