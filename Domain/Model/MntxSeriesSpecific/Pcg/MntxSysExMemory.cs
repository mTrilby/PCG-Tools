// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using System;
using Domain.Model.Common.Synth.MemoryAndFactory;

namespace Domain.Model.MntxSeriesSpecific.Pcg
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class MntxSysExMemory : SysExMemory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="modelType"></param>
        /// <param name="contentType"></param>
        /// <param name="sysExStartOffset"></param>
        /// <param name="sysExEndOffset"></param>
        /// <param name="patchNamesCopyNeeded"></param>
        protected MntxSysExMemory(string fileName, ModelsEModelType modelType,
            PcgMemoryContentType contentType, int sysExStartOffset, int sysExEndOffset, bool patchNamesCopyNeeded)
            : base(fileName, modelType, contentType, sysExStartOffset, sysExEndOffset, patchNamesCopyNeeded)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        public override bool HasProgramCategories => false;


        /// <summary>
        /// 
        /// </summary>
        public override bool HasCombiCategories => false;


        /// <summary>
        /// 
        /// </summary>
        public override bool HasSubCategories => false;


        /// <summary>
        /// 
        /// </summary>
        public override int NumberOfCategories
        {
            get { throw new NotSupportedException("No categories"); }
        }


        /// <summary>
        /// 
        /// </summary>
        public override int NumberOfSubCategories
        {
            get { throw new NotSupportedException("No subcategories"); }
        }
    }
}
