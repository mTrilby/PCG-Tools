#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.PatchCombis;

namespace Domain.MntxSeriesSpecific.Synth
{
    /// <summary>
    /// </summary>
    public abstract class MntxCombiBanks : CombiBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        protected MntxCombiBanks(IPcgMemory pcgMemory)
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