#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using PcgTools.Model.Common.Synth.MemoryAndFactory;

namespace PcgTools.Model.Common.File
{
    public abstract class MkxlPProgFileReader : MkxlFileReader
    {
        /// <summary>
        /// </summary>
        /// <param name="currentPcgMemory"></param>
        /// <param name="content"></param>
        protected MkxlPProgFileReader(IPcgMemory currentPcgMemory, byte[] content)
            : base(currentPcgMemory, content)
        {
        }
    }
}