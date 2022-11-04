#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.MntxSeriesSpecific.Synth;

namespace Domain.Z1Specific.Synth
{
    /// <summary>
    /// </summary>
    public class Z1CombiBanks : MntxCombiBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public Z1CombiBanks(IPcgMemory pcgMemory)
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
                Add(new Z1CombiBank(this, BankType.EType.Int, id, -1));
            }
        }
    }
}