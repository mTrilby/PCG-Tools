#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using PcgTools.Model.Common.Synth.MemoryAndFactory;

#endregion

namespace PcgTools.Model.Common.Synth.PatchInterfaces
{
    /// <summary>
    /// </summary>
    public interface INavigable
    {
        /// <summary>
        /// </summary>
        IMemory Root { get; }

        /// <summary>
        /// </summary>
        INavigable Parent { get; }
    }
}