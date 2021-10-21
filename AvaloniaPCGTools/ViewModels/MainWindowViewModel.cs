#region using

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Avalonia.Controls;
using Avalonia.VisualTree;
using Domain.ClipBoard;
using Domain.Model.Common.File;
using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Themes;
using Domain.Windows;
using PCGTools_Avalonia.Views;
using ReactiveUI;

#endregion

namespace PCGTools_Avalonia.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly ModelMainWindow _model;
        private readonly IServiceProvider? _serviceProvider;

        public MainWindowViewModel(IServiceProvider serviceProvider) : this(new ModelMainWindow())
        {
            _serviceProvider = serviceProvider;
        }

        public MainWindowViewModel(ModelMainWindow model)
        {
            _model = model;
        }

        public ICommand CloseFileCommand =>
            ReactiveCommand.Create(NotImplementedAction, CanExecuteNotImplementedAction);

        public ICommand ExitCommand => ReactiveCommand.Create(NotImplementedAction, CanExecuteNotImplementedAction);

        public ICommand GotoNextWindowCommand =>
            ReactiveCommand.Create(NotImplementedAction, CanExecuteNotImplementedAction);

        public ICommand GotoPreviousWindowCommand =>
            ReactiveCommand.Create(NotImplementedAction, CanExecuteNotImplementedAction);

        public ICommand OpenFileCommand => ReactiveCommand.CreateFromTask(OpenFilesAction, CanExecuteOpenFiles);

        public ICommand RevertToSavedFileCommand =>
            ReactiveCommand.Create(NotImplementedAction, CanExecuteNotImplementedAction);

        public ICommand SaveFileAsCommand =>
            ReactiveCommand.Create(NotImplementedAction, CanExecuteNotImplementedAction);

        public ICommand SaveFileCommand => ReactiveCommand.Create(NotImplementedAction, CanExecuteNotImplementedAction);

        public ICommand ShowAboutCommand =>
            ReactiveCommand.Create(NotImplementedAction, CanExecuteNotImplementedAction);

        public ICommand ShowExternalLinksContributorsCommand =>
            ReactiveCommand.Create(NotImplementedAction, CanExecuteNotImplementedAction);

        public ICommand ShowExternalLinksDonatorsCommand =>
            ReactiveCommand.Create(NotImplementedAction, CanExecuteNotImplementedAction);

        public ICommand ShowExternalLinksKorgRelatedCommand =>
            ReactiveCommand.Create(NotImplementedAction, CanExecuteNotImplementedAction);

        public ICommand ShowExternalLinksOasysVoucherCodeSponsorsCommand =>
            ReactiveCommand.Create(NotImplementedAction, CanExecuteNotImplementedAction);

        public ICommand ShowExternalLinksPersonalCommand =>
            ReactiveCommand.Create(NotImplementedAction, CanExecuteNotImplementedAction);

        public ICommand ShowExternalLinksThirdPartiesCommand =>
            ReactiveCommand.Create(NotImplementedAction, CanExecuteNotImplementedAction);

        public ICommand ShowExternalLinksTranslatorsCommand =>
            ReactiveCommand.Create(NotImplementedAction, CanExecuteNotImplementedAction);

        public ICommand ShowExternalLinksVideoCreatorsCommand =>
            ReactiveCommand.Create(NotImplementedAction, CanExecuteNotImplementedAction);

        public ICommand ShowHomePageCommand =>
            ReactiveCommand.Create(NotImplementedAction, CanExecuteNotImplementedAction);

        public ICommand ShowManualCommand =>
            ReactiveCommand.Create(NotImplementedAction, CanExecuteNotImplementedAction);

        public ICommand ShowMasterFilesCommand =>
            ReactiveCommand.Create(NotImplementedAction, CanExecuteNotImplementedAction);

        public ICommand ShowSettingsCommand =>
            ReactiveCommand.Create(NotImplementedAction, CanExecuteNotImplementedAction);

        public ICommand ShowSingleLinedSetListSlotDescriptionsCommand =>
            ReactiveCommand.Create(NotImplementedAction, CanExecuteNotImplementedAction);

        public ICommand ShowSpecialEventCommand =>
            ReactiveCommand.Create(NotImplementedAction, CanExecuteNotImplementedAction);

        public bool IsShowSingleLinedSetListSlotDescriptions { get; set; }
        public Theme SelectedTheme { get; set; }

        public string Title => _model.Title;
        
        private IObservable<bool> CanExecuteOpenFiles => Observable.Return(true);

        private IObservable<bool>? CanExecuteNotImplementedAction => Observable.Return(NotImplementedCanExecute());

        private async Task OpenFilesAction()
        {
            var openFile = new OpenFileDialog
            {
                Title = null,
                Directory = null,
                Filters = new List<FileDialogFilter>() { new() { Name = "PCG", Extensions = { "pcg" } } },
                InitialFileName = null,
                AllowMultiple = false,
            };

            var parent = ResolveViewFromViewModel(this);
            var thisWindow = (Window)parent.GetVisualRoot();

            var files = await openFile.ShowAsync(thisWindow);
            var openFileList = files?.Where(x => !string.IsNullOrEmpty(x)).ToList() ?? new List<string>();

            if (!openFileList.Any()) return;

            OpenFiles(openFileList);
        }

        private void OpenFiles(List<string> files)
        {
            foreach (var file in files)
            {
                _model.OpenFileName = file;
                CheckAndOpenFile(file);
            }
        }

        /// <summary>
        ///     Check if there are PCG windows opened with the same file name, and open file.
        /// </summary>
        /// <param name="fileNamePath"></param>
        private void CheckAndOpenFile(string fileNamePath)
        {
            // Check if there are PCG windows opened with the same file name.
            if (IsFileAlreadyOpened(fileNamePath))
            {
                // TODO: bring the opened file to the top (no need for the message box)
                // ShowMessageBox(
                //     string.Format(Strings.OpenedDuplicateWarning, fileNamePath),
                //     Strings.PcgTools, Utils.EMessageBoxButton.Ok, Utils.EMessageBoxImage.Warning,
                //     Utils.EMessageBoxResult.Ok);
                return;
            }

            // Open/show file.
            ReadAndShowFile(fileNamePath, true);
        }

        private bool IsFileAlreadyOpened(string fileNamePath)
        {
            // TODO: Query collection of opened PCG files (SNG files) and return whether the file is already open
            return false;
        }

        /// <summary>
        ///     Reads and shows the requested file.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="checkAutoLoadMasterFileSetting">True for checking settings for autoloading the master file</param>
        private void ReadAndShowFile(string fileName, bool checkAutoLoadMasterFileSetting)
        {
#if !DEBUG
            try
#endif
            {
                LoadFileAndMasterFile(fileName, checkAutoLoadMasterFileSetting);
            }
#if !DEBUG
            catch (IOException exception)
            {
                // TODO: Write log and display a friendly message
                ShowMessageBox(String.Format(Strings.FileOpenException, fileName, exception.Message, exception.StackTrace),
                                Strings.PcgTools, WindowUtils.EMessageBoxButton.Ok, WindowUtils.EMessageBoxImage.Error,
                                WindowUtils.EMessageBoxResult.Ok);
            }
            catch (ApplicationException exception)
            {
                // TODO: Write log and display a friendly message
                ShowMessageBox(String.Format(Strings.FileOpenException, fileName, exception.Message, exception.StackTrace),
                                Strings.PcgTools, WindowUtils.EMessageBoxButton.Ok, WindowUtils.EMessageBoxImage.Error,
                                WindowUtils.EMessageBoxResult.Ok);
            }
#endif
        }

        private void LoadFileAndMasterFile(string fileName, bool checkAutoLoadMasterFileSetting)
        {
            // Load file.
            var korgFileReader = new KorgFileReader();
            var memory = korgFileReader.Read(fileName); // Model type/file type only used when error
            if (memory == null)
            {
                return;
            }

            _model.SelectedMemory = memory;

            if (memory is IPcgMemory)
            {
                var model = new PcgViewModel(new PcgClipBoard()) { SelectedMemory = memory };
                var pcgWindow = new PcgWindow(model);
                pcgWindow.Show();
            }

            // Load master file if requested.
            // LoadMasterFileIfRequested(checkAutoLoadMasterFileSetting, fileName);

            // Create child window.
            // MdiChild mdiChild;
            // if (memory is IPcgMemory)
            // {
            //     var width = Settings.Default.UI_PcgWindowWidth == 0 ? 700 : Settings.Default.UI_PcgWindowWidth;
            //     var height = Settings.Default.UI_PcgWindowHeight == 0 ? 500 : Settings.Default.UI_PcgWindowHeight;
            //     mdiChild = _mainViewModel.CreateMdiChildWindow(fileName, MainViewModel.ChildWindowType.Pcg, memory,
            //         width, height);
            //     ((PcgWindow)(mdiChild.Content)).ViewModel.SelectedMemory = memory;
            //     _mainViewModel.CurrentChildViewModel = ((PcgWindow)(mdiChild.Content)).ViewModel;
            //     ((IPcgMemory)memory).SelectFirstBanks();
            // }
            // else if (memory is ISongMemory)
            // {
            //     var width = Settings.Default.UI_SongWindowWidth == 0 ? 700 : Settings.Default.UI_SongWindowWidth;
            //     var height = Settings.Default.UI_SongWindowHeight == 0 ? 500 : Settings.Default.UI_SongWindowHeight;
            //     mdiChild = _mainViewModel.CreateMdiChildWindow(fileName, MainViewModel.ChildWindowType.Song, memory,
            //         width, height);
            //     _mainViewModel.CurrentChildViewModel = ((SongWindow)(mdiChild.Content)).ViewModel;
            //     ((SongWindow)(mdiChild.Content)).ViewModel.SelectedMemory = memory;
            // }
            // else
            // {
            //     throw new ApplicationException("Unknown memory type");
            // }
        }

        private bool NotImplementedCanExecute()
        {
            //TODO: Every use of this method needs to be properly implemented
            return false;
        }

        private void NotImplementedAction()
        {
            // TODO: Every usage of this method needs to be implemented
        }

        /// <summary>
        ///     Finds a view from a given ViewModel
        /// </summary>
        /// <param name="vm">The ViewModel representing a View</param>
        /// <returns>The View that matches the ViewModel. Null is no match found</returns>
        public static Window ResolveViewFromViewModel<T>(T vm) where T : ViewModelBase
        {
            var qualifiedName = vm.GetType().AssemblyQualifiedName;
            var name = qualifiedName!.Replace("ViewModels", "Views").Replace("ViewModel", "");
            var type = Type.GetType(name);
            return type != null ? (Window)Activator.CreateInstance(type)! : null;
        }
    }
}