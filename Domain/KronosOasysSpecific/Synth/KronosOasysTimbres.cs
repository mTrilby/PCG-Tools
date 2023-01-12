#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.PatchCombis;

#endregion

namespace Domain.KronosOasysSpecific.Synth
{
    /// <summary>
    /// </summary>
    public abstract class KronosOasysTimbres : Timbres
    {
        /// <summary>
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