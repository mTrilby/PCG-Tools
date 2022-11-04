#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchPrograms;

namespace Domain.MicroKorgXlSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class MicroKorgXlPlusProgramBanks : ProgramBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public MicroKorgXlPlusProgramBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// </summary>
        protected override void CreateBanks()
        {
            Add(new MicroKorgXlPlusProgramBank(this, BankType.EType.Int, "A", 0, ProgramBank.SynthesisType.Mmt,
                "-")); //  0
        }
    }
}