// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchPrograms;
using Domain.Model.MSpecific.Synth;

namespace Domain.Model.MicroStationSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class MicroStationProgramBanks : MProgramBanks
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pcgMemory"></param>
        public MicroStationProgramBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        protected override void CreateBanks()
        {
            Add(new MicroStationProgramBank(
                this, BankTypeEType.Int, "A", 0, ProgramBankSynthesisType.Edsi, "Id A"));                 //  0

            Add(new MicroStationProgramBank(
                this, BankTypeEType.Int, "B", 1, ProgramBankSynthesisType.Edsi, "Id B"));                 //  1

            Add(new MicroStationProgramBank(
                this, BankTypeEType.Int, "C", 2, ProgramBankSynthesisType.Edsi, "Id C"));                 //  2

            Add(new MicroStationProgramBank(
                this, BankTypeEType.Int, "D", 3, ProgramBankSynthesisType.Edsi, "Id D"));                 //  3


            Add(new MicroStationGmProgramBank(
                this, BankTypeEType.Gm, "GM", 4, ProgramBankSynthesisType.Edsi, "GM2 Main programs"));  //  [4-14]
        }
    }
}
