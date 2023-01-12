﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.PatchCombis;
using Domain.MntxSeriesSpecific.Synth;

#endregion

namespace Domain.M1Specific.Synth
{
    /// <summary>
    /// </summary>
    public sealed class M1Timbres : MntxTimbres
    {
        /// <summary>
        /// </summary>
        /// <param name="combi"></param>
        public M1Timbres(ICombi combi)
            : base(combi, TimbresOffsetConstant)
        {
            for (var n = 0; n < TimbresPerCombi; n++)
            {
                TimbresCollection.Add(new M1Timbre(this, n));
            }
        }

        /// <summary>
        /// </summary>
        private static int TimbresOffsetConstant => 36;

        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        protected override ITimbre CreateNewTimbre(int index)
        {
            return new M1Timbre(this, index);
        }
    }
}