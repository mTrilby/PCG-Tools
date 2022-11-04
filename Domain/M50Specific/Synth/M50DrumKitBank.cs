#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchDrumKits;
using Domain.MSpecific.Synth;

// (c) 2011 Michel Keijzers

namespace Domain.M50Specific.Synth
{
    /// <summary>
    /// </summary>
    public class M50DrumKitBank : MDrumKitBank
    {
        /// <summary>
        /// </summary>
        /// <param name="drumKitBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        public M50DrumKitBank(IDrumKitBanks drumKitBanks, BankType.EType type, string id, int pcgId)
            : base(drumKitBanks, type, id, pcgId)
        {
        }


        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        public override void CreatePatch(int index)
        {
            Add(new M50DrumKit(this, index));
        }
    }
}