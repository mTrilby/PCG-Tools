#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using PcgTools.Model.Common.Synth;
using PcgTools.Model.Common.Synth.MemoryAndFactory;

namespace PcgTools.Model.TritonSpecific.Synth
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