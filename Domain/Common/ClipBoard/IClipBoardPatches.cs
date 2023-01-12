#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System.Collections.ObjectModel;

#endregion

namespace PcgTools.ClipBoard
{
    /// <summary>
    /// </summary>
    public interface IClipBoardPatches
    {
        /// <summary>
        /// </summary>
        int CountUncopied { get; }

        /// <summary>
        /// </summary>
        ObservableCollection<IClipBoardPatch> CopiedPatches { get; }
    }
}