// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchPrograms;
using Domain.Model.MntxSeriesSpecific.Synth;

namespace Domain.Model.XSeries.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class XSeriesProgramBanks : MntxProgramBanks
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pcgMemory"></param>
        public XSeriesProgramBanks(IPcgMemory pcgMemory)
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
                new XSeriesProgramBank(
                    this, BankTypeEType.Int, $"{"A"}", 0, 
                    ProgramBankSynthesisType.Ai, "-"));

            Add(
                new XSeriesProgramBank(
                    this, BankTypeEType.Int, $"{"B"}", 1, 
                    ProgramBankSynthesisType.Ai, "-"));
        }
    }
}
