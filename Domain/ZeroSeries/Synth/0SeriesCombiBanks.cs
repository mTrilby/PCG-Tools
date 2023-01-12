﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;
using Domain.MntxSeriesSpecific.Synth;

#endregion

namespace Domain.ZeroSeries.Synth
{
    /// <summary>
    /// </summary>
    public class ZeroSeriesCombiBanks : MntxCombiBanks
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgMemory"></param>
        public ZeroSeriesCombiBanks(IPcgMemory pcgMemory)
            : base(pcgMemory)
        {
        }

        /// <summary>
        /// </summary>
        protected override void CreateBanks()
        {
            //                          0 
            foreach (var id in new[] { "A", "B", "C", "D" })
            {
                Add(new ZeroSeriesCombiBank(this, BankType.EType.Int, id, -1));
            }

            // Add virtual banks for raw disk image file.
            for (var id = 0; id <= 4; id++)
            {
                Add(new ZeroSeriesCombiBank(this, BankType.EType.Virtual, $"V{id + 1}", -1));
            }
        }
    }
}