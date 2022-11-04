#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.TritonSpecific.Song;

namespace Domain.TritonExtremeSpecific.Song
{
    /// <summary>
    /// </summary>
    public class TritonExtremeSongMemory : TritonSongMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        public TritonExtremeSongMemory(string fileName)
            : base(fileName)
        {
            Model = Models.Find(Models.EOsVersion.EOsVersionTritonExtreme);
        }
    }
}