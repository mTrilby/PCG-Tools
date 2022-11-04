#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.PatchPrograms;

namespace Domain.MntxSeriesSpecific.Synth
{
    /// <summary>
    /// </summary>
    public abstract class MntxProgramBanks : ProgramBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        protected MntxProgramBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }
    }
}