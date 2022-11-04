#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchCombis;
using Domain.MntxSeriesSpecific.Synth;

namespace Domain.M3rSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class M3RCombiBank : MntxCombiBank
    {
        /// <summary>
        /// </summary>
        /// <param name="combiBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        public M3RCombiBank(ICombiBanks combiBanks, BankType.EType type, string id, int pcgId)
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
            Add(new M3RCombi(this, index));
        }
    }
}