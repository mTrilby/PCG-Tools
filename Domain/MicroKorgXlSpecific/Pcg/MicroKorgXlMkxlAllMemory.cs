﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.MicroKorgXlSpecific.Synth;

#endregion

namespace PcgTools.Model.MicroKorgXlSpecific.Pcg
{
    /// <summary>
    /// </summary>
    public class MicroKorgXlMkxlAllMemory : MkxlAllMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        public MicroKorgXlMkxlAllMemory(string fileName)
            : base(fileName, Models.EModelType.MicroKorgXl)
        {
            CombiBanks = null;
            ProgramBanks = new MicroKorgXlProgramBanks(this);
            SetLists = null;
            WaveSequenceBanks = null;
            DrumKitBanks = null;
            DrumPatternBanks = null;
            Global = new MicroKorgXlGlobal(this);
            Model = Models.Find(Models.EOsVersion.EOsVersionMicroKorgXl);
        }

        /// <summary>
        /// </summary>
        public override bool AreCategoriesEditable => false;
    }
}