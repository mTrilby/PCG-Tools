// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using Domain.MasterFiles;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchPrograms;

namespace Domain.Model.TrinitySpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class TrinityProgramBank : ProgramBank
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
        public TrinityProgramBank(IBanks programBanks, BankTypeEType type, string id, int pcgId,
            ProgramBankSynthesisType programBankSynthesisType, string description)
            : base(programBanks, type, id, pcgId, programBankSynthesisType, description)
        {
        }


        public override void CreatePatch(int index)
        {
            Add(new TrinityProgram(this, index));
        }


        /// <summary>
        /// Not used because depending on bank it can also be Prophecy.
        /// </summary>
        public override ProgramBankSynthesisType DefaultModeledProgramBankSynthesisType => ProgramBankSynthesisType.MossZ1;


        /// <summary>
        /// 
        /// </summary>
        public override ProgramBankSynthesisType DefaultSampledSynthesisType => ProgramBankSynthesisType.Access;
    }
}
