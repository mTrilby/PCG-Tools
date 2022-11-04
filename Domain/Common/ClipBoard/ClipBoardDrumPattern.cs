﻿#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using PcgTools.Model.Common;
using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.Common.Synth.PatchDrumPatterns;
using PcgTools.Model.KronosSpecific.Synth;

namespace PcgTools.ClipBoard
{
    /// <summary>
    /// </summary>
    public class ClipBoardDrumPattern : ClipBoardPatch, IClipBoardDrumPattern
    {
        /// <summary>
        /// </summary>
        /// <param name="drumPattern"></param>
        public ClipBoardDrumPattern(IDrumPattern drumPattern)
            : base(drumPattern.PcgRoot.Content, drumPattern.ByteOffset, drumPattern.ByteLength)
        {
            OriginalLocation = drumPattern;

            var memory = drumPattern.Root as PcgMemory;
            if (memory != null && memory.PcgRoot.Model.OsVersion == Models.EOsVersion.EOsVersionKronos15_16)
            {
                KronosOs1516Bank = Util.GetInt(memory.Content, ((KronosDrumPattern)drumPattern).Drk2BankOffset, 1);
                KronosOs1516Patch = Util.GetInt(memory.Content, ((KronosDrumPattern)drumPattern).Drk2PatchOffset, 1);
            }
        }

        /// <summary>
        /// </summary>
        public int KronosOs1516Bank { get; }


        /// <summary>
        /// </summary>
        public int KronosOs1516Patch { get; }
    }
}