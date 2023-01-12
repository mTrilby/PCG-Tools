#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;
using Common.PcgToolsResources;
using PcgTools.Model.Common.Synth.Meta;

#endregion

namespace PcgTools.Model.Common.Synth.PatchCombis
{
    /// <summary>
    /// </summary>
    public abstract class CombiBank : Bank<Combi>, ICombiBank
    {
        /// <summary>
        /// </summary>
        /// <param name="combiBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        protected CombiBank(IBanks combiBanks, BankType.EType type, string id, int pcgId) :
            base(combiBanks, type, id, pcgId)
        {
        }

        /// <summary>
        /// </summary>
        public override string Name
        {
            get => "n.a.";
            set => throw new ApplicationException("Not yet implemented");
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Strings.Bank_2str} {Id}";
        }
    }
}