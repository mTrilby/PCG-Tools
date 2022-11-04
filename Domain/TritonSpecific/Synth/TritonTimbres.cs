#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using PcgTools.Model.Common.Synth.PatchCombis;

namespace PcgTools.Model.TritonSpecific.Synth
{
    /// <summary>
    /// </summary>
    public abstract class TritonTimbres : Timbres
    {
        /// <summary>
        /// </summary>
        /// <param name="combi"></param>
        /// <param name="timbresOffsetConstant"></param>
        protected TritonTimbres(ICombi combi, int timbresOffsetConstant)
            : base(combi, TimbresPerCombiConstant, timbresOffsetConstant)
        {
        }

        /// <summary>
        /// </summary>
        private static int TimbresPerCombiConstant => 8;
    }
}