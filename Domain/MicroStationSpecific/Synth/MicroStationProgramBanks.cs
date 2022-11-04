#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchPrograms;
using Domain.MSpecific.Synth;

namespace Domain.MicroStationSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class MicroStationProgramBanks : MProgramBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public MicroStationProgramBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// </summary>
        protected override void CreateBanks()
        {
            Add(new MicroStationProgramBank(
                this, BankType.EType.Int, "A", 0, ProgramBank.SynthesisType.Edsi, "Id A")); //  0

            Add(new MicroStationProgramBank(
                this, BankType.EType.Int, "B", 1, ProgramBank.SynthesisType.Edsi, "Id B")); //  1

            Add(new MicroStationProgramBank(
                this, BankType.EType.Int, "C", 2, ProgramBank.SynthesisType.Edsi, "Id C")); //  2

            Add(new MicroStationProgramBank(
                this, BankType.EType.Int, "D", 3, ProgramBank.SynthesisType.Edsi, "Id D")); //  3


            Add(new MicroStationGmProgramBank(
                this, BankType.EType.Gm, "GM", 4, ProgramBank.SynthesisType.Edsi, "GM2 Main programs")); //  [4-14]
        }
    }
}