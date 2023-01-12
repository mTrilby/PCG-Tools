#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using Domain.Common.Synth.MemoryAndFactory;
using Domain.Common.Synth.Meta;

#endregion

namespace Domain.Common.Synth.OldParameters
{
    /// <summary>
    /// </summary>
    public interface IFixedParameter : IParameter
    {
        /// <summary>
        /// </summary>
        /// <param name="memory"></param>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="patch"></param>
        void Set(IMemory memory, byte[] data, FixedParameter.EType type, IPatch patch);
    }
}