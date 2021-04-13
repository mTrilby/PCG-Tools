// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.MSpecific.Synth;

namespace Domain.Model.KrossSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class KrossCombiBanks : MCombiBanks
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pcgMemory"></param>
        public KrossCombiBanks(PcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        protected override void CreateBanks()
        {
            //                          0    1   
            foreach (var id in new[] {"A", "B"})
            {
                Add(new KrossCombiBank(this, BankTypeEType.Int, id, -1));
            }

            Add(new KrossCombiBank(this, BankTypeEType.User, "U", -1));
        }
    }
}
