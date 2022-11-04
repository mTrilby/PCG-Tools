#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.Global;
using Domain.Common.Synth.MemoryAndFactory;

namespace Domain.MSpecific.Synth
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