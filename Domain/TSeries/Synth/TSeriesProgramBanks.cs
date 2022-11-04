#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchPrograms;
using Domain.MntxSeriesSpecific.Synth;

namespace Domain.TSeries.Synth
{
    /// <summary>
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class TSeriesProgramBanks : MntxProgramBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public TSeriesProgramBanks(IPcgMemory pcgMemory)
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
                new TSeriesProgramBank(
                    this, BankType.EType.Int, $"{"A"}", 0,
                    ProgramBank.SynthesisType.Ai, "-"));
            Add(
                new TSeriesProgramBank(
                    this, BankType.EType.Int, $"{"B"}", 1,
                    ProgramBank.SynthesisType.Ai, "-"));
        }
    }
}