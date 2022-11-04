#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.MntxSeriesSpecific.Song;

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