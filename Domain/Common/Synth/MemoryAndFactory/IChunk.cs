#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

namespace Domain.Common.Synth.MemoryAndFactory
{
    /// <summary>
    /// </summary>
    public interface IChunk
    {
        /// <summary>
        /// </summary>
        string Name { get; }

        /// <summary>
        /// </summary>
        int Offset { get; }

        /// <summary>
        /// </summary>
        int Size { get; }
    }
}