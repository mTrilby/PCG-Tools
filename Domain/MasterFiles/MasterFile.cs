using System;
using Common.Mvvm;
using Common.Utils;
using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.PcgToolsResources;

namespace Domain.MasterFiles
{
    /// <summary>
    ///
    /// </summary>
    public class MasterFile : ObservableObject, IMasterFile
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="model"></param>
        /// <param name="fileName"></param>
        public MasterFile(IModel model, string fileName)
        {
            Model = model;
            FileName = fileName;
        }


        /// <summary>
        ///
        /// </summary>
        string _fileName;


        /// <summary>
        /// Used for UI control binding for selections.
        /// </summary>
        bool _isSelected;


        /// <summary>
        ///
        /// </summary>
        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                if (_isSelected != value)
                {
                    _isSelected = value;
                    RaisePropertyChanged("IsSelected");
                }
            }
        }


        /// <summary>
        ///
        /// </summary>
        public IModel Model { get; private set; }


        /// <summary>
        ///
        /// </summary>
        [UsedImplicitly]
        public string FileName
        {
            get { return _fileName; }
            set
            {
                if (_fileName != value)
                {
                    _fileName = value;
                    UpdateState();
                    OnPropertyChanged("FileName");
                }
            }
        }


        /// <summary>
        /// Sets a master file with file name to the model specified. Use an empty string to remove.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="fileName"></param>
        public void SetModel(IModel model, string fileName)
        {
            Model = model;
            FileName = fileName;

            switch (model.OsVersion)
            {
                case ModelsEOsVersion.EOsVersionKronos3x:
                    Settings.Default.MasterFile_KronosOS3x = fileName;
                    break;

                case ModelsEOsVersion.EOsVersionKronos2x:
                    Settings.Default.MasterFile_KronosOS2x = fileName;
                    break;

                case ModelsEOsVersion.EOsVersionKronos15_16:
                    Settings.Default.MasterFile_KronosOS15_16 = fileName;
                    break;

                case ModelsEOsVersion.EOsVersionKronos10_11:
                    Settings.Default.MasterFile_KronosOS10_11 = fileName;
                    break;

                case ModelsEOsVersion.EOsVersionOasys:
                    Settings.Default.MasterFile_Oasys = fileName;
                    break;

                case ModelsEOsVersion.EOsVersionKrome:
                    Settings.Default.MasterFile_Krome = fileName;
                    break;

                case ModelsEOsVersion.EOsVersionKromeEx:
                    Settings.Default.MasterFile_Krome = fileName;
                    break;

                case ModelsEOsVersion.EOsVersionKross:
                    Settings.Default.MasterFile_Kross = fileName;
                    break;

                case ModelsEOsVersion.EOsVersionKross2:
                    Settings.Default.MasterFile_Kross2 = fileName;
                    break;

                case ModelsEOsVersion.EOsVersionM3_20:
                    Settings.Default.MasterFile_M3_OS20 = fileName;
                    break;

                case ModelsEOsVersion.EOsVersionM3_1X:
                    Settings.Default.MasterFile_M3_OS1x = fileName;
                    break;

                case ModelsEOsVersion.EOsVersionM50:
                    Settings.Default.MasterFile_M50 = fileName;
                    break;

                case ModelsEOsVersion.EOsVersionMicroStation:
                    Settings.Default.MasterFile_MicroStation = fileName;
                    break;

                case ModelsEOsVersion.EOsVersionTritonExtreme:
                    Settings.Default.MasterFile_TritonExtreme = fileName;
                    break;

                case ModelsEOsVersion.EOsVersionTritonTrClassicStudioRack:
                    Settings.Default.MasterFile_TritonTrClassicStudioRack = fileName;
                    break;

                case ModelsEOsVersion.EOsVersionTritonLe:
                    Settings.Default.MasterFile_TritonLe = fileName;
                    break;

                case ModelsEOsVersion.EOsVersionTritonKarma:
                    Settings.Default.MasterFile_TritonKarma = fileName;
                    break;

                case ModelsEOsVersion.EOsVersionTrinityV2:
                    Settings.Default.MasterFile_TrinityV2 = fileName;
                    break;

                case ModelsEOsVersion.EOsVersionTrinityV3:
                    Settings.Default.MasterFile_TrinityV3 = fileName;
                    break;

                default:
                    throw new ApplicationException("Illegal work station model");
            }

            UpdateState();
        }


        /// <summary>
        ///
        /// </summary>
        public void UpdateState()
        {
            if (FileName == string.Empty)
            {
                FileState = MasterFileEFileState.Unassigned;
            }
            else
            {
                var masterFiles = MasterFiles.Instances;
                if (masterFiles != null)
                {
                    var pcgWindow = masterFiles.MainViewModel.FindPcgViewModelWithName(FileName);
                    if (pcgWindow == null)
                    {
                        FileState = System.IO.File.Exists(FileName) ? MasterFileEFileState.Unloaded : MasterFileEFileState.NotPresent;
                    }
                    else
                    {
                        FileState = MasterFileEFileState.Loaded;
                    }
                }
            }
        }


        /// <summary>
        ///
        /// </summary>
        MasterFileEFileState _fileState;
        [UsedImplicitly]
        public MasterFileEFileState FileState
        {
            get { return _fileState; }
            private set
            {
                if (_fileState != value)
                {
                    _fileState = value;
                    FileStateAsString = FileState2String();
                    //Console.WriteLine("propertychanged"); //TMP
                    OnPropertyChanged("FileState");
                }
            }
        }


        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        string FileState2String()
        {
            string str;
            switch (FileState)
            {
                case MasterFileEFileState.Unassigned:
                    str = Strings.Unassigned_mastd;
                    break;

                case MasterFileEFileState.NotPresent:
                    str = Strings.NotPresent_mastd;
                    break;

                case MasterFileEFileState.Unloaded:
                    str = Strings.Unloaded_mastd;
                    break;

                case MasterFileEFileState.Loaded:
                    str = Strings.Loaded_mastd;
                    break;

                default:
                    throw new ApplicationException("Illegal file state enum");
            }
            return str;
        }


        /// <summary>
        ///
        /// </summary>
        string _fileStateAsString;


        /// <summary>
        ///
        /// </summary>
        [UsedImplicitly]
        public string FileStateAsString
        {
            get { return _fileStateAsString; }
            set { if (_fileStateAsString != value) { _fileStateAsString = value; OnPropertyChanged("FileStateAsString"); } }
        }


        /// <summary>
        ///
        /// </summary>
        [UsedImplicitly]
        public string WorkStationModel
        {
            get { return Model.ModelAsString; }
            set
            {
                // Needed for WPF.
                throw new ApplicationException("Not implemented");
            }
        }


        /// <summary>
        ///
        /// </summary>
        [UsedImplicitly]
        public string OsVersion
        {
            get { return Model.OsVersionString; }
            set
            {
                // Needed for WPF.
                throw new NotSupportedException("Not implemented");
            }
        }
    }
}
