#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.SongsRelated;
using PcgTools.Model.ZeroSeries.Song;

#endregion

namespace PcgTools.Model.Zero3Rw.Song
{
    /// <summary>
    /// </summary>
    public class Zero3RwSongFileReader : ZeroSeriesSongFileReader
    {
        /// <summary>
        /// </summary>
        /// <param name="songMemory"></param>
        /// <param name="content"></param>
        public Zero3RwSongFileReader(ISongMemory songMemory, byte[] content)
            : base(songMemory, content)
        {
        }
    }
}