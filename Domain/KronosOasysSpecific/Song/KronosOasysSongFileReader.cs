#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using PcgTools.Model.Common.File;
using PcgTools.Model.Common.Synth.SongsRelated;

namespace PcgTools.Model.KronosOasysSpecific.Song
{
    /// <summary>
    /// </summary>
    public abstract class KronosOasysSongFileReader : SongFileReader
    {
        /// <summary>
        /// </summary>
        /// <param name="songMemory"></param>
        /// <param name="content"></param>
        protected KronosOasysSongFileReader(ISongMemory songMemory, byte[] content)
            : base(songMemory, content)
        {
        }
    }
}