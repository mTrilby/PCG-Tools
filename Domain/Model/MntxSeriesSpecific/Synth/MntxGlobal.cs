// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using System;
using Domain.Model.Common.Synth.Global;
using Domain.Model.Common.Synth.MemoryAndFactory;

namespace Domain.Model.MntxSeriesSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class MntxGlobal : Global
    {
        /// <summary>
        /// 
        /// </summary>
        protected override int PcgOffsetCategories
        {
            get
            {
                throw new NotSupportedException();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        protected override int CategoryNameLength
        {
            get
            {
                throw new NotSupportedException();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        protected override int NrOfCategories
        {
            get
            {
                throw new NotSupportedException();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        protected override int NrOfSubCategories
        {
            get
            {
                throw new NotSupportedException();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pcgMemory"></param>
        protected MntxGlobal(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }
    }
}
