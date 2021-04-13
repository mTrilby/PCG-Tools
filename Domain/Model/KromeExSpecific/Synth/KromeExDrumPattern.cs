using Domain.Model.Common.Synth.PatchDrumPatterns;
using Domain.Model.MSpecific.Synth;

// (c) 2011 Michel Keijzers

namespace Domain.Model.KromeExSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class KromeExDrumPattern : MDrumPattern
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="drumPatternBank"></param>
        /// <param name="index"></param>
        public KromeExDrumPattern(DrumPatternBank drumPatternBank, int index)
            : base(drumPatternBank, index)
        {
        }
    }
}
