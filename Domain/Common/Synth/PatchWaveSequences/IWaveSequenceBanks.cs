#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.Meta;

#endregion

namespace PcgTools.Model.Common.Synth.PatchWaveSequences
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