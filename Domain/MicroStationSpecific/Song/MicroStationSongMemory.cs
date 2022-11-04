#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.SongsRelated;

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