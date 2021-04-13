// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.PatchCombis;
using Domain.Model.MSpecific.Synth;

namespace Domain.Model.MicroStationSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class MicroStationTimbres : MTimbres
    {
        /// <summary>
        /// 
        /// </summary>
        static int TimbresOffsetConstant => 664;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="combi"></param>
        public MicroStationTimbres(ICombi combi)
            : base(combi, TimbresOffsetConstant)
        {
            for (var n = 0; n < TimbresPerCombi; n++)
            {
                TimbresCollection.Add(new MicroStationTimbre(this, n));
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        protected override ITimbre CreateNewTimbre(int index)
        {
            return new MicroStationTimbre(this, index);
        }

    }
}
