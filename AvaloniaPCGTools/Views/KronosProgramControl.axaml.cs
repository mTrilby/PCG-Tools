using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace PCGTools_Avalonia.Views
{
    public partial class KronosProgramControl : UserControl
    {
        public KronosProgramControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
