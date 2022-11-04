#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System;
using System.Collections.Generic;
using System.IO;
using Common.PcgToolsResources;
using Common.Utils;
using PcgTools.Model.Common.Synth.PatchInterfaces;
using PcgTools.Mvvm;

namespace PcgTools.Model.Common.Synth.MemoryAndFactory
{
    /// <summary>
    /// </summary>
    public abstract class Memory : ObservableObject, IMemory
    {
        /// <summary>
        /// </summary>
        public enum FileType
        {
            Pcg = 0x00, // Various
            Sng = 0x01, // Various
            Bnk, // MS2000
            Exl, // MS2000
            Lib, // MS2000
            MkxlAll, // MicroKorg
            MkxlPAll, // MicroKorg XL Plus
            MkxlPProg, // MicroKorg XL Plus
            MkP0, // MS2000
            Mid, // Midi format (with sysex)
            Raw, // RAW disk image (0 series)
            Tr, // TR file (Kross series)
            Syx // Sysex format
        }


        /// <summary>
        /// </summary>
        private bool _dirty;


        /// <summary>
        /// </summary>
        private string _fileName;


        /// <summary>
        ///     True if the complete file has been read (and chunks handled).
        /// </summary>
        [UsedImplicitly] private bool _readingFinished;


        /// <summary>
        /// </summary>
        public int ByteOffset => 0;


        /// <summary>
        ///     The original file name is to check if the file name has changed later to rename the file.
        /// </summary>
        public string OriginalFileName { get; set; }

        public bool ReadingFinished
        {
// ReSharper disable UnusedMember.Global
            get => _readingFinished;
            // ReSharper restore UnusedMember.Global
            set
            {
                if (_readingFinished != value)
                {
                    _readingFinished = value;
                    OnPropertyChanged("ReadingFinished");
                }
            }
        }


        /// <summary>
        ///     MicroKorg XL uses genres and categories instead of categories and sub categories.
        /// </summary>
        public virtual bool UsesCategoriesAndSubCategories => true;


        /// <summary>
        ///     True if categories (and thus sub categories are editable
        /// </summary>
        public virtual bool AreCategoriesEditable => true;


        /// <summary>
        /// </summary>
        public INavigable Parent => null;


        /// <summary>
        /// </summary>
        public virtual bool AreFavoritesSupported => false;


        /// <summary>
        /// </summary>
        public byte[] Content { get; set; }


        /// <summary>
        /// </summary>
        public FileType MemoryFileType { get; set; }


        /// <summary>
        /// </summary>
        public IModel Model { get; set; }


        /// <summary>
        ///     Date/time the file was saved last (for backup reasons).
        /// </summary>
        public DateTime LastSaved { get; private set; }


        /// <summary>
        ///     Real file is dirty.
        /// </summary>
        public bool IsDirty
        {
            get => _dirty;
            set
            {
                if (_dirty != value)
                {
                    _dirty = value;
                    OnPropertyChanged("IsDirty");
                }

                IsBackupDirty = value;
            }
        }


        /// <summary>
        ///     Backup is dirty.
        /// </summary>
        public bool IsBackupDirty { get; set; }

        public string FileName
        {
            get => _fileName;
            set
            {
                if (_fileName != value)
                {
                    _fileName = value;
                    OnPropertyChanged("FileName");
                }
            }
        }


        /// <summary>
        /// </summary>
        public IMemory Root => this;


        /// <summary>
        /// </summary>
        /// <param name="saveAs"></param>
        /// <param name="saveToFile"></param>
        public abstract void SaveFile(bool saveAs, bool saveToFile);


        /// <summary>
        ///     Backup file.
        /// </summary>
        public void BackupFile()
        {
            var backupFileName = ApplicationData.PcgToolsApplicationDataDir + @"\" +
                                 Path.GetFileNameWithoutExtension(FileName) +
                                 "_" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") +
                                 Path.GetExtension(FileName);

            System.IO.File.WriteAllBytes(backupFileName, Content);
            LastSaved = DateTime.Now;
            IsBackupDirty = false;
        }


        /// <summary>
        ///     Returns the program ID; only supported by Kronos.
        /// </summary>
        /// <param name="rawBankIndex"></param>
        /// <param name="rawProgramIndex"></param>
        /// <returns></returns>
        public virtual string ProgramIdByIndex(int rawBankIndex, int rawProgramIndex)
        {
            throw new ApplicationException("Not supported");
        }


        /// <summary>
        /// </summary>
        /// <param name="fileType"></param>
        /// <returns></returns>
        public static string FileTypeAsString(FileType fileType)
        {
            var map = new Dictionary<FileType, string>
            {
                { FileType.Bnk, Strings.EFileTypeBnk },
                { FileType.Exl, Strings.EFileTypeExl },
                { FileType.Lib, Strings.EFileTypeLib },
                { FileType.Mid, Strings.EFileTypeMid },
                { FileType.MkxlAll, Strings.EFileTypeMkxlAll },
                { FileType.MkxlPAll, Strings.EFileTypeMkxlPAll },
                { FileType.MkxlPProg, Strings.EFileTypeMkxlPProg },
                { FileType.MkP0, Strings.EFileTypeMkP0 },
                { FileType.Pcg, Strings.EFileTypePcg },
                { FileType.Raw, Strings.EFileTypeRaw },
                { FileType.Tr, Strings.EFileTypeTr },
                { FileType.Sng, Strings.EFileTypeSng },
                { FileType.Syx, Strings.EFileTypeSyx }
            };

            if (map.ContainsKey(fileType))
            {
                return map[fileType];
            }

            throw new ApplicationException("Illegal switch");
        }
    }
}