#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.Global;
using PcgTools.Model.Common.Synth.MemoryAndFactory;

#endregion

namespace PcgTools.Model.MSpecific.Synth
{
    /// <summary>
    /// </summary>
    public abstract class MGlobal : Global
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        protected MGlobal(IPcgMemory pcgMemory) : base(pcgMemory)
        {
        }

        /// <summary>
        /// </summary>
        protected override int CategoryNameLength => 24;

        /// <summary>
        /// </summary>
        protected override int NrOfCategories => 18;

        /// <summary>
        /// </summary>
        protected override int NrOfSubCategories => 8;
    }
}