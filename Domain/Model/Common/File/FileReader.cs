namespace Domain.Model.Common.File
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class FileReader
    {
        /// <summary>
        /// Byte offset where timbres start.
        /// </summary>
        protected virtual int TimbresByteOffset => -1;
    }
}
