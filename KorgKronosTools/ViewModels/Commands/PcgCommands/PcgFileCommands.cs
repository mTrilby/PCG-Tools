using System;
using Common.Windows;
using Domain.Interfaces;
using Domain.MasterFiles;
using Domain.Model.Common.File;
using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.SongsRelated;
using Domain.PcgToolsResources;
using PcgTools.Common.Utils;
using PcgTools.Properties;
using WPF.MDI;

namespace PcgTools.ViewModels.Commands.PcgCommands
{
    /// <summary>
    /// Utility class.
    /// </summary>
    public static class PcgFileCommands
    {
        private static MainViewModel _mainViewModel;


        public static void LoadFileAndMasterFile(IMainViewModel mainViewModel, string fileName, bool checkAutoLoadMasterFileSetting)
        {
            _mainViewModel = (MainViewModel)mainViewModel;

            // Load file.
            var korgFileReader = new KorgFileReader();
            var memory = korgFileReader.Read(fileName); // Model type/file type only used when error
            if (memory == null)
            {
                _mainViewModel.ShowMessageBox(
                    string.Format(Strings.FileTypeNotSupportedForThisWorkstation,
                        Memory.FileTypeAsString(korgFileReader.FileType),
                        Model.ModelTypeAsString(korgFileReader.ModelType)),
                    Strings.PcgTools, Utils.EMessageBoxButton.Ok, Utils.EMessageBoxImage.Error,
                    Utils.EMessageBoxResult.Ok);
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
                mdiChild = _mainViewModel.CreateMdiChildWindow(fileName, MainViewModel.ChildWindowType.Pcg, memory, width, height);
                ((PcgWindow)(mdiChild.Content)).ViewModel.SelectedMemory = memory;
                _mainViewModel.CurrentChildViewModel = ((PcgWindow)(mdiChild.Content)).ViewModel;
                ((IPcgMemory) memory).SelectFirstBanks();
            }
            else if (memory is ISongMemory)
            {
                var width = Settings.Default.UI_SongWindowWidth == 0 ? 700 : Settings.Default.UI_SongWindowWidth;
                var height = Settings.Default.UI_SongWindowHeight == 0 ? 500 : Settings.Default.UI_SongWindowHeight;
                mdiChild = _mainViewModel.CreateMdiChildWindow(fileName, MainViewModel.ChildWindowType.Song, memory, width, height);
                _mainViewModel.CurrentChildViewModel = ((SongWindow)(mdiChild.Content)).ViewModel;
                ((SongWindow)(mdiChild.Content)).ViewModel.SelectedMemory = memory;
            }
            else
            {
                throw new ApplicationException("Unknown memory type");
            }
        }


        /// <summary>
        ///
        /// </summary>
        /// <param name="checkAutoLoadMasterFileSetting"></param>
        /// <param name="loadedPcgFileName"></param>
        static void LoadMasterFileIfRequested(bool checkAutoLoadMasterFileSetting, string loadedPcgFileName)
        {
            if (checkAutoLoadMasterFileSetting)
            {
                // Get master file name.
                var masterFile = Domain.MasterFiles.MasterFiles.Instances.FindMasterFile(_mainViewModel.SelectedMemory.Model);
                if ((masterFile != null) && (masterFile.FileState == MasterFileEFileState.Unloaded))
                {
                    switch ((Domain.MasterFiles.MasterFiles.AutoLoadMasterFiles)(Settings.Default.MasterFiles_AutoLoad))
                    {
                        case Domain.MasterFiles.MasterFiles.AutoLoadMasterFiles.Always:
                            if (masterFile.FileName != loadedPcgFileName)
                            {
                                LoadFileAndMasterFile(_mainViewModel, masterFile.FileName, false);
                            }
                            break;

                        case Domain.MasterFiles.MasterFiles.AutoLoadMasterFiles.Ask:
                            if (masterFile.FileName != loadedPcgFileName)
                            {
                                var result = _mainViewModel.ShowMessageBox(
                                    string.Format(Strings.AskForMasterFile, masterFile.FileName),
                                    Strings.PcgTools, Utils.EMessageBoxButton.YesNo,
                                    Utils.EMessageBoxImage.Information,
                                    Utils.EMessageBoxResult.Yes);

                                if (result == Utils.EMessageBoxResult.Yes)
                                {
                                    LoadFileAndMasterFile(_mainViewModel, masterFile.FileName, false);
                                }
                            }
                            break;

                        case Domain.MasterFiles.MasterFiles.AutoLoadMasterFiles.Never:
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
