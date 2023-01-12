#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.SongsRelated;

#endregion

namespace Domain.MSpecific.Song
{
    /// <summary>
    /// </summary>
    public abstract class MSongMemory : SongMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        protected MSongMemory(string fileName)
            : base(fileName)
        {
        }
    }
}