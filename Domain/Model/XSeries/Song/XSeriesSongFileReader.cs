// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using Domain.Model.Common.Synth.PatchCombis;
using Domain.Model.Common.Synth.SongsRelated;
using Domain.Model.MntxSeriesSpecific.Song;
using Domain.Model.XSeries.Synth;

namespace Domain.Model.XSeries.Song
{
    /// <summary>
    /// 
    /// </summary>
    public class XSeriesSongFileReader : MntxSongFileReader
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="songMemory"></param>
        /// <param name="content"></param>
        public XSeriesSongFileReader(ISongMemory songMemory, byte[] content) 
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
            return new XSeriesTimbre(timbres, index);
        }
    }
}
