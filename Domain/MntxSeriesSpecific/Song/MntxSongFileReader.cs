#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System;
using Domain.Common.File;
using Domain.Common.Synth.SongsRelated;

namespace Domain.MntxSeriesSpecific.Song
{
    /// <summary>
    /// </summary>
    public abstract class MntxSongFileReader : SongFileReader
    {
        /// <summary>
        /// </summary>
        /// <param name="songMemory"></param>
        /// <param name="content"></param>
        protected MntxSongFileReader(ISongMemory songMemory, byte[] content)
            : base(songMemory, content)
        {
        }


        /// <summary>
        ///     Number of song tracks (equal to combi timbres)
        /// </summary>
        public override int NumberOfSongTracks => 8;


        /// <summary>
        ///     M, N, T and X series do not use chunks.
        /// </summary>
        public override void ReadChunks()
        {
            throw new NotSupportedException();
        }
    }
}