// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchPrograms;
using Domain.Model.KronosOasysSpecific.Synth;

namespace Domain.Model.OasysSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class OasysProgramBanks : KronosOasysProgramBanks
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pcgMemory"></param>
        public OasysProgramBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        protected override void CreateBanks()
        {
            Add(new OasysProgramBank(
                this, BankTypeEType.Int, "I-A", 0, ProgramBankSynthesisType.Unknown, "SGX-1, EP-1 and best of all other EXi"));             //  0

            Add(new OasysProgramBank(
                this, BankTypeEType.Int, "I-B", 1, ProgramBankSynthesisType.Unknown, "HD-1"));                                              //  1

            Add(new OasysProgramBank(
                this, BankTypeEType.Int, "I-C", 2, ProgramBankSynthesisType.Unknown, "HD-1")); 
            
            //  2
            Add(new OasysProgramBank(
                this, BankTypeEType.Int, "I-D", 3, ProgramBankSynthesisType.Unknown, "HD-1"));                                              //  3
            
            Add(new OasysProgramBank(
                this, BankTypeEType.Int, "I-E", 4, ProgramBankSynthesisType.Unknown, "HD-1"));                                              //  4
            
            Add(new OasysProgramBank(
                this, BankTypeEType.Int, "I-F", 5, ProgramBankSynthesisType.Unknown, "HD-1"));                                              //  5

            
            Add(new OasysProgramBank(
                this, BankTypeEType.User, "U-A", 17, ProgramBankSynthesisType.Unknown,
                "HD1 including Ambient Drums and Sound Effects"));   //  6
            
            Add(new OasysProgramBank(
                this, BankTypeEType.User, "U-B", 18, ProgramBankSynthesisType.Unknown, "AL-1"));                                            //  7
            
            Add(new OasysProgramBank(
                this, BankTypeEType.User, "U-C", 19, ProgramBankSynthesisType.Unknown, "AL-1 and CX-3"));                                   //  8
            
            Add(new OasysProgramBank(
                this, BankTypeEType.User, "U-D", 20, ProgramBankSynthesisType.Unknown, "STR-1"));                                           //  9
            
            Add(new OasysProgramBank(
                this, BankTypeEType.User, "U-E", 21, ProgramBankSynthesisType.Unknown, "MS-20EX & PolysixEX"));                             // 10
            
            Add(new OasysProgramBank(
                this, BankTypeEType.User, "U-F", 22, ProgramBankSynthesisType.Unknown, "MOD-7"));                                           // 11
            
            Add(new OasysProgramBank(
                this, BankTypeEType.User, "U-G", 23, ProgramBankSynthesisType.Unknown, "Initialized HD-1 Programs"));                       // 12

            Add(new OasysGmProgramBank(
                this, BankTypeEType.Gm, "GM", 6, ProgramBankSynthesisType.Hd1, "GM2 Main programs"));                                     // 6-16
        }
    }
}
