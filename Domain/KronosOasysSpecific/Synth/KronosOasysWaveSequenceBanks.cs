#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.PatchWaveSequences;

namespace Domain.KronosOasysSpecific.Synth
{
    /// <summary>
    /// </summary>
    public abstract class KronosOasysWaveSequenceBanks : WaveSequenceBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        protected KronosOasysWaveSequenceBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }
    }
}