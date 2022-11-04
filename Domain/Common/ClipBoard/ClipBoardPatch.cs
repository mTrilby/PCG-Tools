﻿#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System.Collections.Generic;
using System.Diagnostics;
using PcgTools.Model.Common.Synth.Meta;

namespace PcgTools.ClipBoard
{
    /// <summary>
    /// </summary>
    public abstract class ClipBoardPatch : IClipBoardPatch
    {
        /// <summary>
        /// </summary>
        /// <param name="data"></param>
        /// <param name="offset"></param>
        /// <param name="size"></param>
        protected ClipBoardPatch(IList<byte> data, int offset, int size)
        {
            Debug.Assert(data.Count != 0);

            Data = new byte[size];

            for (var index = 0; index < size; index++)
            {
                Data[index] = data[index + offset];
            }
        }

        public byte[] Data { get; }


        /// <summary>
        ///     The original location is only used for cut/paste to fix references.
        /// </summary>
        public IPatch OriginalLocation { get; set; }


        /// <summary>
        ///     Null if not pasted already.
        /// </summary>
        public IPatch PasteDestination { get; set; }
    }
}