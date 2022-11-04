#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchPrograms;

namespace Domain.Ms2000Specific.Synth
{
    /// <summary>
    /// </summary>
    public class Ms2000ProgramBank : ProgramBank
    {
        /// <summary>
        /// </summary>
        /// <param name="programBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        /// <param name="synthesisType"></param>
        /// <param name="description"></param>
        public Ms2000ProgramBank(IBanks programBanks, BankType.EType type, string id, int pcgId,
            SynthesisType synthesisType, string description)
            : base(programBanks, type, id, pcgId, synthesisType, description)
        {
        }

        /// <summary>
        /// </summary>
        public override int NrOfPatches => PcgRoot.CanContainOnlyOnePatch ? 1 : 16;


        /// <summary>
        /// </summary>
        public override SynthesisType DefaultModeledSynthesisType =>
            throw new NotSupportedException("Illegal synthesis engine");


        /// <summary>
        /// </summary>
        public override SynthesisType DefaultSampledSynthesisType => SynthesisType.AnalogModeling;


        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        public override void CreatePatch(int index)
        {
            Add(new Ms2000Program(this, index));
        }
    }
}