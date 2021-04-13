
using Domain.Model.Common.Synth.MemoryAndFactory;

namespace Domain.Model.Common.File
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPatchesFileReader
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileType"></param>
        /// <param name="modelType"></param>
        void ReadContent(MemoryFileType fileType, ModelsEModelType modelType);
    }
}
