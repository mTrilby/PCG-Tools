#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.TritonSpecific.Synth;

#endregion

namespace PcgTools.Model.TritonLeSpecific.Synth
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