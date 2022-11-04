﻿#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Domain.Common;
using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.PatchCombis;
using PcgTools.Edit;
using PcgTools.Properties;
using PcgTools.ViewModels;
using WPF.MDI;

namespace PcgTools
{
    /// <summary>
    ///     Interaction logic for CombiWindow.xaml
    /// </summary>
    public partial class CombiWindow : IChildWindow
    {
        /// <summary>
        /// </summary>
        /// <param name="pcgViewModel"></param>
        /// <param name="combi"></param>
        public CombiWindow(IPcgViewModel pcgViewModel, ICombi combi)
        {
            InitializeComponent();
            ViewModel = new CombiViewModel(pcgViewModel, combi)
            {
                ShowEditDialog = () =>
                {
                    var window = new WindowEditSingleCombi(CombiViewModel.Combi);
                    var result = window.ShowDialog();
                    return result.HasValue && result.Value;
                },

                UpdateUiContent = () =>
                {
                    listViewTimbres.Items.Refresh();
                    listViewTimbres.UpdateLayout();
                },

                CloseWindow = CloseWindow
            };

            DataContext = ViewModel;
        }


        /// <summary>
        /// </summary>
        public CombiWindow()
        {
        }


        /// <summary>
        /// </summary>
        public ICombiViewModel CombiViewModel => (ICombiViewModel)ViewModel;


        /// <summary>
        /// </summary>
        public MdiChild MdiChild { private get; set; }

        /// <summary>
        /// </summary>
        public IViewModel ViewModel { get; }


        /// <summary>
        /// </summary>
        public IMemory Memory => ViewModel.SelectedMemory;


        /// <summary>
        /// </summary>
        /// <param name="property"></param>
        public void ActOnSettingsChanged(string property)
        {
            // No action needed.
        }


        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            listViewTimbres.ItemsSource = CombiViewModel.Combi.Timbres.TimbresCollection;
            var view = CollectionViewSource.GetDefaultView(listViewTimbres.ItemsSource);
            view.Filter = bank => true;
        }


        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListViewTimbresSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                listViewTimbres.ScrollIntoView(e.AddedItems[0]);
                CombiViewModel.UpdateUiContent();
            }
        }


        // IChildWindow

        /// <summary>
        /// </summary>
        private void CloseWindow()
        {
            MdiChild.Close();

            Settings.Default.UI_CombiWindowWidth = (int)MdiChild.Width;
            Settings.Default.UI_CombiWindowHeight = (int)MdiChild.Height;
            Settings.Default.Save();
        }
    }
}