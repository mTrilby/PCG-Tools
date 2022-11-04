#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.KronosOasysSpecific.Song;

namespace PcgTools.Model.OasysSpecific.Song
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