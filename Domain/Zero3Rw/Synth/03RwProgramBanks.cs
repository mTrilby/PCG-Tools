﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchPrograms;
using Domain.ZeroSeries.Synth;

#endregion

namespace Domain.Zero3Rw.Synth
{
    /// <summary>
    /// </summary>
    public class Zero3RwProgramBanks : ZeroSeriesProgramBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public Zero3RwProgramBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }

        /// <summary>
        /// </summary>
        protected override void CreateBanks()
        {
            // Add internal banks.
            var pcgId = 0;
            foreach (var id in new[] { "A" }) // Banks C and D not used in file, pretending everything is in A.
            {
                Add(
                    new Zero3RwProgramBank(
                        this, BankType.EType.Int, id, pcgId, ProgramBank.SynthesisType.Ai2, string.Empty));
                pcgId++;
            }

            Add(new Zero3RwGmProgramBank(this, BankType.EType.Gm, "GM", 255, ProgramBank.SynthesisType.Ai2, "GM Bank"));
        }
    }
}