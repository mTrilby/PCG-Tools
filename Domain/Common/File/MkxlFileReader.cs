#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;

namespace Domain.Common.File
{
    /// <summary>
    /// </summary>
    public abstract class MkxlFileReader : PatchesFileReader
    {
        /// <summary>
        /// </summary>
        /// <param name="currentPcgMemory"></param>
        /// <param name="content"></param>
        protected MkxlFileReader(IPcgMemory currentPcgMemory, byte[] content)
            : base(currentPcgMemory, content)
        {
        }
    }
}