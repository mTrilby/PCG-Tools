#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.PatchDrumKits;
using Domain.TritonSpecific.Synth;

// (c) 2011 Michel Keijzers

namespace Domain.TritonTrClassicStudioRackSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class TritonTrClassicDrumKit : TritonDrumKit
    {
        /// <summary>
        /// </summary>
        /// <param name="drumKitBank"></param>
        /// <param name="index"></param>
        public TritonTrClassicDrumKit(IDrumKitBank drumKitBank, int index)
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