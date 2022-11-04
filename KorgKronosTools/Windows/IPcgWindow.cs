#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using PcgTools.ViewModels;

namespace PcgTools.Windows
{
    /// <summary>
    /// </summary>
    public interface IPcgWindow : IWindow
    {
        /// <summary>
        /// </summary>
        IViewModel ViewModel { get; }
    }
}