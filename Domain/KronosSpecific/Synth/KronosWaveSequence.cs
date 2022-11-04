#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.PatchWaveSequences;
using Domain.KronosOasysSpecific.Synth;

// (c) 2011 Michel Keijzers

namespace Domain.KronosSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class KronosWaveSequence : KronosOasysWaveSequence
    {
        /// <summary>
        /// </summary>
        /// <param name="waveSeqBank"></param>
        /// <param name="index"></param>
        public KronosWaveSequence(WaveSequenceBank waveSeqBank, int index)
            : base(waveSeqBank, index)
        {
        }


        /// <summary>
        ///     Used for OS 1.5/1.6.
        /// </summary>
        public int Wsq2BankOffset => ((WaveSequenceBanks)Parent.Parent).Wsq2PcgOffset +
                                     128 * ((WaveSequenceBank)Parent).Index + Index;


        /// <summary>
        ///     Used for OS 1.5/1.6.
        /// </summary>
        public int Wsq2PatchOffset => 128 * 128 + ((WaveSequenceBanks)Parent.Parent).Wsq2PcgOffset +
                                      128 * ((WaveSequenceBank)Parent).Index + Index;


        /// <summary>
        ///     Sets parameters after initialization.
        /// </summary>
        public override void SetParameters()
        {
        }
    }
}