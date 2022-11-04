#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.KronosOasysSpecific.Synth;

namespace Domain.KronosSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class KronosGlobal : KronosOasysGlobal
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public KronosGlobal(IPcgMemory pcgMemory) : base(pcgMemory)
        {
        }
    }
}