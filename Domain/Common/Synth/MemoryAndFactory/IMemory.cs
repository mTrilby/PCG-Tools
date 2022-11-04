﻿#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using System.ComponentModel;
using Domain.Common.Synth.PatchInterfaces;

namespace Domain.Common.Synth.MemoryAndFactory
{
    /// <summary>
    /// </summary>
    public interface IMemory : INavigable, IDirtiable, ISupportedFeatures, INotifyPropertyChanged
    {
        /// <summary>
        /// </summary>
        string FileName { get; set; }


        /// <summary>
        /// </summary>
        byte[] Content { get; }


        /// <summary>
        /// </summary>
        IModel Model { get; }


        /// <summary>
        /// </summary>
        Memory.FileType MemoryFileType { get; set; }


        /// <summary>
        /// </summary>
        /// <param name="saveAs"></param>
        /// <param name="saveToFile"></param>
        void SaveFile(bool saveAs, bool saveToFile);


        /// <summary>
        ///     Make a backup of the file.
        /// </summary>
        void BackupFile();


        /// <summary>
        ///     Returns the program ID; only supported by Kronos.
        /// </summary>
        /// <param name="rawBankIndex"></param>
        /// <param name="rawProgramIndex"></param>
        /// <returns></returns>
        string ProgramIdByIndex(int rawBankIndex, int rawProgramIndex);
    }
}