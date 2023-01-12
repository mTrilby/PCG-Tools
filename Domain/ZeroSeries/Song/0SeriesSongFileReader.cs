#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.PatchCombis;
using PcgTools.Model.Common.Synth.SongsRelated;
using PcgTools.Model.MntxSeriesSpecific.Song;
using PcgTools.Model.ZeroSeries.Synth;

#endregion

namespace PcgTools.Model.ZeroSeries.Song
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