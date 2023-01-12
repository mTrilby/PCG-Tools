#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.PatchCombis;

#endregion

namespace PcgTools.Model.MSpecific.Synth
{
    /// <summary>
    /// </summary>
    public abstract class MTimbres : Timbres
    {
        /// <summary>
        /// </summary>
        /// <param name="combi"></param>
        /// <param name="timbresOffsetConstant"></param>
        protected MTimbres(ICombi combi, int timbresOffsetConstant)
            : base(combi, TimbresPerCombiConstant, timbresOffsetConstant)
        {
        }

        /// <summary>
        /// </summary>
        private static int TimbresPerCombiConstant => 16;
    }
}