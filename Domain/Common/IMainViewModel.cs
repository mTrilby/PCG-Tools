// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using PcgTools.Common.Utils;
using PcgTools.Model.Common.Synth.MemoryAndFactory;

namespace PcgTools.ViewModels
{
    /// <summary>
    /// 
    /// </summary>
    public interface IMainViewModel
    {
        /// <summary>
        ///
        /// </summary>
        IViewModel CurrentChildViewModel { set; }


        /// <summary>
        /// 
        /// </summary>
        ObservableCollection<IChildWindow> ChildWindows { get; }

        event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 
        /// </summary>
        IMemory SelectedMemory { get; set; }


        /// <summary>
        /// 
        /// </summary>
        Func<string, string, WindowUtil.EMessageBoxButton, WindowUtil.EMessageBoxImage, WindowUtil.EMessageBoxResult,
            WindowUtil.EMessageBoxResult> ShowMessageBox { get; }


        /// <summary>
        /// Checks if there is already a file open with the file name, if so, show dialog. Always open file afterwards.
        /// </summary>
        /// <param name="fileNameToOpen"></param>
        void CheckAndOpenFile(string fileNameToOpen);


        /// <summary>
        ///  Closes all PCG files with specified name.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>True if all files with specified name close (can be cancelled due to dirty unsaved file).</returns>
        bool ClosePcgFile(string fileName);


        /// <summary>
        /// Timer.
        /// </summary>
        void OnTimerTick();

        IPcgViewModel FindPcgViewModelWithName(string fileName);

        /// <summary>
        /// 
        /// </summary>
        ClipBoard.PcgClipBoard PcgClipBoard { get; }
    }
}

