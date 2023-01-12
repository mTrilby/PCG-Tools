﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.Common.Synth.Meta;
using PcgTools.Model.Common.Synth.PatchDrumKits;

#endregion

namespace PcgTools.Model.M50Specific.Synth
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