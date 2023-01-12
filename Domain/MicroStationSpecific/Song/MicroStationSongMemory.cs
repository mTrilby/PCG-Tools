#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.SongsRelated;

#endregion

namespace Domain.MicroStationSpecific.Song
{
    /// <summary>
    /// </summary>
    public class MicroStationSongMemory : SongMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        public MicroStationSongMemory(string fileName)
            : base(fileName)
        {
        }
    }
}