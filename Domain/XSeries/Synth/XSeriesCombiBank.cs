﻿#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.Meta;
using Domain.MntxSeriesSpecific.Synth;

namespace Domain.XSeries.Synth
{
    /// <summary>
    /// </summary>
    public class XSeriesCombiBank : MntxCombiBank
    {
        /// <summary>
        /// </summary>
        /// <param name="combiBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        public XSeriesCombiBank(IBanks combiBanks, BankType.EType type, string id, int pcgId)
            : base(combiBanks, type, id, pcgId)
        {
        }

        /// <summary>
        /// </summary>
        public override int NrOfPatches => 100;


        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        public override void CreatePatch(int index)
        {
            Add(new XSeriesCombi(this, index));
        }
    }
}