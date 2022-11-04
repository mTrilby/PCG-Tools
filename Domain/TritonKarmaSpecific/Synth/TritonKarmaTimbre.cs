#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.PatchCombis;
using Domain.TritonSpecific.Synth;

namespace Domain.TritonKarmaSpecific.Synth
{
    /// <summary>
    /// </summary>
    public sealed class TritonKarmaTimbre : TritonTimbre
    {
        /// <summary>
        /// </summary>
        /// <param name="timbres"></param>
        /// <param name="index"></param>
        public TritonKarmaTimbre(ITimbres timbres, int index)
            : base(timbres, index)
        {
        }
    }
}