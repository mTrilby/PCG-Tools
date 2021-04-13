using System;
using Domain.Model.Common.Synth.Meta;
using Domain.PcgToolsResources;

// (c) 2011 Michel Keijzers

namespace Domain.Model.Common.Synth.PatchWaveSequences
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class WaveSequenceBank : Bank<WaveSequence>, IWaveSequenceBank
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="waveSeqBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        protected WaveSequenceBank(IWaveSequenceBanks waveSeqBanks, BankTypeEType type, string id, int pcgId)
            : base(waveSeqBanks, type, id, pcgId)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        public override string Name { get { return "n.a."; } set { throw new ApplicationException("Not yet implemented"); } }



        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Strings.Bank_2str} {Id}";
        }
    }
}
