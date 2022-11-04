#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.MntxSeriesSpecific.Song;

namespace Domain.XSeries.Song
{
    /// <summary>
    /// </summary>
    public class XSeriesSongMemory : MntxSongMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        public XSeriesSongMemory(string fileName)
            : base(fileName)
        {
        }
    }
}