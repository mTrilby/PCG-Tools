#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.MSpecific.Song;

namespace Domain.KrossSpecific.Song
{
    /// <summary>
    /// </summary>
    public class KrossSongMemory : MSongMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        public KrossSongMemory(string fileName)
            : base(fileName)
        {
            Model = Models.Find(Models.EOsVersion.EOsVersionKross);
        }
    }
}