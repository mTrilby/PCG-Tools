﻿

// (c) 2011 Michel Keijzers

using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchDrumKits;

namespace Domain.Model.M50Specific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class M50DrumKitBanks : DrumKitBanks
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pcgMemory"></param>
        public M50DrumKitBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        protected override void CreateBanks()
        {
            Add(new M50DrumKitBank(this, BankTypeEType.Int, "INT", -1)); // Unkown PCG Id
            Add(new M50DrumKitBank(this, BankTypeEType.User, "USER", -1)); // Unkown PCG Id
        }
    }
}