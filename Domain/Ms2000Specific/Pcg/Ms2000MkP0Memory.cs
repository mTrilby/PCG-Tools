#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.Ms2000Specific.Synth;

#endregion

namespace Domain.Ms2000Specific.Pcg
{
    /// <summary>
    /// </summary>
    public class Ms2000MkP0Memory : PcgMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        public Ms2000MkP0Memory(string fileName)
            : base(fileName, Models.EModelType.Ms2000)
        {
            CombiBanks = null;
            ProgramBanks = new Ms2000ProgramBanks(this);
            SetLists = null;
            WaveSequenceBanks = null;
            DrumKitBanks = null;
            DrumPatternBanks = null;
            Global = new Ms2000Global(this);
            Model = Models.Find(Models.EOsVersion.EOsVersionMs2000);
        }

        /// <summary>
        /// </summary>
        public override bool HasSubCategories => false;

        /// <summary>
        ///     Hardcoded (taken from Mode parameter).
        /// </summary>
        public override int NumberOfCategories => 4;

        /// <summary>
        /// </summary>
        public override int NumberOfSubCategories => throw new NotSupportedException();

        /// <summary>
        /// </summary>
        public override bool AreCategoriesEditable => false;
    }
}