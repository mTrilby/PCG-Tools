﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchPrograms;
using Domain.MntxSeriesSpecific.Synth;

#endregion

namespace Domain.Z1Specific.Synth
{
    /// <summary>
    /// </summary>
    public class Z1ProgramBanks : MntxProgramBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public Z1ProgramBanks(IPcgMemory pcgMemory)
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
            var bankId = 0;
            foreach (var id in new[] { "A", "B" })
            {
                Add(
                    new Z1ProgramBank(
                        this, BankType.EType.Int, $"{id}", bankId,
                        ProgramBank.SynthesisType.MossZ1, "-"));
                bankId++;
            }

            // Add Card banks.
            foreach (var id in new[] { "CARD-A", "CARD-B" })
            {
                Add(
                    new Z1ProgramBank(
                        this, BankType.EType.Int, $"{id}", bankId,
                        ProgramBank.SynthesisType.MossZ1, "-"));
                bankId++;
            }
        }
    }
}