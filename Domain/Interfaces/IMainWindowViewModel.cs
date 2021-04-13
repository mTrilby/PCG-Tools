using System.Collections.ObjectModel;
using System.ComponentModel;
using Common.Utils;
using Common.Windows;

namespace Domain.Interfaces
{
    public interface IMainViewModel : INotifyPropertyChanged
    {
        ObservableCollection<IChildWindow> ChildWindows { get; }
        IPcgViewModel FindPcgViewModelWithName(string fileName);

        void CheckAndOpenFile(string fileNameToOpen);
        bool ClosePcgFile(string fileName);
    }
}