#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;

namespace Domain.MicroKorgXlSpecific.Pcg
{
    /// <summary>
    /// </summary>
    public class MicroKorgXlMkxlPAllFileReader : MicroKorgXlMkxlAllFileReader
    {
        /// <summary>
        /// </summary>
        /// <param name="currentPcgMemory"></param>
        /// <param name="content"></param>
        public MicroKorgXlMkxlPAllFileReader(IPcgMemory currentPcgMemory, byte[] content)
            : base(currentPcgMemory, content)
        {
        }
    }
}