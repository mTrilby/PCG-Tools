#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.Meta;

#endregion

namespace PcgTools.Model.Common.Synth.PatchPrograms
{
    /// <summary>
    /// </summary>
    public interface IProgramBank : IBank
    {
        /// <summary>
        /// </summary>
        bool IsModeled { get; }

        /// <summary>
        /// </summary>
        ProgramBank.SynthesisType BankSynthesisType { get; set; }

        /// <summary>
        /// </summary>
        ProgramBank.SynthesisType DefaultSampledSynthesisType { get; }
    }
}