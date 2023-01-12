﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;
using PcgTools.Model.Common.Synth.Meta;
using PcgTools.Model.Common.Synth.PatchPrograms;

#endregion

namespace PcgTools.Model.TritonKarmaSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class TritonKarmaGmProgramBank : ProgramBank
    {
        /// <summary>
        /// </summary>
        /// <param name="programBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        /// <param name="synthesisType"></param>
        /// <param name="description"></param>
        public TritonKarmaGmProgramBank(IBanks programBanks, BankType.EType type, string id, int pcgId,
            SynthesisType synthesisType, string description)
            : base(programBanks, type, id, pcgId, synthesisType, description)
        {
        }

        /// <summary>
        /// </summary>
        public override SynthesisType DefaultModeledSynthesisType =>
            throw new NotSupportedException("Unsupported synthesis engine");

        /// <summary>
        /// </summary>
        public override SynthesisType DefaultSampledSynthesisType => SynthesisType.Hi;

        /// <summary>
        ///     E.g. GM banks have index 1.
        /// </summary>
        public override int IndexOffset => 1;

        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        public override void CreatePatch(int index)
        {
            Add(new TritonKarmaGmProgram(this, index, "GM" + (index + 1))); //FUTURE: Real name instead of GMn
        }
    }
}