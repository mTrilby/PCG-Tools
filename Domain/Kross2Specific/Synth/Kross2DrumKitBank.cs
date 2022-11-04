#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System;
using Domain.Common.Synth.Meta;
using Domain.Common.Synth.PatchDrumKits;
using Domain.MSpecific.Synth;

// (c) 2011 Michel Keijzers

namespace Domain.Kross2Specific.Synth
{
    /// <summary>
    /// </summary>
    public class Kross2DrumKitBank : MDrumKitBank
    {
        /// <summary>
        /// </summary>
        /// <param name="drumKitBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        public Kross2DrumKitBank(IDrumKitBanks drumKitBanks, BankType.EType type, string id, int pcgId)
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
                        return 42;

                    case BankType.EType.User:
                        return 16; // 42-57

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
            Add(new Kross2DrumKit(this, index));
        }
    }
}