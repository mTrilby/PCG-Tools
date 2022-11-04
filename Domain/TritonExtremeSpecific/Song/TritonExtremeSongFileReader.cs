#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.PatchCombis;
using Domain.Common.Synth.SongsRelated;
using Domain.TritonExtremeSpecific.Synth;
using Domain.TritonSpecific.Song;

namespace Domain.TritonExtremeSpecific.Song
{
    /// <summary>
    /// </summary>
    public class TritonExtremeSongFileReader : TritonSongFileReader
    {
        /// <summary>
        /// </summary>
        /// <param name="songMemory"></param>
        /// <param name="content"></param>
        public TritonExtremeSongFileReader(ISongMemory songMemory, byte[] content)
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
            return new TritonExtremeTimbre(timbres, index);
        }
    }
}