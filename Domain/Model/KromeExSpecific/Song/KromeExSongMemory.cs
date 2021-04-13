// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.MSpecific.Song;

namespace Domain.Model.KromeExSpecific.Song
{
    /// <summary>
    /// 
    /// </summary>
    public class KromeExSongMemory : MSongMemory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        public KromeExSongMemory(string fileName)
            : base(fileName)
        {
            Model = Models.Find(ModelsEOsVersion.EOsVersionKromeEx);
        }
    }
}
