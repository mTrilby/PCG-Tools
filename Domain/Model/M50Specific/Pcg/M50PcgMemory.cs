// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.M50Specific.Synth;
using Domain.Model.MSpecific.Pcg;

namespace Domain.Model.M50Specific.Pcg
{
    /// <summary>
    /// 
    /// </summary>
    public class M50PcgMemory : MPcgMemory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        public M50PcgMemory(string fileName)
            : base(fileName, ModelsEModelType.M50)
        {
            CombiBanks = new M50CombiBanks(this);
            ProgramBanks = new M50ProgramBanks(this);
            SetLists = null;
            WaveSequenceBanks = null;
            DrumKitBanks = new M50DrumKitBanks(this);
            DrumPatternBanks = new M50DrumPatternBanks(this);
            Global = new M50Global(this);
            Model = Models.Find(ModelsEOsVersion.EOsVersionM50);
        }
    }
}
