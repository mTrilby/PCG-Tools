#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System.Collections.Generic;

namespace Domain.Common.Synth.MemoryAndFactory
{
    /// <summary>
    /// </summary>
    public interface IChunks
    {
        /// <summary>
        /// </summary>
        List<IChunk> Collection { get; }
    }
}