#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.TritonSpecific.Pcg;
using PcgTools.Model.TritonTrClassicStudioRackSpecific.Synth;

#endregion

namespace PcgTools.Model.TritonTrClassicStudioRackSpecific.Pcg
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