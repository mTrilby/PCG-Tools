﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchPrograms;
using Domain.MntxSeriesSpecific.Synth;

#endregion

namespace Domain.M1Specific.Synth
{
    /// <summary>
    /// </summary>
    public class M1ProgramBanks : MntxProgramBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public M1ProgramBanks(IPcgMemory pcgMemory)
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
                new M1ProgramBank(
                    this, BankType.EType.Int, $"{"I"}", 0,
                    ProgramBank.SynthesisType.Ai, "-"));

            // Add Card banks.
            Add(
                new M1ProgramBank(
                    this, BankType.EType.Int, $"{"C"}", 1,
                    ProgramBank.SynthesisType.Ai, "-"));
        }
    }
}