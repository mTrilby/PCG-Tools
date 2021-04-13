// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using Domain.Model.Common.Synth.MemoryAndFactory;

namespace Domain.Model.KronosOasysSpecific.Pcg
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class KronosOasysPcgMemory : PcgMemory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="modelType"></param>
        protected KronosOasysPcgMemory(string fileName, ModelsEModelType modelType)
            : base(fileName, modelType)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        public override bool HasSubCategories => true;


        /// <summary>
        /// 
        /// </summary>
        public override int NumberOfCategories => 18;


        /// <summary>
        /// 
        /// </summary>
        public override int NumberOfSubCategories => 8;
    }
}
