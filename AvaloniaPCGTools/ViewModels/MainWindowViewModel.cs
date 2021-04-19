using System;
using System.Windows.Input;
using ReactiveUI;

namespace PCGTools_Avalonia.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";

        public ICommand ClickedCommand => ReactiveCommand.Create(MyAction);

        private static void MyAction()
        {
            Console.WriteLine("MyAction");
        }
    }
}