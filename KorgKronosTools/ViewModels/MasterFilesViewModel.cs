#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System.Linq;
using System.Windows.Input;
using Common.Utils;
using Domain.Common;
using Domain.Common.MasterFiles;
using PcgTools.MasterFiles;
using PcgTools.Mvvm;

#endregion

namespace PcgTools.ViewModels
{
    /// <summary>
    /// </summary>
    public class MasterFilesViewModel : ViewModel
    {
        /// <summary>
        /// </summary>
        private readonly IMainViewModel _mainViewModel;

        /// <summary>
        /// </summary>
        private ICommand _closeMasterFileCommand;

        /// <summary>
        /// </summary>
        private ICommand _openMasterFileCommand;

        /// <summary>
        /// </summary>
        private ICommand _unassignMasterFileCommand;

        /// <summary>
        /// </summary>
        /// <param name="mainViewModel"></param>
        public MasterFilesViewModel(IMainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;

            // Select first if none selected.
            var masterFiles = Domain.Common.MasterFiles.MasterFiles.Instances;
            if (masterFiles.Count > 0 && masterFiles.Count(item => item.IsSelected) == 0)
            {
                masterFiles[0].IsSelected = true;
            }
        }

        private IMasterFile SelectedMasterFile
        {
            get { return Domain.Common.MasterFiles.MasterFiles.Instances.FirstOrDefault(file => file.IsSelected); }
        }

        /// <summary>
        /// </summary>
        [UsedImplicitly]
        // ReSharper disable once UnusedMember.Global
        public ICommand OpenMasterFileCommand
        {
            get
            {
                return _openMasterFileCommand ?? (_openMasterFileCommand = new RelayCommand(param => OpenMasterFile(),
                    param => CanExecuteOpenMasterFileCommand));
            }
        }

        /// <summary>
        /// </summary>
        private bool CanExecuteOpenMasterFileCommand => SelectedMasterFile.FileState == MasterFile.EFileState.Unloaded;

        /// <summary>
        /// </summary>
        [UsedImplicitly]
        // ReSharper disable once UnusedMember.Global
        public ICommand CloseMasterFileCommand
        {
            get
            {
                return _closeMasterFileCommand ??
                       (_closeMasterFileCommand = new RelayCommand(param => CloseMasterFile(),
                           param => CanExecuteCloseMasterFileCommand));
            }
        }

        /// <summary>
        /// </summary>
        private bool CanExecuteCloseMasterFileCommand => SelectedMasterFile.FileState == MasterFile.EFileState.Loaded;

        /// <summary>
        /// </summary>
        [UsedImplicitly]
        // ReSharper disable once UnusedMember.Global
        public ICommand UnassignMasterFileCommand
        {
            get
            {
                return _unassignMasterFileCommand ??
                       (_unassignMasterFileCommand = new RelayCommand(param => UnassignMasterFile(),
                           param => CanExecuteUnassignMasterFileCommand));
            }
        }

        /// <summary>
        /// </summary>
        private bool CanExecuteUnassignMasterFileCommand =>
            SelectedMasterFile.FileState != MasterFile.EFileState.Unassigned;

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
        /// <returns></returns>
        public override bool Revert()
        {
            return true;
        }

        /// <summary>
        /// </summary>
        private void OpenMasterFile()
        {
            _mainViewModel.CheckAndOpenFile(SelectedMasterFile.FileName);
        }

        /// <summary>
        /// </summary>
        private void CloseMasterFile()
        {
            _mainViewModel.ClosePcgFile(SelectedMasterFile.FileName);
        }

        /// <summary>
        /// </summary>
        private void UnassignMasterFile()
        {
            SelectedMasterFile.SetModel(SelectedMasterFile.Model, string.Empty);
        }
    }
}