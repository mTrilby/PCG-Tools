#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System.Windows;
using Common.MVVM;
using Domain.Common.Synth.Meta;
using PcgTools.Mvvm;
using PcgTools.ViewModels;

#endregion

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