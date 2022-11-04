#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using PcgTools.Model.Common.Synth.PatchDrumPatterns;

// (c) 2011 Michel Keijzers

namespace PcgTools.Model.MSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class M3DrumPattern : MDrumPattern
    {
        /// <summary>
        /// </summary>
        /// <param name="drumPatternBank"></param>
        /// <param name="index"></param>
        public M3DrumPattern(DrumPatternBank drumPatternBank, int index)
            : base(drumPatternBank, index)
        {
        }
    }
}