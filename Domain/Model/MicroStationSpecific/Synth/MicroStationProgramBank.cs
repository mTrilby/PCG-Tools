// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using System;
using Domain.MasterFiles;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchPrograms;
using Domain.Model.MSpecific.Synth;

namespace Domain.Model.MicroStationSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class MicroStationProgramBank : MProgramBank
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
        public MicroStationProgramBank(IProgramBanks programBanks, BankTypeEType type, string id, int pcgId,
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
            Add(new MicroStationProgram(this, index));
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
        public override ProgramBankSynthesisType DefaultSampledSynthesisType => ProgramBankSynthesisType.Edsi;
    }
}