#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

namespace Domain.Common.ClipBoard
{
    /// <summary>
    /// </summary>
    public interface IClipBoardProgram : IClipBoardPatch
    {
        /// <summary>
        ///     References to used drum kits.
        /// </summary>
        IClipBoardPatches ReferencedDrumKits { get; set; }


        /// <summary>
        ///     References to used wave sequences.
        /// </summary>
        IClipBoardPatches ReferencedWaveSequences { get; set; }
    }
}