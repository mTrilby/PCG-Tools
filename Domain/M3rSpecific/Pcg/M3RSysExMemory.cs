#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.M3rSpecific.Synth;
using Domain.MntxSeriesSpecific.Pcg;

#endregion

namespace Domain.M3rSpecific.Pcg
{
    /// <summary>
    /// </summary>
    public class M3RSysExMemory : MntxSysExMemory
    {
        public M3RSysExMemory(string fileName,
            ContentType contentType, int sysExStartOffset, int sysExEndOffset)
            : base(fileName, Models.EModelType.M3R, contentType, sysExStartOffset, sysExEndOffset, false)
        {
            CombiBanks = new M3RCombiBanks(this);
            ProgramBanks = new M3RProgramBanks(this);
            SetLists = null;
            WaveSequenceBanks = null;
            DrumKitBanks = null;
            DrumPatternBanks = null;
            Global = new M3RGlobal(this);
            Model = Models.Find(Models.EOsVersion.EOsVersionM3R);
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