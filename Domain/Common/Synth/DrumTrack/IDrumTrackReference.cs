#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.PatchDrumPatterns;

#endregion

namespace Domain.Common.Synth.DrumTrack
{
    /// <summary>
    ///     Interface for patches (programs/combis) using a drum track (containing of a (drum track) program and a (drum track)
    ///     pattern.
    /// </summary>
    public interface IDrumTrackReference
    {
        /// <summary>
        ///     Drum pattern assigned to the program.
        /// </summary>
        IDrumPattern UsedDrumTrackPattern { get; set; }
    }
}