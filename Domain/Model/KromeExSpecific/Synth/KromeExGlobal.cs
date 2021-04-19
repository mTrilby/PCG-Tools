﻿// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.MSpecific.Synth;

namespace Domain.Model.KromeExSpecific.Synth
{
    public class KromeExGlobal : MGlobal
    {
        protected override int PcgOffsetCategories => 9558;
// In full PCG: global at 3613a0, categories at 363902

        public KromeExGlobal(PcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }
    }
}