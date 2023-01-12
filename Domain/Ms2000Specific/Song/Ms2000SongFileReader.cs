#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;
using Domain.Common.File;
using Domain.Common.Synth.PatchCombis;
using Domain.Common.Synth.SongsRelated;

#endregion

namespace Domain.Ms2000Specific.Song
{
    /// <summary>
    /// </summary>
    public class Ms2000SongFileReader : SongFileReader
    {
        /// <summary>
        /// </summary>
        /// <param name="songMemory"></param>
        /// <param name="content"></param>
        public Ms2000SongFileReader(ISongMemory songMemory, byte[] content)
            : base(songMemory, content)
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="timbres"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public override ITimbre CreateTimbre(ITimbres timbres, int index)
        {
            throw new ApplicationException("Songs not supported");
        }
    }
}