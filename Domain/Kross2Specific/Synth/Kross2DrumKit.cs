#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.PatchDrumKits;
using Domain.MSpecific.Synth;

// (c) 2011 Michel Keijzers

namespace Domain.Kross2Specific.Synth
{
    /// <summary>
    /// </summary>
    public class Kross2DrumKit : MDrumKit
    {
        /// <summary>
        /// </summary>
        /// <param name="drumKitBank"></param>
        /// <param name="index"></param>
        public Kross2DrumKit(IDrumKitBank drumKitBank, int index)
            : base(drumKitBank, index)
        {
        }


        /// <summary>
        ///     Sets parameters after initialization.
        /// </summary>
        public override void SetParameters()
        {
        }
    }
}