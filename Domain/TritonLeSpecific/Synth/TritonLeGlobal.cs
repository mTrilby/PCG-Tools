#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.TritonSpecific.Synth;

namespace Domain.TritonLeSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class TritonLeGlobal : TritonGlobal
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public TritonLeGlobal(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }
    }
}