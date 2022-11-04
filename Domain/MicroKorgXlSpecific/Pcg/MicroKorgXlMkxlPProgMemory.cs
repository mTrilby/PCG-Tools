﻿#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.MicroKorgXlSpecific.Synth;

namespace Domain.MicroKorgXlSpecific.Pcg
{
    /// <summary>
    /// </summary>
    public class MicroKorgXlMkxlPProgMemory : MkxlAllMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        public MicroKorgXlMkxlPProgMemory(string fileName)
            : base(fileName, Models.EModelType.MicroKorgXlPlus)
        {
            CombiBanks = null;
            ProgramBanks = new MicroKorgXlPlusProgramBanks(this);
            SetLists = null;
            WaveSequenceBanks = null;
            DrumKitBanks = null;
            DrumPatternBanks = null;
            Global = new MicroKorgXlGlobal(this);
            Model = Models.Find(Models.EOsVersion.EOsVersionMicroKorgXlPlus);
        }
    }
}