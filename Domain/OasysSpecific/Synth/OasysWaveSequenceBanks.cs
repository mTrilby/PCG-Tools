#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.KronosOasysSpecific.Synth;

// (c) 2011 Michel Keijzers

namespace Domain.OasysSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class OasysWaveSequenceBanks : KronosOasysWaveSequenceBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public OasysWaveSequenceBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// </summary>
        protected override void CreateBanks()
        {
            Add(new OasysWaveSequenceBank(this, BankType.EType.Int, "INT", -1));

            foreach (var id in new[] { "U-A", "U-B", "U-C", "U-D", "U-E", "U-F", "U-G" })
            {
                Add(new OasysWaveSequenceBank(this, BankType.EType.User, id, -1));
            }
        }
    }
}