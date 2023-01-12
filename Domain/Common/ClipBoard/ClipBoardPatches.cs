#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

#endregion

namespace Domain.Common.ClipBoard
{
    /// <summary>
    /// </summary>
    public class ClipBoardPatches : IClipBoardPatches
    {
        /// <summary>
        /// </summary>
        public ClipBoardPatches()
        {
            CopiedPatches = new ObservableCollection<IClipBoardPatch>();
        }

        /// <summary>
        /// </summary>
        public ObservableCollection<IClipBoardPatch> CopiedPatches { get; }

        /// <summary>
        /// </summary>
        public int CountUncopied
        {
            get { return CopiedPatches.Count(patch => patch.PasteDestination == null); }
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public IEnumerator<IClipBoardPatch> GetEnumerator()
        {
            return CopiedPatches.GetEnumerator();
        }
    }
}