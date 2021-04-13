// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.TritonSpecific.Pcg;
using Domain.Model.TritonTrClassicStudioRackSpecific.Synth;

namespace Domain.Model.TritonTrClassicStudioRackSpecific.Pcg
{
    /// <summary>
    /// 
    /// </summary>
    public class TritonTrClassicStudioRackPcgMemory : TritonPcgMemory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        public TritonTrClassicStudioRackPcgMemory(string fileName)
            : base(fileName, ModelsEModelType.TritonTrClassicStudioRack)
        {
            CombiBanks = new TritonTrClassicStudioRackCombiBanks(this);
            ProgramBanks = new TritonTrClassicStudioRackProgramBanks(this);
            SetLists = null;
            WaveSequenceBanks = null;
            DrumKitBanks = new TritonTrClassicStudioRackDrumKitBanks(this);
            DrumPatternBanks = null;
            Global = new TritonTrClassicStudioRackGlobal(this);
            Model = Models.Find(ModelsEOsVersion.EOsVersionTritonTrClassicStudioRack);
        }

    }
}
