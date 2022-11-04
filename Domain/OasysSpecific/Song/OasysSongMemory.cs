#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.KronosOasysSpecific.Song;

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