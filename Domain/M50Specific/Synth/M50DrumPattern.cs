#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.PatchDrumPatterns;
using Domain.MSpecific.Synth;

#endregion

// (c) 2011 Michel Keijzers

namespace Domain.M50Specific.Synth
{
    /// <summary>
    /// </summary>
    public class M50DrumPattern : MDrumPattern
    {
        /// <summary>
        /// </summary>
        /// <param name="drumPatternBank"></param>
        /// <param name="index"></param>
        public M50DrumPattern(DrumPatternBank drumPatternBank, int index)
            : base(drumPatternBank, index)
        {
        }
    }
}