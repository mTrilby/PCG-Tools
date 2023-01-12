#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.Common.Synth.Meta;
using PcgTools.Model.KronosOasysSpecific.Synth;

#endregion

// (c) 2011 Michel Keijzers

namespace PcgTools.Model.KronosSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class KronosDrumPatternBanks : KronosOasysDrumPatternBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public KronosDrumPatternBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }

        /// <summary>
        /// </summary>
        protected override void CreateBanks()
        {
            Add(new KronosDrumPatternBank(this, BankType.EType.Int, "P", 0)); // Preset

            Add(new KronosDrumPatternBank(this, BankType.EType.User, "U", 1));
        }
    }
}