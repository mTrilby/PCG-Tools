﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.PatchDrumKits;
using PcgTools.Model.TritonSpecific.Synth;

#endregion

// (c) 2011 Michel Keijzers

namespace PcgTools.Model.TritonKarmaSpecific.Synth
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