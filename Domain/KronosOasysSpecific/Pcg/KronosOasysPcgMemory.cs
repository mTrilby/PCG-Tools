#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.MemoryAndFactory;

#endregion

namespace PcgTools.Model.KronosOasysSpecific.Pcg
{
    /// <summary>
    /// </summary>
    public abstract class KronosOasysPcgMemory : PcgMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="modelType"></param>
        protected KronosOasysPcgMemory(string fileName, Models.EModelType modelType)
            : base(fileName, modelType)
        {
        }

        /// <summary>
        /// </summary>
        public override bool HasSubCategories => true;

        /// <summary>
        /// </summary>
        public override int NumberOfCategories => 18;

        /// <summary>
        /// </summary>
        public override int NumberOfSubCategories => 8;
    }
}