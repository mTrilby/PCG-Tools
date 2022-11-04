#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchWaveSequences;
using Domain.KronosOasysSpecific.Synth;

// (c) 2011 Michel Keijzers

namespace Domain.KronosSpecific.Synth
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