#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.PatchCombis;

namespace Domain.MSpecific.Synth
{
    /// <summary>
    /// </summary>
    public abstract class MCombiBanks : CombiBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        protected MCombiBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }
    }
}