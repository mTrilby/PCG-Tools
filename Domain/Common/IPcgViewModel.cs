#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;
using PcgTools.Common.Utils;
using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Model.Common.Synth.Meta;
using PcgTools.Mvvm;

#endregion

namespace PcgTools.ViewModels
{
    /// <summary>
    /// </summary>
    public interface IPcgViewModel : IViewModel
    {
        /// <summary>
        /// </summary>
        string WindowTitle { get; set; }

        /// <summary>
        /// </summary>
        IPcgMemory SelectedPcgMemory { get; }

        /// <summary>
        /// </summary>
        ScopeSet SelectedScopeSet { get; set; }

        /// <summary>
        ///     Add needed, so cannot be an enumerable.
        /// </summary>
        // ReSharper disable once ReturnTypeCanBeEnumerable.Global
        ObservableCollectionEx<IBank> Banks { get; }

        /// <summary>
        /// </summary>
        ObservableCollectionEx<IPatch> Patches { set; get; }

        /// <summary>
        /// </summary>
        bool ProgramBanksSelected { get; }

        /// <summary>
        /// </summary>
        bool CombiBanksSelected { get; }

        /// <summary>
        /// </summary>
        bool SetListsSelected { get; }

        /// <summary>
        /// </summary>
        bool DrumKitBanksSelected { get; }

        /// <summary>
        /// </summary>
        bool DrumPatternBanksSelected { get; }

        /// <summary>
        /// </summary>
        bool WaveSequenceBanksSelected { get; }

        /// <summary>
        /// </summary>
        bool AllPatchesSelected { get; }

        /// <summary>
        /// </summary>
        Action UpdateTimbresWindows { get; }

        /// <summary>
        ///     Last selected program or combi, used for assigning to set list slots.
        ///     Needs to be stored even when switching to e.g. list views, drum kits etc.
        /// </summary>
        IPatch LastSelectedProgramOrCombi { get; set; }

        /// <summary>
        /// </summary>
        Func<string, string, WindowUtil.EMessageBoxButton, WindowUtil.EMessageBoxImage, WindowUtil.EMessageBoxResult,
            WindowUtil.EMessageBoxResult> ShowMessageBox { get; }

        /// <summary>
        ///     Number of selected patches displayed in PCG winwdow.
        /// </summary>
        int NumberOfSelectedPatches { get; set; }

        /// <summary>
        /// </summary>
        void UpdateWindowTitle();

        /// <summary>
        /// </summary>
        void EditSelectedItem();

        /// <summary>
        /// </summary>
        /// <param name="saveAs"></param>
        /// <param name="saveToFile"></param>
        /// <returns></returns>
        void SaveFile(bool saveAs, bool saveToFile);

        /// <summary>
        ///     From PCG window -> notification that banks changed.
        /// </summary>
        void BanksChanged();
    }
}