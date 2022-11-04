#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.PatchPrograms;

namespace Domain.TritonSpecific.Synth
{
    /// <summary>
    /// </summary>
    public abstract class TritonProgramBanks : ProgramBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        protected TritonProgramBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }
    }
}