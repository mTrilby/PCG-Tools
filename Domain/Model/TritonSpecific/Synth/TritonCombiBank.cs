// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using Domain.Model.Common.Synth.Meta;
using Domain.Model.Common.Synth.PatchCombis;

namespace Domain.Model.TritonSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class TritonCombiBank : CombiBank
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="combiBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        protected TritonCombiBank(IBanks combiBanks, BankTypeEType type, string id, int pcgId)
            : base(combiBanks, type, id, pcgId)
        {
        }
    }
}
