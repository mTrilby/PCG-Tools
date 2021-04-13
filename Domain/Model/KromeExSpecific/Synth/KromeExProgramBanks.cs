// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchPrograms;
using Domain.Model.MSpecific.Synth;

namespace Domain.Model.KromeExSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class KromeExProgramBanks : MProgramBanks
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pcgMemory"></param>
        public KromeExProgramBanks(PcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        protected override void CreateBanks()
        {
            Add(new KromeExProgramBank(this, BankTypeEType.Int, "A", 0, ProgramBankSynthesisType.Edsx, "Id A"));    //  0
            Add(new KromeExProgramBank(this, BankTypeEType.Int, "B", 1, ProgramBankSynthesisType.Edsx, "Id B"));    //  1
            Add(new KromeExProgramBank(this, BankTypeEType.Int, "C", 2, ProgramBankSynthesisType.Edsx, "Id C"));    //  2
            Add(new KromeExProgramBank(this, BankTypeEType.Int, "D", 3, ProgramBankSynthesisType.Edsx, "Id D"));    //  3
            Add(new KromeExProgramBank(this, BankTypeEType.Int, "E", 4, ProgramBankSynthesisType.Edsx, "Id E"));    //  4
            Add(new KromeExProgramBank(this, BankTypeEType.Int, "F", 5, ProgramBankSynthesisType.Edsx, "Id F"));    //  5

            Add(new KromeExProgramBank(this, BankTypeEType.User, "U-A", 6 , ProgramBankSynthesisType.Edsx, "Id U-A"));    //  6
            Add(new KromeExProgramBank(this, BankTypeEType.User, "U-B", 7 , ProgramBankSynthesisType.Edsx, "Id U-B"));    //  7
            Add(new KromeExProgramBank(this, BankTypeEType.User, "U-C", 8 , ProgramBankSynthesisType.Edsx, "Id U-C"));    //  8
            Add(new KromeExProgramBank(this, BankTypeEType.User, "U-D", 9 , ProgramBankSynthesisType.Edsx, "Id U-D"));    //  9
            Add(new KromeExProgramBank(this, BankTypeEType.User, "U-E", 10, ProgramBankSynthesisType.Edsx, "Id U-E"));    //  10
            Add(new KromeExProgramBank(this, BankTypeEType.User, "U-F", 11, ProgramBankSynthesisType.Edsx, "Id U-F"));    //  11

            Add(new KromeExGmProgramBank(
                this, BankTypeEType.Gm, "GM", 6, ProgramBankSynthesisType.Edsx, "GM2 Main programs"));   //  6-15
        }                                                                                                                         
    }
}                                                                                                                                                            