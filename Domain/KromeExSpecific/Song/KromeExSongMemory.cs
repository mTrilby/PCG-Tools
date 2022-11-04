#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.MSpecific.Song;

namespace Domain.KromeExSpecific.Song
{
    /// <summary>
    /// </summary>
    public class KromeExSongMemory : MSongMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        public KromeExSongMemory(string fileName)
            : base(fileName)
        {
            Model = Models.Find(Models.EOsVersion.EOsVersionKromeEx);
        }
    }
}