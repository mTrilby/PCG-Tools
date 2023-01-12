#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.MntxSeriesSpecific.Song;

#endregion

namespace Domain.ZeroSeries.Song
{
    /// <summary>
    /// </summary>
    public class ZeroSeriesSongMemory : MntxSongMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        public ZeroSeriesSongMemory(string fileName)
            : base(fileName)
        {
        }
    }
}