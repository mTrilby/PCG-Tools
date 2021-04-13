// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.MicroKorgXlSpecific.Synth;

namespace Domain.Model.MicroKorgXlSpecific.Pcg
{
    /// <summary>
    /// 
    /// </summary>
    public class MicroKorgXlMkxlAllMemory : MkxlAllMemory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        public MicroKorgXlMkxlAllMemory(string fileName)
            : base(fileName, ModelsEModelType.MicroKorgXl)
        {
            CombiBanks = null;
            ProgramBanks = new MicroKorgXlProgramBanks(this);
            SetLists = null;
            WaveSequenceBanks = null;
            DrumKitBanks = null;
            DrumPatternBanks = null;
            Global = new MicroKorgXlGlobal(this);
            Model = Models.Find(ModelsEOsVersion.EOsVersionMicroKorgXl);
        }


        /// <summary>
        /// </summary>
        public override bool AreCategoriesEditable => false;
    }
}
