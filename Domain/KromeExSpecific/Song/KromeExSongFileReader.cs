#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.File;
using PcgTools.Model.Common.Synth.PatchCombis;
using PcgTools.Model.Common.Synth.SongsRelated;
using PcgTools.Model.KromeExSpecific.Synth;

#endregion

namespace PcgTools.Model.KromeExSpecific.Song
{
    /// <summary>
    /// </summary>
    public class KromeExSongFileReader : SongFileReader
    {
        /// <summary>
        /// </summary>
        /// <param name="songMemory"></param>
        /// <param name="content"></param>
        public KromeExSongFileReader(ISongMemory songMemory, byte[] content)
            : base(songMemory, content)
        {
        }

        /// <summary>
        ///     Number of bytes in a song track (equal to length of a combi timbre).
        /// </summary>
        public override int SongTrackByteLength => 112;

        /// <summary>
        /// </summary>
        /// <param name="timbres"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public override ITimbre CreateTimbre(ITimbres timbres, int index)
        {
            return new KromeExTimbre(timbres, index);
        }
    }
}