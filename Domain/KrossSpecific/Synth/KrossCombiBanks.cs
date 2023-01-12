#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.MSpecific.Synth;

#endregion

namespace Domain.KrossSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class KrossCombiBanks : MCombiBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public KrossCombiBanks(PcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }

        /// <summary>
        /// </summary>
        protected override void CreateBanks()
        {
            //                          0    1   
            foreach (var id in new[] { "A", "B" })
            {
                Add(new KrossCombiBank(this, BankType.EType.Int, id, -1));
            }

            Add(new KrossCombiBank(this, BankType.EType.User, "U", -1));
        }
    }
}