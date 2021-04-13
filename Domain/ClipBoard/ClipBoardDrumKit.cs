// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using Domain.Model.Common;
using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.PatchDrumKits;
using Domain.Model.KronosSpecific.Synth;

namespace Domain.ClipBoard
{
    /// <summary>
    /// 
    /// </summary>
    public class ClipBoardDrumKit : ClipBoardPatch, IClipBoardDrumKit
    {
        /// <summary>
        /// 
        /// </summary>
        public int KronosOs1516Bank { get; private set; }
        

        /// <summary>
        /// 
        /// </summary>
        public int KronosOs1516Patch { get; private set; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="drumKit"></param>
        public ClipBoardDrumKit(IDrumKit drumKit)
            : base(drumKit.PcgRoot.Content, drumKit.ByteOffset, drumKit.ByteLength)
        {
            OriginalLocation = drumKit;

            var memory = drumKit.Root as PcgMemory;
            if ((memory != null) && (memory.PcgRoot.Model.OsVersion == ModelsEOsVersion.EOsVersionKronos15_16))
            {
                KronosOs1516Bank = Util.GetInt(memory.Content, ((KronosDrumKit) drumKit).Drk2BankOffset, 1);
                KronosOs1516Patch = Util.GetInt(memory.Content, ((KronosDrumKit) drumKit).Drk2PatchOffset, 1);
            }
        }
    }
}
