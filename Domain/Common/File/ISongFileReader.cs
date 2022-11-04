#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

namespace PcgTools.Model.Common.File
{
    /// <summary>
    /// </summary>
    public interface ISongFileReader
    {
        /// <summary>
        ///     Number of song tracks (equal to number of timbres in a combi).
        /// </summary>
        int NumberOfSongTracks { get; }


        /// <summary>
        ///     Number of bytes in a song track (equal to length of a combi timbre).
        /// </summary>
        int SongTrackByteLength { get; }

        /// <summary>
        /// </summary>
        void ReadChunks();
    }
}