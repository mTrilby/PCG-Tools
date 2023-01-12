#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.PatchDrumKits;
using PcgTools.Model.KronosOasysSpecific.Synth;

#endregion

// (c) 2011 Michel Keijzers

namespace PcgTools.Model.OasysSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class OasysDrumKit : KronosOasysDrumKit
    {
        /// <summary>
        /// </summary>
        /// <param name="drumKitBank"></param>
        /// <param name="index"></param>
        public OasysDrumKit(IDrumKitBank drumKitBank, int index)
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