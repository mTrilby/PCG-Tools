#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.MSpecific.Synth;

#endregion

namespace Domain.M50Specific.Synth
{
    /// <summary>
    /// </summary>
    public class M50CombiBanks : MCombiBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public M50CombiBanks(IPcgMemory pcgMemory)
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
                Add(new M50CombiBank(this, BankType.EType.Int, id, -1));
            }
        }
    }
}