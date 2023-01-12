#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;
using PcgTools.Model.Common.Synth.Global;
using PcgTools.Model.Common.Synth.MemoryAndFactory;

#endregion

namespace PcgTools.Model.TritonSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class TritonGlobal : Global
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        protected TritonGlobal(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }

        /// <summary>
        /// </summary>
        protected override int PcgOffsetCategories => 324;

        /// <summary>
        /// </summary>
        protected override int CategoryNameLength => 16;

        /// <summary>
        /// </summary>
        protected override int NrOfCategories => 16;

        /// <summary>
        /// </summary>
        protected override int NrOfSubCategories => throw new NotSupportedException("No sub categories supported");
    }
}