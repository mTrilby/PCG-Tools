// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchPrograms;
using Domain.Model.MSpecific.Synth;

namespace Domain.Model.M50Specific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class M50ProgramBanks : MProgramBanks
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pcgMemory"></param>
        public M50ProgramBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        protected override void CreateBanks()
        {
            Add(new M50ProgramBank(this, BankTypeEType.Int, "A", 0, ProgramBankSynthesisType.Eds, "Id A"));                   //  0
            Add(new M50ProgramBank(this, BankTypeEType.Int, "B", 1, ProgramBankSynthesisType.Eds, "Id B"));                   //  1
            Add(new M50ProgramBank(this, BankTypeEType.Int, "C", 2, ProgramBankSynthesisType.Eds, "Id C"));                   //  2
            Add(new M50ProgramBank(this, BankTypeEType.Int, "D", 3, ProgramBankSynthesisType.Eds, "Id D"));                   //  3
            Add(new M50ProgramBank(this, BankTypeEType.Int, "E", 4, ProgramBankSynthesisType.Eds, "Id E"));                   //  4

            Add(new M50GmProgramBank(this, BankTypeEType.Gm, "GM", 5, ProgramBankSynthesisType.Eds, "GM2 Main programs"));    //  5-15
        }
    }
}
