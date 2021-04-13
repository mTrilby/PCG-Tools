// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using System;
using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Ms2000Specific.Synth;

namespace Domain.Model.Ms2000Specific.Pcg
{
    /// <summary>
    /// 
    /// </summary>
    public class Ms2000MkP0Memory : PcgMemory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        public Ms2000MkP0Memory(string fileName) 
            : base(fileName, ModelsEModelType.Ms2000)
        {
            CombiBanks = null;
            ProgramBanks = new Ms2000ProgramBanks(this);
            SetLists = null;
            WaveSequenceBanks = null;
            DrumKitBanks = null;
            DrumPatternBanks = null;
            Global = new Ms2000Global(this);
            Model = Models.Find(ModelsEOsVersion.EOsVersionMs2000);
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
