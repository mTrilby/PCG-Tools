#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.MntxSeriesSpecific.Song;

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