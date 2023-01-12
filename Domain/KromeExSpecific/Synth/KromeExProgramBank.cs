#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;
using PcgTools.Model.Common.Synth;
using PcgTools.Model.Common.Synth.Meta;
using PcgTools.Model.MSpecific.Synth;

#endregion

namespace PcgTools.Model.KromeExSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class KromeExProgramBank : MProgramBank
    {
        /// <summary>
        /// </summary>
        /// <param name="programBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        /// <param name="synthesisType"></param>
        /// <param name="description"></param>
        public KromeExProgramBank(ProgramBanks programBanks, BankType.EType type, string id, int pcgId,
            SynthesisType synthesisType, string description)
            : base(programBanks, type, id, pcgId, synthesisType, description)
        {
        }

        /// <summary>
        /// </summary>
        public override SynthesisType DefaultModeledSynthesisType => throw new NotSupportedException();

        /// <summary>
        /// </summary>
        public override SynthesisType DefaultSampledSynthesisType => SynthesisType.Edsx;

        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        public override void CreatePatch(int index)
        {
            Add(new KromeExProgram(this, index));
        }
    }
}