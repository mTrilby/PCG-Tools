#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.File;
using PcgTools.Model.Common.Synth.SongsRelated;

#endregion

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