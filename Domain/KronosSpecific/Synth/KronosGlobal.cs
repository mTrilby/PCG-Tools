#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.MemoryAndFactory;
using Domain.KronosOasysSpecific.Synth;

#endregion

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