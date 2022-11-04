#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using PcgTools.Mvvm;

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