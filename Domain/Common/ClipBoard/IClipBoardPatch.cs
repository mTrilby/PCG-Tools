#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.Meta;

#endregion

namespace Domain.Common.ClipBoard
{
    /// <summary>
    /// </summary>
    public interface IClipBoardPatch
    {
        /// <summary>
        ///     Null if not pasted already.
        /// </summary>
        IPatch PasteDestination { get; set; }

        /// <summary>
        /// </summary>
        IPatch OriginalLocation { get; set; }

        /// <summary>
        /// </summary>
        byte[] Data { get; }
    }
}