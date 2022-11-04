#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.SongsRelated;

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