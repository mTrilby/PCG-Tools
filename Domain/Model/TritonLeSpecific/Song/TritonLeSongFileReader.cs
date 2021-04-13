// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.PatchCombis;
using Domain.Model.Common.Synth.SongsRelated;
using Domain.Model.TritonLeSpecific.Synth;
using Domain.Model.TritonSpecific.Song;

namespace Domain.Model.TritonLeSpecific.Song
{
    /// <summary>
    /// 
    /// </summary>
    public class TritonLeSongFileReader: TritonSongFileReader
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="songMemory"></param>
        /// <param name="content"></param>
        public TritonLeSongFileReader(ISongMemory songMemory, byte[] content) 
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
            return new TritonLeTimbre(timbres, index);
        }
    }
}
