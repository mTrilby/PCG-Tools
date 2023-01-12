#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.MSpecific.Synth;

#endregion

namespace Domain.Kross2Specific.Synth
{
    /// <summary>
    /// </summary>
    public class Kross2CombiBanks : MCombiBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public Kross2CombiBanks(PcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }

        /// <summary>
        /// </summary>
        protected override void CreateBanks()
        {
            // Do not remove UNUSED banks, otherwise the ID to bank mapping is incorrect.
            foreach (var id in new[] { "A", "B", "C", "D", "UNUSED", "UNUSED", "UNUSED" })
            {
                Add(new Kross2CombiBank(this, BankType.EType.Int, id, -1));
            }

            foreach (var id in new[] { "UA", "UB", "UC", "UD" })
            {
                Add(new Kross2CombiBank(this, BankType.EType.User, id, -1));
            }
        }
    }
}