#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.KronosOasysSpecific.Synth;

#endregion

namespace Domain.OasysSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class OasysCombiBanks : KronosOasysCombiBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public OasysCombiBanks(IPcgMemory pcgMemory) : base(pcgMemory)
        {
        }

        /// <summary>
        /// </summary>
        protected override void CreateBanks()
        {
            foreach (var id in new[] { "I-A", "I-B", "I-C", "I-D", "I-E", "I-F", "I-G" })
            {
                Add(new OasysCombiBank(this, BankType.EType.Int, id, -1));
            }

            foreach (var id in new[] { "U-A", "U-B", "U-C", "U-D", "U-E", "U-F", "U-G" })
            {
                Add(new OasysCombiBank(this, BankType.EType.User, id, -1));
            }
        }
    }
}