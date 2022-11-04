#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.PatchDrumPatterns;
using Domain.MSpecific.Synth;

// (c) 2011 Michel Keijzers

namespace Domain.KromeExSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class KromeExDrumPattern : MDrumPattern
    {
        /// <summary>
        /// </summary>
        /// <param name="drumPatternBank"></param>
        /// <param name="index"></param>
        public KromeExDrumPattern(DrumPatternBank drumPatternBank, int index)
            : base(drumPatternBank, index)
        {
        }
    }
}