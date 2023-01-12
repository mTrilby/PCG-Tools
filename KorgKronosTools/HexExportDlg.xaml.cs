#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System.Windows;

#endregion

namespace PcgTools
{
    /// <summary>
    ///     Interaction logic for HexExportDlg.xaml
    /// </summary>
    public partial class HexExportDlg : Window
    {
        public HexExportDlg(string text)
        {
            InitializeComponent();
            TextBlock.Text = text;
        }
    }
}