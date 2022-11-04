#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;

namespace Domain.Common.Synth.SongsRelated
{
    /// <summary>
    /// </summary>
    public interface ISongMemoryInit : IMemoryInit
    {
        /// <summary>
        /// </summary>
        IRegions Regions { get; }


        /// <summary>
        /// </summary>
        ISongs Songs { get; }
    }
}