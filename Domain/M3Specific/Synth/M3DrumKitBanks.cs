#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchDrumKits;

#endregion

namespace Domain.M3Specific.Synth
{
    /// <summary>
    /// </summary>
    public class M3DrumKitBanks : DrumKitBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public M3DrumKitBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }

        /// <summary>
        /// </summary>
        protected override void CreateBanks()
        {
            Add(new M3DrumKitBank(this, BankType.EType.Int, "INT", -1)); // Unknown PCG Id

            foreach (var id in new[] { "U-A", "U-B", "U-C", "U-D", "U-E", "U-F", "U-G" })
            {
                Add(new M3DrumKitBank(this, BankType.EType.User, id, -1)); // Unknown PCG Id
            }
        }
    }
}