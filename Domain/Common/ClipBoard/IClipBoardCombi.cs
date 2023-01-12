#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

namespace PcgTools.ClipBoard
{
    /// <summary>
    /// </summary>
    public interface IClipBoardCombi : IClipBoardPatch
    {
        /// <summary>
        ///     References to timbres/programs.
        /// </summary>
        IClipBoardPatches References { get; }
    }
}