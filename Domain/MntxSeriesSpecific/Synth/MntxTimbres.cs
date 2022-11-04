#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.PatchCombis;

namespace Domain.MntxSeriesSpecific.Synth
{
    /// <summary>
    /// </summary>
    public abstract class MntxTimbres : Timbres
    {
        /// <summary>
        /// </summary>
        /// <param name="combi"></param>
        /// <param name="timbresOffsetConstant"></param>
        protected MntxTimbres(ICombi combi, int timbresOffsetConstant)
            : base(combi, TimbresPerCombiConstant, timbresOffsetConstant)
        {
        }

        /// <summary>
        /// </summary>
        private static int TimbresPerCombiConstant => 8;
    }
}