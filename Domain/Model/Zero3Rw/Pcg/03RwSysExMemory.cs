// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Zero3Rw.Synth;
using Domain.Model.ZeroSeries.Pcg;

namespace Domain.Model.Zero3Rw.Pcg
{
    /// <summary>
    /// 
    /// </summary>
    public class Zero3RwSysExMemory : ZeroSeriesSysExMemory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="contentType"></param>
        /// <param name="sysExStartOffset"></param>
        /// <param name="sysExEndOffset"></param>
        /// <param name="patchNamesCopyNeeded"></param>
        public Zero3RwSysExMemory(string fileName,
            PcgMemoryContentType contentType, int sysExStartOffset, int sysExEndOffset, bool patchNamesCopyNeeded)
            : base(fileName, contentType, sysExStartOffset, sysExEndOffset, patchNamesCopyNeeded)
        {
            CombiBanks = new Zero3RwCombiBanks(this);
            ProgramBanks = new Zero3RwProgramBanks(this);
            SetLists = null;
            WaveSequenceBanks = null;
            DrumKitBanks = null;
            DrumPatternBanks = null;
            Global = new Zero3RwGlobal(this);
            Model = Models.Find(ModelsEOsVersion.EosVersionZero3Rw);
        }
    }
}
