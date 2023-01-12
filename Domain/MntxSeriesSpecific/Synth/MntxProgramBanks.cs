#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth;
using PcgTools.Model.Common.Synth.MemoryAndFactory;

#endregion

namespace PcgTools.Model.MntxSeriesSpecific.Synth
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