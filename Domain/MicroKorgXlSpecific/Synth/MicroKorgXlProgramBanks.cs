#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchPrograms;

#endregion

namespace Domain.MicroKorgXlSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class MicroKorgXlProgramBanks : ProgramBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public MicroKorgXlProgramBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }

        /// <summary>
        /// </summary>
        protected override void CreateBanks()
        {
            Add(new MicroKorgXlProgramBank(this, BankType.EType.Int, "A", -1, ProgramBank.SynthesisType.Mmt,
                "-")); //  0
            Add(new MicroKorgXlProgramBank(this, BankType.EType.Int, "B", -1, ProgramBank.SynthesisType.Mmt,
                "-")); //  1
        }
    }
}