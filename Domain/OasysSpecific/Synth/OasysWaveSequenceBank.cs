﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchWaveSequences;
using Domain.KronosOasysSpecific.Synth;

#endregion

// (c) 2011 Michel Keijzers

namespace Domain.OasysSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class OasysWaveSequenceBank : KronosOasysWaveSequenceBank
    {
        /// <summary>
        /// </summary>
        /// <param name="waveSeqBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        public OasysWaveSequenceBank(IWaveSequenceBanks waveSeqBanks, BankType.EType type, string id, int pcgId)
            : base(waveSeqBanks, type, id, pcgId)
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        public override void CreatePatch(int index)
        {
            Add(new OasysWaveSequence(this, index));
        }
    }
}