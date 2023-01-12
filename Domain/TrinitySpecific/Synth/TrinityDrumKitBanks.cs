#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchDrumKits;

#endregion

namespace Domain.TrinitySpecific.Synth
{
    /// <summary>
    /// </summary>
    public class TrinityDrumKitBanks : DrumKitBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public TrinityDrumKitBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }

        /// <summary>
        /// </summary>
        protected override void CreateBanks()
        {
            foreach (var id in new[] { "A" })
            {
                Add(new TrinityDrumKitBank(this, BankType.EType.Int, id, -1));
            }
        }
    }
}