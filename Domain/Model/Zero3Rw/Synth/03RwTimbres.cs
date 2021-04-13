// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.PatchCombis;
using Domain.Model.ZeroSeries.Synth;

namespace Domain.Model.Zero3Rw.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class Zero3RwTimbres : ZeroSeriesTimbres
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="combi"></param>
        public Zero3RwTimbres(ICombi combi)
            : base(combi)
        {
            TimbresCollection.Clear(); //IMPR: is clear really necessary here?
            for (var n = 0; n < TimbresPerCombi; n++)
            {
                TimbresCollection.Add(new Zero3RwTimbre(this, n));
            }
        }

    }
}
