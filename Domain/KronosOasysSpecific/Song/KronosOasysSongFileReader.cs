#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.File;
using Domain.Common.Synth.SongsRelated;

namespace Domain.KronosOasysSpecific.Song
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