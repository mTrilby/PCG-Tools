#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.KronosOasysSpecific.Pcg;
using Domain.OasysSpecific.Synth;

namespace Domain.OasysSpecific.Pcg
{
    /// <summary>
    /// </summary>
    public class OasysPcgMemory : KronosOasysPcgMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        public OasysPcgMemory(string fileName)
            : base(fileName, Models.EModelType.Oasys)
        {
            CombiBanks = new OasysCombiBanks(this);
            ProgramBanks = new OasysProgramBanks(this);
            SetLists = null;
            WaveSequenceBanks = new OasysWaveSequenceBanks(this);
            DrumKitBanks = new OasysDrumKitBanks(this);
            DrumPatternBanks = null;
            Global = new OasysGlobal(this);
            Model = Models.Find(Models.EOsVersion.EOsVersionOasys);
        }
    }
}