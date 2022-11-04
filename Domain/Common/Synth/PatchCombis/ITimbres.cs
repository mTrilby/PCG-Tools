#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using PcgTools.Model.Common.Synth.PatchInterfaces;
using PcgTools.Mvvm;

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