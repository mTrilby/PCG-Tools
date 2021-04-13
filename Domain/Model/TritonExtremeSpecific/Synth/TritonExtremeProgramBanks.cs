// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchPrograms;
using Domain.Model.TritonSpecific.Synth;

namespace Domain.Model.TritonExtremeSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class TritonExtremeProgramBanks : TritonProgramBanks
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pcgMemory"></param>
        public TritonExtremeProgramBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }
        

        /// <summary>
        /// 
        /// </summary>
        protected override void CreateBanks()
        {
            Add(new TritonExtremeProgramBank(this, BankTypeEType.Int, "A", 0, ProgramBankSynthesisType.Hi, "Id A"));          //  0
            Add(new TritonExtremeProgramBank(this, BankTypeEType.Int, "B", 1, ProgramBankSynthesisType.Hi, "Id B"));          //  1
            Add(new TritonExtremeProgramBank(this, BankTypeEType.Int, "C", 2, ProgramBankSynthesisType.Hi, "Id C"));          //  2
            Add(new TritonExtremeProgramBank(this, BankTypeEType.Int, "D", 3, ProgramBankSynthesisType.Hi, "Id D"));          //  3
            Add(new TritonExtremeProgramBank(this, BankTypeEType.Int, "E", 4, ProgramBankSynthesisType.Hi, "Id E"));          //  4
            Add(new TritonExtremeProgramBank(this, BankTypeEType.Int, "F", 5, ProgramBankSynthesisType.MossZ1, "Id F"));      //  5

            Add(new TritonExtremeProgramBank(this, BankTypeEType.User, "H", 17, ProgramBankSynthesisType.Hi, "Id H"));        //  6
            Add(new TritonExtremeProgramBank(this, BankTypeEType.User, "I", 18, ProgramBankSynthesisType.Hi, "Id I"));        //  7
            Add(new TritonExtremeProgramBank(this, BankTypeEType.User, "J", 19, ProgramBankSynthesisType.Hi, "Id J"));        //  8
            Add(new TritonExtremeProgramBank(this, BankTypeEType.User, "K", 20, ProgramBankSynthesisType.Hi, "Id K"));        //  9
            Add(new TritonExtremeProgramBank(this, BankTypeEType.User, "L", 21, ProgramBankSynthesisType.Hi, "Id L"));        // 10
            Add(new TritonExtremeProgramBank(this, BankTypeEType.User, "M", 22, ProgramBankSynthesisType.Hi, "Id M"));        // 11
            Add(new TritonExtremeProgramBank(this, BankTypeEType.User, "N", 23, ProgramBankSynthesisType.Hi, "Id N"));        // 12

            Add(new TritonExtremeGmProgramBank(
                this,  BankTypeEType.Gm, "GM", 6, ProgramBankSynthesisType.Hi, "GM2 Main programs"));     // [6-16]
        }                                                                                                                                                           
            // Index:              0       1       2       3       4        5
            // Name:               A       B       C       D       E        F      
            // return this[new[] { 0x0000, 0x0001, 0x0002, 0x0003, 0x0004, 0x08000, 
            // Index:  6         7        8        9       10       11       12       13       14       15       16
            // Name:   G       g(1)     g(2)     g(3)     g(4)     g(5)     g(6)     g(7)     g(8)     g(9)     g(d)       
            //        0xF0000, 0xF0001, 0xF0002, 0xF0003, 0xF0004, 0xF0005, 0xF0006, 0xF0007, 0xF0008, 0xF0009, 0xF000A,
            // Index: 17       18       19       20       21       22       23
            // Name:   H        I        J        K        L        M        N
            //        0x20000, 0x20001, 0x20002, 0x20003, 0x20004, 0x20005, 0x20006}[]
    }
}
