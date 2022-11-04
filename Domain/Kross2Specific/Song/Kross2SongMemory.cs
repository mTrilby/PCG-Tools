#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.MSpecific.Song;

namespace Domain.Kross2Specific.Song
{
    /// <summary>
    /// </summary>
    public class Kross2SongMemory : MSongMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        public Kross2SongMemory(string fileName)
            : base(fileName)
        {
            Model = Models.Find(Models.EOsVersion.EOsVersionKross2);
        }
    }
}