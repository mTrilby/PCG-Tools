﻿#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using PcgTools.Model.Common.Synth;
using PcgTools.Model.Common.Synth.MemoryAndFactory;

namespace PcgTools.Model.KronosOasysSpecific.Synth
{
    /// <summary>
    /// </summary>
    public abstract class KronosOasysProgramBanks : ProgramBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        protected KronosOasysProgramBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }
    }
}