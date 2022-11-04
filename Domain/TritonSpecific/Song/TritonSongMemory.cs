#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using PcgTools.Model.Common.Synth.SongsRelated;

namespace PcgTools.Model.TritonSpecific.Song
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