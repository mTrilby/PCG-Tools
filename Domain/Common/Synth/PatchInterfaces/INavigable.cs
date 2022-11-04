#region copyright

// (c) Copyright 2011-2022 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

using Domain.Common.Synth.MemoryAndFactory;

namespace Domain.Common.Synth.PatchInterfaces
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