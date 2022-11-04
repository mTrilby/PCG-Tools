﻿#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System;
using PcgTools.Model.Common.Synth.Meta;
using PcgTools.Model.MntxSeriesSpecific.Synth;

namespace PcgTools.Model.ZeroSeries.Synth
{
    /// <summary>
    /// </summary>
    public class ZeroSeriesProgramBank : MntxProgramBank
    {
        /// <summary>
        /// </summary>
        /// <param name="programBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        /// <param name="synthesisType"></param>
        /// <param name="description"></param>
        public ZeroSeriesProgramBank(IBanks programBanks, BankType.EType type, string id, int pcgId,
            SynthesisType synthesisType, string description)
            : base(programBanks, type, id, pcgId, synthesisType, description)
        {
        }

        /// <summary>
        /// </summary>
        public override int NrOfPatches => 100;


        /// <summary>
        /// </summary>
        public override SynthesisType DefaultModeledSynthesisType =>
            throw new NotSupportedException("Unsupported synthesis engine");


        /// <summary>
        /// </summary>
        public override SynthesisType DefaultSampledSynthesisType => SynthesisType.Ai2;


        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        public override void CreatePatch(int index)
        {
            Add(new ZeroSeriesProgram(this, index));
        }
    }
}