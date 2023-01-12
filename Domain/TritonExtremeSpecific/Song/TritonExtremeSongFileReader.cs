#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.PatchCombis;
using PcgTools.Model.Common.Synth.SongsRelated;
using PcgTools.Model.TritonExtremeSpecific.Synth;
using PcgTools.Model.TritonSpecific.Song;

#endregion

namespace PcgTools.Model.TritonExtremeSpecific.Song
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