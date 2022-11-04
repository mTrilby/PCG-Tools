#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.PatchCombis;
using Domain.MSpecific.Synth;

namespace Domain.M50Specific.Synth
{
    /// <summary>
    /// </summary>
    public sealed class M50Timbres : MTimbres
    {
        /// <summary>
        /// </summary>
        /// <param name="combi"></param>
        public M50Timbres(ICombi combi)
            : base(combi, TimbresOffsetConstant)
        {
            for (var n = 0; n < TimbresPerCombi; n++)
            {
                TimbresCollection.Add(new M50Timbre(this, n));
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
            return new M50Timbre(this, index);
        }
    }
}