// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.MSpecific.Synth;

namespace Domain.Model.M3Specific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class M3Global : MGlobal
    {
        /// <summary>
        /// 
        /// </summary>
        protected override int PcgOffsetCategories => 15730;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pcgMemory"></param>
        public M3Global(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }
    }
}
