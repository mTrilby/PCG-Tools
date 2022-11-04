#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.MntxSeriesSpecific.Synth;

namespace Domain.M1Specific.Synth
{
    /// <summary>
    /// </summary>
    public class M1CombiBanks : MntxCombiBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public M1CombiBanks(IPcgMemory pcgMemory)
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
                Add(new M1CombiBank(this, BankType.EType.Int, id, -1));
            }
        }
    }
}