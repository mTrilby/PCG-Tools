#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.PatchDrumPatterns;
using Domain.KronosOasysSpecific.Synth;

// (c) 2011 Michel Keijzers

namespace Domain.KronosSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class KronosDrumPattern : KronosOasysDrumPattern
    {
        /// <summary>
        /// </summary>
        /// <param name="drumPatternBank"></param>
        /// <param name="index"></param>
        public KronosDrumPattern(DrumPatternBank drumPatternBank, int index)
            : base(drumPatternBank, index)
        {
        }


        /// <summary>
        ///     Used for OS 1.5/1.6.
        /// </summary>
        public int Drk2BankOffset => ((DrumPatternBanks)Parent.Parent).Drk2PcgOffset +
                                     128 * ((DrumPatternBank)Parent).Index + Index;


        /// <summary>
        ///     Used for OS 1.5/1.6.
        /// </summary>
        public int Drk2PatchOffset => 128 * 128 + ((KronosDrumPatternBanks)Parent.Parent).Drk2PcgOffset +
                                      128 * ((DrumPatternBank)Parent).Index + Index;


        /// <summary>
        ///     Sets parameters after initialization.
        /// </summary>
        public override void SetParameters()
        {
        }
    }
}