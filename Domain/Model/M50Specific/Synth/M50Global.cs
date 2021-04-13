// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.MSpecific.Synth;

namespace Domain.Model.M50Specific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class M50Global : MGlobal
    {
        /// <summary>
        /// 
        /// </summary>
        protected override int PcgOffsetCategories => 9558;

// In full PCG: global at 3613a0, categories at 363902


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pcgMemory"></param>
        public M50Global(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }
    }
}
