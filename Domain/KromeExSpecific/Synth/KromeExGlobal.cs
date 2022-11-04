﻿#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.MSpecific.Synth;

namespace Domain.KromeExSpecific.Synth
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