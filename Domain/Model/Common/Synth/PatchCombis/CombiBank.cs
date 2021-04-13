// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using System;
using Domain.Model.Common.Synth.Meta;
using Domain.PcgToolsResources;

namespace Domain.Model.Common.Synth.PatchCombis
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class CombiBank : Bank<Combi>, ICombiBank
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="combiBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        protected CombiBank(IBanks combiBanks, BankTypeEType type, string id, int pcgId) : 
            base(combiBanks, type, id, pcgId)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        public override string Name { get { return "n.a."; } set { throw new ApplicationException("Not yet implemented"); } }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Strings.Bank_2str} {Id}";
        }
    }
}
