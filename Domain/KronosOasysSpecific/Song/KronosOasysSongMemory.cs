#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.SongsRelated;

namespace Domain.KronosOasysSpecific.Song
{
    /// <summary>
    /// </summary>
    public abstract class KronosOasysSongMemory : SongMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        protected KronosOasysSongMemory(string fileName)
            : base(fileName)
        {
        }
    }
}