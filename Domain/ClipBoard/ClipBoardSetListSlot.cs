// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using Domain.Model.Common;
using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.PatchSetLists;
using Domain.Model.KronosSpecific.Pcg;
using Domain.Model.KronosSpecific.Synth;

namespace Domain.ClipBoard
{
    /// <summary>
    /// 
    /// </summary>
    public class ClipBoardSetListSlot : ClipBoardPatch, IClipBoardSetListSlot, IClipboardSetListSlotKronosOs1516
    {
        /// <summary>
        ///  Reference to program or combi (or null if song).
        /// </summary>
        public IClipBoardPatch Reference { get; set; }


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
        /// <param name="setListSlot"></param>
        public ClipBoardSetListSlot(ISetListSlot setListSlot)
            : base(setListSlot.PcgRoot.Content, setListSlot.ByteOffset, setListSlot.ByteLength)
        {
            OriginalLocation = setListSlot;

            var memory = setListSlot.Root as KronosPcgMemory;
            if ((memory != null) && (memory.PcgRoot.Model.OsVersion == ModelsEOsVersion.EOsVersionKronos15_16))
            {
                KronosOs1516Bank = Util.GetInt(memory.Content, ((KronosSetListSlot) setListSlot).Stl2BankOffset, 1);
                KronosOs1516Patch = Util.GetInt(memory.Content, ((KronosSetListSlot) setListSlot).Stl2PatchOffset, 1);
            }
        }
    }
}
