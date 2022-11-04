#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.OldParameters;
using Domain.Common.Synth.PatchCombis;
using Domain.MSpecific.Synth;

namespace Domain.KromeSpecific.Synth
{
    /// <summary>
    /// </summary>
    public sealed class KromeTimbre : MTimbre
    {
        /// <summary>
        /// </summary>
        /// <param name="timbres"></param>
        /// <param name="index"></param>
        public KromeTimbre(ITimbres timbres, int index)
            : base(timbres, index, TimbresSizeConstant)
        {
        }

        /// <summary>
        /// </summary>
        private static int TimbresSizeConstant => 112;


        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public override IParameter GetParam(ParameterNames.TimbreParameterName name)
        {
            IParameter parameter;

            switch (name)
            {
                default:
                    parameter = base.GetParam(name);
                    break;
            }

            return parameter;
        }
    }
}