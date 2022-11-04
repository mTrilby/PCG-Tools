#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using PcgTools.Model.Common.Synth.PatchCombis;
using PcgTools.Model.Common.Synth.SongsRelated;
using PcgTools.Model.TritonLeSpecific.Synth;
using PcgTools.Model.TritonSpecific.Song;

namespace PcgTools.Model.TritonLeSpecific.Song
{
    /// <summary>
    /// </summary>
    public class TritonLeSongFileReader : TritonSongFileReader
    {
        /// <summary>
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