using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace PCGTools_Avalonia.Views
{
    public partial class KronosProgramBankControl : UserControl
    {
        public KronosProgramBankControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
