#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.PatchCombis;
using Domain.TritonSpecific.Synth;

#endregion

namespace Domain.TritonLeSpecific.Synth
{
    /// <summary>
    /// </summary>
    public sealed class TritonLeTimbre : TritonTimbre
    {
        /// <summary>
        /// </summary>
        /// <param name="timbres"></param>
        /// <param name="index"></param>
        public TritonLeTimbre(ITimbres timbres, int index)
            : base(timbres, index)
        {
        }
    }
}