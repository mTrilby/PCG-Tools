#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.Meta;
using PcgTools.Model.Common.Synth.PatchDrumKits;
using PcgTools.Model.MSpecific.Synth;

#endregion

// (c) 2011 Michel Keijzers

namespace PcgTools.Model.KromeExSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class KromeExDrumKit : MDrumKit
    {
        /// <summary>
        /// </summary>
        /// <param name="drumKitBank"></param>
        /// <param name="index"></param>
        public KromeExDrumKit(DrumKitBank drumKitBank, int index)
            : base(drumKitBank, index)
        {
            // Override ID.
            var indexInId = index;
            if (drumKitBank.Type == BankType.EType.User)
            {
                indexInId += PcgRoot.DrumKitBanks.BankCollection[0].NrOfPatches;
            }

            Id = $"{drumKitBank.Id}{indexInId.ToString("000")}";
        }
    }
}