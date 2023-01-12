#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.MemoryAndFactory;
using Domain.M50Specific.Synth;
using Domain.MSpecific.Pcg;

#endregion

namespace Domain.M50Specific.Pcg
{
    /// <summary>
    /// </summary>
    public class M50PcgMemory : MPcgMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        public M50PcgMemory(string fileName)
            : base(fileName, Models.EModelType.M50)
        {
            CombiBanks = new M50CombiBanks(this);
            ProgramBanks = new M50ProgramBanks(this);
            SetLists = null;
            WaveSequenceBanks = null;
            DrumKitBanks = new M50DrumKitBanks(this);
            DrumPatternBanks = new M50DrumPatternBanks(this);
            Global = new M50Global(this);
            Model = Models.Find(Models.EOsVersion.EOsVersionM50);
        }
    }
}