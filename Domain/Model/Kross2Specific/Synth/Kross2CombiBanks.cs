// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.MSpecific.Synth;

namespace Domain.Model.Kross2Specific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class Kross2CombiBanks : MCombiBanks
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pcgMemory"></param>
        public Kross2CombiBanks(PcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        protected override void CreateBanks()
        {
            // Do not remove UNUSED banks, otherwise the ID to bank mapping is incorrect.
            foreach (var id in new[] {"A", "B", "C", "D", "UNUSED", "UNUSED", "UNUSED" })
            {
                Add(new Kross2CombiBank(this, BankTypeEType.Int, id, -1));
            }

            foreach (var id in new[] {"UA", "UB", "UC", "UD"})
            {
                Add(new Kross2CombiBank(this, BankTypeEType.User, id, -1));
            }
        }
    }
}
