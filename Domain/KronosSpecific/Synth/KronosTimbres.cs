﻿#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using PcgTools.Model.Common.Synth.PatchCombis;

namespace PcgTools.Model.KronosSpecific.Synth
{
    /// <summary>
    /// </summary>
    public sealed class KronosTimbres : Timbres
    {
        /// <summary>
        /// </summary>
        /// <param name="combi"></param>
        public KronosTimbres(Combi combi)
            : base(combi, TimbresPerCombiConstant, TimbresOffsetConstant)
        {
            for (var n = 0; n < TimbresPerCombi; n++)
            {
                TimbresCollection.Add(new KronosTimbre(this, n));
            }
        }

        /// <summary>
        /// </summary>
        public static int TimbresPerCombiConstant => 16;


        /// <summary>
        /// </summary>
        private static int TimbresOffsetConstant => 4802;


        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        protected override ITimbre CreateNewTimbre(int index)
        {
            return new KronosTimbre(this, index);
        }
    }
}