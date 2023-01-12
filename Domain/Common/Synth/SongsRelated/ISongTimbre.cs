#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.PatchCombis;

#endregion

namespace Domain.Common.Synth.SongsRelated
{
    /// <summary>
    /// </summary>
    public interface ISongTimbre : ITimbre
    {
        /// <summary>
        ///     Returns the raw/uncoverted program index of the timbre.
        /// </summary>
        int ProgramRawIndex { get; }

        /// <summary>
        ///     Returns the raw/uncoverted program bank index of the timbre.
        /// </summary>
        int ProgramRawBankIndex { get; }
    }
}