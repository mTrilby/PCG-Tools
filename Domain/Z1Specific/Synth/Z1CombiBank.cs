#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.Meta;
using Domain.MntxSeriesSpecific.Synth;

#endregion

namespace Domain.Z1Specific.Synth
{
    /// <summary>
    /// </summary>
    public class Z1CombiBank : MntxCombiBank
    {
        /// <summary>
        /// </summary>
        /// <param name="combiBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        public Z1CombiBank(IBanks combiBanks, BankType.EType type, string id, int pcgId)
            : base(combiBanks, type, id, pcgId) // 16 multis
        {
        }

        /// <summary>
        /// </summary>
        public override int NrOfPatches => 16;

        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        public override void CreatePatch(int index)
        {
            Add(new Z1Combi(this, index));
        }
    }
}