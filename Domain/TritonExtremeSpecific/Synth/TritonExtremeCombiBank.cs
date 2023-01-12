﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchCombis;
using Domain.TritonSpecific.Synth;

#endregion

namespace Domain.TritonExtremeSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class TritonExtremeCombiBank : TritonCombiBank
    {
        /// <summary>
        /// </summary>
        /// <param name="combiBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        public TritonExtremeCombiBank(ICombiBanks combiBanks, BankType.EType type, string id, int pcgId) :
            base(combiBanks, type, id, pcgId)
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        public override void CreatePatch(int index)
        {
            Add(new TritonExtremeCombi(this, index));
        }
    }
}