using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchDrumPatterns;

// (c) 2011 Michel Keijzers

namespace Domain.Model.MSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class MDrumPatternBanks : DrumPatternBanks
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pcgMemory"></param>
        public MDrumPatternBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        protected override void CreateBanks()
        {
            Add(new MDrumPatternBank(this, BankTypeEType.Int, "P", 0)); // Preset

            Add(new MDrumPatternBank(this, BankTypeEType.User, "U", 1));
        }
    }
}
