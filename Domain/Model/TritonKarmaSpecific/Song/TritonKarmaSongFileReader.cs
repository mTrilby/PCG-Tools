// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.PatchCombis;
using Domain.Model.Common.Synth.SongsRelated;
using Domain.Model.TritonKarmaSpecific.Synth;
using Domain.Model.TritonSpecific.Song;

namespace Domain.Model.TritonKarmaSpecific.Song
{
    /// <summary>
    /// 
    /// </summary>
    public class TritonKarmaSongFileReader: TritonSongFileReader
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="songMemory"></param>
        /// <param name="content"></param>
        public TritonKarmaSongFileReader(ISongMemory songMemory, byte[] content) 
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
            return new TritonKarmaTimbre(timbres, index);
        }
    }
}
