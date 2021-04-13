// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using System;
using System.Collections.Generic;
using System.IO;
using Common.Mvvm;
using Common.Utils;
using Domain.Model.Common.Synth.PatchInterfaces;
using Domain.PcgToolsResources;

namespace Domain.Model.Common.Synth.MemoryAndFactory
{
    /// <summary>
    /// 
    /// </summary>
    abstract public class Memory : ObservableObject, IMemory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileType"></param>
        /// <returns></returns>
        public static string FileTypeAsString(MemoryFileType fileType)
        {
            var map = new Dictionary<MemoryFileType, string>
            {
                {MemoryFileType.Bnk, Strings.EFileTypeBnk},
                {MemoryFileType.Exl, Strings.EFileTypeExl},
                {MemoryFileType.Lib, Strings.EFileTypeLib},
                {MemoryFileType.Mid, Strings.EFileTypeMid},
                {MemoryFileType.MkxlAll, Strings.EFileTypeMkxlAll},
                {MemoryFileType.MkxlPAll, Strings.EFileTypeMkxlPAll},
                {MemoryFileType.MkxlPProg, Strings.EFileTypeMkxlPProg},
                {MemoryFileType.MkP0, Strings.EFileTypeMkP0},
                {MemoryFileType.Pcg, Strings.EFileTypePcg},
                {MemoryFileType.Raw, Strings.EFileTypeRaw},
                {MemoryFileType.Tr, Strings.EFileTypeTr},
                {MemoryFileType.Sng, Strings.EFileTypeSng},
                {MemoryFileType.Syx, Strings.EFileTypeSyx}
            };

            if (map.ContainsKey(fileType))
            {
                return map[fileType];
            }

            throw new ApplicationException("Illegal switch");
        }


        /// <summary>
         /// 
         /// </summary>
        public INavigable Parent => null;


        /// <summary>
        /// 
        /// </summary>
        public int ByteOffset => 0;


        /// <summary>
        /// 
        /// </summary>
        public virtual bool AreFavoritesSupported => false;


        /// <summary>
        /// 
        /// </summary>
        public byte[] Content { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public MemoryFileType MemoryFileType { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public IModel Model { get; set; }


        /// <summary>
        /// 
        /// </summary>
        bool _dirty;


        /// <summary>
        /// Date/time the file was saved last (for backup reasons).
        /// </summary>
        public DateTime LastSaved { get; private set; }


        /// <summary>
        /// Real file is dirty.
        /// </summary>
        public bool IsDirty
        {
            get { return _dirty; }
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
        /// Backup is dirty.
        /// </summary>
        public bool IsBackupDirty { get; set; }


        /// <summary>
        /// The original file name is to check if the file name has changed later to rename the file.
        /// </summary>
        public string OriginalFileName { get; set; }


        /// <summary>
        /// 
        /// </summary>
        string _fileName;
        public string FileName
        {
            get { return _fileName; }
            set { if (_fileName != value) { _fileName = value; OnPropertyChanged("FileName"); } }
        }


        /// <summary>
        /// True if the complete file has been read (and chunks handled).
        /// </summary>
        [UsedImplicitly]
        bool _readingFinished;
        public bool ReadingFinished
        {
// ReSharper disable UnusedMember.Global
            get { return _readingFinished; }
// ReSharper restore UnusedMember.Global
            set { if (_readingFinished != value) { _readingFinished = value; OnPropertyChanged("ReadingFinished"); } }
        }


        /// <summary>
        /// MicroKorg XL uses genres and categories instead of categories and sub categories.
        /// </summary>
        public virtual bool UsesCategoriesAndSubCategories => true;


        /// <summary>
        /// True if categories (and thus sub categories are editable
        /// </summary>
        public virtual bool AreCategoriesEditable => true;


        /// <summary>
        /// 
        /// </summary>
        public IMemory Root => this;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="saveAs"></param>
        /// <param name="saveToFile"></param>
        public abstract void SaveFile(bool saveAs, bool saveToFile);


        /// <summary>
        ///  Backup file.
        /// </summary>
        public void BackupFile(string pcgToolsApplicationDataDir)
        {
            var backupFileName = pcgToolsApplicationDataDir + @"\" +
                                 Path.GetFileNameWithoutExtension(FileName) +
                                 "_" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") +
                                 Path.GetExtension(FileName);

            System.IO.File.WriteAllBytes(backupFileName, Content);
            LastSaved = DateTime.Now;
            IsBackupDirty = false;
        }


        /// <summary>
        /// Returns the program ID; only supported by Kronos.
        /// </summary>
        /// <param name="rawBankIndex"></param>
        /// <param name="rawProgramIndex"></param>
        /// <returns></returns>
        public virtual string ProgramIdByIndex(int rawBankIndex, int rawProgramIndex)
        {
            throw new ApplicationException("Not supported");
        }
    }
}
