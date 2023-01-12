#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.KronosOasysSpecific.Synth;

#endregion

namespace PcgTools.Model.OasysSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class OasysGlobal : KronosOasysGlobal
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public OasysGlobal(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }
    }
}