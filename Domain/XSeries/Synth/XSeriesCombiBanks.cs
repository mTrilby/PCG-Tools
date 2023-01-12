#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.Common.Synth.Meta;
using PcgTools.Model.MntxSeriesSpecific.Synth;

#endregion

namespace PcgTools.Model.XSeries.Synth
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