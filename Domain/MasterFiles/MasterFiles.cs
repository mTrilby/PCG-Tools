using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using Common.Mvvm;
using Common.Utils;
using Domain.Interfaces;
using Domain.Model.Common.Synth.MemoryAndFactory;

namespace Domain.MasterFiles
{
    /// <summary>
    ///
    /// </summary>
    public class MasterFiles : ObservableCollectionEx<MasterFile>, IMasterFiles
    {
        /// <summary>
        ///
        /// </summary>
        [NotNull] static readonly MasterFiles AllInstances = new MasterFiles();


        /// <summary>
        ///
        /// </summary>
        public static MasterFiles Instances => AllInstances;


        /// <summary>
        ///
        /// </summary>
        public IMainViewModel MainViewModel { get; private set; }


        /// <summary>
        ///
        /// </summary>
        // TODO: Needs to be moved to the VM layer
        //public MasterFilesWindow MasterFilesWindow { private get; set; }


        /// <summary>
        ///
        /// </summary>
        public enum AutoLoadMasterFiles
        {
            Always,
            Ask,
            Never
        }


        /// <summary>
        ///
        /// </summary>
        /// <param name="mainViewModel"></param>
        public void Set(IMainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
            //MasterFilesWindow = MasterFilesWindow;

            Add(new MasterFile(Models.Find(ModelsEOsVersion.EOsVersionKronos3x), Settings.Default.MasterFile_KronosOS3x));
            Add(new MasterFile(Models.Find(ModelsEOsVersion.EOsVersionKronos2x), Settings.Default.MasterFile_KronosOS2x));
            Add(new MasterFile(Models.Find(ModelsEOsVersion.EOsVersionKronos15_16), Settings.Default.MasterFile_KronosOS15_16));
            Add(new MasterFile(Models.Find(ModelsEOsVersion.EOsVersionKronos10_11), Settings.Default.MasterFile_KronosOS10_11));
            Add(new MasterFile(Models.Find(ModelsEOsVersion.EOsVersionOasys), Settings.Default.MasterFile_Oasys));
            Add(new MasterFile(Models.Find(ModelsEOsVersion.EOsVersionKrome), Settings.Default.MasterFile_Krome));
            Add(new MasterFile(Models.Find(ModelsEOsVersion.EOsVersionKromeEx), Settings.Default.MasterFile_KromeEx));
            Add(new MasterFile(Models.Find(ModelsEOsVersion.EOsVersionKross), Settings.Default.MasterFile_Kross));
            Add(new MasterFile(Models.Find(ModelsEOsVersion.EOsVersionKross2), Settings.Default.MasterFile_Kross2));
            Add(new MasterFile(Models.Find(ModelsEOsVersion.EOsVersionM3_1X), Settings.Default.MasterFile_M3_OS1x));
            Add(new MasterFile(Models.Find(ModelsEOsVersion.EOsVersionM3_20), Settings.Default.MasterFile_M3_OS20));
            Add(new MasterFile(Models.Find(ModelsEOsVersion.EOsVersionM50),  Settings.Default.MasterFile_M50));
            Add(new MasterFile(Models.Find(ModelsEOsVersion.EOsVersionMicroStation), Settings.Default.MasterFile_MicroStation));
            Add(new MasterFile(Models.Find(ModelsEOsVersion.EOsVersionTritonExtreme), Settings.Default.MasterFile_TritonExtreme));
            Add(new MasterFile(Models.Find(ModelsEOsVersion.EOsVersionTritonTrClassicStudioRack), Settings.Default.MasterFile_TritonTrClassicStudioRack));
            Add(new MasterFile(Models.Find(ModelsEOsVersion.EOsVersionTritonLe), Settings.Default.MasterFile_TritonLe));
            Add(new MasterFile(Models.Find(ModelsEOsVersion.EOsVersionTritonKarma), Settings.Default.MasterFile_TritonKarma));
            Add(new MasterFile(Models.Find(ModelsEOsVersion.EOsVersionTrinityV2), Settings.Default.MasterFile_TrinityV2));
            Add(new MasterFile(Models.Find(ModelsEOsVersion.EOsVersionTrinityV3), Settings.Default.MasterFile_TrinityV3));

            MainViewModel.PropertyChanged += OnMainViewModelPropertyChanged;
        }


        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnMainViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if ((e.PropertyName == "ChildWindows") || (e.PropertyName == "CurrentChildViewModel"))
            {
                foreach (var child in MainViewModel.ChildWindows)
                {
                    if ((child.ViewModel is IPcgViewModel))
                    {
                        child.ViewModel.PropertyChanged += OnPcgViewModelPropertyChanged;
                    }
                }

                Instances.UpdateStates();
            }
        }


        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void OnPcgViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
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
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void OnSelectedPcgMemoryPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "FileName")
            {
                Instances.UpdateStates();
            }
        }


        /// <summary>
        ///
        /// </summary>
        public void UpdateStates()
        {
            foreach (var masterFile in this)
            {
                masterFile.UpdateState();
            }
        }


        /// <summary>
        ///
        /// </summary>
        /// <param name="model"></param>
        /// <param name="fileName"></param>
        public void SetPcgFileAsMasterFile(IModel model, string fileName)
        {
            var masterFile = this.FirstOrDefault(file => (file.Model == model));
            Debug.Assert(masterFile != null);
            masterFile.SetModel(model, fileName);
        }


        /// <summary>
        ///
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public IPcgMemory FindMasterPcg(IModel model)
        {
            var viewModel = (from masterFile in this
                             where (masterFile.Model == model) && (masterFile.FileState == MasterFileEFileState.Loaded)
                             select MainViewModel.FindPcgViewModelWithName(masterFile.FileName)).FirstOrDefault();

            if ((viewModel != null) && (viewModel.SelectedPcgMemory != null))
            {
                return viewModel.SelectedPcgMemory;
            }

            return null;
        }


        /// <summary>
        ///
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public IMasterFile FindMasterFile(IModel model)
        {
            return (from masterFile in this
                    where (masterFile.Model == model)
                    select masterFile).FirstOrDefault();
        }
    }
}
