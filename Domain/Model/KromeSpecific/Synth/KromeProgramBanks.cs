// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchPrograms;
using Domain.Model.MSpecific.Synth;

namespace Domain.Model.KromeSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class KromeProgramBanks : MProgramBanks
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pcgMemory"></param>
        public KromeProgramBanks(PcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        protected override void CreateBanks()
        {
            Add(new KromeProgramBank(this, BankTypeEType.Int, "A", 0, ProgramBankSynthesisType.Edsx, "Id A"));    //  0
            Add(new KromeProgramBank(this, BankTypeEType.Int, "B", 1, ProgramBankSynthesisType.Edsx, "Id B"));    //  1
            Add(new KromeProgramBank(this, BankTypeEType.Int, "C", 2, ProgramBankSynthesisType.Edsx, "Id C"));    //  2
            Add(new KromeProgramBank(this, BankTypeEType.Int, "D", 3, ProgramBankSynthesisType.Edsx, "Id D"));    //  3
            Add(new KromeProgramBank(this, BankTypeEType.Int, "E", 4, ProgramBankSynthesisType.Edsx, "Id E"));    //  4
            Add(new KromeProgramBank(this, BankTypeEType.Int, "F", 5, ProgramBankSynthesisType.Edsx, "Id F"));    //  5

            Add(new KromeGmProgramBank(
                this, BankTypeEType.Gm, "GM", 6, ProgramBankSynthesisType.Edsx, "GM2 Main programs"));   //  6-15
        }                                                                                                                         
    }
}                                                                                                                                                            