#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System.Windows;
using PatchDatabaseBackEnd;

#endregion

namespace PatchDbFrontEnd
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// </summary>
        public PatchDataList PatchList;

        /// <summary>
        /// </summary>
        public MainWindow()
        {
            PatchList = new PatchDataList();

            InitializeComponent();

            Read();
        }

        private void Read()
        {
            PatchDataTextBox.Text = CsvHelper.ReadAsCsv().ToString();
        }
    }
}