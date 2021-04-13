using Domain.Model.Common.Synth.MemoryAndFactory;

namespace Domain.Model.Common.Synth.SongsRelated
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISongMemory : ISongMemoryInit
    {
        /// <summary>
        /// PCG memory is connected with; should be of same model.
        /// </summary>
        IPcgMemory  ConnectedPcgMemory { get; set; }
    }
}
