// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchPrograms;
using Domain.Model.MntxSeriesSpecific.Synth;

namespace Domain.Model.M1Specific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class M1ProgramBanks : MntxProgramBanks
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pcgMemory"></param>
        public M1ProgramBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// The first (default internal) eight program banks are called A..H.
        /// The next (virtual) banks will be called V1A, V1B, ... V1H, V2A, ...
        /// </summary>
        protected override void CreateBanks()
        {
            // Add internal banks.
            Add(
                new M1ProgramBank(
                    this, BankTypeEType.Int, $"{"I"}", 0,
                    ProgramBankSynthesisType.Ai, "-"));

            // Add Card banks.
            Add(
                new M1ProgramBank(
                    this, BankTypeEType.Int, $"{"C"}", 1,
                    ProgramBankSynthesisType.Ai, "-"));
        }
    }
}
