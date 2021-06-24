using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Avalonia.Controls;
using Avalonia.VisualTree;
using Domain.Interfaces;
using Domain.Themes;
using Domain.Windows;
using PCGTools_Avalonia.Views;
using ReactiveUI;

namespace PCGTools_Avalonia.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly IServiceProvider? _serviceProvider;
        private readonly ModelMainWindow _model;

        public MainWindowViewModel(IServiceProvider serviceProvider): this(new ModelMainWindow())
        {
            _serviceProvider = serviceProvider;
        }

        public MainWindowViewModel(ModelMainWindow model)
        {
            _model = model;
        }

        public IActiveChildViewModel ActiveChildViewModel { get; set; } = new DefaultChildViewModel();

        public ICommand OpenFileCommand => ReactiveCommand.Create(OpenFilesAction, CanExecuteOpenFiles);
        public ICommand SaveFileCommand => ReactiveCommand.Create(SaveFileAction, CanExecuteSaveFile);
        public ICommand SaveFileAsCommand => ReactiveCommand.Create(SaveFileAsAction, CanExecuteSaveFileAs);
        public ICommand CloseFileCommand => ReactiveCommand.Create(SaveFileAsAction, CanExecuteSaveFileAs);
        public ICommand ExitCommand => ReactiveCommand.Create(SaveFileAsAction, CanExecuteSaveFileAs);
        public ICommand RevertToSavedFileCommand => ReactiveCommand.Create(SaveFileAsAction, CanExecuteSaveFileAs);
        public ICommand ShowSingleLinedSetListSlotDescriptionsCommand => ReactiveCommand.Create(SaveFileAsAction, CanExecuteSaveFileAs);
        public ICommand ShowSpecialEventCommand => ReactiveCommand.Create(SaveFileAsAction, CanExecuteSaveFileAs);
        public ICommand ShowMasterFilesCommand => ReactiveCommand.Create(SaveFileAsAction, CanExecuteSaveFileAs);
        public ICommand ShowSettingsCommand => ReactiveCommand.Create(SaveFileAsAction, CanExecuteSaveFileAs);
        public ICommand GotoNextWindowCommand => ReactiveCommand.Create(SaveFileAsAction, CanExecuteSaveFileAs);
        public ICommand GotoPreviousWindowCommand => ReactiveCommand.Create(SaveFileAsAction, CanExecuteSaveFileAs);
        public ICommand ShowAboutCommand => ReactiveCommand.Create(SaveFileAsAction, CanExecuteSaveFileAs);
        public ICommand ShowHomePageCommand => ReactiveCommand.Create(SaveFileAsAction, CanExecuteSaveFileAs);
        public ICommand ShowManualCommand => ReactiveCommand.Create(SaveFileAsAction, CanExecuteSaveFileAs);
        public ICommand ShowExternalLinksKorgRelatedCommand => ReactiveCommand.Create(SaveFileAsAction, CanExecuteSaveFileAs);
        public ICommand ShowExternalLinksContributorsCommand => ReactiveCommand.Create(SaveFileAsAction, CanExecuteSaveFileAs);
        public ICommand ShowExternalLinksVideoCreatorsCommand => ReactiveCommand.Create(SaveFileAsAction, CanExecuteSaveFileAs);
        public ICommand ShowExternalLinksDonatorsCommand => ReactiveCommand.Create(SaveFileAsAction, CanExecuteSaveFileAs);
        public ICommand ShowExternalLinksTranslatorsCommand => ReactiveCommand.Create(SaveFileAsAction, CanExecuteSaveFileAs);
        public ICommand ShowExternalLinksThirdPartiesCommand => ReactiveCommand.Create(SaveFileAsAction, CanExecuteSaveFileAs);
        public ICommand ShowExternalLinksOasysVoucherCodeSponsorsCommand => ReactiveCommand.Create(SaveFileAsAction, CanExecuteSaveFileAs);
        public ICommand ShowExternalLinksPersonalCommand => ReactiveCommand.Create(SaveFileAsAction, CanExecuteSaveFileAs);

        public bool IsShowSingleLinedSetListSlotDescriptions { get; set; }
        public Theme SelectedTheme { get; set; }

        private IObservable<bool>? CanExecuteOpenFiles => null;
        private async Task OpenFilesAction()
        {
            var openFile = new OpenFileDialog();

            openFile.AllowMultiple = false;
            openFile.Filters.Add(new FileDialogFilter() {Name = "PCG", Extensions = {"pcg"}});

            var parent = ResolveViewFromViewModel(this);
            var thisWindow = (Window) parent.GetVisualRoot();

            var files = await openFile.ShowAsync(thisWindow);
            if (files == null || files.Length == 0) return;

            var pcgWindow = new PcgDetails();
        }

        private IObservable<bool>? CanExecuteSaveFile => null;
        private void SaveFileAction() => _model.SaveFile();

        private IObservable<bool>? CanExecuteSaveFileAs => null;
        private void SaveFileAsAction() => _model.SaveFileAs();

        /// <summary>
        /// Finds a view from a given ViewModel
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