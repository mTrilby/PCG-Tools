#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.PatchCombis;
using Domain.Common.Synth.SongsRelated;
using Domain.MntxSeriesSpecific.Song;
using Domain.ZeroSeries.Synth;

namespace Domain.ZeroSeries.Song
{
    /// <summary>
    /// </summary>
    public class ZeroSeriesSongFileReader : MntxSongFileReader
    {
        /// <summary>
        /// </summary>
        /// <param name="songMemory"></param>
        /// <param name="content"></param>
        public ZeroSeriesSongFileReader(ISongMemory songMemory, byte[] content)
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
            return new ZeroSeriesTimbre(timbres, index);
        }
    }
}