#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.MntxSeriesSpecific.Song;

namespace Domain.M3rSpecific.Song
{
    /// <summary>
    /// </summary>
    public class M3RSongMemory : MntxSongMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        public M3RSongMemory(string fileName)
            : base(fileName)
        {
        }
    }
}