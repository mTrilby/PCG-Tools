﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.Meta;

#endregion

namespace Domain.Common.Synth.PatchWaveSequences
{
    /// <summary>
    /// </summary>
    public interface IWaveSequenceBanks : IBanks
    {
        /// <summary>
        /// </summary>
        int Wsq2PcgOffset { get; set; }
    }
}