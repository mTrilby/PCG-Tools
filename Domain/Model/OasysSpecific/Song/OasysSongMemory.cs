// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.KronosOasysSpecific.Song;

namespace Domain.Model.OasysSpecific.Song
{
    /// <summary>
    /// 
    /// </summary>
    public class OasysSongMemory : KronosOasysSongMemory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        public OasysSongMemory(string fileName)
            : base(fileName)
        {
            Model = Models.Find(ModelsEOsVersion.EOsVersionOasys);
        }

    }
}
