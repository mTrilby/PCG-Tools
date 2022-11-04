#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchDrumPatterns;

// (c) 2011 Michel Keijzers

namespace Domain.KromeSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class KromeDrumPatternBank : DrumPatternBank
    {
        /// <summary>
        /// </summary>
        /// <param name="drumPatternBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        public KromeDrumPatternBank(IDrumPatternBanks drumPatternBanks, BankType.EType type, string id, int pcgId)
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
                        return 1000;

                    case BankType.EType.User:
                        return 1000;

                    default:
                        throw new NotSupportedException();
                }
            }
        }


        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        public override void CreatePatch(int index)
        {
            Add(new KromeDrumPattern(this, index));
        }
    }
}