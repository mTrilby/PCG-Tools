#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.OldParameters;
using Domain.Common.Synth.PatchCombis;
using Domain.ZeroSeries.Synth;

namespace Domain.Zero3Rw.Synth
{
    /// <summary>
    /// </summary>
    public class Zero3RwCombi : ZeroSeriesCombi
    {
        /// <summary>
        /// </summary>
        /// <param name="combiBank"></param>
        /// <param name="index"></param>
        public Zero3RwCombi(ICombiBank combiBank, int index)
            : base(combiBank, index)
        {
            if (combiBank.Type == BankType.EType.Int)
            {
                Id = $"{combiBank.Id}{index.ToString("00")}";
            }
            else
            {
                throw new NotSupportedException("Unsupported bank type");
            }

            Timbres = new Zero3RwTimbres(this);
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
                default:
                    parameter = base.GetParam(name);
                    break;
            }

            return parameter;
        }
    }
}