#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.PatchDrumKits;
using PcgTools.Model.MSpecific.Synth;

#endregion

// (c) 2011 Michel Keijzers

namespace PcgTools.Model.KromeSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class KromeDrumKit : MDrumKit
    {
        /// <summary>
        /// </summary>
        /// <param name="drumKitBank"></param>
        /// <param name="index"></param>
        public KromeDrumKit(DrumKitBank drumKitBank, int index)
            : base(drumKitBank, index)
        {
        }
    }
}