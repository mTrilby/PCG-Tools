#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.PatchCombis;

#endregion

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