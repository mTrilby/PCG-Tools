#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.TritonSpecific.Synth;

namespace Domain.TritonExtremeSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class TritonExtremeGlobal : TritonGlobal
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public TritonExtremeGlobal(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }
    }
}