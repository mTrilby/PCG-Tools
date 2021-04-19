// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.MasterFiles;
using Domain.Model.Common.Synth.OldParameters;
using Domain.Model.Common.Synth.PatchCombis;
using Domain.Model.MSpecific.Synth;

namespace Domain.Model.KrossSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class KrossTimbre : MTimbre
    {
        /// <summary>
        /// 
        /// </summary>
        private static int TimbresSizeConstant => 44;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="timbres"></param>
        /// <param name="index"></param>
        public KrossTimbre(ITimbres timbres, int index)
            : base(timbres, index, TimbresSizeConstant)
        {
        }


        /// <summary>
        /// 
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