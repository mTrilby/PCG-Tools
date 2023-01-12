﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.PatchCombis;
using PcgTools.Model.MSpecific.Synth;

#endregion

namespace PcgTools.Model.KromeExSpecific.Synth
{
    /// <summary>
    /// </summary>
    public sealed class KromeExTimbres : MTimbres
    {
        /// <summary>
        /// </summary>
        /// <param name="combi"></param>
        public KromeExTimbres(Combi combi)
            : base(combi, TimbresOffsetConstant)
        {
            for (var n = 0; n < TimbresPerCombi; n++)
            {
                TimbresCollection.Add(new KromeExTimbre(this, n));
            }
        }

        /// <summary>
        /// </summary>
        private static int TimbresOffsetConstant => 836;

        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        protected override ITimbre CreateNewTimbre(int index)
        {
            return new KromeExTimbre(this, index);
        }
    }
}