#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.PatchWaveSequences;
using Domain.KronosSpecific.Pcg;
using Domain.KronosSpecific.Synth;

namespace Domain.Common.ClipBoard
{
    /// <summary>
    /// </summary>
    public class ClipBoardWaveSequence : ClipBoardPatch
    {
        /// <summary>
        /// </summary>
        /// <param name="waveSequence"></param>
        public ClipBoardWaveSequence(IWaveSequence waveSequence)
            : base(waveSequence.PcgRoot.Content, waveSequence.ByteOffset, waveSequence.ByteLength)
        {
            OriginalLocation = waveSequence;

            var memory = waveSequence.Root as KronosPcgMemory;
            if (memory != null && memory.PcgRoot.Model.OsVersion == Models.EOsVersion.EOsVersionKronos15_16)
            {
                KronosOs1516Bank =
                    Util.GetInt(memory.Content, ((KronosWaveSequence)waveSequence).Wsq2BankOffset, 1);

                KronosOs1516Patch =
                    Util.GetInt(memory.Content, ((KronosWaveSequence)waveSequence).Wsq2PatchOffset, 1);
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