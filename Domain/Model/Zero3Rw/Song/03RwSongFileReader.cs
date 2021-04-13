// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using Domain.Model.Common.Synth.SongsRelated;
using Domain.Model.ZeroSeries.Song;

namespace Domain.Model.Zero3Rw.Song
{
    /// <summary>
    /// 
    /// </summary>
    public class Zero3RwSongFileReader : ZeroSeriesSongFileReader
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="songMemory"></param>
        /// <param name="content"></param>
        public Zero3RwSongFileReader(ISongMemory songMemory, byte[] content) 
            : base(songMemory, content)
        {
        }
    }
}
