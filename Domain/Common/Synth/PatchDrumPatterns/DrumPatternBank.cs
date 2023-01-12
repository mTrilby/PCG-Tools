#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;
using Common.PcgToolsResources;
using PcgTools.Model.Common.Synth.Meta;

#endregion

// (c) 2011 Michel Keijzers

namespace PcgTools.Model.Common.Synth.PatchDrumPatterns
{
    /// <summary>
    /// </summary>
    public abstract class DrumPatternBank : Bank<DrumPattern>, IDrumPatternBank
    {
        /// <summary>
        /// </summary>
        /// <param name="drumPatternBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        protected DrumPatternBank(IBanks drumPatternBanks, BankType.EType type, string id, int pcgId)
            : base(drumPatternBanks, type, id, pcgId)
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