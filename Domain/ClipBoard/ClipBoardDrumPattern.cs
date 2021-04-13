// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using Domain.Model.Common;
using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.PatchDrumPatterns;
using Domain.Model.KronosSpecific.Synth;

namespace Domain.ClipBoard
{
    /// <summary>
    /// 
    /// </summary>
    public class ClipBoardDrumPattern : ClipBoardPatch, IClipBoardDrumPattern
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
        /// <param name="drumPattern"></param>
        public ClipBoardDrumPattern(IDrumPattern drumPattern)
            : base(drumPattern.PcgRoot.Content, drumPattern.ByteOffset, drumPattern.ByteLength)
        {
            OriginalLocation = drumPattern;

            var memory = drumPattern.Root as PcgMemory;
            if ((memory != null) && (memory.PcgRoot.Model.OsVersion == ModelsEOsVersion.EOsVersionKronos15_16))
            {
                KronosOs1516Bank = Util.GetInt(memory.Content, ((KronosDrumPattern)drumPattern).Drk2BankOffset, 1);
                KronosOs1516Patch = Util.GetInt(memory.Content, ((KronosDrumPattern)drumPattern).Drk2PatchOffset, 1);
            }
        }
    }
}
