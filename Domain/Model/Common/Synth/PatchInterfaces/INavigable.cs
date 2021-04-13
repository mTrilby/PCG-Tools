// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using Domain.Model.Common.Synth.MemoryAndFactory;

namespace Domain.Model.Common.Synth.PatchInterfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface INavigable
    {
        /// <summary>
        /// 
        /// </summary>
        IMemory Root { get; }

        
        /// <summary>
        /// 
        /// </summary>
        INavigable Parent { get; }
    }
}
