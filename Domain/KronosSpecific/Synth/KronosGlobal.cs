﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.KronosOasysSpecific.Synth;

#endregion

namespace PcgTools.Model.KronosSpecific.Synth
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