﻿#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using PcgTools.Model.Common;
using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.Common.Synth.PatchSetLists;
using PcgTools.Model.KronosSpecific.Pcg;
using PcgTools.Model.KronosSpecific.Synth;

namespace PcgTools.ClipBoard
{
    /// <summary>
    /// </summary>
    public class ClipBoardSetListSlot : ClipBoardPatch, IClipBoardSetListSlot
    {
        /// <summary>
        /// </summary>
        /// <param name="setListSlot"></param>
        public ClipBoardSetListSlot(ISetListSlot setListSlot)
            : base(setListSlot.PcgRoot.Content, setListSlot.ByteOffset, setListSlot.ByteLength)
        {
            OriginalLocation = setListSlot;

            var memory = setListSlot.Root as KronosPcgMemory;
            if (memory != null && memory.PcgRoot.Model.OsVersion == Models.EOsVersion.EOsVersionKronos15_16)
            {
                KronosOs1516Bank = Util.GetInt(memory.Content, ((KronosSetListSlot)setListSlot).Stl2BankOffset, 1);
                KronosOs1516Patch = Util.GetInt(memory.Content, ((KronosSetListSlot)setListSlot).Stl2PatchOffset, 1);
            }
        }


        /// <summary>
        /// </summary>
        public int KronosOs1516Bank { get; }


        /// <summary>
        /// </summary>
        public int KronosOs1516Patch { get; }

        /// <summary>
        ///     Reference to program or combi (or null if song).
        /// </summary>
        public IClipBoardPatch Reference { get; set; }
    }
}