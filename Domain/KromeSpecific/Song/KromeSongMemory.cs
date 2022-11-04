#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.MSpecific.Song;

namespace Domain.KromeSpecific.Song
{
    /// <summary>
    /// </summary>
    public class KromeSongMemory : MSongMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        public KromeSongMemory(string fileName)
            : base(fileName)
        {
            Model = Models.Find(Models.EOsVersion.EOsVersionKrome);
        }
    }
}