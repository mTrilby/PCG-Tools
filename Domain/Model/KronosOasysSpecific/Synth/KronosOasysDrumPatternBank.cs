using System;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchDrumPatterns; // (c) 2011 Michel Keijzers

namespace Domain.Model.KronosOasysSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class KronosOasysDrumPatternBank : DrumPatternBank
    {
        /// <summary>
        /// 
        /// </summary>
        public override int NrOfPatches
        {
            get
            {
                switch (Type)
                {
                    case BankTypeEType.Int:
                        return 1000; // Maximum amount

                    case BankTypeEType.User:
                        return 1000; // Maximum amount

                    default:
                        throw new NotSupportedException();
                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="drumPatternBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        protected KronosOasysDrumPatternBank(IDrumPatternBanks drumPatternBanks, BankTypeEType type, string id, 
            int pcgId)
            : base(drumPatternBanks, type, id, pcgId)
        {
        }
    }
}
