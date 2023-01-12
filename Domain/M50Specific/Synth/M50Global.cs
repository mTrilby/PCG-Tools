#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.MSpecific.Synth;

#endregion

namespace PcgTools.Model.M50Specific.Synth
{
    /// <summary>
    /// </summary>
    public class M50Global : MGlobal
    {
// In full PCG: global at 3613a0, categories at 363902

/// <summary>
/// </summary>
/// <param name="pcgMemory"></param>
public M50Global(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }

/// <summary>
/// </summary>
protected override int PcgOffsetCategories => 9558;
    }
}