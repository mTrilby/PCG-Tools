#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.SongsRelated;

#endregion

namespace Domain.MntxSeriesSpecific.Song
{
    /// <summary>
    /// </summary>
    public abstract class MntxSongMemory : SongMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        protected MntxSongMemory(string fileName)
            : base(fileName)
        {
        }
    }
}