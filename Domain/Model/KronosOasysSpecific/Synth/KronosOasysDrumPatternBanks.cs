

// (c) 2011 Michel Keijzers

using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.PatchDrumPatterns;

namespace Domain.Model.KronosOasysSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class KronosOasysDrumPatternBanks : DrumPatternBanks
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pcgMemory"></param>
        protected KronosOasysDrumPatternBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }
    }
}
