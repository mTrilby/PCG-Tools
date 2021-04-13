using System;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchWaveSequences; // (c) 2011 Michel Keijzers

namespace Domain.Model.KronosOasysSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class KronosOasysWaveSequenceBank : WaveSequenceBank
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
                        return 150;
                    
                    case BankTypeEType.User:
                        return 32;

                    case BankTypeEType.Gm: // fall through
                    case BankTypeEType.UserExtended: // fall through
                    case BankTypeEType.Virtual: // fall through
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="waveSeqBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        protected KronosOasysWaveSequenceBank(IWaveSequenceBanks waveSeqBanks, BankTypeEType type, string id, int pcgId) : base(waveSeqBanks, type, id, pcgId)
        {
        }
    }
}
