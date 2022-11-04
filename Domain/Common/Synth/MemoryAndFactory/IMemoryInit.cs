#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

namespace PcgTools.Model.Common.Synth.MemoryAndFactory
{
    /// <summary>
    /// </summary>
    public interface IMemoryInit : IMemory
    {
        /// <summary>
        ///     IMPR: Is new needed?
        /// </summary>
        new byte[] Content { get; set; }
    }
}