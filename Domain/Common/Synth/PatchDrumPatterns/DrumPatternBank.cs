#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System;
using Common.PcgToolsResources;
using Domain.Common.Synth.Meta;

// (c) 2011 Michel Keijzers

namespace Domain.Common.Synth.PatchDrumPatterns
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