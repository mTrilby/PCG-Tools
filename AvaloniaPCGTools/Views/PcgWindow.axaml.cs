using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Domain.ClipBoard;
using PCGTools_Avalonia.ViewModels;

namespace PCGTools_Avalonia.Views
{
    public class PcgWindow : Window
    {
        public PcgWindow() : this (new PcgViewModel(new PcgClipBoard()))
        {
        }
        
        public PcgWindow(PcgViewModel model)
        {
            var fileName = model.SelectedMemory?.FileName;
            Title = string.IsNullOrEmpty(fileName) ? "Empty PCG" : System.IO.Path.GetFileNameWithoutExtension(fileName);
            DataContext = model;
            
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
