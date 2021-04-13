// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.MasterFiles;
using Domain.Model.Common.Synth.Meta;
using Domain.Model.TritonSpecific.Synth;

namespace Domain.Model.TritonTrClassicStudioRackSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public class TritonTrClassicStudioRackCombiBank : TritonCombiBank
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="combiBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        public TritonTrClassicStudioRackCombiBank(IBanks combiBanks, BankTypeEType type, string id, int pcgId):
            base(combiBanks, type, id, pcgId)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        public override void CreatePatch(int index)
        {
            Add(new TritonTrClassicStudioRackCombi(this, index));
        }
    }
}
