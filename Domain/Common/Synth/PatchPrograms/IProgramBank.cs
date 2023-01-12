#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.Meta;

#endregion

namespace Domain.Common.Synth.PatchPrograms
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