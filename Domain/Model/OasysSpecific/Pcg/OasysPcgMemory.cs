// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.KronosOasysSpecific.Pcg;
using Domain.Model.OasysSpecific.Synth;

namespace Domain.Model.OasysSpecific.Pcg
{
    /// <summary>
    /// 
    /// </summary>
    public class OasysPcgMemory : KronosOasysPcgMemory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        public OasysPcgMemory(string fileName)
            : base(fileName, ModelsEModelType.Oasys)
        {
            CombiBanks = new OasysCombiBanks(this);
            ProgramBanks = new OasysProgramBanks(this);
            SetLists = null;
            WaveSequenceBanks = new OasysWaveSequenceBanks(this);
            DrumKitBanks = new OasysDrumKitBanks(this);
            DrumPatternBanks = null;
            Global = new OasysGlobal(this);
            Model = Models.Find(ModelsEOsVersion.EOsVersionOasys);
        }
    }
}
