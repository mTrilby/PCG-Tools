#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchPrograms;
using Domain.MSpecific.Synth;

namespace Domain.M50Specific.Synth
{
    /// <summary>
    /// </summary>
    public class M50ProgramBanks : MProgramBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public M50ProgramBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// </summary>
        protected override void CreateBanks()
        {
            Add(new M50ProgramBank(this, BankType.EType.Int, "A", 0, ProgramBank.SynthesisType.Eds, "Id A")); //  0
            Add(new M50ProgramBank(this, BankType.EType.Int, "B", 1, ProgramBank.SynthesisType.Eds, "Id B")); //  1
            Add(new M50ProgramBank(this, BankType.EType.Int, "C", 2, ProgramBank.SynthesisType.Eds, "Id C")); //  2
            Add(new M50ProgramBank(this, BankType.EType.Int, "D", 3, ProgramBank.SynthesisType.Eds, "Id D")); //  3
            Add(new M50ProgramBank(this, BankType.EType.Int, "E", 4, ProgramBank.SynthesisType.Eds, "Id E")); //  4

            Add(new M50GmProgramBank(this, BankType.EType.Gm, "GM", 5, ProgramBank.SynthesisType.Eds,
                "GM2 Main programs")); //  5-15
        }
    }
}