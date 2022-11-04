#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.PatchWaveSequences;
using Domain.KronosOasysSpecific.Synth;

// (c) 2011 Michel Keijzers

namespace Domain.OasysSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class OasysWaveSequence : KronosOasysWaveSequence
    {
        /// <summary>
        /// </summary>
        /// <param name="waveSeqBank"></param>
        /// <param name="index"></param>
        public OasysWaveSequence(IWaveSequenceBank waveSeqBank, int index)
            : base(waveSeqBank, index)
        {
        }
    }
}