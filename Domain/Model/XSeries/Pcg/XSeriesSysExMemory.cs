// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using System;
using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.MntxSeriesSpecific.Pcg;
using Domain.Model.XSeries.Synth;

namespace Domain.Model.XSeries.Pcg
{
    /// <summary>
    /// 
    /// </summary>
    public class XSeriesSysExMemory : MntxSysExMemory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="contentType"></param>
        /// <param name="sysExStartOffset"></param>
        /// <param name="sysExEndOffset"></param>
        public XSeriesSysExMemory(string fileName,
            PcgMemoryContentType contentType, int sysExStartOffset, int sysExEndOffset)
            : base(fileName, ModelsEModelType.XSeries, contentType, sysExStartOffset, sysExEndOffset, false)
        {
            CombiBanks = new XSeriesCombiBanks(this);
            ProgramBanks = new XSeriesProgramBanks(this);
            SetLists = null;
            WaveSequenceBanks = null;
            DrumKitBanks = null;
            DrumPatternBanks = null;
            Global = new XSeriesGlobal(this);
            Model = Models.Find(ModelsEOsVersion.EOsVersionXSeries);
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
