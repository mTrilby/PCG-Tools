#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchDrumKits;

namespace Domain.KrossSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class KrossDrumKitBanks : DrumKitBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public KrossDrumKitBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// </summary>
        protected override void CreateBanks()
        {
            Add(new KrossDrumKitBank(this, BankType.EType.Int, "INT", -1));

            // 00(INT)..31(INT)
            //32(USER)..47(USER)
            foreach (var id in new[] { "INT", "U-B", "U-C", "U-D", "U-E", "U-F", "U-G" })
            {
                Add(new KrossDrumKitBank(this, BankType.EType.User, id, -1));
            }
        }
    }
}