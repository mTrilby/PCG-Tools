﻿// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using Domain.Model.Common.Synth.Meta;

namespace Domain.Model.Common.Synth.PatchWaveSequences
{
    /// <summary>
    /// 
    /// </summary>
    public interface IWaveSequenceBanks : IBanks
    {
        /// <summary>
        /// 
        /// </summary>
        int Wsq2PcgOffset { get; set; }
    }
}