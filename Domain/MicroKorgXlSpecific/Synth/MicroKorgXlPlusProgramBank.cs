#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchPrograms;

namespace Domain.MicroKorgXlSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class MicroKorgXlPlusProgramBank : ProgramBank
    {
        /// <summary>
        /// </summary>
        /// <param name="programBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        /// <param name="synthesisType"></param>
        /// <param name="description"></param>
        public MicroKorgXlPlusProgramBank(IBanks programBanks, BankType.EType type, string id, int pcgId,
            SynthesisType synthesisType, string description)
            : base(programBanks, type, id, pcgId, synthesisType, description)
        {
        }

        /// <summary>
        /// </summary>
        public override int NrOfPatches => 1;


        /// <summary>
        /// </summary>
        public override SynthesisType DefaultModeledSynthesisType =>
            throw new NotSupportedException("Unsupported synthesis engine");


        /// <summary>
        /// </summary>
        public override SynthesisType DefaultSampledSynthesisType => SynthesisType.Mmt;


        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        public override void CreatePatch(int index)
        {
            Add(new MicroKorgXlProgram(this, index));
        }
    }
}