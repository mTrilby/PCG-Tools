#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.MntxSeriesSpecific.Synth;

namespace Domain.M3rSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class M3RCombiBanks : MntxCombiBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public M3RCombiBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// </summary>
        protected override void CreateBanks()
        {
            //                          0 
            foreach (var id in new[] { "I", "C" })
            {
                Add(new M3RCombiBank(this, BankType.EType.Int, id, -1));
            }
        }
    }
}