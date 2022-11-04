#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchDrumKits;

namespace Domain.KromeSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class KromeDrumKitBanks : DrumKitBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public KromeDrumKitBanks(PcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// </summary>
        protected override void CreateBanks()
        {
            Add(new KromeDrumKitBank(this, BankType.EType.Int, "INT", -1));

            // 00(INT)..31(INT)
            //32(USER)..47(USER)
            foreach (var id in new[] { "U-INT", "U-B", "U-C", "U-D", "U-E", "U-F", "U-G" })
            {
                Add(new KromeDrumKitBank(this, BankType.EType.User, id, -1));
            }
        }
    }
}