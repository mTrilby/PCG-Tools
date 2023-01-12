#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;

#endregion

namespace Domain.Common.Synth.MemoryAndFactory
{
    /// <summary>
    /// </summary>
    public class Chunk : IChunk
    {
        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="offset"></param>
        /// <param name="size"></param>
        public Chunk(string name, int offset, int size)
        {
// ReSharper disable RedundantStringFormatCall
            Console.WriteLine($"Chunk {name}, offset {offset:x10}, size {size:x10}");
// ReSharper restore RedundantStringFormatCall
            Name = name;
            Offset = offset;
            Size = size;
        }

        /// <summary>
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// </summary>
        public int Offset { get; }

        /// <summary>
        /// </summary>
        public int Size { get; }
    }
}