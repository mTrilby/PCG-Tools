﻿#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchDrumKits;

namespace Domain.TritonSpecific.Synth
{
    /// <summary>
    /// </summary>
    public abstract class TritonDrumKitBank : DrumKitBank
    {
        /// <summary>
        /// </summary>
        /// <param name="drumKitBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        protected TritonDrumKitBank(IBanks drumKitBanks, BankType.EType type, string id, int pcgId)
            : base(drumKitBanks, type, id, pcgId)
        {
        }

        /// <summary>
        /// </summary>
        public override int NrOfPatches => 16;
    }
}