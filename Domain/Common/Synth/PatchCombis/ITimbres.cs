#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Common.MVVM;
using Domain.Common.Synth.PatchInterfaces;

#endregion

namespace Domain.Common.Synth.PatchCombis
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