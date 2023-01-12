﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.File;
using PcgTools.Model.Common.Synth.SongsRelated;

#endregion

namespace PcgTools.Model.MSpecific.Song
{
    /// <summary>
    /// </summary>
    public abstract class MSongFileReader : SongFileReader
    {
        /// <summary>
        /// </summary>
        /// <param name="songMemory"></param>
        /// <param name="content"></param>
        protected MSongFileReader(ISongMemory songMemory, byte[] content)
            : base(songMemory, content)
        {
        }

        /// <summary>
        ///     Number of bytes in a song track (equal to length of a combi timbre).
        /// </summary>
        public override int SongTrackByteLength => 112;
    }
}