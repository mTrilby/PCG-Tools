#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System.Windows;
using PcgTools.Model.Common.Synth.Meta;
using PcgTools.Mvvm;
using PcgTools.ViewModels;

namespace PcgTools.Edit
{
    /// <summary>
    ///     Interaction logic for WindowEditParameter.xaml
    /// </summary>
    public partial class WindowEditParameter : Window
    {
        /// <summary>
        ///     Constructor.
        /// </summary>
        public WindowEditParameter(ObservableCollectionEx<IPatch> patches)
        {
            InitializeComponent();
            ViewModel = new EditParameterViewModel(patches);
            DataContext = ViewModel;
        }

        /// <summary>
        /// </summary>
        public EditParameterViewModel ViewModel { get; }
    }
}