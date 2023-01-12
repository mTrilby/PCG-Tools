﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Mvvm;

#endregion

namespace PcgTools.Model.Common.Synth.SongsRelated
{
    /// <summary>
    /// </summary>
    public class Songs : ISongs
    {
        /// <summary>
        /// </summary>
        public Songs()
        {
            SongCollection = new ObservableCollectionEx<ISong>();
        }

        /// <summary>
        /// </summary>
        public ObservableCollectionEx<ISong> SongCollection { get; }
    }
}