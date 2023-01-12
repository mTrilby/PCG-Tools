﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.OldParameters;
using PcgTools.Model.Common.Synth.PatchCombis;
using PcgTools.Model.TritonSpecific.Synth;

#endregion

namespace PcgTools.Model.TritonTrClassicStudioRackSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class TritonTrClassicStudioRackCombi : TritonCombi
    {
        /// <summary>
        /// </summary>
        /// <param name="combiBank"></param>
        /// <param name="index"></param>
        public TritonTrClassicStudioRackCombi(ICombiBank combiBank, int index)
            : base(combiBank, index)
        {
            Timbres = new TritonTrClassicStudioRackTimbres(this);
        }

        /// <summary>
        ///     Sets parameters after initialization.
        /// </summary>
        public override void SetParameters()
        {
        }

        /// <summary>
        ///     /
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public override IParameter GetParam(ParameterNames.CombiParameterName name)
        {
            IParameter parameter;

            switch (name)
            {
                case ParameterNames.CombiParameterName.Category:
                    parameter = IntParameter.Instance.Set(PcgRoot, PcgRoot.Content, ByteOffset + 214, 3, 0, false,
                        this);
                    break;

                default:
                    parameter = base.GetParam(name);
                    break;
            }

            return parameter;
        }
    }
}