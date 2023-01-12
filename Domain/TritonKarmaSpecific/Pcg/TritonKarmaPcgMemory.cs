#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.MemoryAndFactory;
using Domain.TritonKarmaSpecific.Synth;
using Domain.TritonSpecific.Pcg;

#endregion

namespace Domain.TritonKarmaSpecific.Pcg
{
    /// <summary>
    /// </summary>
    public class TritonKarmaPcgMemory : TritonPcgMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        public TritonKarmaPcgMemory(string fileName)
            : base(fileName, Models.EModelType.TritonKarma)
        {
            CombiBanks = new TritonKarmaCombiBanks(this);
            ProgramBanks = new TritonKarmaProgramBanks(this);
            SetLists = null;
            WaveSequenceBanks = null;
            DrumKitBanks = new TritonKarmaDrumKitBanks(this);
            DrumPatternBanks = null;
            Global = new TritonKarmaGlobal(this);
            Model = Models.Find(Models.EOsVersion.EOsVersionTritonKarma);
        }
    }
}