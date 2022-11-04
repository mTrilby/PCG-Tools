#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;

namespace Domain.TritonSpecific.Pcg
{
    /// <summary>
    /// </summary>
    public abstract class TritonPcgMemory : PcgMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="modelType"></param>
        protected TritonPcgMemory(string fileName, Models.EModelType modelType)
            : base(fileName, modelType)
        {
        }


        /// <summary>
        /// </summary>
        public override bool HasSubCategories => false;


        /// <summary>
        /// </summary>
        public override int NumberOfCategories => 16;


        /// <summary>
        /// </summary>
        public override int NumberOfSubCategories => 0;
    }
}