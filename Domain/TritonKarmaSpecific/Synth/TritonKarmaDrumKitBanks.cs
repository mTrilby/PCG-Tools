﻿#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchDrumKits;

namespace Domain.TritonKarmaSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class TritonKarmaDrumKitBanks : DrumKitBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public TritonKarmaDrumKitBanks(PcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// </summary>
        protected override void CreateBanks()
        {
            // LV: Following is based on documentation in "Karma Basic Guide page 93".
            // I did not find a PCG for Karma, to verify it loads correctly.
            // I am also not sure if it is correct for other Triton models that share this same class implementation!
            // Also have a look at PcgFileReader.DrumKitBankId2DrumKitIndex() if in the PCG the USER bank has id 0x20000.
            // Sorry but I could not do better than this at the moment, the Triton Drumkit banks are very differently organized...

            foreach (var id in new[] { "A/B", "C", "D" })
            {
                Add(new TritonKarmaDrumKitBank(this, BankType.EType.Int, id, -1));
            }

            Add(new TritonKarmaDrumKitBank(this, BankType.EType.User, "USER", -1));
        }
    }
}