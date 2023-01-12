#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.MemoryAndFactory;
using Domain.KronosOasysSpecific.Song;

#endregion

namespace Domain.OasysSpecific.Song
{
    /// <summary>
    /// </summary>
    public class OasysSongMemory : KronosOasysSongMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        public OasysSongMemory(string fileName)
            : base(fileName)
        {
            Model = Models.Find(Models.EOsVersion.EOsVersionOasys);
        }
    }
}