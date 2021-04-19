using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace PCGTools_Avalonia.Views
{
    public class SplashWindow : Window
    {
        public SplashWindow()
        {
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
