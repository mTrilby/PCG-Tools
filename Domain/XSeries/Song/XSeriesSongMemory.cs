#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.MntxSeriesSpecific.Song;

#endregion

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