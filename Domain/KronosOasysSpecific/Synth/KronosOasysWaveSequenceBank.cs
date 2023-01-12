#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchWaveSequences;

#endregion

// (c) 2011 Michel Keijzers

namespace Domain.KronosOasysSpecific.Synth
{
    /// <summary>
    /// </summary>
    public abstract class KronosOasysWaveSequenceBank : WaveSequenceBank
    {
        /// <summary>
        /// </summary>
        /// <param name="waveSeqBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        protected KronosOasysWaveSequenceBank(IWaveSequenceBanks waveSeqBanks, BankType.EType type, string id,
            int pcgId) : base(waveSeqBanks, type, id, pcgId)
        {
        }

        /// <summary>
        /// </summary>
        public override int NrOfPatches
        {
            get
            {
                switch (Type)
                {
                    case BankType.EType.Int:
                        return 150;

                    case BankType.EType.User:
                        return 32;

                    case BankType.EType.Gm: // fall through
                    case BankType.EType.UserExtended: // fall through
                    case BankType.EType.Virtual: // fall through
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}