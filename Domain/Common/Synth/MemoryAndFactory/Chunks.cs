#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System.Collections.Generic;

namespace PcgTools.Model.Common.Synth.MemoryAndFactory
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