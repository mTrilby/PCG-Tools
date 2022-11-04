#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;

namespace Domain.Common.Synth.SongsRelated
{
    /// <summary>
    /// </summary>
    public interface ISongMemory : ISongMemoryInit
    {
        /// <summary>
        ///     PCG memory is connected with; should be of same model.
        /// </summary>
        IPcgMemory ConnectedPcgMemory { get; set; }
    }
}