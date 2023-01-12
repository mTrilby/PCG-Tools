#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.MntxSeriesSpecific.Song;

#endregion

namespace Domain.TSeries.Song
{
    /// <summary>
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class TSeriesSongMemory : MntxSongMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        public TSeriesSongMemory(string fileName)
            : base(fileName)
        {
        }
    }
}