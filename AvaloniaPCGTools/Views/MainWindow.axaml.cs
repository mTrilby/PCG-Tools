using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace PCGTools_Avalonia.Views
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            Closing += (s, e) =>
            {
                //TODO: Prevent this window from closing if there are open PCGWindows
                e.Cancel = true;
            };
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void SelectUiLanguage(object? sender, RoutedEventArgs e)
        {

        }
    }
}
