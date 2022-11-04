#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.TritonSpecific.Synth;

namespace Domain.TritonTrClassicStudioRackSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class TritonTrClassicStudioRackGlobal : TritonGlobal
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public TritonTrClassicStudioRackGlobal(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }
    }
}