#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.PatchDrumPatterns;
using Domain.MSpecific.Synth;

// (c) 2011 Michel Keijzers

namespace Domain.KromeSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class KromeDrumPattern : MDrumPattern
    {
        /// <summary>
        /// </summary>
        /// <param name="drumPatternBank"></param>
        /// <param name="index"></param>
        public KromeDrumPattern(DrumPatternBank drumPatternBank, int index)
            : base(drumPatternBank, index)
        {
        }
    }
}