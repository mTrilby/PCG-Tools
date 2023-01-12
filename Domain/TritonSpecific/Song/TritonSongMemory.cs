#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.SongsRelated;

#endregion

namespace Domain.TritonSpecific.Song
{
    /// <summary>
    /// </summary>
    public abstract class TritonSongMemory : SongMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        protected TritonSongMemory(string fileName)
            : base(fileName)
        {
        }
    }
}