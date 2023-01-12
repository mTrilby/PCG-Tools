#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

namespace PcgTools.ClipBoard
{
    /// <summary>
    /// </summary>
    public interface IClipBoardSetListSlot : IClipBoardPatch
    {
        /// <summary>
        ///     Reference to program or combi (or null if song).
        /// </summary>
        IClipBoardPatch Reference { get; set; }
    }
}