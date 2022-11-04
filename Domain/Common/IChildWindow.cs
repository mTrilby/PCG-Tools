#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.ViewModels;

namespace PcgTools
{
    /// <summary>
    /// </summary>
    public interface IChildWindow
    {
        /// <summary>
        /// </summary>
        IMemory Memory { get; }


        /// <summary>
        /// </summary>
        IViewModel ViewModel { get; }


        /// <summary>
        ///     When settings are changed, this is called.
        /// </summary>
        /// <param name="property"></param>
        void ActOnSettingsChanged(string property);
    }
}