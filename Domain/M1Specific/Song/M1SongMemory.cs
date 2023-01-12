#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.MntxSeriesSpecific.Song;

#endregion

namespace Domain.M1Specific.Song
{
    /// <summary>
    /// </summary>
    public class M1SongMemory : MntxSongMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        public M1SongMemory(string fileName)
            : base(fileName)
        {
        }
    }
}