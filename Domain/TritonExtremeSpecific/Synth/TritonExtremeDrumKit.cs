#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.PatchDrumKits;
using Domain.TritonSpecific.Synth;

// (c) 2011 Michel Keijzers

namespace Domain.TritonExtremeSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class TritonExtremeDrumKit : TritonDrumKit
    {
        /// <summary>
        /// </summary>
        /// <param name="drumKitBank"></param>
        /// <param name="index"></param>
        public TritonExtremeDrumKit(IDrumKitBank drumKitBank, int index)
            : base(drumKitBank, index)
        {
        }


        /// <summary>
        /// </summary>
        public override void SetParameters()
        {
        }
    }
}