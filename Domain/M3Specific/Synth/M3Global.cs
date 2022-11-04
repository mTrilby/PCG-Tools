#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.MSpecific.Synth;

namespace Domain.M3Specific.Synth
{
    /// <summary>
    /// </summary>
    public class M3Global : MGlobal
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public M3Global(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }

        /// <summary>
        /// </summary>
        protected override int PcgOffsetCategories => 15730;
    }
}