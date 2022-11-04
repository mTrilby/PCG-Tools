#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.TritonSpecific.Song;

namespace Domain.TritonLeSpecific.Song
{
    /// <summary>
    /// </summary>
    public class TritonLeSongMemory : TritonSongMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        public TritonLeSongMemory(string fileName)
            : base(fileName)
        {
            Model = Models.Find(Models.EOsVersion.EOsVersionTritonLe);
        }
    }
}