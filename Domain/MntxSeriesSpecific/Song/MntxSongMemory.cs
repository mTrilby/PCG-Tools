#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.SongsRelated;

#endregion

namespace PcgTools.Model.MntxSeriesSpecific.Song
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