// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.MasterFiles;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchCombis;
using Domain.Model.MSpecific.Synth;

namespace Domain.Model.M3Specific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class M3CombiBank : MCombiBank
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="combiBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        public M3CombiBank(ICombiBanks combiBanks, BankTypeEType type, string id, int pcgId)
            : base(combiBanks, type, id, pcgId)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        public override void CreatePatch(int index)
        {
            Add(new M3Combi(this, index));
        }
    }
}
