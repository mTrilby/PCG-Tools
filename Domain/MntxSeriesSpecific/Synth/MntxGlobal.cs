﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;
using PcgTools.Model.Common.Synth.Global;
using PcgTools.Model.Common.Synth.MemoryAndFactory;

#endregion

namespace PcgTools.Model.MntxSeriesSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class MntxGlobal : Global
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        protected MntxGlobal(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }

        /// <summary>
        /// </summary>
        protected override int PcgOffsetCategories => throw new NotSupportedException();

        /// <summary>
        /// </summary>
        protected override int CategoryNameLength => throw new NotSupportedException();

        /// <summary>
        /// </summary>
        protected override int NrOfCategories => throw new NotSupportedException();

        /// <summary>
        /// </summary>
        protected override int NrOfSubCategories => throw new NotSupportedException();
    }
}