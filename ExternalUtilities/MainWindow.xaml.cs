#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System.Windows;

#endregion

namespace ExternalUtilities
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //var window = new NumberOfCodeLinesWindow();
            //window.ShowDialog();
        }

        private void ButtonShowLanguageCrossReferenceList_Click(object sender, RoutedEventArgs e)
        {
            var window = new LanguageCrossReferenceWindow();
            window.ShowDialog();
        }

        private void ButtonShowNumberOfCodeLines_Click(object sender, RoutedEventArgs e)
        {
            var window = new NumberOfCodeLinesWindow();
            window.ShowDialog();
        }
    }
}