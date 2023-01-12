#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;
using Domain.Common.File;
using Domain.Common.Synth.PatchCombis;
using Domain.Common.Synth.SongsRelated;

#endregion

namespace Domain.MicroKorgXlSpecific.Song
{
    /// <summary>
    /// </summary>
    public class MicroKorgXlSongFileReader : SongFileReader
    {
        /// <summary>
        /// </summary>
        /// <param name="songMemory"></param>
        /// <param name="content"></param>
        public MicroKorgXlSongFileReader(ISongMemory songMemory, byte[] content)
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