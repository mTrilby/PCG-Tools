﻿// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.KronosOasysSpecific.Synth;

namespace Domain.Model.OasysSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class OasysCombiBanks : KronosOasysCombiBanks
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pcgMemory"></param>
        public OasysCombiBanks(IPcgMemory pcgMemory) : base(pcgMemory)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        protected override void CreateBanks()
        {
            foreach (var id in new[] {"I-A", "I-B", "I-C", "I-D", "I-E", "I-F", "I-G"})
            {
                Add(new OasysCombiBank(this, BankTypeEType.Int, id, -1));
            }

            foreach (var id in new[] {"U-A", "U-B", "U-C", "U-D", "U-E", "U-F", "U-G"})
            {
                Add(new OasysCombiBank(this, BankTypeEType.User, id, -1));
            }
        }
    }
}