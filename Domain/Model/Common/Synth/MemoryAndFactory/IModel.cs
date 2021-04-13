namespace Domain.Model.Common.Synth.MemoryAndFactory
{
    /// <summary>
    /// 
    /// </summary>
    public interface IModel
    {
        /// <summary>
        /// 
        /// </summary>
        ModelsEOsVersion OsVersion { get; }


        /// <summary>
        /// 
        /// </summary>
        ModelsEModelType ModelType { get; }


        /// <summary>
        /// 
        /// </summary>
        string OsVersionString { get; }


        /// <summary>
        /// 
        /// </summary>
        string ModelAsString { get; }


        string ModelAndVersionAsString { get; }
    }
}
