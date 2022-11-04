#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.MSpecific.Synth;

namespace Domain.KromeExSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class KromeExCombiBanks : MCombiBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public KromeExCombiBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// </summary>
        protected override void CreateBanks()
        {
            //                          0    1    2    3    4    5
            foreach (var id in new[] { "A", "B", "C", "D", "E", "F" })
            {
                Add(new KromeExCombiBank(this, BankType.EType.Int, id, -1));
            }
        }
    }
}