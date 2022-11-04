#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System;
using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.Common.Synth.Meta;
using PcgTools.Model.MntxSeriesSpecific.Synth;

namespace PcgTools.Model.XSeries.Synth
{
    /// <summary>
    /// </summary>
    public class XSeriesGlobal : MntxGlobal
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public XSeriesGlobal(IPcgMemory pcgMemory)
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