#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchCombis;
using Domain.MSpecific.Synth;

namespace Domain.KromeExSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class KromeExCombiBank : MCombiBank
    {
        /// <summary>
        /// </summary>
        /// <param name="combiBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        public KromeExCombiBank(ICombiBanks combiBanks, BankType.EType type, string id, int pcgId)
            : base(combiBanks, type, id, pcgId)
        {
        }


        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        public override void CreatePatch(int index)
        {
            Add(new KromeExCombi(this, index));
        }
    }
}