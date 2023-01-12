#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Mvvm;

#endregion

namespace PcgTools.Model.Common.Synth.SongsRelated
{
    /// <summary>
    /// </summary>
    public interface ISongs
    {
        /// <summary>
        /// </summary>
        ObservableCollectionEx<ISong> SongCollection { get; }
    }
}