#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.MicroKorgXlSpecific.Synth;

namespace Domain.MicroKorgXlSpecific.Pcg
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