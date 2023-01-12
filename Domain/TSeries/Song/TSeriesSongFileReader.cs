#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.PatchCombis;
using PcgTools.Model.Common.Synth.SongsRelated;
using PcgTools.Model.MntxSeriesSpecific.Song;
using PcgTools.Model.TSeries.Synth;

#endregion

namespace PcgTools.Model.TSeriesSpecific.Song
{
    /// <summary>
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class TSeriesSongFileReader : MntxSongFileReader
    {
        /// <summary>
        /// </summary>
        /// <param name="songMemory"></param>
        /// <param name="content"></param>
        public TSeriesSongFileReader(ISongMemory songMemory, byte[] content)
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
            return new TSeriesTimbre(timbres, index);
        }
    }
}