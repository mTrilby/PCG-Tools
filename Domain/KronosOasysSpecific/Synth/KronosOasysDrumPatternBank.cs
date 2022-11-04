#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System;
using PcgTools.Model.Common.Synth.Meta;
using PcgTools.Model.Common.Synth.PatchDrumPatterns;

// (c) 2011 Michel Keijzers

namespace PcgTools.Model.KronosOasysSpecific.Synth
{
    /// <summary>
    /// </summary>
    public abstract class KronosOasysDrumPatternBank : DrumPatternBank
    {
        /// <summary>
        /// </summary>
        /// <param name="drumPatternBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        protected KronosOasysDrumPatternBank(IDrumPatternBanks drumPatternBanks, BankType.EType type, string id,
            int pcgId)
            : base(drumPatternBanks, type, id, pcgId)
        {
        }

        /// <summary>
        /// </summary>
        public override int NrOfPatches
        {
            get
            {
                switch (Type)
                {
                    case BankType.EType.Int:
                        return 1000; // Maximum amount

                    case BankType.EType.User:
                        return 1000; // Maximum amount

                    default:
                        throw new NotSupportedException();
                }
            }
        }
    }
}