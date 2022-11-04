#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.TritonSpecific.Synth;

namespace PcgTools.Model.TritonKarmaSpecific.Synth
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