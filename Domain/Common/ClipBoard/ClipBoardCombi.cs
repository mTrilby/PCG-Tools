﻿#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.KronosSpecific.Pcg;
using Domain.KronosSpecific.Synth;

namespace Domain.Common.ClipBoard
{
    /// <summary>
    /// </summary>
    public class ClipBoardCombi : ClipBoardPatch, IClipBoardCombi
    {
        /// <summary>
        /// </summary>
        /// <param name="combi"></param>
        public ClipBoardCombi(IPatch combi) : base(combi.Root.Content, combi.ByteOffset, combi.ByteLength)
        {
            OriginalLocation = combi;

            References = new ClipBoardPatches();

            KronosOs1516Content =
                new byte[KronosCombiBanks.ParametersInCbk2Chunk * KronosTimbres.TimbresPerCombiConstant];

            var memory = combi.Root as KronosPcgMemory;

            // CBK2 content.
            if (memory != null && memory.Model.OsVersion == Models.EOsVersion.EOsVersionKronos15_16)
            {
                for (var parameter = 0; parameter < KronosCombiBanks.ParametersInCbk2Chunk; parameter++)
                {
                    for (var timbre = 0; timbre < KronosTimbres.TimbresPerCombiConstant; timbre++)
                    {
                        var patchParameterOffset = ((KronosCombiBank)
                            combi.Parent).GetParameterOffsetInCbk2(combi.Index, timbre, parameter);

                        KronosOs1516Content[parameter + timbre * KronosCombiBanks.ParametersInCbk2Chunk] =
                            combi.Root.Content[patchParameterOffset];
                    }
                }
            }
        }

        /// <summary>
        ///     Contains CBK2 in order:
        ///     (param 0, timbre 1), (param 1, timbre 1), (param 0, timbre 2), ... (param 1, timbre 16)).
        /// </summary>
        public byte[] KronosOs1516Content { get; }


        /// <summary>
        ///     References to timbres/programs.
        /// </summary>
        public IClipBoardPatches References { get; }
    }
}