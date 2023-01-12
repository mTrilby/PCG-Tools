﻿#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System.Windows;

#endregion

namespace PcgTools
{
    /// <summary>
    ///     Interaction logic for CommandLineInterfaceWindow.xaml
    /// </summary>
    public partial class CommandLineInterfaceWindow // : Window
    {
        /// <summary>
        /// </summary>
        private readonly string _diagnosticsText;

        /// <summary>
        /// </summary>
        /// <param name="diagnosticsText"></param>
        public CommandLineInterfaceWindow(string diagnosticsText)
        {
            _diagnosticsText = diagnosticsText;
            InitializeComponent();
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textBlock.Text = _diagnosticsText;
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCloseClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}