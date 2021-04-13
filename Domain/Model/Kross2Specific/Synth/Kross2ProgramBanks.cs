// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchPrograms;
using Domain.Model.MSpecific.Synth;

namespace Domain.Model.Kross2Specific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class Kross2ProgramBanks : MProgramBanks
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pcgMemory"></param>
        public Kross2ProgramBanks(PcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        protected override void CreateBanks()
        {
            Add(new Kross2ProgramBank(this, BankTypeEType.Int, "A", 0, ProgramBankSynthesisType.Edsx, "Id A"));     //  0
            Add(new Kross2ProgramBank(this, BankTypeEType.Int, "B", 1, ProgramBankSynthesisType.Edsx, "Id B"));     //  1
            Add(new Kross2ProgramBank(this, BankTypeEType.Int, "C", 2, ProgramBankSynthesisType.Edsx, "Id C"));     //  2
            Add(new Kross2ProgramBank(this, BankTypeEType.Int, "D", 3, ProgramBankSynthesisType.Edsx, "Id D"));     //  3
            Add(new Kross2ProgramBank(this, BankTypeEType.Int, "E", 4, ProgramBankSynthesisType.Edsx, "Id E"));     //  4
            Add(new Kross2ProgramBank(this, BankTypeEType.Int, "F", 5, ProgramBankSynthesisType.Edsx, "Id F"));     //  5

            Add(new Kross2ProgramBank(this, BankTypeEType.User, "UA", 6, ProgramBankSynthesisType.Edsx, "UA"));     //  6
            Add(new Kross2ProgramBank(this, BankTypeEType.User, "UB", 7, ProgramBankSynthesisType.Edsx, "UB"));     //  7
            Add(new Kross2ProgramBank(this, BankTypeEType.User, "UC", 8, ProgramBankSynthesisType.Edsx, "UC"));     //  8
            Add(new Kross2ProgramBank(this, BankTypeEType.User, "UD", 9, ProgramBankSynthesisType.Edsx, "ID"));     //  9

            Add(new Kross2GmProgramBank(
                this, BankTypeEType.Gm, "GM", 10, ProgramBankSynthesisType.Edsx, "GM2 Main programs"));   //  10-...

        }
    }
}                                                                                                                                                            