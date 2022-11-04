#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.TritonSpecific.Synth;

namespace Domain.TritonLeSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class TritonLeCombiBanks : TritonCombiBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public TritonLeCombiBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// </summary>
        protected override void CreateBanks()
        {
            //                          0    1    2 
            foreach (var id in new[] { "A", "B", "C" })
            {
                Add(new TritonLeCombiBank(this, BankType.EType.Int, id, -1));
            }
        }
    }
}