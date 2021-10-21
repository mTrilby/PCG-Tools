using System.Windows.Input;

namespace Domain.Interfaces
{
    public interface IActiveChildViewModel : IViewModel
    {
        ICommand ExportToCubaseCommand { get; }
        ICommand EditSelectedItemCommand { get; }
        ICommand SetFavoriteCommand { get; }
        ICommand UnsetFavoriteCommand { get; }
        ICommand ClearCommand { get; }
        ICommand ClearDuplicatesCommand { get; }
        ICommand CompactCommand { get; }
        ICommand SortCommand { get; }
        ICommand CutCommand { get; }
        ICommand ExitCopyPasteModeCommand { get; }
        ICommand CopyCommand { get; }
        ICommand PasteCommand { get; }
        ICommand RecallCommand { get; }
        ICommand MoveUpCommand { get; }
        ICommand MoveDownCommand { get; }
        ICommand ChangeVolumeCommand { get; }
        ICommand InitAsMpeCombiCommand { get; }
        ICommand AssignCommand { get; }
        ICommand AutoFillInSetListSlotNamesCommand { get; }
        ICommand CapitalizeNameCommand { get; }
        ICommand TitleCaseNameCommand { get; }
        ICommand DecapitalizeNameCommand { get; }
        ICommand ShowTimbresCommand { get; }
        ICommand ExportToHexCommand { get; }
        ICommand SetPcgFileAsMasterFileCommand { get; }
        ICommand RunListGeneratorCommand { get; }
        ICommand RunProgramReferencesChangerCommand { get; }
        ICommand DoubleToSingleKeyboardCommand { get; }
        ICommand AssignClearProgramCommand { get; }
    }
}