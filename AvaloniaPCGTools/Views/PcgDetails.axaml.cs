using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace PCGTools_Avalonia.Views
{
    public partial class PcgDetails : UserControl
    {
        public PcgDetails()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
