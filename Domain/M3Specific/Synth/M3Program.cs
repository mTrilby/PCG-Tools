﻿#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System.Collections.Generic;
using Domain.Common.Synth.OldParameters;
using Domain.Common.Synth.PatchPrograms;
using Domain.MSpecific.Synth;

namespace Domain.M3Specific.Synth
{
    /// <summary>
    /// </summary>
    public class M3Program : MProgram
    {
        public M3Program(IProgramBank programBank, int index)
            : base(programBank, index)
        {
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
        public override IParameter GetParam(ParameterNames.ProgramParameterName name)
        {
            IParameter parameter;

            switch (name)
            {
                case ParameterNames.ProgramParameterName.OscMode:
                    parameter = EnumParameter.Instance.Set(Root, Root.Content, ByteOffset + 3256, 2, 0,
                        new List<string> { "Single", "Double", "Drums", "Radias", "SamplerBank" }, this);
                    break;

                case ParameterNames.ProgramParameterName.Category:
                    parameter = IntParameter.Instance.Set(Root, Root.Content, ByteOffset + 3266, 4, 0, false, this);
                    break;

                case ParameterNames.ProgramParameterName.SubCategory:
                    parameter = IntParameter.Instance.Set(Root, Root.Content, ByteOffset + 3266, 7, 5, false, this);
                    break;

                default:
                    parameter = base.GetParam(name);
                    break;
            }

            return parameter;
        }


        /// <summary>
        ///     Do not take drum track program references into account.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        protected override bool UseIndexForDifferencing(int index)
        {
            return index != 3250 && index != 3251;
        }
    }
}