#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.MSpecific.Song;

namespace Domain.M3Specific.Song
{
    /// <summary>
    /// </summary>
    public class M3SongMemory : MSongMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        public M3SongMemory(string fileName)
            : base(fileName)
        {
            Model = Models.Find(Models.EOsVersion.EOsVersionM3_20); // Songs are always considered M3 2.0 files
        }
    }
}