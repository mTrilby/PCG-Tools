// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.SongsRelated;

namespace Domain.Model.TritonSpecific.Song
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class TritonSongMemory : SongMemory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        protected TritonSongMemory(string fileName)
            : base(fileName)
        {
        }
    }
}
