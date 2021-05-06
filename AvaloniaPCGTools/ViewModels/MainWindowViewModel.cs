using System;
using System.Windows.Input;
using Domain.Interfaces;
using Domain.Themes;
using Domain.Windows;
using ReactiveUI;

namespace PCGTools_Avalonia.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly ModelMainWindow _model;

        public MainWindowViewModel(): this(new ModelMainWindow())
        {
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
        private void OpenFilesAction() => _model.OpenFiles();

        private IObservable<bool>? CanExecuteSaveFile => null;
        private void SaveFileAction() => _model.SaveFile();

        private IObservable<bool>? CanExecuteSaveFileAs => null;
        private void SaveFileAsAction() => _model.SaveFileAs();
    }
}