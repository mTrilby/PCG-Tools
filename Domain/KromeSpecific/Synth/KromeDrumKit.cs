#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.PatchDrumKits;
using Domain.MSpecific.Synth;

// (c) 2011 Michel Keijzers

namespace Domain.KromeSpecific.Synth
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