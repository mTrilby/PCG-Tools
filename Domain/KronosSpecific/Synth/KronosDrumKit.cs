#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using PcgTools.Model.Common.Synth.PatchDrumKits;
using PcgTools.Model.KronosOasysSpecific.Synth;

// (c) 2011 Michel Keijzers

namespace PcgTools.Model.KronosSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class KronosDrumKit : KronosOasysDrumKit
    {
        /// <summary>
        /// </summary>
        /// <param name="drumKitBank"></param>
        /// <param name="index"></param>
        public KronosDrumKit(DrumKitBank drumKitBank, int index)
            : base(drumKitBank, index)
        {
        }


        /// <summary>
        ///     Used for OS 1.5/1.6.
        /// </summary>
        public int Drk2BankOffset => ((DrumKitBanks)Parent.Parent).Drk2PcgOffset +
                                     128 * ((DrumKitBank)Parent).Index + Index;


        /// <summary>
        ///     Used for OS 1.5/1.6.
        /// </summary>
        public int Drk2PatchOffset => 128 * 128 + ((KronosDrumKitBanks)Parent.Parent).Drk2PcgOffset +
                                      128 * ((DrumKitBank)Parent).Index + Index;


        /// <summary>
        ///     Sets parameters after initialization.
        /// </summary>
        public override void SetParameters()
        {
        }
    }
}