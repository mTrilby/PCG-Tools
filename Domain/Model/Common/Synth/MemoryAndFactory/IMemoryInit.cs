namespace Domain.Model.Common.Synth.MemoryAndFactory
{
    /// <summary>
    /// 
    /// </summary>
    public interface IMemoryInit : IMemory
    {

        /// <summary>
        /// IMPR: Is new needed?
        /// </summary>
        new byte[] Content { get; set; }
    }
}
