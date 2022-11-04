#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.PatchCombis;
using Domain.Common.Synth.SongsRelated;
using Domain.TritonSpecific.Song;
using Domain.TritonTrClassicStudioRackSpecific.Synth;

namespace Domain.TritonTrClassicStudioRackSpecific.Song
{
    /// <summary>
    /// </summary>
    public class TritonTrClassicStudioRackSongFileReader : TritonSongFileReader
    {
        /// <summary>
        /// </summary>
        /// <param name="songMemory"></param>
        /// <param name="content"></param>
        public TritonTrClassicStudioRackSongFileReader(ISongMemory songMemory, byte[] content)
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
            return new TritonTrClassicStudioRackTimbre(timbres, index);
        }
    }
}