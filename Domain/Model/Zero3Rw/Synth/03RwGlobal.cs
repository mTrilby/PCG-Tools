// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.ZeroSeries.Synth;

namespace Domain.Model.Zero3Rw.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class Zero3RwGlobal : ZeroSeriesGlobal
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pcgMemory"></param>
        public Zero3RwGlobal(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }
    }
}
