﻿#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;
using Domain.TritonLeSpecific.Synth;
using Domain.TritonSpecific.Pcg;

namespace Domain.TritonLeSpecific.Pcg
{
    /// <summary>
    /// </summary>
    public class TritonLePcgMemory : TritonPcgMemory
    {
        /// <summary>
        /// </summary>
        /// <param name="fileName"></param>
        public TritonLePcgMemory(string fileName)
            : base(fileName, Models.EModelType.TritonLe)
        {
            CombiBanks = new TritonLeCombiBanks(this);
            ProgramBanks = new TritonLeProgramBanks(this);
            SetLists = null;
            WaveSequenceBanks = null;
            DrumKitBanks = new TritonLeDrumKitBanks(this);
            DrumPatternBanks = null;
            Global = new TritonLeGlobal(this);
            Model = Models.Find(Models.EOsVersion.EOsVersionTritonLe);
        }
    }
}