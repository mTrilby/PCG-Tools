using Domain.MasterFiles;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchWaveSequences;
using Domain.Model.KronosOasysSpecific.Synth;

// (c) 2011 Michel Keijzers

namespace Domain.Model.OasysSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class OasysWaveSequenceBank : KronosOasysWaveSequenceBank
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="waveSeqBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        public OasysWaveSequenceBank(IWaveSequenceBanks waveSeqBanks, BankTypeEType type, string id, int pcgId)
            : base(waveSeqBanks, type, id, pcgId)
        {
        }


        ///<summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        public override void CreatePatch(int index)
        {
            Add(new OasysWaveSequence(this, index));
        }
    }
}