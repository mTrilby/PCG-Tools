// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.TritonSpecific.Song;

namespace Domain.Model.TritonTrClassicStudioRackSpecific.Song
{
    /// <summary>
    /// 
    /// </summary>
    public class TritonTrClassicStudioRackSongMemory : TritonSongMemory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        public TritonTrClassicStudioRackSongMemory(string fileName)
            : base(fileName)
        {
            Model = Models.Find(ModelsEOsVersion.EOsVersionTritonTrClassicStudioRack);
        }
    }
}
