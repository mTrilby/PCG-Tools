#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.MemoryAndFactory;

#endregion

namespace PcgTools.Model.Common.Synth.SongsRelated
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