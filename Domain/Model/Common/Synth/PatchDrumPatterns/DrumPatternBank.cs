using System;
using Domain.Model.Common.Synth.Meta;
using Domain.PcgToolsResources;

// (c) 2011 Michel Keijzers

namespace Domain.Model.Common.Synth.PatchDrumPatterns
{
    /// <summary>
    /// </summary>
    public abstract class DrumPatternBank : Bank<DrumPattern>, IDrumPatternBank
    {
        /// <summary>
        /// </summary>
        /// <param name="drumPatternBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        protected DrumPatternBank(IBanks drumPatternBanks, BankTypeEType type, string id, int pcgId)
            : base(drumPatternBanks, type, id, pcgId)
        {
        }


        /// <summary>
        /// </summary>
        public override string Name
        {
            get { return "n.a."; }
            set { throw new ApplicationException("Not yet implemented"); }
        }


        /// <summary>
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Strings.Bank_2str} {Id}";
        }
    }
}