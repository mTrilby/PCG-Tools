// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchPrograms;
using Domain.Model.TritonSpecific.Synth;

namespace Domain.Model.TritonLeSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class TritonLeProgramBanks : TritonProgramBanks
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pcgMemory"></param>
        public TritonLeProgramBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }
        

        /// <summary>
        /// 
        /// </summary>
        protected override void CreateBanks()
        {
            Add(new TritonLeProgramBank(
                this, BankTypeEType.Int, "A", 0, ProgramBankSynthesisType.Hi, "Id A"));                 //  0

            Add(new TritonLeProgramBank(
                this, BankTypeEType.Int, "B", 1, ProgramBankSynthesisType.Hi, "Id B"));                 //  1

            Add(new TritonLeProgramBank(
                this, BankTypeEType.Int, "C", 2, ProgramBankSynthesisType.Hi, "Id C"));                 //  2

            Add(new TritonLeProgramBank(
                this, BankTypeEType.Int, "D", 3, ProgramBankSynthesisType.Hi, "Id D"));                 //  3

            Add(new TritonLeGmProgramBank(
                this, BankTypeEType.Gm, "GM", 6, ProgramBankSynthesisType.Hi, "GM2 Main programs"));   // [6,16?]
        }
        
            // Index:              0       1       2       3     
            // Name:               A       B       C       D     
            // return this[new[] { 0x0000, 0x0001, 0x0002, 0x0003
            // Index:  6        16???
            // Name:   G       g(d)       
            //        0xF0000, 0xF000A,
            // Index: 17         23
    }
}
