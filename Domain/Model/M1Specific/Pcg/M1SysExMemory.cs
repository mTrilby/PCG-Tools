// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using System;
using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.M1Specific.Synth;
using Domain.Model.MntxSeriesSpecific.Pcg;

namespace Domain.Model.M1Specific.Pcg
{
    /// <summary>
    /// 
    /// </summary>
    public class M1SysExMemory : MntxSysExMemory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="contentType"></param>
        /// <param name="sysExStartOffset"></param>
        /// <param name="sysExEndOffset"></param>
        public M1SysExMemory(string fileName,
            PcgMemoryContentType contentType, int sysExStartOffset, int sysExEndOffset)
            : base(fileName, ModelsEModelType.M1, contentType, sysExStartOffset, sysExEndOffset, false)
        {
            CombiBanks = new M1CombiBanks(this);
            ProgramBanks = new M1ProgramBanks(this);
            SetLists = null;
            WaveSequenceBanks = null;
            DrumKitBanks = null;
            DrumPatternBanks = null;
            Global = new M1Global(this);
            Model = Models.Find(ModelsEOsVersion.EOsVersionM1);
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
