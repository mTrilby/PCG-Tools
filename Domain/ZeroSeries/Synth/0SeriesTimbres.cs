#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.PatchCombis;
using Domain.MntxSeriesSpecific.Synth;

#endregion

namespace Domain.ZeroSeries.Synth
{
    /// <summary>
    /// </summary>
    public class ZeroSeriesTimbres : MntxTimbres
    {
        /// <summary>
        /// </summary>
        /// <param name="combi"></param>
        public ZeroSeriesTimbres(ICombi combi)
            : base(combi, TimbresOffsetConstant)
        {
            for (var n = 0; n < TimbresPerCombi; n++)
            {
                TimbresCollection.Add(new ZeroSeriesTimbre(this, n));
            }
        }

        /// <summary>
        /// </summary>
        private static int TimbresOffsetConstant => 40;

        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        protected override ITimbre CreateNewTimbre(int index)
        {
            return new ZeroSeriesTimbre(this, index);
        }
    }
}