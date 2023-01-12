﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;
using PcgTools.Model.Common.Synth.Meta;
using PcgTools.Model.Common.Synth.PatchDrumPatterns;

#endregion

// (c) 2011 Michel Keijzers

namespace PcgTools.Model.MSpecific.Synth
{
    /// <summary>
    /// </summary>
    public class MDrumPatternBank : DrumPatternBank
    {
        /// <summary>
        /// </summary>
        /// <param name="drumPatternBanks"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="pcgId"></param>
        public MDrumPatternBank(IDrumPatternBanks drumPatternBanks, BankType.EType type, string id, int pcgId)
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

        /// <summary>
        /// </summary>
        /// <param name="index"></param>
        public override void CreatePatch(int index)
        {
            Add(new MDrumPattern(this, index));
        }
    }
}