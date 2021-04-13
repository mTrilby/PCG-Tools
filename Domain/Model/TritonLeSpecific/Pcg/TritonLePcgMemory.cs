// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.TritonLeSpecific.Synth;
using Domain.Model.TritonSpecific.Pcg;

namespace Domain.Model.TritonLeSpecific.Pcg
{
    /// <summary>
    /// 
    /// </summary>
    public class TritonLePcgMemory : TritonPcgMemory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        public TritonLePcgMemory(string fileName)
            : base(fileName, ModelsEModelType.TritonLe)
        {
            CombiBanks = new TritonLeCombiBanks(this);
            ProgramBanks = new TritonLeProgramBanks(this);
            SetLists = null;
            WaveSequenceBanks = null;
            DrumKitBanks = new TritonLeDrumKitBanks(this);
            DrumPatternBanks = null;
            Global = new TritonLeGlobal(this);
            Model = Models.Find(ModelsEOsVersion.EOsVersionTritonLe);
        }

    }
}
