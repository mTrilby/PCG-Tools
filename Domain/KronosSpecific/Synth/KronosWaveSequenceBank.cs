#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.Meta;
using PcgTools.Model.Common.Synth.PatchWaveSequences;
using PcgTools.Model.KronosOasysSpecific.Synth;

#endregion

// (c) 2011 Michel Keijzers

namespace PcgTools.Model.KronosSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class KronosWaveSequenceBank : KronosOasysWaveSequenceBank
    {
        /// <summary>
        /// </summary>
        /// <param name="waveSeqBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        public KronosWaveSequenceBank(IWaveSequenceBanks waveSeqBanks, BankType.EType type, string id, int pcgId)
            : base(waveSeqBanks, type, id, pcgId)
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        public override void CreatePatch(int index)
        {
            Add(new KronosWaveSequence(this, index));
        }
    }
}