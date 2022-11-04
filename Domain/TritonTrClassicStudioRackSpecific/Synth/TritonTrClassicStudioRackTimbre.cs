#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.PatchCombis;
using Domain.TritonSpecific.Synth;

namespace Domain.TritonTrClassicStudioRackSpecific.Synth
{
    /// <summary>
    /// </summary>
    public sealed class TritonTrClassicStudioRackTimbre : TritonTimbre
    {
        /// <summary>
        /// </summary>
        /// <param name="timbres"></param>
        /// <param name="index"></param>
        public TritonTrClassicStudioRackTimbre(ITimbres timbres, int index)
            : base(timbres, index)
        {
        }
    }
}