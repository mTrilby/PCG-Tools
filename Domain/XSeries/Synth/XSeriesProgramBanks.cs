#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchPrograms;
using Domain.MntxSeriesSpecific.Synth;

namespace Domain.XSeries.Synth
{
    /// <summary>
    /// </summary>
    public class XSeriesProgramBanks : MntxProgramBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public XSeriesProgramBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        ///     The first (default internal) eight program banks are called A..H.
        ///     The next (virtual) banks will be called V1A, V1B, ... V1H, V2A, ...
        /// </summary>
        protected override void CreateBanks()
        {
            // Add internal banks.
            Add(
                new XSeriesProgramBank(
                    this, BankType.EType.Int, $"{"A"}", 0,
                    ProgramBank.SynthesisType.Ai, "-"));

            Add(
                new XSeriesProgramBank(
                    this, BankType.EType.Int, $"{"B"}", 1,
                    ProgramBank.SynthesisType.Ai, "-"));
        }
    }
}