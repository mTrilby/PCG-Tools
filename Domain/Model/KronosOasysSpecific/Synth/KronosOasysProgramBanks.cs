﻿// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.PatchPrograms;

namespace Domain.Model.KronosOasysSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class KronosOasysProgramBanks : ProgramBanks
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pcgMemory"></param>
        protected KronosOasysProgramBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }
    }
}