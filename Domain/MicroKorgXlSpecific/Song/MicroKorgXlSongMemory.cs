#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.SongsRelated;

#endregion

namespace Domain.MicroKorgXlSpecific.Song
{
    /// <summary>
    /// </summary>
    public class MicroKorgXlSongMemory : SongMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        public MicroKorgXlSongMemory(string fileName)
            : base(fileName)
        {
        }
    }
}