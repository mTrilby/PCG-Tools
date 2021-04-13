// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using System;
using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.M3rSpecific.Synth;
using Domain.Model.MntxSeriesSpecific.Pcg;

namespace Domain.Model.M3rSpecific.Pcg
{
    /// <summary>
    /// 
    /// </summary>
    public class M3RSysExMemory : MntxSysExMemory
    {
        public M3RSysExMemory(string fileName,
            PcgMemoryContentType contentType, int sysExStartOffset, int sysExEndOffset)
            : base(fileName, ModelsEModelType.M3R, contentType, sysExStartOffset, sysExEndOffset, false)
        {
            CombiBanks = new M3RCombiBanks(this);
            ProgramBanks = new M3RProgramBanks(this);
            SetLists = null;
            WaveSequenceBanks = null;
            DrumKitBanks = null;
            DrumPatternBanks = null;
            Global = new M3RGlobal(this);
            Model = Models.Find(ModelsEOsVersion.EOsVersionM3R);
        }
        

        /// <summary>
        /// 
        /// </summary>
        public override bool HasSubCategories => false;


        /// <summary>
        /// Hardcoded (taken from Mode parameter).
        /// </summary>
        public override int NumberOfCategories => 4;


        /// <summary>
        /// 
        /// </summary>
        public override int NumberOfSubCategories
        {
            get
            {
                throw new NotSupportedException();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public override bool AreCategoriesEditable => false;
    }
}
