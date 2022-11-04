#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.TritonSpecific.Synth;

namespace Domain.TritonKarmaSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class TritonKarmaGlobal : TritonGlobal
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public TritonKarmaGlobal(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }
    }
}