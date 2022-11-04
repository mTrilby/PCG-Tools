#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.PatchCombis;
using Domain.Common.Synth.SongsRelated;
using Domain.M1Specific.Synth;
using Domain.MntxSeriesSpecific.Song;

namespace Domain.M1Specific.Song
{
    /// <summary>
    /// </summary>
    public class M1SongFileReader : MntxSongFileReader
    {
        /// <summary>
        /// </summary>
        /// <param name="songMemory"></param>
        /// <param name="content"></param>
        public M1SongFileReader(ISongMemory songMemory, byte[] content)
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
            return new M1Timbre(timbres, index);
        }
    }
}