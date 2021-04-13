// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.TritonKarmaSpecific.Synth;
using Domain.Model.TritonSpecific.Pcg;

namespace Domain.Model.TritonKarmaSpecific.Pcg
{
    /// <summary>
    /// 
    /// </summary>
    public class TritonKarmaPcgMemory : TritonPcgMemory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        public TritonKarmaPcgMemory(string fileName)
            : base(fileName, ModelsEModelType.TritonKarma)
        {
            CombiBanks = new TritonKarmaCombiBanks(this);
            ProgramBanks = new TritonKarmaProgramBanks(this);
            SetLists = null;
            WaveSequenceBanks = null;
            DrumKitBanks = new TritonKarmaDrumKitBanks(this);
            DrumPatternBanks = null;
            Global = new TritonKarmaGlobal(this);
            Model = Models.Find(ModelsEOsVersion.EOsVersionTritonKarma);
        }

    }
}
