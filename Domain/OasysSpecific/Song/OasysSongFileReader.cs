#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.PatchCombis;
using Domain.Common.Synth.SongsRelated;
using Domain.KronosOasysSpecific.Song;
using Domain.OasysSpecific.Synth;

#endregion

namespace Domain.OasysSpecific.Song
{
    /// <summary>
    /// </summary>
    public class OasysSongFileReader : KronosOasysSongFileReader
    {
        /// <summary>
        /// </summary>
        /// <param name="songMemory"></param>
        /// <param name="content"></param>
        public OasysSongFileReader(ISongMemory songMemory, byte[] content)
            : base(songMemory, content)
        {
        }

        /// <summary>
        ///     Byte offset where timbres start.
        /// </summary>
        protected override int TimbresByteOffset => 4790 + 12;

        /// <summary>
        ///     Number of bytes in a song track (equal to length of a combi timbre).
        /// </summary>
        public override int SongTrackByteLength => 186;

        /// <summary>
        /// </summary>
        /// <param name="timbres"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public override ITimbre CreateTimbre(ITimbres timbres, int index)
        {
            return new OasysTimbre(timbres, index);
        }
    }
}