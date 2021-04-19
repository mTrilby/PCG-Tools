﻿

// (c) 2011 Michel Keijzers

using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchDrumKits;

namespace Domain.Model.KromeSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class KromeDrumKitBanks : DrumKitBanks
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pcgMemory"></param>
        public KromeDrumKitBanks(PcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        protected override void CreateBanks()
        {
            Add(new KromeDrumKitBank(this, BankTypeEType.Int, "INT", -1));

            // 00(INT)..31(INT)
            //32(USER)..47(USER)
            foreach (var id in new[] { "U-INT", "U-B", "U-C", "U-D", "U-E", "U-F", "U-G" })
            {
                Add(new KromeDrumKitBank(this, BankTypeEType.User, id, -1));
            }
        }
    }
}