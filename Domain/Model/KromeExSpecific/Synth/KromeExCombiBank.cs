// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using Domain.MasterFiles;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchCombis;
using Domain.Model.MSpecific.Synth;

namespace Domain.Model.KromeExSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class KromeExCombiBank : MCombiBank
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="combiBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        public KromeExCombiBank(ICombiBanks combiBanks, BankTypeEType type, string id, int pcgId)
            : base(combiBanks, type, id, pcgId)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        public override void CreatePatch(int index)
        {
            Add(new KromeExCombi(this, index));
        }
    }
}