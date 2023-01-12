#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.Common.Synth.PatchWaveSequences;

#endregion

namespace PcgTools.Model.KronosOasysSpecific.Synth
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