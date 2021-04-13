// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.PatchCombis;
using Domain.Model.MntxSeriesSpecific.Synth;

namespace Domain.Model.ZeroSeries.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class ZeroSeriesTimbres : MntxTimbres
    {
        /// <summary>
        /// 
        /// </summary>
        private static int TimbresOffsetConstant => 40;


        /// <summary>
        /// 
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
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        protected override ITimbre CreateNewTimbre(int index)
        {
            return new ZeroSeriesTimbre(this, index);
        }

    }
}
