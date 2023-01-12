#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.PatchInterfaces;
using PcgTools.Mvvm;

#endregion

namespace PcgTools.Model.Common.Synth.PatchCombis
{
    /// <summary>
    /// </summary>
    public interface ITimbres : INavigable
    {
        /// <summary>
        /// </summary>
        ObservableCollectionEx<ITimbre> TimbresCollection { get; }

        /// <summary>
        /// </summary>
        int ByteOffset { get; set; }
    }
}