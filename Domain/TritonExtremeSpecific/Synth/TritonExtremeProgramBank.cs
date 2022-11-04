#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchPrograms;
using Domain.TritonSpecific.Synth;

namespace Domain.TritonExtremeSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class TritonExtremeProgramBank : TritonProgramBank
    {
        /// <summary>
        /// </summary>
        /// <param name="programBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        /// <param name="synthesisType"></param>
        /// <param name="description"></param>
        public TritonExtremeProgramBank(IProgramBanks programBanks, BankType.EType type, string id, int pcgId,
            SynthesisType synthesisType, string description)
            : base(programBanks, type, id, pcgId, synthesisType, description)
        {
        }


        /// <summary>
        /// </summary>
        public override SynthesisType DefaultModeledSynthesisType => SynthesisType.MossZ1;


        /// <summary>
        /// </summary>
        public override SynthesisType DefaultSampledSynthesisType => SynthesisType.Hi;


        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        public override void CreatePatch(int index)
        {
            Add(new TritonExtremeProgram(this, index));
        }
    }
}