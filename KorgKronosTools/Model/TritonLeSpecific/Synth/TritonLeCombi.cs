﻿// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using PcgTools.Model.Common.Synth.OldParameters;
using PcgTools.Model.Common.Synth.PatchCombis;
using PcgTools.Model.TritonSpecific.Synth;

namespace PcgTools.Model.TritonLeSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class TritonLeCombi : TritonCombi
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="combiBank"></param>
        /// <param name="index"></param>
        public TritonLeCombi(ICombiBank combiBank, int index)
            : base(combiBank, index)
        {
            Timbres = new TritonLeTimbres(this);
        }


        /// <summary>
        /// Sets parameters after initialization.
        /// </summary>
        public override void SetParameters()
        {
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public override IParameter GetParam(ParameterNames.CombiParameterName name)
        {
            IParameter parameter;

            switch (name)
            {
                case ParameterNames.CombiParameterName.Category:
                    parameter = IntParameter.Instance.Set(PcgRoot, PcgRoot.Content, ByteOffset + 214, 3, 0, false, this);
                    break;

                default:
                    parameter = base.GetParam(name);
                    break;
            }
            return parameter;
        }
    }
}
