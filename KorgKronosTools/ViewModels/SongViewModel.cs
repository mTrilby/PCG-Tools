﻿#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Common.MVVM;
using Common.PcgToolsResources;
using Domain.Common.OpenedFiles;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.SongsRelated;
using PcgTools.Mvvm;
using PcgTools.ViewModels.Commands.PcgCommands;

namespace PcgTools.ViewModels
{
    /// <summary>
    /// </summary>
    public class SongViewModel : ObservableObject, ISongViewModel
    {
        /// <summary>
        /// </summary>
        private OpenedPcgWindows _openedPcgWindows;


        /// <summary>
        /// </summary>
        private RelayCommand _saveCommand;


        /// <summary>
        /// </summary>
        private string _selectedPcgFileName;


        /// <summary>
        /// </summary>
        private ISong _song;


        /// <summary>
        /// </summary>
        private string _windowTitle;

        /// <summary>
        /// </summary>
        public SongViewModel(OpenedPcgWindows openedPcgWindows)
        {
            OpenedPcgWindows = openedPcgWindows;
            OpenedPcgWindows.Items.CollectionChanged += OpenedPcgWindowsChanged;
        }


        /// <summary>
        /// </summary>
        // ReSharper disable once MemberCanBePrivate.Global
        public ICommand SaveCommand
        {
            get
            {
                return _saveCommand ?? (_saveCommand = new RelayCommand(
                    param => ExecuteCommandSaveSong(), param => CanExecuteSaveCommand()));
            }
        }


        /// <summary>
        /// </summary>
        public ISongMemory SelectedSongMemory => (ISongMemory)SelectedMemory;


        /// <summary>
        /// </summary>
        public string SelectedPcgFileName
        {
            get => _selectedPcgFileName;

            set
            {
                if (_selectedPcgFileName != value)
                {
                    _selectedPcgFileName = value;
                    OnPropertyChanged("SelectedPcgFileName");
                }
            }
        }


        /// <summary>
        /// </summary>
        // ReSharper disable once MemberCanBePrivate.Global
        public OpenedPcgWindows OpenedPcgWindows
        {
            get => _openedPcgWindows;

            set
            {
                if (_openedPcgWindows != value)
                {
                    _openedPcgWindows = value;
                    RaisePropertyChanged("OpenedPcgWindows");
                }
            }
        }


        /// <summary>
        /// </summary>
        public string WindowTitle
        {
            get => _windowTitle;
            private set
            {
                if (value != WindowTitle)
                {
                    _windowTitle = value;
                }
            }
        }


        /// <summary>
        /// </summary>
        // ReSharper disable once MemberCanBePrivate.Global
        public void UpdateWindowTitle()
        {
            WindowTitle =
                $"{SelectedMemory.FileName}{(SelectedMemory.IsDirty ? " *" : string.Empty)} ({SelectedMemory.Model.ModelAndVersionAsString})";
        }


        /// <summary>
        /// </summary>
        // ReSharper disable once MemberCanBePrivate.Global
        public ISong Song
        {
            get => _song;

            // ReSharper disable once UnusedMember.Global
            set
            {
                if (_song != value)
                {
                    _song = value;
                    OnPropertyChanged("Song");
                }
            }
        }


        /// <summary>
        /// </summary>
        /// <returns></returns>
        public bool Revert()
        {
            return true;
        }


        /// <summary>
        /// </summary>
        public IMemory SelectedMemory { get; set; }


        /// <summary>
        /// </summary>
        /// <param name="exitMode"></param>
        /// <returns></returns>
        public bool Close(bool exitMode)
        {
            SelectedMemory = null;
            return true;
        }


        /// <summary>
        ///     Not used; does not work either.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenedPcgWindowsChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            // If no file selected and model is correct, use it.
            if (string.IsNullOrEmpty(SelectedPcgFileName))
            {
                if (e.NewItems != null)
                {
                    foreach (var item in e.NewItems.Cast<OpenedPcgWindow>().Where(item =>
                                 SelectedMemory.Model.ModelType == Models.EModelType.Kronos &&
                                 ModelCompatibility.AreModelsCompatible(SelectedMemory.Model, item.PcgMemory.Model)))
                    {
                        SelectedPcgFileName = item.PcgMemory.FileName;
                        break;
                    }
                }
            }
            else
            {
                if (e.OldItems != null)
                {
                    // If file is selected which is closed, deselect it.
                    foreach (
                        var item in
                        e.OldItems.Cast<OpenedPcgWindow>()
                            .Where(item => SelectedPcgFileName == item.PcgMemory.FileName))
                    {
                        SelectedPcgFileName = null;
                        break;
                    }
                }
            }
        }


        /// <summary>
        /// </summary>
        /// <returns></returns>
        private bool CanExecuteSaveCommand()
        {
            return _song.Memory.IsDirty;
        }


        /// <summary>
        /// </summary>
        private void ExecuteCommandSaveSong()
        {
            try
            {
                Song.Memory.SaveFile(false, true);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, Strings.PcgTools, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        /// <summary>
        /// </summary>
        /// <param name="o"></param>
        /// <param name="args"></param>
        private void OnPropertyChanged(object o, PropertyChangedEventArgs args)
        {
            switch (args.PropertyName)
            {
                case "Dirty":
                    UpdateWindowTitle();
                    break;
            }
        }
    }
}