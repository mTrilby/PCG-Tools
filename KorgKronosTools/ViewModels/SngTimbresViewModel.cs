#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;
using System.ComponentModel;
using System.Linq;
using Common.Utils;
using Domain.Common.Synth.SongsRelated;

#endregion

namespace PcgTools.ViewModels
{
    /// <summary>
    /// </summary>
    public class SngTimbresViewModel : ViewModel, ISngTimbresViewModel
    {
        /// <summary>
        /// </summary>
        /// <param name="songViewModel"></param>
        public SngTimbresViewModel(ISongViewModel songViewModel)
        {
            SongViewModel = songViewModel;

            Song = SongViewModel.Song;

            // Select first if none selected.
            if (Song.Timbres.TimbresCollection.Any() &&
                Song.Timbres.TimbresCollection.Count(item => item.IsSelected) == 0)
            {
                Song.Timbres.TimbresCollection[0].IsSelected = true;
            }
        }

        /// <summary>
        /// </summary>
        private ISongViewModel SongViewModel { get; }

        /// <summary>
        /// </summary>
        public ISong Song { get; }

        /// <summary>
        /// </summary>
        public Action UpdateUiContent { get; set; }

        /// <summary>
        /// </summary>
        /// <param name="exit"></param>
        /// <returns></returns>
        public override bool Close(bool exit)
        {
            CloseWindow();
            return true;
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        [UsedImplicitly]
        private void OnSongRootChanged(object sender, PropertyChangedEventArgs e)
        {
            //switch (e.PropertyName)
            {
                // default: Ignore file name (and possibly more.
            }
        }
    }
}