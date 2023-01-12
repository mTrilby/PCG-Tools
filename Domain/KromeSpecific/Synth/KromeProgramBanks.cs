﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchPrograms;
using Domain.MSpecific.Synth;

#endregion

namespace Domain.KromeSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class KromeProgramBanks : MProgramBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public KromeProgramBanks(PcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }

        /// <summary>
        /// </summary>
        protected override void CreateBanks()
        {
            Add(new KromeProgramBank(this, BankType.EType.Int, "A", 0, ProgramBank.SynthesisType.Edsx, "Id A")); //  0
            Add(new KromeProgramBank(this, BankType.EType.Int, "B", 1, ProgramBank.SynthesisType.Edsx, "Id B")); //  1
            Add(new KromeProgramBank(this, BankType.EType.Int, "C", 2, ProgramBank.SynthesisType.Edsx, "Id C")); //  2
            Add(new KromeProgramBank(this, BankType.EType.Int, "D", 3, ProgramBank.SynthesisType.Edsx, "Id D")); //  3
            Add(new KromeProgramBank(this, BankType.EType.Int, "E", 4, ProgramBank.SynthesisType.Edsx, "Id E")); //  4
            Add(new KromeProgramBank(this, BankType.EType.Int, "F", 5, ProgramBank.SynthesisType.Edsx, "Id F")); //  5

            Add(new KromeGmProgramBank(
                this, BankType.EType.Gm, "GM", 6, ProgramBank.SynthesisType.Edsx, "GM2 Main programs")); //  6-15
        }
    }
}