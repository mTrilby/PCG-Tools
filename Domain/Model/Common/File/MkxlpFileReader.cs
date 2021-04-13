using Domain.Model.Common.Synth.MemoryAndFactory;

namespace Domain.Model.Common.File
{
    public abstract class MkxlPProgFileReader : MkxlFileReader
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentPcgMemory"></param>
        /// <param name="content"></param>
        protected MkxlPProgFileReader(IPcgMemory currentPcgMemory, byte[] content)
            : base(currentPcgMemory, content)
        {
        }
    }
}