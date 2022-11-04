#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.PatchCombis;
using Domain.Common.Synth.SongsRelated;
using Domain.M3Specific.Synth;
using Domain.MSpecific.Song;

namespace Domain.M3Specific.Song
{
    /// <summary>
    /// </summary>
    public class M3SongFileReader : MSongFileReader
    {
        /// <summary>
        /// </summary>
        /// <param name="songMemory"></param>
        /// <param name="content"></param>
        public M3SongFileReader(ISongMemory songMemory, byte[] content)
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
            return new M3Timbre(timbres, index);
        }
    }
}