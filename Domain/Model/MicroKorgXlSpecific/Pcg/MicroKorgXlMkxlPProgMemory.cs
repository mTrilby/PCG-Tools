// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.MicroKorgXlSpecific.Synth;

namespace Domain.Model.MicroKorgXlSpecific.Pcg
{
    /// <summary>
    /// 
    /// </summary>
    public class MicroKorgXlMkxlPProgMemory : MkxlAllMemory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        public MicroKorgXlMkxlPProgMemory(string fileName)
            : base(fileName, ModelsEModelType.MicroKorgXlPlus)
        {
            CombiBanks = null;
            ProgramBanks = new MicroKorgXlPlusProgramBanks(this);
            SetLists = null;
            WaveSequenceBanks = null;
            DrumKitBanks = null;
            DrumPatternBanks = null;
            Global = new MicroKorgXlGlobal(this);
            Model = Models.Find(ModelsEOsVersion.EOsVersionMicroKorgXlPlus);
        }
    }
}
