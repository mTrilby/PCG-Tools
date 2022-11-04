#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using PcgTools.Model.Common.Synth.MemoryAndFactory;

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