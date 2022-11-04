#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.TritonSpecific.Song;

namespace Domain.TritonKarmaSpecific.Song
{
    /// <summary>
    /// </summary>
    public class TritonKarmaSongMemory : TritonSongMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        public TritonKarmaSongMemory(string fileName)
            : base(fileName)
        {
            Model = Models.Find(Models.EOsVersion.EOsVersionTritonKarma);
        }
    }
}