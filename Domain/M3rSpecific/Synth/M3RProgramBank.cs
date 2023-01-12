#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;
using PcgTools.Model.Common.Synth.Meta;
using PcgTools.Model.Common.Synth.PatchPrograms;
using PcgTools.Model.MntxSeriesSpecific.Synth;

#endregion

namespace PcgTools.Model.M3rSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class M3RProgramBank : MntxProgramBank
    {
        /// <summary>
        /// </summary>
        /// <param name="programBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        /// <param name="synthesisType"></param>
        /// <param name="description"></param>
        public M3RProgramBank(IProgramBanks programBanks, BankType.EType type, string id, int pcgId,
            SynthesisType synthesisType, string description)
            : base(programBanks, type, id, pcgId, synthesisType, description)
        {
        }

        /// <summary>
        /// </summary>
        public override int NrOfPatches => 100;

        /// <summary>
        /// </summary>
        public override SynthesisType DefaultModeledSynthesisType => throw new NotSupportedException();

        /// <summary>
        /// </summary>
        public override SynthesisType DefaultSampledSynthesisType => SynthesisType.AnalogModeling;

        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        public override void CreatePatch(int index)
        {
            Add(new M3RProgram(this, index));
        }
    }
}