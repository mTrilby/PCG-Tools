﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System.Collections.Generic;
using Domain.Common.Synth.OldParameters;
using Domain.Common.Synth.PatchPrograms;
using Domain.MSpecific.Synth;

#endregion

namespace Domain.KromeSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class KromeProgram : MProgram
    {
        /// <summary>
        /// </summary>
        /// <param name="programBank"></param>
        /// <param name="index"></param>
        public KromeProgram(ProgramBank programBank, int index)
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
                    parameter = EnumParameter.Instance.Set(Root, Root.Content, ByteOffset + 836, 2, 0,
                        new List<string> { "Single", "Double", "Drums" }, this);
                    break;

                case ParameterNames.ProgramParameterName.Category:
                    parameter = IntParameter.Instance.Set(Root, Root.Content, ByteOffset + 846, 4, 0, false, this);
                    break;

                case ParameterNames.ProgramParameterName.SubCategory:
                    parameter = IntParameter.Instance.Set(Root, Root.Content, ByteOffset + 846, 7, 5, false, this);
                    break;

                default:
                    parameter = base.GetParam(name);
                    break;
            }

            return parameter;
        }
    }
}