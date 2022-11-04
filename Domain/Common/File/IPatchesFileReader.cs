#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;

namespace Domain.Common.File
{
    /// <summary>
    /// </summary>
    public interface IPatchesFileReader
    {
        /// <summary>
        /// </summary>
        /// <param name="fileType"></param>
        /// <param name="modelType"></param>
        void ReadContent(Memory.FileType fileType, Models.EModelType modelType);
    }
}