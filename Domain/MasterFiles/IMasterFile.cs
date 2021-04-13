using System.ComponentModel;
using Domain.Model.Common.Synth.MemoryAndFactory;
using Domain.Model.Common.Synth.PatchInterfaces;

namespace Domain.MasterFiles
{
    /// <summary>
    /// 
    /// </summary>
    public interface IMasterFile : ISelectable, INotifyPropertyChanged
    {
        /// <summary>
        /// 
        /// </summary>
        string FileName { get; }


        /// <summary>
        /// 
        /// </summary>
        MasterFileEFileState FileState { get; }


        /// <summary>
        /// Model
        /// </summary>
        IModel Model { get; }


        /// <summary>
        /// Sets a master file with file name to the model specified. Use an empty string to remove.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="fileName"></param>
        void SetModel(IModel model, string fileName);
    }
}
