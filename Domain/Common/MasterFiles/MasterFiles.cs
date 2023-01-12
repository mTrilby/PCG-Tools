#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using Common.Utils;
using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Mvvm;
using PcgTools.ViewModels;

#endregion

namespace PcgTools.MasterFiles
{
    /// <summary>
    /// </summary>
    public class MasterFiles : ObservableCollectionEx<MasterFile>
    {
        /// <summary>
        /// </summary>
        public enum AutoLoadMasterFiles
        {
            Always,
            Ask,
            Never
        }

        /// <summary>
        /// </summary>
        [NotNull] private static readonly MasterFiles AllInstances = new();

        /// <summary>
        /// </summary>
        private MasterFiles()
        {
        }

        /// <summary>
        /// </summary>
        public static MasterFiles Instances => AllInstances;

        /// <summary>
        /// </summary>
        public IMainViewModel MainViewModel { get; private set; }

        /// <summary>
        /// </summary>
        public IChildWindow MasterFilesWindow { private get; set; }

        /// <summary>
        /// </summary>
        /// <param name="mainViewModel"></param>
        public void Set(IMainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
            MasterFilesWindow = MasterFilesWindow;

            Add(new MasterFile(Models.Find(Models.EOsVersion.EOsVersionKronos3x),
                SettingsDefault.MasterFile_KronosOS3x));
            Add(new MasterFile(Models.Find(Models.EOsVersion.EOsVersionKronos2x),
                SettingsDefault.MasterFile_KronosOS2x));
            Add(new MasterFile(Models.Find(Models.EOsVersion.EOsVersionKronos15_16),
                SettingsDefault.MasterFile_KronosOS15_16));
            Add(new MasterFile(Models.Find(Models.EOsVersion.EOsVersionKronos10_11),
                SettingsDefault.MasterFile_KronosOS10_11));
            Add(new MasterFile(Models.Find(Models.EOsVersion.EOsVersionOasys), SettingsDefault.MasterFile_Oasys));
            Add(new MasterFile(Models.Find(Models.EOsVersion.EOsVersionKrome), SettingsDefault.MasterFile_Krome));
            Add(new MasterFile(Models.Find(Models.EOsVersion.EOsVersionKromeEx), SettingsDefault.MasterFile_KromeEx));
            Add(new MasterFile(Models.Find(Models.EOsVersion.EOsVersionKross), SettingsDefault.MasterFile_Kross));
            Add(new MasterFile(Models.Find(Models.EOsVersion.EOsVersionKross2), SettingsDefault.MasterFile_Kross2));
            Add(new MasterFile(Models.Find(Models.EOsVersion.EOsVersionM3_1X), SettingsDefault.MasterFile_M3_OS1x));
            Add(new MasterFile(Models.Find(Models.EOsVersion.EOsVersionM3_20), SettingsDefault.MasterFile_M3_OS20));
            Add(new MasterFile(Models.Find(Models.EOsVersion.EOsVersionM50), SettingsDefault.MasterFile_M50));
            Add(new MasterFile(Models.Find(Models.EOsVersion.EOsVersionMicroStation),
                SettingsDefault.MasterFile_MicroStation));
            Add(new MasterFile(Models.Find(Models.EOsVersion.EOsVersionTritonExtreme),
                SettingsDefault.MasterFile_TritonExtreme));
            Add(new MasterFile(Models.Find(Models.EOsVersion.EOsVersionTritonTrClassicStudioRack),
                SettingsDefault.MasterFile_TritonTrClassicStudioRack));
            Add(new MasterFile(Models.Find(Models.EOsVersion.EOsVersionTritonLe), SettingsDefault.MasterFile_TritonLe));
            Add(new MasterFile(Models.Find(Models.EOsVersion.EOsVersionTritonKarma),
                SettingsDefault.MasterFile_TritonKarma));
            Add(new MasterFile(Models.Find(Models.EOsVersion.EOsVersionTrinityV2),
                SettingsDefault.MasterFile_TrinityV2));
            Add(new MasterFile(Models.Find(Models.EOsVersion.EOsVersionTrinityV3),
                SettingsDefault.MasterFile_TrinityV3));

            MainViewModel.PropertyChanged += OnMainViewModelPropertyChanged;
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnMainViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ChildWindows" || e.PropertyName == "CurrentChildViewModel")
            {
                foreach (var child in MainViewModel.ChildWindows)
                {
                    if (child.ViewModel is IPcgViewModel)
                    {
                        child.ViewModel.PropertyChanged += OnPcgViewModelPropertyChanged;
                    }
                }

                Instances.UpdateStates();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void OnPcgViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "SelectedMemory")
            {
                var memory = ((IPcgViewModel)sender).SelectedPcgMemory;
                if (memory != null)
                {
                    memory.PropertyChanged += OnSelectedPcgMemoryPropertyChanged;
                }

                Instances.UpdateStates();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void OnSelectedPcgMemoryPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "FileName")
            {
                Instances.UpdateStates();
            }
        }

        /// <summary>
        /// </summary>
        public void UpdateStates()
        {
            foreach (var masterFile in this)
            {
                masterFile.UpdateState();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="model"></param>
        /// <param name="fileName"></param>
        public void SetPcgFileAsMasterFile(IModel model, string fileName)
        {
            var masterFile = this.FirstOrDefault(file => file.Model == model);
            Debug.Assert(masterFile != null);
            masterFile.SetModel(model, fileName);
        }

        /// <summary>
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public IPcgMemory FindMasterPcg(IModel model)
        {
            var viewModel = (from masterFile in this
                where masterFile.Model == model && masterFile.FileState == MasterFile.EFileState.Loaded
                select MainViewModel.FindPcgViewModelWithName(masterFile.FileName)).FirstOrDefault();

            if (viewModel != null && viewModel.SelectedPcgMemory != null)
            {
                return viewModel.SelectedPcgMemory;
            }

            return null;
        }

        /// <summary>
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public MasterFile FindMasterFile(IModel model)
        {
            return (from masterFile in this
                where masterFile.Model == model
                select masterFile).FirstOrDefault();
        }
    }
}