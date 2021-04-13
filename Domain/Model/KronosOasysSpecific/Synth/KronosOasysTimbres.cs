// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.PatchCombis;

namespace Domain.Model.KronosOasysSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class KronosOasysTimbres : Timbres
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="combi"></param>
        /// <param name="timbresPerCombiConstant"></param>
        /// <param name="timbresOffsetConstant"></param>
        protected KronosOasysTimbres(Combi combi, int timbresPerCombiConstant, int timbresOffsetConstant)
            : base(combi, timbresPerCombiConstant, timbresOffsetConstant)
        {
        }
    }
}
