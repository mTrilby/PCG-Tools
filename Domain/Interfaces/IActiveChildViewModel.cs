using System.Windows.Input;

namespace Domain.Interfaces
{
    public interface IActiveChildViewModel : IViewModel
    {
        ICommand ExportToCubaseCommand { get; set; }
        ICommand EditSelectedItemCommand { get; set; }
        ICommand SetFavoriteCommand { get; set; }
        ICommand UnsetFavoriteCommand { get; set; }
        ICommand ClearCommand { get; set; }
        ICommand ClearDuplicatesCommand { get; set; }
        ICommand CompactCommand { get; set; }
        ICommand SortCommand { get; set; }
        ICommand CutCommand { get; set; }
        ICommand ExitCopyPasteModeCommand { get; set; }
        ICommand CopyCommand { get; set; }
        ICommand PasteCommand { get; set; }
        ICommand RecallCommand { get; set; }
        ICommand MoveUpCommand { get; set; }
        ICommand MoveDownCommand { get; set; }
        ICommand ChangeVolumeCommand { get; set; }
        ICommand InitAsMpeCombiCommand { get; set; }
        ICommand AssignCommand { get; set; }
        ICommand AutoFillInSetListSlotNamesCommand { get; set; }
        ICommand CapitalizeNameCommand { get; set; }
        ICommand TitleCaseNameCommand { get; set; }
        ICommand DecapitalizeNameCommand { get; set; }
        ICommand ShowTimbresCommand { get; set; }
        ICommand ExportToHexCommand { get; set; }
        ICommand SetPcgFileAsMasterFileCommand { get; set; }
        ICommand RunListGeneratorCommand { get; set; }
        ICommand RunProgramReferencesChangerCommand { get; set; }
        ICommand DoubleToSingleKeyboardCommand { get; set; }
        ICommand AssignClearProgramCommand { get; set; }
    }
}