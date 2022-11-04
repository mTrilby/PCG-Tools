#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchDrumKits;

namespace Domain.M50Specific.Synth
{
    /// <summary>
    /// </summary>
    public class M50DrumKitBanks : DrumKitBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public M50DrumKitBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// </summary>
        protected override void CreateBanks()
        {
            Add(new M50DrumKitBank(this, BankType.EType.Int, "INT", -1)); // Unkown PCG Id
            Add(new M50DrumKitBank(this, BankType.EType.User, "USER", -1)); // Unkown PCG Id
        }
    }
}