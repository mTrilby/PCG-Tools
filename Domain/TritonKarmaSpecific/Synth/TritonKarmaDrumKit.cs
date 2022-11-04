#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.PatchDrumKits;
using Domain.TritonSpecific.Synth;

// (c) 2011 Michel Keijzers

namespace Domain.TritonKarmaSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class TritonKarmaDrumKit : TritonDrumKit
    {
        /// <summary>
        /// </summary>
        /// <param name="drumKitBank"></param>
        /// <param name="index"></param>
        public TritonKarmaDrumKit(IDrumKitBank drumKitBank, int index)
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