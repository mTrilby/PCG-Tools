#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.PatchDrumKits;
using Domain.KronosSpecific.Synth;

#endregion

namespace Domain.Common.ClipBoard
{
    /// <summary>
    /// </summary>
    public class ClipBoardDrumKit : ClipBoardPatch, IClipBoardDrumKit
    {
        /// <summary>
        /// </summary>
        /// <param name="drumKit"></param>
        public ClipBoardDrumKit(IDrumKit drumKit)
            : base(drumKit.PcgRoot.Content, drumKit.ByteOffset, drumKit.ByteLength)
        {
            OriginalLocation = drumKit;

            var memory = drumKit.Root as PcgMemory;
            if (memory != null && memory.PcgRoot.Model.OsVersion == Models.EOsVersion.EOsVersionKronos15_16)
            {
                KronosOs1516Bank = Util.GetInt(memory.Content, ((KronosDrumKit)drumKit).Drk2BankOffset, 1);
                KronosOs1516Patch = Util.GetInt(memory.Content, ((KronosDrumKit)drumKit).Drk2PatchOffset, 1);
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