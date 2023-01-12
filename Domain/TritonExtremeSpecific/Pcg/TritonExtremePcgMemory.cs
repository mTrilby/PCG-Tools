#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.TritonExtremeSpecific.Synth;
using PcgTools.Model.TritonSpecific.Pcg;

#endregion

namespace PcgTools.Model.TritonExtremeSpecific.Pcg
{
    /// <summary>
    /// </summary>
    public class TritonExtremePcgMemory : TritonPcgMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        public TritonExtremePcgMemory(string fileName)
            : base(fileName, Models.EModelType.TritonExtreme)
        {
            CombiBanks = new TritonExtremeCombiBanks(this);
            ProgramBanks = new TritonExtremeProgramBanks(this);
            SetLists = null;
            WaveSequenceBanks = null;
            DrumKitBanks = new TritonExtremeDrumKitBanks(this);
            DrumPatternBanks = null;
            Global = new TritonExtremeGlobal(this);
            Model = Models.Find(Models.EOsVersion.EOsVersionTritonExtreme);
        }
    }
}