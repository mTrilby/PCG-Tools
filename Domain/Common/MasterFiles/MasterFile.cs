﻿using System;
using Common.PcgToolsResources;
using Common.Utils;

using PcgTools.Model.Common.Synth.MemoryAndFactory;
using PcgTools.Mvvm;
using PcgTools.PcgToolsResources;

namespace PcgTools.MasterFiles
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
                case Models.EOsVersion.EOsVersionKronos3x:
                    SettingsDefault.SetMasterFile_KronosOS3x(fileName);
                    break;

                case Models.EOsVersion.EOsVersionKronos2x:
                    SettingsDefault.SetMasterFile_KronosOS2x(fileName);
                    break;

                case Models.EOsVersion.EOsVersionKronos15_16:
                    SettingsDefault.SetMasterFile_KronosOS15_16(fileName);
                    break;

                case Models.EOsVersion.EOsVersionKronos10_11:
                    SettingsDefault.SetMasterFile_KronosOS10_11(fileName);
                    break;

                case Models.EOsVersion.EOsVersionOasys:
                    SettingsDefault.SetMasterFile_Oasys(fileName);
                    break;

                case Models.EOsVersion.EOsVersionKrome:
                    SettingsDefault.SetMasterFile_Krome(fileName);
                    break;

                case Models.EOsVersion.EOsVersionKromeEx:
                    SettingsDefault.SetMasterFile_KromeEx(fileName);
                    break;

                case Models.EOsVersion.EOsVersionKross:
                    SettingsDefault.SetMasterFile_Kross(fileName);
                    break;

                case Models.EOsVersion.EOsVersionKross2:
                    SettingsDefault.SetMasterFile_Kross2(fileName);
                    break;

                case Models.EOsVersion.EOsVersionM3_20:
                    SettingsDefault.SetMasterFile_M3_OS20(fileName);
                    break;

                case Models.EOsVersion.EOsVersionM3_1X:
                    SettingsDefault.SetMasterFile_M3_OS1x(fileName);
                    break;

                case Models.EOsVersion.EOsVersionM50:
                    SettingsDefault.SetMasterFile_M50(fileName);
                    break;

                case Models.EOsVersion.EOsVersionMicroStation:
                    SettingsDefault.SetMasterFile_MicroStation(fileName);
                    break;

                case Models.EOsVersion.EOsVersionTritonExtreme:
                    SettingsDefault.SetMasterFile_TritonExtreme(fileName);
                    break;

                case Models.EOsVersion.EOsVersionTritonTrClassicStudioRack:
                    SettingsDefault.SetMasterFile_TritonTrClassicStudioRack(fileName);
                    break;

                case Models.EOsVersion.EOsVersionTritonLe:
                    SettingsDefault.SetMasterFile_TritonLe(fileName);
                    break;

                case Models.EOsVersion.EOsVersionTritonKarma:
                    SettingsDefault.SetMasterFile_TritonKarma(fileName);
                    break;

                case Models.EOsVersion.EOsVersionTrinityV2:
                    SettingsDefault.SetMasterFile_TrinityV2(fileName);
                    break;

                case Models.EOsVersion.EOsVersionTrinityV3:
                    SettingsDefault.SetMasterFile_TrinityV3(fileName);
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
                FileState = EFileState.Unassigned;
            }
            else
            {
                var masterFiles = MasterFiles.Instances;
                if (masterFiles != null)
                {
                    var pcgWindow = masterFiles.MainViewModel.FindPcgViewModelWithName(FileName);
                    if (pcgWindow == null)
                    {
                        FileState = System.IO.File.Exists(FileName) ? EFileState.Unloaded : EFileState.NotPresent;
                    }
                    else
                    {
                        FileState = EFileState.Loaded;
                    }
                }
            }
        }


        /// <summary>
        ///
        /// </summary>
        [UsedImplicitly]
        public enum EFileState
        {
            Unassigned,
            NotPresent,
            Unloaded,
            Loaded
        }


        /// <summary>
        ///
        /// </summary>
        EFileState _fileState;
        [UsedImplicitly]
        public EFileState FileState
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
                case EFileState.Unassigned:
                    str = Strings.Unassigned_mastd;
                    break;

                case EFileState.NotPresent:
                    str = Strings.NotPresent_mastd;
                    break;

                case EFileState.Unloaded:
                    str = Strings.Unloaded_mastd;
                    break;

                case EFileState.Loaded:
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