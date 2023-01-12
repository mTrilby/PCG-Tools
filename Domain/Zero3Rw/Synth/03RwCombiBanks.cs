#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.Common.Synth.Meta;
using PcgTools.Model.ZeroSeries.Synth;

#endregion

namespace PcgTools.Model.Zero3Rw.Synth
{
    /// <summary>
    /// </summary>
    public class Zero3RwCombiBanks : ZeroSeriesCombiBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public Zero3RwCombiBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }

        /// <summary>
        /// </summary>
        protected override void CreateBanks()
        {
            //                          0 
            foreach (var id in new[] { "A" }) // Pretending all is in A bank
            {
                Add(new Zero3RwCombiBank(this, BankType.EType.Int, id, -1));
            }
        }
    }
}