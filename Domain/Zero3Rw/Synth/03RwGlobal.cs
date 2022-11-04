﻿#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.ZeroSeries.Synth;

namespace PcgTools.Model.Zero3Rw.Synth
{
    /// <summary>
    /// </summary>
    public class Zero3RwGlobal : ZeroSeriesGlobal
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public Zero3RwGlobal(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }
    }
}