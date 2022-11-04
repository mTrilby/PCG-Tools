#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.KronosOasysSpecific.Synth;

namespace Domain.OasysSpecific.Synth
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