using Domain.Model.Common.Synth.PatchDrumPatterns;
using Domain.Model.MSpecific.Synth;

// (c) 2011 Michel Keijzers

namespace Domain.Model.M3Specific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class M3DrumPattern : MDrumPattern
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="drumPatternBank"></param>
        /// <param name="index"></param>
        public M3DrumPattern(DrumPatternBank drumPatternBank, int index)
            : base(drumPatternBank, index)
        {
        }
    }
}
