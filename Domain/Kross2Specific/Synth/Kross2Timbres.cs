﻿#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.PatchCombis;
using Domain.MSpecific.Synth;

namespace Domain.Kross2Specific.Synth
{
    /// <summary>
    /// </summary>
    public sealed class Kross2Timbres : MTimbres
    {
        /// <summary>
        /// </summary>
        /// <param name="combi"></param>
        public Kross2Timbres(Combi combi)
            : base(combi, TimbresOffsetConstant)
        {
            for (var n = 0; n < TimbresPerCombi; n++)
            {
                TimbresCollection.Add(new Kross2Timbre(this, n));
            }
        }

        /// <summary>
        /// </summary>
        private static int TimbresOffsetConstant => 1276;


        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        protected override ITimbre CreateNewTimbre(int index)
        {
            return new Kross2Timbre(this, index);
        }
    }
}