// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using Domain.Model.Common.File;
using Domain.Model.Common.Synth.SongsRelated;

namespace Domain.Model.KronosOasysSpecific.Song
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class KronosOasysSongFileReader: SongFileReader
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="songMemory"></param>
        /// <param name="content"></param>
        protected KronosOasysSongFileReader(ISongMemory songMemory, byte[] content) 
            : base(songMemory, content)
        {
        }
    }
}
