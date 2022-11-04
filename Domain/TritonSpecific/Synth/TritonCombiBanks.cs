#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.PatchCombis;

namespace Domain.TritonSpecific.Synth
{
    /// <summary>
    /// </summary>
    public abstract class TritonCombiBanks : CombiBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        protected TritonCombiBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// </summary>
        protected override void CreateBanks()
        {
        }
    }
}