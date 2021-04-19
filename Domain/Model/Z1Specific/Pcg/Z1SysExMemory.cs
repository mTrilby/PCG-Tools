﻿// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using System;
using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.MntxSeriesSpecific.Pcg;
using Domain.Model.Z1Specific.Synth;

namespace Domain.Model.Z1Specific.Pcg
{
    /// <summary>
    /// 
    /// </summary>
    public class Z1SysExMemory : MntxSysExMemory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="contentType"></param>
        /// <param name="sysExStartOffset"></param>
        /// <param name="sysExEndOffset"></param>
        public Z1SysExMemory(string fileName,
            PcgMemoryContentType contentType, int sysExStartOffset, int sysExEndOffset)
            : base(fileName, ModelsEModelType.Z1, contentType, sysExStartOffset, sysExEndOffset, false)
        {
            CombiBanks = new Z1CombiBanks(this);
            ProgramBanks = new Z1ProgramBanks(this);
            SetLists = null;
            WaveSequenceBanks = null;
            DrumKitBanks = null;
            DrumPatternBanks = null;
            Global = new Z1Global(this);
            Model = Models.Find(ModelsEOsVersion.EOsVersionZ1);
        }
        

        /// <summary>
        /// 
        /// </summary>
        public override bool HasProgramCategories => true;


        /// <summary>
        /// 
        /// </summary>
        public override bool HasCombiCategories => false;


        /// <summary>
        /// Hardcoded (taken from Mode parameter).
        /// </summary>
        public override int NumberOfCategories => 18;


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
        public override bool AreCategoriesEditable => true;
    }
}