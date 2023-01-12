#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;
using Common.PcgToolsResources;
using Common.Utils;
using Domain.Common;
using Domain.Common.File;
using Domain.Common.MasterFiles;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.SongsRelated;
using PcgTools.Properties;
using WPF.MDI;

#endregion

namespace PcgTools.ViewModels.Commands.PcgCommands
{
    /// <summary>
    ///     Utility class.
    /// </summary>
    public static class PcgFileCommands
    {
        private static IMainViewModel _mainViewModel;

        public static void LoadFileAndMasterFile(IMainViewModel mainViewModel, string fileName,
            bool checkAutoLoadMasterFileSetting)
        {
            _mainViewModel = mainViewModel;

            // Load file.
            var korgFileReader = new KorgFileReader();
            var memory = korgFileReader.Read(fileName); // Model type/file type only used when error
            if (memory == null)
            {
                _mainViewModel.ShowMessageBox(
                    string.Format(Strings.FileTypeNotSupportedForThisWorkstation,
                        Memory.FileTypeAsString(korgFileReader.FileType),
                        Model.ModelTypeAsString(korgFileReader.ModelType)),
                    Strings.PcgTools, WindowUtil.EMessageBoxButton.Ok, WindowUtil.EMessageBoxImage.Error,
                    WindowUtil.EMessageBoxResult.Ok);
                return;
            }

            _mainViewModel.SelectedMemory = memory;

            // Load master file if requested.
            LoadMasterFileIfRequested(checkAutoLoadMasterFileSetting, fileName);

            // Create child window.
            MdiChild mdiChild;
            if (memory is IPcgMemory)
            {
                var width = Settings.Default.UI_PcgWindowWidth == 0 ? 700 : Settings.Default.UI_PcgWindowWidth;
                var height = Settings.Default.UI_PcgWindowHeight == 0 ? 500 : Settings.Default.UI_PcgWindowHeight;
                mdiChild = ((MainViewModel)_mainViewModel).CreateMdiChildWindow(fileName,
                    MainViewModel.ChildWindowType.Pcg, memory, width, height);
                ((PcgWindow)mdiChild.Content).ViewModel.SelectedMemory = memory;
                _mainViewModel.CurrentChildViewModel = ((PcgWindow)mdiChild.Content).ViewModel;
                ((IPcgMemory)memory).SelectFirstBanks();
            }
            else if (memory is ISongMemory)
            {
                var width = Settings.Default.UI_SongWindowWidth == 0 ? 700 : Settings.Default.UI_SongWindowWidth;
                var height = Settings.Default.UI_SongWindowHeight == 0 ? 500 : Settings.Default.UI_SongWindowHeight;
                mdiChild = ((MainViewModel)_mainViewModel).CreateMdiChildWindow(fileName,
                    MainViewModel.ChildWindowType.Song, memory, width, height);
                _mainViewModel.CurrentChildViewModel = ((SongWindow)mdiChild.Content).ViewModel;
                ((SongWindow)mdiChild.Content).ViewModel.SelectedMemory = memory;
            }
            else
            {
                throw new ApplicationException("Unknown memory type");
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="checkAutoLoadMasterFileSetting"></param>
        /// <param name="loadedPcgFileName"></param>
        private static void LoadMasterFileIfRequested(bool checkAutoLoadMasterFileSetting, string loadedPcgFileName)
        {
            if (checkAutoLoadMasterFileSetting)
            {
                // Get master file name.
                var masterFile = Domain.Common.MasterFiles.MasterFiles.Instances.FindMasterFile(_mainViewModel.SelectedMemory.Model);
                if (masterFile != null && masterFile.FileState == MasterFile.EFileState.Unloaded)
                {
                    switch ((Domain.Common.MasterFiles.MasterFiles.AutoLoadMasterFiles)Settings.Default.MasterFiles_AutoLoad)
                    {
                        case Domain.Common.MasterFiles.MasterFiles.AutoLoadMasterFiles.Always:
                            if (masterFile.FileName != loadedPcgFileName)
                            {
                                LoadFileAndMasterFile(_mainViewModel, masterFile.FileName, false);
                            }

                            break;

                        case Domain.Common.MasterFiles.MasterFiles.AutoLoadMasterFiles.Ask:
                            if (masterFile.FileName != loadedPcgFileName)
                            {
                                var result = _mainViewModel.ShowMessageBox(
                                    string.Format(Strings.AskForMasterFile, masterFile.FileName),
                                    Strings.PcgTools, WindowUtil.EMessageBoxButton.YesNo,
                                    WindowUtil.EMessageBoxImage.Information,
                                    WindowUtil.EMessageBoxResult.Yes);

                                if (result == WindowUtil.EMessageBoxResult.Yes)
                                {
                                    LoadFileAndMasterFile(_mainViewModel, masterFile.FileName, false);
                                }
                            }

                            break;

                        case Domain.Common.MasterFiles.MasterFiles.AutoLoadMasterFiles.Never:
                            // Do nothing.
                            break;

                        default:
                            throw new ApplicationException("Illegal case");
                    }
                }
            }
        }
    }
}