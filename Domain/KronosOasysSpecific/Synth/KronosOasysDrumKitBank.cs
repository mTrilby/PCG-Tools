#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchDrumKits;

// (c) 2011 Michel Keijzers

namespace Domain.KronosOasysSpecific.Synth
{
    /// <summary>
    /// </summary>
    public abstract class KronosOasysDrumKitBank : DrumKitBank
    {
        /// <summary>
        /// </summary>
        /// <param name="drumKitBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        protected KronosOasysDrumKitBank(IDrumKitBanks drumKitBanks, BankType.EType type, string id, int pcgId)
            : base(drumKitBanks, type, id, pcgId)
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
                        return 40;

                    case BankType.EType.User:
                        return 16;

                    default:
                        throw new NotSupportedException();
                }
            }
        }
    }
}