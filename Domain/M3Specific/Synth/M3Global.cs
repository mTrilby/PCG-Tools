#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.MSpecific.Synth;

#endregion

namespace PcgTools.Model.M3Specific.Synth
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