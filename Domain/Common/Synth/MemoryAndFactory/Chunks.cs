#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System.Collections.Generic;

#endregion

namespace Domain.Common.Synth.MemoryAndFactory
{
    /// <summary>
    /// </summary>
    public class Chunks : IChunks
    {
        /// <summary>
        /// </summary>
        public Chunks()
        {
            Collection = new List<IChunk>();
        }

        /// <summary>
        /// </summary>
        public List<IChunk> Collection { get; }
    }
}