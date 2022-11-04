#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.MSpecific.Synth;

namespace Domain.KromeSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class KromeCombiBanks : MCombiBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public KromeCombiBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// </summary>
        protected override void CreateBanks()
        {
            //                          0    1    2    3   
            foreach (var id in new[] { "A", "B", "C", "D" })
            {
                Add(new KromeCombiBank(this, BankType.EType.Int, id, -1));
            }
        }
    }
}