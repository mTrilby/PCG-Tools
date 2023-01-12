#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchDrumPatterns;

#endregion

// (c) 2011 Michel Keijzers

namespace Domain.KronosOasysSpecific.Synth
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