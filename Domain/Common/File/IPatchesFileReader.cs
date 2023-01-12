#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.MemoryAndFactory;

#endregion

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