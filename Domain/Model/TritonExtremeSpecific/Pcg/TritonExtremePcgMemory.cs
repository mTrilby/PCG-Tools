// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.TritonExtremeSpecific.Synth;
using Domain.Model.TritonSpecific.Pcg;

namespace Domain.Model.TritonExtremeSpecific.Pcg
{
    /// <summary>
    /// 
    /// </summary>
    public class TritonExtremePcgMemory : TritonPcgMemory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        public TritonExtremePcgMemory(string fileName)
            : base(fileName, ModelsEModelType.TritonExtreme)
        {
            CombiBanks = new TritonExtremeCombiBanks(this);
            ProgramBanks = new TritonExtremeProgramBanks(this);
            SetLists = null;
            WaveSequenceBanks = null;
            DrumKitBanks = new TritonExtremeDrumKitBanks(this);
            DrumPatternBanks = null;
            Global = new TritonExtremeGlobal(this);
            Model = Models.Find(ModelsEOsVersion.EOsVersionTritonExtreme);
        }

    }
}
