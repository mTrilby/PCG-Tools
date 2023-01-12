﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.Global;
using PcgTools.Model.Common.Synth.MemoryAndFactory;

#endregion

namespace PcgTools.Model.KronosOasysSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class KronosOasysGlobal : Global
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        protected KronosOasysGlobal(IPcgMemory pcgMemory) : base(pcgMemory)
        {
        }

        /// <summary>
        /// </summary>
        protected override int CategoryNameLength => 24;

        /// <summary>
        /// </summary>
        protected override int PcgOffsetCategories => 12912;

// 12918 for kronos ? 9558; } } // In full PCG: global at 3613a0, categories at 363902

/// <summary>
/// </summary>
protected override int NrOfCategories => 18;

/// <summary>
/// </summary>
protected override int NrOfSubCategories => 8;
    }
}