#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.KronosOasysSpecific.Synth;

// (c) 2011 Michel Keijzers

namespace Domain.KronosSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class KronosWaveSequenceBanks : KronosOasysWaveSequenceBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public KronosWaveSequenceBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// </summary>
        protected override void CreateBanks()
        {
            Add(new KronosWaveSequenceBank(this, BankType.EType.Int, "INT", -1));

            foreach (var id in new[] { "U-A", "U-B", "U-C", "U-D", "U-E", "U-F", "U-G" })
            {
                Add(new KronosWaveSequenceBank(this, BankType.EType.User, id, -1));
            }

            foreach (var id in new[] { "U-AA", "U-BB", "U-CC", "U-DD", "U-EE", "U-FF", "U-GG" })
            {
                Add(new KronosWaveSequenceBank(this, BankType.EType.User, id, -1));
            }
        }
    }
}