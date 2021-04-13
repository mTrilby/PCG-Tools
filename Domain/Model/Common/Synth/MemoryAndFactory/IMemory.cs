// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using System.ComponentModel;
using Domain.Model.Common.Synth.PatchInterfaces;

namespace Domain.Model.Common.Synth.MemoryAndFactory
{
    /// <summary>
    /// 
    /// </summary>
    public interface IMemory : INavigable, IDirtiable, ISupportedFeatures, INotifyPropertyChanged
    {
        /// <summary>
        /// 
        /// </summary>
        string FileName { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        byte[] Content { get; }


        /// <summary>
        /// 
        /// </summary>
        IModel Model { get; }


        /// <summary>
        /// 
        /// </summary>
        MemoryFileType MemoryFileType { get; set; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="saveAs"></param>
        /// <param name="saveToFile"></param>
        void SaveFile(bool saveAs, bool saveToFile);


        /// <summary>
        /// Make a backup of the file.
        /// </summary>
        /// <param name="pcgToolsApplicationDataDir"></param>
        void BackupFile(string pcgToolsApplicationDataDir);


        /// <summary>
        /// Returns the program ID; only supported by Kronos.
        /// </summary>
        /// <param name="rawBankIndex"></param>
        /// <param name="rawProgramIndex"></param>
        /// <returns></returns>
        string ProgramIdByIndex(int rawBankIndex, int rawProgramIndex);
    }
}
