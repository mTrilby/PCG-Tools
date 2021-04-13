// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using Domain.Model.Common;
using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.PatchWaveSequences;
using Domain.Model.KronosSpecific.Pcg;
using Domain.Model.KronosSpecific.Synth;

namespace Domain.ClipBoard
{
    /// <summary>
    /// 
    /// </summary>
    public class ClipBoardWaveSequence : ClipBoardPatch
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
        /// <param name="waveSequence"></param>
        public ClipBoardWaveSequence(IWaveSequence waveSequence)
            : base(waveSequence.PcgRoot.Content, waveSequence.ByteOffset, waveSequence.ByteLength)
        {
            OriginalLocation = waveSequence;

            var memory = waveSequence.Root as KronosPcgMemory;
            if ((memory != null) && (memory.PcgRoot.Model.OsVersion == ModelsEOsVersion.EOsVersionKronos15_16))
            {
                KronosOs1516Bank = 
                    Util.GetInt(memory.Content, ((KronosWaveSequence) waveSequence).Wsq2BankOffset, 1);

                KronosOs1516Patch = 
                    Util.GetInt(memory.Content, ((KronosWaveSequence) waveSequence).Wsq2PatchOffset, 1);
            }
        }
    }
}
