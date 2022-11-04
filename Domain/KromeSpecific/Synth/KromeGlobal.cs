#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.MSpecific.Synth;

namespace PcgTools.Model.KromeSpecific.Synth
{
    public class KromeGlobal : MGlobal
    {
// In full PCG: global at 3613a0, categories at 363902

        public KromeGlobal(PcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }

        protected override int PcgOffsetCategories => 9558;
    }
}