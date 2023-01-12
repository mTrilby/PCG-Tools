#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Common.Utils;
using Domain.Common.ClipBoard;
using Domain.Common.Synth.MemoryAndFactory;

#endregion

namespace Domain.Common
{
    /// <summary>
    /// </summary>
    public interface IMainViewModel
    {
        /// <summary>
        /// </summary>
        IViewModel CurrentChildViewModel { set; }

        /// <summary>
        /// </summary>
        ObservableCollection<IChildWindow> ChildWindows { get; }

        /// <summary>
        /// </summary>
        IMemory SelectedMemory { get; set; }

        /// <summary>
        /// </summary>
        Func<string, string, WindowUtil.EMessageBoxButton, WindowUtil.EMessageBoxImage, WindowUtil.EMessageBoxResult,
            WindowUtil.EMessageBoxResult> ShowMessageBox { get; }

        /// <summary>
        /// </summary>
        PcgClipBoard PcgClipBoard { get; }

        event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        ///     Checks if there is already a file open with the file name, if so, show dialog. Always open file afterwards.
        /// </summary>
        /// <param name="fileNameToOpen"></param>
        void CheckAndOpenFile(string fileNameToOpen);

        /// <summary>
        ///     Closes all PCG files with specified name.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>True if all files with specified name close (can be cancelled due to dirty unsaved file).</returns>
        bool ClosePcgFile(string fileName);

        /// <summary>
        ///     Timer.
        /// </summary>
        void OnTimerTick();

        IPcgViewModel FindPcgViewModelWithName(string fileName);
    }
}