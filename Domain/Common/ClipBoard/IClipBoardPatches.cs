#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System.Collections.ObjectModel;

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