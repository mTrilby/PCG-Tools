using System;
using System.Windows.Input;
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

        public ICommand OpenFilesCommand => ReactiveCommand.Create(OpenFilesAction, CanExecuteOpenFiles);
        public ICommand SaveFileCommand => ReactiveCommand.Create(SaveFileAction, CanExecuteSaveFile);
        public ICommand SaveFileAsCommand => ReactiveCommand.Create(SaveFileAsAction, CanExecuteSaveFileAs);

        private IObservable<bool>? CanExecuteOpenFiles => null;
        private void OpenFilesAction() => _model.OpenFiles();

        private IObservable<bool>? CanExecuteSaveFile => null;
        private void SaveFileAction() => _model.SaveFile();

        private IObservable<bool>? CanExecuteSaveFileAs => null;
        private void SaveFileAsAction() => _model.SaveFileAs();
    }
}