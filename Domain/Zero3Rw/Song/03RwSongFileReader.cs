﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.SongsRelated;
using Domain.ZeroSeries.Song;

#endregion

namespace Domain.Zero3Rw.Song
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