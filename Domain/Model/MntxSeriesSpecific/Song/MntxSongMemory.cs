// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.SongsRelated;

namespace Domain.Model.MntxSeriesSpecific.Song
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class MntxSongMemory : SongMemory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        protected MntxSongMemory(string fileName)
            : base(fileName)
        {
        }
    }
}
