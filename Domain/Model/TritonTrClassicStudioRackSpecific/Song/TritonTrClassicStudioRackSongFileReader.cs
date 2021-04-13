// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.PatchCombis;
using Domain.Model.Common.Synth.SongsRelated;
using Domain.Model.TritonSpecific.Song;
using Domain.Model.TritonTrClassicStudioRackSpecific.Synth;

namespace Domain.Model.TritonTrClassicStudioRackSpecific.Song
{
    /// <summary>
    /// 
    /// </summary>
    public class TritonTrClassicStudioRackSongFileReader: TritonSongFileReader
    {
        /// <summary>
        /// 
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
