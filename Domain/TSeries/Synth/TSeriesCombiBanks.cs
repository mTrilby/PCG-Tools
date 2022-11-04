#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.MntxSeriesSpecific.Synth;

namespace Domain.TSeries.Synth
{
    /// <summary>
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class TSeriesCombiBanks : MntxCombiBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public TSeriesCombiBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }


        /// <summary>
        /// </summary>
        protected override void CreateBanks()
        {
            //                          0 
            foreach (var id in new[] { "C" })
            {
                Add(new TSeriesCombiBank(this, BankType.EType.Int, id, -1));
            }
        }
    }
}