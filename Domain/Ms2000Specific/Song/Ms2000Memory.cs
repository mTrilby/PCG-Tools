#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.SongsRelated;

#endregion

namespace Domain.Ms2000Specific.Song
{
    /// <summary>
    /// </summary>
    public class Ms2000SongMemory : SongMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        public Ms2000SongMemory(string fileName)
            : base(fileName)
        {
        }
    }
}