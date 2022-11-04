#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.SongsRelated;

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