// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using Domain.Model.Common.File;
using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.PatchPrograms;

namespace Domain.Model.MicroKorgXlSpecific.Pcg
{
    /// <summary>
    /// 
    /// </summary>
    public class MicroKorgXlMkxlPProgFileReader : PatchesFileReader
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentPcgMemory"></param>
        /// <param name="content"></param>
        public MicroKorgXlMkxlPProgFileReader(IPcgMemory currentPcgMemory, byte[] content)
            : base(currentPcgMemory, content)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="filetype"></param>
        /// <param name="modelType"></param>
        public override void ReadContent(MemoryFileType filetype, ModelsEModelType modelType)
        {
            var bank = (ProgramBank) CurrentPcgMemory.ProgramBanks[0];
            bank.ByteOffset = Index;
            bank.BankSynthesisType = ProgramBankSynthesisType.Mmt;
            bank.PatchSize = 496;
            bank.IsWritable = true;
            bank.IsLoaded = true;

            // Place in PcgMemory.
            var program = (Program) bank[0];
            program.ByteOffset = 32; // Fixed
            program.ByteLength = bank.PatchSize;
            program.IsLoaded = true;
        }
    }
}
