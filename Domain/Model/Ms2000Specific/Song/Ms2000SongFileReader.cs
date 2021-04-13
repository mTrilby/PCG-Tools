// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using System;
using Domain.Model.Common.File;
using Domain.Model.Common.Synth.PatchCombis;
using Domain.Model.Common.Synth.SongsRelated;

namespace Domain.Model.Ms2000Specific.Song
{
    /// <summary>
    /// 
    /// </summary>
    public class Ms2000SongFileReader : SongFileReader
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="songMemory"></param>
        /// <param name="content"></param>
        public Ms2000SongFileReader(ISongMemory songMemory, byte[] content) 
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
            throw new ApplicationException("Songs not supported");
        }
    }
}
