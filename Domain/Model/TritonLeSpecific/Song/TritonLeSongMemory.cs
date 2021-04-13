// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.TritonSpecific.Song;

namespace Domain.Model.TritonLeSpecific.Song
{
    /// <summary>
    /// 
    /// </summary>
    public class TritonLeSongMemory : TritonSongMemory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        public TritonLeSongMemory(string fileName)
            : base(fileName)
        {
            Model = Models.Find(ModelsEOsVersion.EOsVersionTritonLe);
        }

    }
}
