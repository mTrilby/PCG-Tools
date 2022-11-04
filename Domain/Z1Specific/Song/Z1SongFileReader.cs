#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.PatchCombis;
using Domain.Common.Synth.SongsRelated;
using Domain.MntxSeriesSpecific.Song;
using Domain.Z1Specific.Synth;

namespace Domain.Z1Specific.Song
{
    /// <summary>
    /// </summary>
    public class Z1SongFileReader : MntxSongFileReader
    {
        /// <summary>
        /// </summary>
        /// <param name="songMemory"></param>
        /// <param name="content"></param>
        public Z1SongFileReader(ISongMemory songMemory, byte[] content)
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
            return new Z1Timbre(timbres, index);
        }
    }
}