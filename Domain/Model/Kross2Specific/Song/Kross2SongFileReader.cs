﻿// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using Domain.Model.Common.File;
using Domain.Model.Common.Synth.PatchCombis;
using Domain.Model.Common.Synth.SongsRelated;
using Domain.Model.Kross2Specific.Synth;

namespace Domain.Model.Kross2Specific.Song
{
    /// <summary>
    /// 
    /// </summary>
    public class Kross2SongFileReader: SongFileReader
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="songMemory"></param>
        /// <param name="content"></param>
        public Kross2SongFileReader(ISongMemory songMemory, byte[] content) 
            : base(songMemory, content)
        {
        }


        /// <summary>
        /// Number of bytes in a song track (equal to length of a combi timbre).
        /// </summary>
        public override int SongTrackByteLength => 44;


        /// <summary>
        /// </summary>
        /// <param name="timbres"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public override ITimbre CreateTimbre(ITimbres timbres, int index)
        {
            return new Kross2Timbre(timbres, index);
        }
    }
}