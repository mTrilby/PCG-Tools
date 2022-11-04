#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.TritonSpecific.Pcg;
using Domain.TritonTrClassicStudioRackSpecific.Synth;

namespace Domain.TritonTrClassicStudioRackSpecific.Pcg
{
    /// <summary>
    /// </summary>
    public class TritonTrClassicStudioRackPcgMemory : TritonPcgMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        public TritonTrClassicStudioRackPcgMemory(string fileName)
            : base(fileName, Models.EModelType.TritonTrClassicStudioRack)
        {
            CombiBanks = new TritonTrClassicStudioRackCombiBanks(this);
            ProgramBanks = new TritonTrClassicStudioRackProgramBanks(this);
            SetLists = null;
            WaveSequenceBanks = null;
            DrumKitBanks = new TritonTrClassicStudioRackDrumKitBanks(this);
            DrumPatternBanks = null;
            Global = new TritonTrClassicStudioRackGlobal(this);
            Model = Models.Find(Models.EOsVersion.EOsVersionTritonTrClassicStudioRack);
        }
    }
}