#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchDrumKits;
using Domain.MSpecific.Synth;

// (c) 2011 Michel Keijzers

namespace Domain.KromeExSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class KromeExDrumKitBank : MDrumKitBank
    {
        /// <summary>
        /// </summary>
        /// <param name="drumKitBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        public KromeExDrumKitBank(IDrumKitBanks drumKitBanks, BankType.EType type, string id, int pcgId)
            : base(drumKitBanks, type, id, pcgId)
        {
        }


        /// <summary>
        /// </summary>
        public override int NrOfPatches
        {
            get
            {
                int nrOfPatches;
                switch (Type)
                {
                    case BankType.EType.Int:
                        nrOfPatches = 48;
                        break;

                    case BankType.EType.User:
                        nrOfPatches = 80 - 48;
                        break;

                    case BankType.EType.Gm:
                        nrOfPatches = 88 - 80;
                        break;

                    default:
                        throw new NotSupportedException();
                }

                return nrOfPatches;
            }
        }


        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        public override void CreatePatch(int index)
        {
            Add(new KromeExDrumKit(this, index));
        }
    }
}