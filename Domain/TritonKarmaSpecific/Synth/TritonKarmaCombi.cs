#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.OldParameters;
using Domain.Common.Synth.PatchCombis;
using Domain.TritonSpecific.Synth;

namespace Domain.TritonKarmaSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class TritonKarmaCombi : TritonCombi
    {
        /// <summary>
        /// </summary>
        /// <param name="combiBank"></param>
        /// <param name="index"></param>
        public TritonKarmaCombi(ICombiBank combiBank, int index)
            : base(combiBank, index)
        {
            Timbres = new TritonKarmaTimbres(this);
        }


        /// <summary>
        ///     Sets parameters after initialization.
        /// </summary>
        public override void SetParameters()
        {
        }


        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public override IParameter GetParam(ParameterNames.CombiParameterName name)
        {
            IParameter parameter;

            switch (name)
            {
                case ParameterNames.CombiParameterName.Category:
                    parameter = IntParameter.Instance.Set(PcgRoot, PcgRoot.Content, ByteOffset + 762, 3, 0, false,
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