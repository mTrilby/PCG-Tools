#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchPrograms;
using Domain.MSpecific.Synth;

namespace Domain.Kross2Specific.Synth
{
    /// <summary>
    /// </summary>
    public class Kross2ProgramBanks : MProgramBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public Kross2ProgramBanks(PcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// </summary>
        protected override void CreateBanks()
        {
            Add(new Kross2ProgramBank(this, BankType.EType.Int, "A", 0, ProgramBank.SynthesisType.Edsx, "Id A")); //  0
            Add(new Kross2ProgramBank(this, BankType.EType.Int, "B", 1, ProgramBank.SynthesisType.Edsx, "Id B")); //  1
            Add(new Kross2ProgramBank(this, BankType.EType.Int, "C", 2, ProgramBank.SynthesisType.Edsx, "Id C")); //  2
            Add(new Kross2ProgramBank(this, BankType.EType.Int, "D", 3, ProgramBank.SynthesisType.Edsx, "Id D")); //  3
            Add(new Kross2ProgramBank(this, BankType.EType.Int, "E", 4, ProgramBank.SynthesisType.Edsx, "Id E")); //  4
            Add(new Kross2ProgramBank(this, BankType.EType.Int, "F", 5, ProgramBank.SynthesisType.Edsx, "Id F")); //  5

            Add(new Kross2ProgramBank(this, BankType.EType.User, "UA", 6, ProgramBank.SynthesisType.Edsx, "UA")); //  6
            Add(new Kross2ProgramBank(this, BankType.EType.User, "UB", 7, ProgramBank.SynthesisType.Edsx, "UB")); //  7
            Add(new Kross2ProgramBank(this, BankType.EType.User, "UC", 8, ProgramBank.SynthesisType.Edsx, "UC")); //  8
            Add(new Kross2ProgramBank(this, BankType.EType.User, "UD", 9, ProgramBank.SynthesisType.Edsx, "ID")); //  9

            Add(new Kross2GmProgramBank(
                this, BankType.EType.Gm, "GM", 10, ProgramBank.SynthesisType.Edsx, "GM2 Main programs")); //  10-...
        }
    }
}