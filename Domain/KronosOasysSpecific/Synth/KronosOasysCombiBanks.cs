#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.PatchCombis;

namespace Domain.KronosOasysSpecific.Synth
{
    /// <summary>
    /// </summary>
    public abstract class KronosOasysCombiBanks : CombiBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        protected KronosOasysCombiBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }
    }
}