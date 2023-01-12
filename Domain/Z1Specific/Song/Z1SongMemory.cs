#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.MntxSeriesSpecific.Song;

#endregion

namespace Domain.Z1Specific.Song
{
    /// <summary>
    /// </summary>
    public class Z1SongMemory : MntxSongMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        public Z1SongMemory(string fileName)
            : base(fileName)
        {
        }
    }
}