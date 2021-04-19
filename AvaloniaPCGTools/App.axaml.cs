using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using PCGTools_Avalonia.ViewModels;
using PCGTools_Avalonia.Views;

namespace PCGTools_Avalonia
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                async void AppAsyncLoadingStart()
                {
                    var splashViewModel = new SplashWindowViewModel();
                    var splash = new SplashWindow { DataContext = splashViewModel };
                    splash.Show();

                    desktop.MainWindow = await GetMainWindowAsync(splashViewModel);

                    desktop.MainWindow.Show();
                    desktop.MainWindow.Activate();

                    await Task.Delay(3000);

                    splash.Close();

                }

                AppAsyncLoadingStart();
            }

            base.OnFrameworkInitializationCompleted();
        }

        private static async Task<MainWindow> GetMainWindowAsync(SplashWindowViewModel splashViewModel)
        {
            // Initialize here
            return await Task.FromResult(new MainWindow() { DataContext = new MainWindowViewModel() });
        }
    }
}
