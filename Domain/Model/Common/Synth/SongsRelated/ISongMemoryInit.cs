
using Domain.Model.Common.Synth.MemoryAndFactory;

namespace Domain.Model.Common.Synth.SongsRelated
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISongMemoryInit : IMemoryInit
    {
        /// <summary>
        /// 
        /// </summary>
        IRegions Regions { get; }


        /// <summary>
        /// 
        /// </summary>
        ISongs Songs { get; }
    }
}

