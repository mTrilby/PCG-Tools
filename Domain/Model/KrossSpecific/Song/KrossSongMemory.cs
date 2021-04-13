// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.MSpecific.Song;

namespace Domain.Model.KrossSpecific.Song
{
    /// <summary>
    /// 
    /// </summary>
    public class KrossSongMemory : MSongMemory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        public KrossSongMemory(string fileName)
            : base(fileName)
        {
            Model = Models.Find(ModelsEOsVersion.EOsVersionKross);
        }
    }
}
