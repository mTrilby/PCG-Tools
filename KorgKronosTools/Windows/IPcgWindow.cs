#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common;
using PcgTools.ViewModels;

#endregion

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