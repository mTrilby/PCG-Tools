#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.MntxSeriesSpecific.Synth;

namespace Domain.XSeries.Synth
{
    /// <summary>
    /// </summary>
    public class XSeriesCombiBanks : MntxCombiBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public XSeriesCombiBanks(IPcgMemory pcgMemory)
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
                Add(new XSeriesCombiBank(this, BankType.EType.Int, id, -1));
            }
        }
    }
}