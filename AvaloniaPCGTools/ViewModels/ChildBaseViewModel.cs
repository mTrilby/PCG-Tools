using System.ComponentModel;
using System.Windows.Input;
using Domain.Interfaces;
using Domain.Model.Common.Synth.MemoryAndFactory;

namespace PCGTools_Avalonia.ViewModels
{
    public abstract class ChildBaseViewModel : IActiveChildViewModel
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public IMemory SelectedMemory { get; set; }
        public bool Close(bool exitMode)
        {
            throw new System.NotImplementedException();
        }

        public bool Revert()
        {
            throw new System.NotImplementedException();
        }

        public ICommand ExportToCubaseCommand { get; set; }
        public ICommand EditSelectedItemCommand { get; set; }
        public ICommand SetFavoriteCommand { get; set; }
        public ICommand UnsetFavoriteCommand { get; set; }
        public ICommand ClearCommand { get; set; }
        public ICommand ClearDuplicatesCommand { get; set; }
        public ICommand CompactCommand { get; set; }
        public ICommand SortCommand { get; set; }
        public ICommand CutCommand { get; set; }
        public ICommand ExitCopyPasteModeCommand { get; set; }
        public ICommand CopyCommand { get; set; }
        public ICommand PasteCommand { get; set; }
        public ICommand RecallCommand { get; set; }
        public ICommand MoveUpCommand { get; set; }
        public ICommand MoveDownCommand { get; set; }
        public ICommand ChangeVolumeCommand { get; set; }
        public ICommand InitAsMpeCombiCommand { get; set; }
        public ICommand AssignCommand { get; set; }
        public ICommand AutoFillInSetListSlotNamesCommand { get; set; }
        public ICommand CapitalizeNameCommand { get; set; }
        public ICommand TitleCaseNameCommand { get; set; }
        public ICommand DecapitalizeNameCommand { get; set; }
        public ICommand ShowTimbresCommand { get; set; }
        public ICommand ExportToHexCommand { get; set; }
        public ICommand SetPcgFileAsMasterFileCommand { get; set; }
        public ICommand RunListGeneratorCommand { get; set; }
        public ICommand RunProgramReferencesChangerCommand { get; set; }
        public ICommand DoubleToSingleKeyboardCommand { get; set; }
        public ICommand AssignClearProgramCommand { get; set; }
    }
}