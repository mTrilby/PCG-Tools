﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.MntxSeriesSpecific.Synth;

#endregion

namespace Domain.M3rSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class M3RGlobal : MntxGlobal
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public M3RGlobal(PcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }

        /// <summary>
        ///     Category names are not in PCG.
        /// </summary>
        protected override int CategoryNameLength => throw new NotSupportedException();

        /// <summary>
        ///     Hardcoded.
        /// </summary>
        protected override int PcgOffsetCategories => throw new NotSupportedException();

        /// <summary>
        ///     Categories are taken from Mode.
        /// </summary>
        protected override int NrOfCategories => throw new NotSupportedException();

        /// <summary>
        /// </summary>
        protected override int NrOfSubCategories => throw new NotSupportedException();

        /// <summary>
        /// </summary>
        /// <param name="patch"></param>
        /// <returns></returns>
        public override string GetCategoryName(IPatch patch)
        {
            throw new NotSupportedException();
        }
    }
}