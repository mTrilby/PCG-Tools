#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.Meta;
using Domain.TritonSpecific.Synth;

// (c) 2011 Michel Keijzers

namespace Domain.TritonTrClassicStudioRackSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class TritonTrClassicStudioRackDrumKitBank : TritonDrumKitBank
    {
        /// <summary>
        /// </summary>
        /// <param name="drumKitBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        public TritonTrClassicStudioRackDrumKitBank(IBanks drumKitBanks, BankType.EType type, string id, int pcgId)
            : base(drumKitBanks, type, id, pcgId)
        {
        }


        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        public override void CreatePatch(int index)
        {
            Add(new TritonTrClassicStudioRackDrumKit(this, index));
        }
    }
}