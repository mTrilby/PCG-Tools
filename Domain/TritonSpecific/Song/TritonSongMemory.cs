#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.SongsRelated;

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