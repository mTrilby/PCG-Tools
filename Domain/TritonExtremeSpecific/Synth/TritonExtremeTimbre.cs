#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.PatchCombis;
using PcgTools.Model.TritonSpecific.Synth;

#endregion

namespace PcgTools.Model.TritonExtremeSpecific.Synth
{
    /// <summary>
    /// </summary>
    public sealed class TritonExtremeTimbre : TritonTimbre
    {
        /// <summary>
        /// </summary>
        /// <param name="timbres"></param>
        /// <param name="index"></param>
        public TritonExtremeTimbre(ITimbres timbres, int index)
            : base(timbres, index)
        {
        }
    }
}