// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using System;
using Domain.MasterFiles;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchPrograms;

namespace Domain.Model.TritonKarmaSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class TritonKarmaGmProgramBank : ProgramBank
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="programBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        /// <param name="programBankSynthesisType"></param>
        /// <param name="description"></param>
        public TritonKarmaGmProgramBank(IBanks programBanks, BankTypeEType type, string id, int pcgId,
            ProgramBankSynthesisType programBankSynthesisType, string description)
            : base(programBanks, type, id, pcgId, programBankSynthesisType, description)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        public override void CreatePatch(int index)
        {
            Add(new TritonKarmaGmProgram(this, index, "GM" + (index + 1))); //FUTURE: Real name instead of GMn
        }


        /// <summary>
        /// 
        /// </summary>
        public override ProgramBankSynthesisType DefaultModeledProgramBankSynthesisType
        {
            get { throw new NotSupportedException("Unsupported synthesis engine"); }
        }


        /// <summary>
        /// 
        /// </summary>
        public override ProgramBankSynthesisType DefaultSampledSynthesisType => ProgramBankSynthesisType.Hi;


        /// <summary>
        /// E.g. GM banks have index 1.
        /// </summary>
        public override int IndexOffset => 1;
    }
    
}