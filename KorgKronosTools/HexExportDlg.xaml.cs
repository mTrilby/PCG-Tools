#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System.Windows;

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