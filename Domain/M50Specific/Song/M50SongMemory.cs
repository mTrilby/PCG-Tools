#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.MSpecific.Song;

namespace PcgTools.Model.M50Specific.Song
{
    /// <summary>
    /// </summary>
    public class M50SongMemory : MSongMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        public M50SongMemory(string fileName)
            : base(fileName)
        {
            Model = Models.Find(Models.EOsVersion.EOsVersionM50);
        }
    }
}