#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.PatchCombis;
using Domain.MSpecific.Synth;

namespace Domain.KromeSpecific.Synth
{
    /// <summary>
    /// </summary>
    public sealed class KromeTimbres : MTimbres
    {
        /// <summary>
        /// </summary>
        /// <param name="combi"></param>
        public KromeTimbres(Combi combi)
            : base(combi, TimbresOffsetConstant)
        {
            for (var n = 0; n < TimbresPerCombi; n++)
            {
                TimbresCollection.Add(new KromeTimbre(this, n));
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
            return new KromeTimbre(this, index);
        }
    }
}