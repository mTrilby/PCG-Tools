// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.Meta;

namespace Domain.ClipBoard
{
    /// <summary>
    /// 
    /// </summary>
    public interface IClipBoardPatch
    {
        /// <summary>
        /// Null if not pasted already.
        /// </summary>
        IPatch PasteDestination { get; set; }


        /// <summary>
        /// 
        /// </summary>
        IPatch OriginalLocation { get; set; }


        /// <summary>
        /// 
        /// </summary>
        byte[] Data { get; }
    }
}
