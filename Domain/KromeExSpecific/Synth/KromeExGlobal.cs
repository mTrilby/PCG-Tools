#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.MSpecific.Synth;

#endregion

namespace PcgTools.Model.KromeExSpecific.Synth
{
    public class KromeExGlobal : MGlobal
    {
// In full PCG: global at 3613a0, categories at 363902

        public KromeExGlobal(PcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }

        protected override int PcgOffsetCategories => 9558;
    }
}