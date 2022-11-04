#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Common.MVVM;

namespace Domain.Common.Synth.SongsRelated
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