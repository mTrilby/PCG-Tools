// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using System.Windows;

namespace PcgTools
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static string[] Arguments { get; private set;  }

        void Application_Startup(object sender, StartupEventArgs e)
        {
            if (e.Args.Length > 0)
            {
                Arguments = e.Args;
            }
        }
    }
}
