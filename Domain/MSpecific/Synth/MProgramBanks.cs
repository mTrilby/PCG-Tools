#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.PatchPrograms;

#endregion

namespace Domain.MSpecific.Synth
{
    /// <summary>
    /// </summary>
    public abstract class MProgramBanks : ProgramBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        protected MProgramBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }
    }
}