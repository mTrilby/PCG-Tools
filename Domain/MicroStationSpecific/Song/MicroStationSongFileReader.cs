#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using PcgTools.Model.Common.File;
using PcgTools.Model.Common.Synth.PatchCombis;
using PcgTools.Model.Common.Synth.SongsRelated;
using PcgTools.Model.MicroStationSpecific.Synth;

namespace PcgTools.Model.MicroStationSpecific.Song
{
    /// <summary>
    /// </summary>
    public class MicroStationSongFileReader : SongFileReader
    {
        /// <summary>
        /// </summary>
        /// <param name="songMemory"></param>
        /// <param name="content"></param>
        public MicroStationSongFileReader(ISongMemory songMemory, byte[] content)
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
            return new MicroStationTimbre(timbres, index);
        }
    }
}