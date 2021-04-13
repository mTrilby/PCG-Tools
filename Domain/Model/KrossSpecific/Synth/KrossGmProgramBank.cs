// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using System;
using Domain.MasterFiles;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchPrograms;

namespace Domain.Model.KrossSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class KrossGmProgramBank : ProgramBank
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
        public KrossGmProgramBank(IProgramBanks programBanks, BankTypeEType type, string id, int pcgId,
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
            Add(new KrossGmProgram(this, index, "GM" + (index + 1))); //FUTURE: Real name instead of GMn, use GmPrograms.cs
        }


        /// <summary>
        /// 
        /// </summary>
        public override ProgramBankSynthesisType DefaultModeledProgramBankSynthesisType
        {
            get { throw new NotSupportedException(); }
        }


        /// <summary>
        /// 
        /// </summary>
        public override ProgramBankSynthesisType DefaultSampledSynthesisType => ProgramBankSynthesisType.Edsx;


        /// <summary>
        /// E.g. GM banks have index 1.
        /// </summary>
        public override int IndexOffset => 1;
    }
}
