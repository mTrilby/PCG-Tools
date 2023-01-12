#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.PatchCombis;
using PcgTools.Model.TritonSpecific.Synth;

#endregion

namespace PcgTools.Model.TritonKarmaSpecific.Synth
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