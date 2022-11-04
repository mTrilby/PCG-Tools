#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.TritonSpecific.Synth;

namespace PcgTools.Model.TritonExtremeSpecific.Synth
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