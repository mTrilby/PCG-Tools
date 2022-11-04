#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.OldParameters;
using Domain.Common.Synth.PatchPrograms;
using Domain.ZeroSeries.Synth;

namespace Domain.Zero3Rw.Synth
{
    /// <summary>
    /// </summary>
    public class Zero3RwProgram : ZeroSeriesProgram
    {
        /// <summary>
        /// </summary>
        /// <param name="programBank"></param>
        /// <param name="index"></param>
        public Zero3RwProgram(IProgramBank programBank, int index)
            : base(programBank, index)
        {
            switch (programBank.Type)
            {
                case BankType.EType.Virtual:
                    throw new NotSupportedException("03R/W has no virtual banks");

                // default: Do nothing.
            }
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
                default:
                    parameter = base.GetParam(name);
                    break;
            }

            return parameter;
        }
    }
}