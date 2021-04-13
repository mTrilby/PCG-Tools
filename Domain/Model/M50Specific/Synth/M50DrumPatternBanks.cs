

// (c) 2011 Michel Keijzers

using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchDrumPatterns;

namespace Domain.Model.M50Specific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class M50DrumPatternBanks : DrumPatternBanks
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pcgMemory"></param>
        public M50DrumPatternBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        protected override void CreateBanks()
        {
            Add(new M50DrumPatternBank(this, BankTypeEType.Int, "P", 0)); // Preset

            Add(new M50DrumPatternBank(this, BankTypeEType.User, "U", 1));
        }
    }
}
