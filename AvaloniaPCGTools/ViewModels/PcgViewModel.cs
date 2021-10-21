using Common.Mvvm;
using Domain.ClipBoard;
using Domain.Model.Common.Synth.Meta;
using PcgTools.ViewModels.Commands.PcgCommands;
using PCGTools_Avalonia.ViewModels.Commands;

namespace PCGTools_Avalonia.ViewModels
{
    public class PcgViewModel : PcgBaseViewModel
    {
        public PcgViewModel(): this(new PcgClipBoard())
        {
        }
        
        /// <summary>
        ///
        /// </summary>
        /// <param name="pcgClipBoard"></param>
        public PcgViewModel(PcgClipBoard pcgClipBoard)
        {
            PcgClipBoard = pcgClipBoard;
            Banks = new ObservableCollectionEx<IBank>();
            Patches = new ObservableCollectionEx<IPatch>();
            _copyPasteCommands = new CopyPasteCommands();
            _clearCommands = new ClearCommands();
            _doubleToSingleKeyboardCommands = new DoubleToSingleKeyboardCommands();
        }
    }
}