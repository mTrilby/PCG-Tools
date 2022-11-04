#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using PcgTools.Model.Common.Synth.SongsRelated;
using PcgTools.Songs;

namespace PcgTools.ViewModels
{
    /// <summary>
    /// </summary>
    public interface ISongViewModel : IViewModel
    {
        /// <summary>
        /// </summary>
        string WindowTitle { get; }


        /// <summary>
        /// </summary>
        // ReSharper disable once MemberCanBePrivate.Global
        ISong Song { get; set; }


        OpenedPcgWindows OpenedPcgWindows { get; }


        /// <summary>
        /// </summary>
        // ReSharper disable once MemberCanBePrivate.Global
        void UpdateWindowTitle();
    }
}